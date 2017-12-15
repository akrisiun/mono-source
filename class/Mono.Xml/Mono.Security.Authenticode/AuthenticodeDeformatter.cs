
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Authenticode
{  

   [Guid("e9d65aa6-5140-3395-b950-369c3d923139")]
   public class AuthenticodeDeformatter : AuthenticodeBase
   {
       public bool IsTrusted() { throw new NotImplementedException(); }
       protected override byte[] HashFile(string fileName, string hashName) { throw new NotImplementedException(); }
      //ctor: 
      public AuthenticodeDeformatter () {}
      //ctor: 
      public AuthenticodeDeformatter (string fileName) {}
      public string FileName { get; set; }
      public Byte[] Hash { get { throw new NotImplementedException(); } }
      public int Reason { get { throw new NotImplementedException(); } }
      public Byte[] Signature { get { throw new NotImplementedException(); } }
      public DateTime Timestamp { get { throw new NotImplementedException(); } }
      public Mono.Security.X509.X509CertificateCollection Certificates { get { throw new NotImplementedException(); } }
      public Mono.Security.X509.X509Certificate SigningCertificate { get { throw new NotImplementedException(); } }
       // Field: 
       public static const string spcIndirectDataContext = "1.3.6.1.4.1.311.2.1.4";
   }
}
