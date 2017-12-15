
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("e280228d-5955-322b-b91c-1056b2a2d4d1")]
   public enum X509ChainStatusFlags 
   {
       // Field: 
       InvalidBasicConstraints = 1024,
       // Field: 
       NoError = 0,
       // Field: 
       NotSignatureValid = 8,
       // Field: 
       NotTimeNested = 2,
       // Field: 
       NotTimeValid = 1,
       // Field: 
       PartialChain = 65536,
       // Field: 
       UntrustedRoot = 32,
   }
}
