
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("65ab8b1e-1ae8-314d-8562-cf2753f3372a")]
   public class X509Store
   {
       public void Clear() {}
       public void Import(Mono.Security.X509.X509Certificate certificate) {}
       public void Import(Mono.Security.X509.X509Crl crl) {}
       public void Remove(Mono.Security.X509.X509Certificate certificate) {}
       public void Remove(Mono.Security.X509.X509Crl crl) {}
      public X509CertificateCollection Certificates { get { throw new NotImplementedException(); } }
      public System.Collections.ArrayList Crls { get { throw new NotImplementedException(); } }
      public string Name { get { throw new NotImplementedException(); } }
   }
}
