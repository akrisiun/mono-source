
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("69319b21-86ea-3fe6-a6d9-dab36c8aa1cc")]
   public class PrivateKeyUsagePeriodExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       public override string ToString() { throw new NotImplementedException(); }
       protected virtual override void Encode() {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public PrivateKeyUsagePeriodExtension () {}
      //ctor: 
      public PrivateKeyUsagePeriodExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public PrivateKeyUsagePeriodExtension (Mono.Security.X509.X509Extension extension) {}
      public override string Name { get { throw new NotImplementedException(); } }
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
