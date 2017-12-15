
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("f89c91a5-6489-3118-bc75-f032e002c3f1")]
   public enum TlsProtocols 
   {
       // Field: 
       Zero = 0,
       // Field: 
       Tls10Client = 128,
       // Field: 
       Tls10Server = 64,
       // Field: 
       Tls10 = 192,
       // Field: 
       Tls11Client = 512,
       // Field: 
       Tls11Server = 256,
       // Field: 
       Tls11 = 768,
       // Field: 
       Tls12Client = 2048,
       // Field: 
       Tls12Server = 1024,
       // Field: 
       Tls12 = 3072,
       // Field: 
       ClientMask = 2688,
       // Field: 
       ServerMask = 1344,
   }
}
