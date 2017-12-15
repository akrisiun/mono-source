
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("e2b38ded-2c91-3567-80f5-12761e060182")]
   public class KeyUsageExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       protected override void Encode() {}
       public bool Support(Mono.Security.X509.Extensions.KeyUsages usage) { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public KeyUsageExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public KeyUsageExtension (Mono.Security.X509.X509Extension extension) {}
      //ctor: 
      public KeyUsageExtension () {}
      public KeyUsages KeyUsage { get; set; }
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
