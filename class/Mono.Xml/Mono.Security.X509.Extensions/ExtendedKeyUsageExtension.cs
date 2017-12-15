
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("479ad496-a363-37b7-8fae-9df47d703a1a")]
   public class ExtendedKeyUsageExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       protected override void Encode() {}
       public override string ToString() { throw new NotImplementedException(); }
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public ExtendedKeyUsageExtension () {}
      //ctor: 
      public ExtendedKeyUsageExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public ExtendedKeyUsageExtension (Mono.Security.X509.X509Extension extension) {}
      public System.Collections.ArrayList KeyPurpose { get { throw new NotImplementedException(); } }
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
