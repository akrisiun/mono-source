
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509.Extensions
{  

   [Guid("603a3a47-c66a-3f11-835c-498163600bde")]
   public class SubjectAltNameExtension : Mono.Security.X509.X509Extension
   {
       protected override void Decode() {}
       public override string ToString() { throw new NotImplementedException(); }
       protected virtual override void Encode() {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      public SubjectAltNameExtension () {}
      //ctor: 
      public SubjectAltNameExtension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public SubjectAltNameExtension (Mono.Security.X509.X509Extension extension) {}
      //ctor: 
      public SubjectAltNameExtension (string[] rfc822, string[] dnsNames, string[] ipAddresses, string[] uris) {}
      public override string Name { get { throw new NotImplementedException(); } }
      public String[] RFC822 { get { throw new NotImplementedException(); } }
      public String[] DNSNames { get { throw new NotImplementedException(); } }
      public String[] IPAddresses { get { throw new NotImplementedException(); } }
      public String[] UniformResourceIdentifiers { get { throw new NotImplementedException(); } }
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
