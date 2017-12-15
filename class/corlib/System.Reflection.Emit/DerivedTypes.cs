//
// System.Reflection.Emit.DerivedTypes.cs
//
// Authors:
// 	Rodrigo Kumpera <rkumpera@novell.com>
//
//
// Copyright (C) 2009 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if !FULL_AOT_RUNTIME
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;


namespace System.Reflection.Emit
{
	[StructLayout (LayoutKind.Sequential)]
	abstract partial class SymbolType
	{
		internal Type m_baseType;

		internal SymbolType (Type elementType)
		{
			this.m_baseType = elementType;
		}

        //  https://source.dot.net/#System.Private.CoreLib/src/System/Reflection/Emit/SymbolType.cs,7703ecbc489b61b7
        internal static Type FormCompoundType(string format, Type baseType, int curIndex)
        {
            // This function takes a string to describe the compound type, such as "[,][]", and a baseType.
            // 
            // Example: [2..4]  - one dimension array with lower bound 2 and size of 3
            // Example: [3, 5, 6] - three dimension array with lower bound 3, 5, 6
            // Example: [-3, ] [] - one dimensional array of two dimensional array (with lower bound -3 for 
            //          the first dimension)
            // Example: []* - pointer to a one dimensional array
            // Example: *[] - one dimensional array. The element type is a pointer to the baseType
            // Example: []& - ByRef of a single dimensional array. Only one & is allowed and it must appear the last!
            // Example: [?] - Array with unknown bound

            SymbolType symbolType;
            int iLowerBound;
            int iUpperBound;

            if (format == null || curIndex == format.Length)
            {
                // we have consumed all of the format string
                return baseType;
            }




            if (format[curIndex] == '&')
            {
                // ByRef case

                symbolType = new SymbolType_(TypeKind.IsByRef);
                symbolType.SetFormat(format, curIndex, 1);
                curIndex++;

                if (curIndex != format.Length)
                    // ByRef has to be the last char!!
                    throw new ArgumentException("Argument_BadSigFormat");

                symbolType.SetElementType(baseType);
                return symbolType;
            }

            if (format[curIndex] == '[')
            {
                // Array type.
                symbolType = new SymbolType(TypeKind.IsArray);
                int startIndex = curIndex;
                curIndex++;

                iLowerBound = 0;
                iUpperBound = -1;

                // Example: [2..4]  - one dimension array with lower bound 2 and size of 3
                // Example: [3, 5, 6] - three dimension array with lower bound 3, 5, 6
                // Example: [-3, ] [] - one dimensional array of two dimensional array (with lower bound -3 sepcified)

                while (format[curIndex] != ']')
                {
                    if (format[curIndex] == '*')
                    {
                        symbolType.m_isSzArray = false;
                        curIndex++;
                    }
                    // consume, one dimension at a time
                    if ((format[curIndex] >= '0' && format[curIndex] <= '9') || format[curIndex] == '-')
                    {
                        bool isNegative = false;
                        if (format[curIndex] == '-')
                        {
                            isNegative = true;
                            curIndex++;
                        }

                        // lower bound is specified. Consume the low bound
                        while (format[curIndex] >= '0' && format[curIndex] <= '9')
                        {
                            iLowerBound = iLowerBound * 10;
                            iLowerBound += format[curIndex] - '0';
                            curIndex++;
                        }

                        if (isNegative)
                        {
                            iLowerBound = 0 - iLowerBound;
                        }

                        // set the upper bound to be less than LowerBound to indicate that upper bound it not specified yet!
                        iUpperBound = iLowerBound - 1;
                    }
                    if (format[curIndex] == '.')
                    {
                        // upper bound is specified

                        // skip over ".."
                        curIndex++;
                        if (format[curIndex] != '.')
                        {
                            // bad format!! Throw exception
                            throw new ArgumentException("Argument_BadSigFormat");
                        }

                        curIndex++;
                        // consume the upper bound
                        if ((format[curIndex] >= '0' && format[curIndex] <= '9') || format[curIndex] == '-')
                        {
                            bool isNegative = false;
                            iUpperBound = 0;
                            if (format[curIndex] == '-')
                            {
                                isNegative = true;
                                curIndex++;
                            }

                            // lower bound is specified. Consume the low bound
                            while (format[curIndex] >= '0' && format[curIndex] <= '9')
                            {
                                iUpperBound = iUpperBound * 10;
                                iUpperBound += format[curIndex] - '0';
                                curIndex++;
                            }
                            if (isNegative)
                            {
                                iUpperBound = 0 - iUpperBound;
                            }
                            if (iUpperBound < iLowerBound)
                            {
                                // User specified upper bound less than lower bound, this is an error.
                                // Throw error exception.
                                throw new ArgumentException("Argument_BadSigFormat");
                            }
                        }
                    }

                    if (format[curIndex] == ',')
                    {
                        // We have more dimension to deal with.
                        // now set the lower bound, the size, and increase the dimension count!
                        curIndex++;
                        symbolType.SetBounds(iLowerBound, iUpperBound);

                        // clear the lower and upper bound information for next dimension
                        iLowerBound = 0;
                        iUpperBound = -1;
                    }
                    else if (format[curIndex] != ']')
                    {
                        throw new ArgumentException("Argument_BadSigFormat"); // SR.Argument_BadSigFormat);
                    }
                }

                // The last dimension information
                symbolType.SetBounds(iLowerBound, iUpperBound);

                // skip over ']'
                curIndex++;

                symbolType.SetFormat(format, startIndex, curIndex - startIndex);

                // set the base type of array
                symbolType.SetElementType(baseType);
                return FormCompoundType(format, symbolType, curIndex);
            }
            else if (format[curIndex] == '*')
            {
                // pointer type.

                symbolType = new SymbolType_(TypeKind.IsPointer);
                symbolType.SetFormat(format, curIndex, 1);
                curIndex++;
                symbolType.SetElementType(baseType);
                return FormCompoundType(format, symbolType, curIndex);
            }

            return null;
        }

        private void SetBounds(int lower, int upper)
        {
            // Increase the rank, set lower and upper bound

            if (lower != 0 || upper != -1)
                m_isSzArray = false;

            if (m_iaLowerBound.Length <= m_cRank)
            {
                // resize the bound array
                int[] iaTemp = new int[m_cRank * 2];
                Array.Copy(m_iaLowerBound, 0, iaTemp, 0, m_cRank);
                m_iaLowerBound = iaTemp;
                Array.Copy(m_iaUpperBound, 0, iaTemp, 0, m_cRank);
                m_iaUpperBound = iaTemp;
            }

            m_iaLowerBound[m_cRank] = lower;
            m_iaUpperBound[m_cRank] = upper;
            m_cRank++;
        }

        internal void SetFormat(string format, int curIndex, int length)
        {
            // Cache the text display format for this SymbolType

            m_format = format.Substring(curIndex, length);
        }

        #region Data Members

        internal TypeKind m_typeKind;
        // internal Type m_baseType;
        protected Type BaseType => m_baseType;

        internal int m_cRank;        // count of dimension
        // If LowerBound and UpperBound is equal, that means one element. 
        // If UpperBound is less than LowerBound, then the size is not specified.
        internal int[] m_iaLowerBound;
        internal int[] m_iaUpperBound; // count of dimension
        private string m_format;      // format string to form the full name.
        private bool m_isSzArray = true;

        #endregion


        internal abstract String FormatName (string elementName);

		protected virtual // override
             bool IsArrayImpl ()
		{
			return false;
		}

		protected virtual // override
            bool IsByRefImpl ()
		{
			return false;
		}

		protected virtual // override
            bool IsPointerImpl ()
		{
			return false;
		}

		public virtual // override
             Type MakeArrayType ()
		{
			return new ArrayType (this, 0);
		}

		public virtual // override
             Type MakeArrayType (int rank)
		{
			if (rank < 1)
				throw new IndexOutOfRangeException ();
			return new ArrayType (this, rank);
		}

		public virtual // override
             Type MakeByRefType ()
		{
			return new ByRefType_ (this);
		}

		public virtual // override
             Type MakePointerType ()
		{
			return new PointerType_ (this);
		}

		public override string ToString ()
		{
			return FormatName (m_baseType.ToString ());
		}

		public virtual // override
             string AssemblyQualifiedName {
			get {
				string fullName = FormatName (m_baseType.FullName);
				if (fullName == null)
					return null;
				return fullName + ", " + m_baseType.Assembly.FullName;
			}
		}


		public virtual // override
             string FullName {
			get {
				return FormatName (m_baseType.FullName);
			}
		}

		public virtual // override
             string Name {
			get {
				return FormatName (m_baseType.Name);
			}
		}
	
		public virtual // override
             Type UnderlyingSystemType {
			get {
				return this;
			}
		}

		internal virtual // override
             bool IsUserType {
			get {
				return m_baseType.IsUserType;
			}
		}

		// Called from the runtime to return the corresponding finished Type object
		internal virtual // override
             Type RuntimeResolve () {
			return InternalResolve ();
		}
	}

	[StructLayout (LayoutKind.Sequential)]
	internal class ArrayType : SymbolType
	{
		int rank;

		internal ArrayType (Type elementType, int rank) : base (elementType)
		{
			this.rank = rank;
		}

		internal int GetEffectiveRank ()
		{
			return rank;
		}

		internal virtual // override 
            Type InternalResolve ()
		{
			Type et = m_baseType.InternalResolve ();
			if (rank == 0)
				return et.MakeArrayType ();
			return et.MakeArrayType (rank);
		}

		internal override Type RuntimeResolve ()
		{
			Type et = m_baseType.RuntimeResolve ();
			if (rank == 0)
				return et.MakeArrayType ();
			return et.MakeArrayType (rank);
		}

		protected override bool IsArrayImpl ()
		{
			return true;
		}

		public virtual // override 
            int GetArrayRank ()
		{
			return (rank == 0) ? 1 : rank;
		}

		internal override String FormatName (string elementName)
		{
			if (elementName == null)
				return null;
			StringBuilder sb = new StringBuilder (elementName);
			sb.Append ("[");
			for (int i = 1; i < rank; ++i)
				sb.Append (",");
			if (rank == 1)
				sb.Append ("*");
			sb.Append ("]");
			return sb.ToString ();
		}
	}

	[StructLayout (LayoutKind.Sequential)]
	internal class ByRefType_ : SymbolType
	{
		internal ByRefType_ (Type elementType) // : base (elementType)
		{
		}

		internal virtual // override
            Type InternalResolve ()
		{
			return m_baseType.InternalResolve ().MakeByRefType (); 
		}

		protected override
            bool IsByRefImpl ()
		{
			return true;
		}

		internal override
            String FormatName (string elementName)
		{
			if (elementName == null)
				return null;
			return elementName + "&";
		}

		public   override
            Type MakeArrayType ()
		{
			throw new ArgumentException ("Cannot create an array type of a byref type");
		}

		public override
            Type MakeArrayType (int rank)
		{
			throw new ArgumentException ("Cannot create an array type of a byref type");
		}

		public override
            Type MakeByRefType ()
		{
			throw new ArgumentException ("Cannot create a byref type of an already byref type");
		}

		public virtual // override
             Type MakePointerType ()
		{
			throw new ArgumentException ("Cannot create a pointer type of a byref type");
		}
	}

	[StructLayout (LayoutKind.Sequential)]
	internal class PointerType_ : SymbolType
	{
		internal PointerType (Type elementType) // : base (elementType)
		{
		}

		internal virtual // override
             Type InternalResolve ()
		{
			return m_baseType.InternalResolve ().MakePointerType (); 
		}

		protected override
             bool IsPointerImpl ()
		{
			return true;
		}

		internal override
            String FormatName (string elementName)
		{
			if (elementName == null)
				return null;
			return elementName + "*";
		}
	}

}
#endif
