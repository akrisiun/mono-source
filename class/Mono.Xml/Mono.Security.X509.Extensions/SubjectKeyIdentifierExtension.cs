
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("c7ab1fce-ea45-35e5-a8ca-16bc70907a8f")]
   public class SubjectKeyIdentifierExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       protected override void Encode() {}
       public override string ToString() { throw new NotImplementedException(); }
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public SubjectKeyIdentifierExtension () {}
      //ctor: 
      public SubjectKeyIdentifierExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public SubjectKeyIdentifierExtension (Mono.Security.X509.X509Extension extension) {}
      public override string Name { get { throw new NotImplementedException(); } }
      public Byte[] Identifier { get; set; }
      public Mono.Security.ASN1 ASN1 { get { throw new NotImplementedException(); } }
      public string Oid { get { throw new NotImplementedException(); } }
      public bool Critical { get; set; }
      public Mono.Security.ASN1 Value { get { throw new NotImplementedException(); } }
       // Field: 
       protected string extnOid;
       // Field: 
       protected bool extnCritical;
       // Field: 
       protected Mono.Security.ASN1 extnValue;
   }
}
