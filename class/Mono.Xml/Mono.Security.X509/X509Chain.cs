
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("90d2a43f-95c6-3523-90b1-032cd38ef00d")]
   public class X509Chain
   {
       public void LoadCertificate(Mono.Security.X509.X509Certificate x509) {}
       public void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection) {}
       public X509Certificate FindByIssuerName(string issuerName) { throw new NotImplementedException(); }
       public bool Build(Mono.Security.X509.X509Certificate leaf) { throw new NotImplementedException(); }
       public void Reset() {}
      //ctor: 
      public X509Chain () {}
      //ctor: 
      public X509Chain (Mono.Security.X509.X509CertificateCollection chain) {}
      public X509CertificateCollection Chain { get { throw new NotImplementedException(); } }
      public X509Certificate Root { get { throw new NotImplementedException(); } }
      public X509ChainStatusFlags Status { get { throw new NotImplementedException(); } }
      public X509CertificateCollection TrustAnchors { get; set; }
   }
}
