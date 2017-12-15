
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("256db9b9-94c2-3e84-84b7-3425faa9922e")]
   public class X509Extension
   {
       protected virtual void Decode() {}
       protected virtual void Encode() {}
       public override bool Equals(object obj) { throw new NotImplementedException(); }
       public byte[] GetBytes() { throw new NotImplementedException(); }
       public override int GetHashCode() { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
      //ctor: 
      protected X509Extension () {}
      //ctor: 
      public X509Extension (Mono.Security.ASN1 asn1) {}
      //ctor: 
      public X509Extension (Mono.Security.X509.X509Extension extension) {}
      public Mono.Security.ASN1 ASN1 { get { throw new NotImplementedException(); } }
      public string Oid { get { throw new NotImplementedException(); } }
      public bool Critical { get; set; }
      public virtual string Name { get { throw new NotImplementedException(); } }
      public Mono.Security.ASN1 Value { get { throw new NotImplementedException(); } }
       // Field: 
       protected string extnOid;
       // Field: 
       protected bool extnCritical;
       // Field: 
       protected Mono.Security.ASN1 extnValue;
   }
}
