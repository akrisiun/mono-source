
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("e0f0748d-d44f-356b-8941-aa04ce0ebc35")]
   public class ValidationResult
   {
      //ctor: 
      public ValidationResult (bool trusted, bool user_denied, int error_code, Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors) {}
      public bool Trusted { get { throw new NotImplementedException(); } }
      public bool UserDenied { get { throw new NotImplementedException(); } }
      public int ErrorCode { get { throw new NotImplementedException(); } }
      public System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> PolicyErrors { get { throw new NotImplementedException(); } }
   }
}
