
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("9ee25e98-7cc8-3306-b5e7-3fe12d759b2e")]
   public class X509CertificateBuilder : X509Builder
   {
       protected override Mono.Security.ASN1 ToBeSigned(string oid) { throw new NotImplementedException(); }
       protected override string GetOid(string hashName) { throw new NotImplementedException(); }
       public virtual override byte[] Sign(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw new NotImplementedException(); }
       public virtual override byte[] Sign(System.Security.Cryptography.RSA key) { throw new NotImplementedException(); }
       public virtual override byte[] Sign(System.Security.Cryptography.DSA key) { throw new NotImplementedException(); }
      //ctor: 
      public X509CertificateBuilder () {}
      //ctor: 
      public X509CertificateBuilder (byte version) {}
      public byte Version { get; set; }
      public Byte[] SerialNumber { get; set; }
      public string IssuerName { get; set; }
      public DateTime NotBefore { get; set; }
      public DateTime NotAfter { get; set; }
      public string SubjectName { get; set; }
      public System.Security.Cryptography.AsymmetricAlgorithm SubjectPublicKey { get; set; }
      public Byte[] IssuerUniqueId { get; set; }
      public Byte[] SubjectUniqueId { get; set; }
      public X509ExtensionCollection Extensions { get { throw new NotImplementedException(); } }
      public string Hash { get; set; }
   }
}
