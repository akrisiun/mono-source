
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("bbef61d2-be6b-316e-9f41-b3832930c954")]
   public enum MonoSslPolicyErrors 
   {
       // Field: 
       None = 0,
       // Field: 
       RemoteCertificateNotAvailable = 1,
       // Field: 
       RemoteCertificateNameMismatch = 2,
       // Field: 
       RemoteCertificateChainErrors = 4,
   }
}
