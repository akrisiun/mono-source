
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("0940f9c9-b56c-37a0-9211-9bf742e6ca1c")]
   public class NetscapeCertTypeExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       public bool Support(Mono.Security.X509.Extensions.CertTypes usage) { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
       protected virtual override void Encode() {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public NetscapeCertTypeExtension () {}
      //ctor: 
      public NetscapeCertTypeExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public NetscapeCertTypeExtension (Mono.Security.X509.X509Extension extension) {}
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
   public sealed enum CertTypes.CertTypes
   }
}
