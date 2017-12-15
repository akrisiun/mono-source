
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("5b2e123c-afac-3774-9a5c-69661a262cae")]
   public abstract class X509Builder
   {
       protected abstract Mono.Security.ASN1 ToBeSigned(string hashName) { throw new NotImplementedException(); }
       protected string GetOid(string hashName) { throw new NotImplementedException(); }
       public virtual byte[] Sign(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw new NotImplementedException(); }
       public virtual byte[] Sign(System.Security.Cryptography.RSA key) { throw new NotImplementedException(); }
       public virtual byte[] Sign(System.Security.Cryptography.DSA key) { throw new NotImplementedException(); }
      //ctor: 
      protected X509Builder () {}
      public string Hash { get; set; }
   }
}
