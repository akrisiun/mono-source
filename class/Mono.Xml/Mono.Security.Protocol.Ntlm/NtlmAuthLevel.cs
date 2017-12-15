
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("3f52f39d-4fe9-3d50-8ab2-464557b8dcb7")]
   public enum NtlmAuthLevel 
   {
       // Field: 
       LM_and_NTLM = 0,
       // Field: 
       LM_and_NTLM_and_try_NTLMv2_Session = 1,
       // Field: 
       NTLM_only = 2,
       // Field: 
       NTLMv2_only = 3,
   }
}
