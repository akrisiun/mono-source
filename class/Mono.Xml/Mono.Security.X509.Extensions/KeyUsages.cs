
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("3548e43a-7408-32a1-a677-23464947f1e0")]
   public enum KeyUsages 
   {
       // Field: 
       digitalSignature = 128,
       // Field: 
       nonRepudiation = 64,
       // Field: 
       keyEncipherment = 32,
       // Field: 
       dataEncipherment = 16,
       // Field: 
       keyAgreement = 8,
       // Field: 
       keyCertSign = 4,
       // Field: 
       cRLSign = 2,
       // Field: 
       encipherOnly = 1,
       // Field: 
       decipherOnly = 2048,
       // Field: 
       none = 0,
   }
}
