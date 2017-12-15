
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("c9a15374-e55d-3923-8494-4d20f5f31b03")]
   public static class CertificateValidationHelper
   {
       public static ICertificateValidator GetValidator(Mono.Security.Interface.MonoTlsSettings settings) { throw new NotImplementedException(); }
      public static bool SupportsX509Chain { get { throw new NotImplementedException(); } }
      public static bool SupportsTrustAnchors { get { throw new NotImplementedException(); } }
   }
}
