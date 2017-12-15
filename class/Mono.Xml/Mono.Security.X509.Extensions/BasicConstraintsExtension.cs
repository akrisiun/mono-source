
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("61b5422b-cfc0-3532-bf0c-61f1a8d2bea4")]
   public class BasicConstraintsExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       protected override void Encode() {}
       public override string ToString() { throw new NotImplementedException(); }
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public BasicConstraintsExtension () {}
      //ctor: 
      public BasicConstraintsExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public BasicConstraintsExtension (Mono.Security.X509.X509Extension extension) {}
      public bool CertificateAuthority { get; set; }
      public override string Name { get { throw new NotImplementedException(); } }
      public int PathLenConstraint { get; set; }
      public Mono.Security.ASN1 ASN1 { get { throw new NotImplementedException(); } }
      public string Oid { get { throw new NotImplementedException(); } }
      public bool Critical { get; set; }
      public Mono.Security.ASN1 Value { get { throw new NotImplementedException(); } }
       // Field: 
       public static const int NoPathLengthConstraint = -1;
       // Field: 
       protected string extnOid;
       // Field: 
       protected bool extnCritical;
       // Field: 
       protected Mono.Security.ASN1 extnValue;
   }
}
