
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("2c0beabf-8462-3dc5-86e2-81b16874c99c")]
   public class CRLDistributionPointsExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       public override string ToString() { throw new NotImplementedException(); }
       protected virtual override void Encode() {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public CRLDistributionPointsExtension () {}
      //ctor: 
      public CRLDistributionPointsExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public CRLDistributionPointsExtension (Mono.Security.X509.X509Extension extension) {}
      public override string Name { get { throw new NotImplementedException(); } }
      public System.Collections.Generic.IEnumerable<Mono.Security.X509.Extensions.DistributionPoint> DistributionPoints { get { throw new NotImplementedException(); } }
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
   public class DistributionPoint.DistributionPoint
   public sealed enum ReasonFlags.ReasonFlags
   }
}
