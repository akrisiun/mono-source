
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Authenticode
{  

   [Guid("cba7dffd-560b-3e6b-992f-92fa270aeb27")]
   public class AuthenticodeFormatter : AuthenticodeBase
   {
       public Mono.Security.ASN1 TimestampRequest(byte[] signature) { throw new NotImplementedException(); }
       public void ProcessTimestamp(byte[] response) {}
       public bool Sign(string fileName) { throw new NotImplementedException(); }
       public bool Timestamp(string fileName) { throw new NotImplementedException(); }
       protected override byte[] HashFile(string fileName, string hashName) { throw new NotImplementedException(); }
      //ctor: 
      public AuthenticodeFormatter () {}
      public Authority Authority { get; set; }
      public Mono.Security.X509.X509CertificateCollection Certificates { get { throw new NotImplementedException(); } }
      public System.Collections.ArrayList Crl { get { throw new NotImplementedException(); } }
      public string Hash { get; set; }
      public System.Security.Cryptography.RSA RSA { get; set; }
      public Uri TimestampUrl { get; set; }
      public string Description { get; set; }
      public Uri Url { get; set; }
       // Field: 
       public static const string spcIndirectDataContext = "1.3.6.1.4.1.311.2.1.4";
   }
}
