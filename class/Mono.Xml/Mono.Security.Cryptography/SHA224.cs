
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("4fe0f8e4-3e3f-35e9-86d8-609b39cee2f3")]
   public abstract class SHA224 : System.Security.Cryptography.HashAlgorithm
   {
       public new static SHA224 Create() { throw new NotImplementedException(); }
       public new static SHA224 Create(string hashName) { throw new NotImplementedException(); }
       public override byte[] ComputeHash(System.IO.Stream inputStream) { throw new NotImplementedException(); }
       public override byte[] ComputeHash(byte[] buffer) { throw new NotImplementedException(); }
       public override byte[] ComputeHash(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
       public virtual override int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw new NotImplementedException(); }
       public virtual override byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public override void Clear() {}
       protected virtual override void Dispose(bool disposing) {}
       public abstract override void Initialize() {}
       protected abstract override void HashCore(byte[] array, int ibStart, int cbSize) {}
       protected abstract override byte[] HashFinal() { throw new NotImplementedException(); }
      //ctor: 
      public SHA224 () {}
      public virtual int HashSize { get { throw new NotImplementedException(); } }
      public virtual Byte[] Hash { get { throw new NotImplementedException(); } }
      public virtual int InputBlockSize { get { throw new NotImplementedException(); } }
      public virtual int OutputBlockSize { get { throw new NotImplementedException(); } }
      public virtual bool CanTransformMultipleBlocks { get { throw new NotImplementedException(); } }
      public virtual bool CanReuseTransform { get { throw new NotImplementedException(); } }
       // Field: 
       protected int HashSizeValue;
       // Field: 
       protected int State;
   }
}
