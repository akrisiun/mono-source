
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("40b7cc2e-b1a3-3ef0-be42-2d9fd294c032")]
   public static class ChallengeResponse2
   {
       public static void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) {}
   }
}
