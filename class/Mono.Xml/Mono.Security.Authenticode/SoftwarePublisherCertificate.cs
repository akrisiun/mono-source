
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Authenticode
{  

   [Guid("3fad4317-7900-354b-a467-bc043b75dafd")]
   public class SoftwarePublisherCertificate
   {
       public byte[] GetBytes() { throw new NotImplementedException(); }
       public static SoftwarePublisherCertificate CreateFromFile(string filename) { throw new NotImplementedException(); }
      //ctor: 
      public SoftwarePublisherCertificate () {}
      //ctor: 
      public SoftwarePublisherCertificate (byte[] data) {}
      public Mono.Security.X509.X509CertificateCollection Certificates { get { throw new NotImplementedException(); } }
      public System.Collections.ArrayList Crls { get { throw new NotImplementedException(); } }
   }
}
