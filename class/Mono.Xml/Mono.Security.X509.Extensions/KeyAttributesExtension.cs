
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("fc9c376c-1640-3667-a978-2c0d340410e1")]
   public class KeyAttributesExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       public bool Support(Mono.Security.X509.Extensions.KeyUsages usage) { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
       protected virtual override void Encode() {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public KeyAttributesExtension () {}
      //ctor: 
      public KeyAttributesExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public KeyAttributesExtension (Mono.Security.X509.X509Extension extension) {}
      public Byte[] KeyIdentifier { get { throw new NotImplementedException(); } }
      public override string Name { get { throw new NotImplementedException(); } }
      public DateTime NotAfter { get { throw new NotImplementedException(); } }
      public DateTime NotBefore { get { throw new NotImplementedException(); } }
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
