//
// CodeTryCatchFinallyStatementCas.cs 
//	- CAS unit tests for System.CodeDom.CodeTryCatchFinallyStatement
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
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

using NUnit.Framework;

using System;
using System.CodeDom;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace MonoCasTests.System.CodeDom {

	[TestFixture]
	[Category ("CAS")]
	public class CodeTryCatchFinallyStatementCas {

		[SetUp]
		public void SetUp ()
		{
			if (!SecurityManager.SecurityEnabled)
				Assert.Ignore ("SecurityManager.SecurityEnabled is OFF");
		}

		[Test]
		[PermissionSet (SecurityAction.Deny, Unrestricted = true)]
		public void Constructor0_Deny_Unrestricted ()
		{
			CodeTryCatchFinallyStatement ctcfs = new CodeTryCatchFinallyStatement ();
			Assert.AreEqual (0, ctcfs.CatchClauses.Count, "CatchClauses");
			Assert.AreEqual (0, ctcfs.FinallyStatements.Count, "FinallyStatements");
			Assert.AreEqual (0, ctcfs.TryStatements.Count, "TryStatements");
		}

		[Test]
		[PermissionSet (SecurityAction.Deny, Unrestricted = true)]
		public void Constructor1_Deny_Unrestricted ()
		{
			CodeStatement[] try_statements = new CodeStatement[1] { new CodeStatement () };
			CodeCatchClause[] catch_clauses = new CodeCatchClause[1] { new CodeCatchClause () };
			CodeTryCatchFinallyStatement ctcfs = new CodeTryCatchFinallyStatement (try_statements, catch_clauses);
			Assert.AreEqual (1, ctcfs.CatchClauses.Count, "CatchClauses");
			Assert.AreEqual (0, ctcfs.FinallyStatements.Count, "FinallyStatements");
			Assert.AreEqual (1, ctcfs.TryStatements.Count, "TryStatements");
		}

		[Test]
		[PermissionSet (SecurityAction.Deny, Unrestricted = true)]
		public void Constructor2_Deny_Unrestricted ()
		{
			CodeStatement[] try_statements = new CodeStatement[1] { new CodeStatement () };
			CodeCatchClause[] catch_clauses = new CodeCatchClause[1] { new CodeCatchClause () };
			CodeStatement[] finally_statements = new CodeStatement[1] { new CodeStatement () };
			CodeTryCatchFinallyStatement ctcfs = new CodeTryCatchFinallyStatement (try_statements, catch_clauses, finally_statements);
			Assert.AreEqual (1, ctcfs.CatchClauses.Count, "CatchClauses");
			Assert.AreEqual (1, ctcfs.FinallyStatements.Count, "FinallyStatements");
			Assert.AreEqual (1, ctcfs.TryStatements.Count, "TryStatements");
		}

		[Test]
		[PermissionSet (SecurityAction.Deny, Unrestricted = true)]
		public void LinkDemand_Deny_Unrestricted ()
		{
			ConstructorInfo ci = typeof (CodeTryCatchFinallyStatement).GetConstructor (new Type[0]);
			Assert.IsNotNull (ci, "default .ctor");
			Assert.IsNotNull (ci.Invoke (null), "invoke");
		}
	}
}
