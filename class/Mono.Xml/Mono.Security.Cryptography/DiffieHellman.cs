
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("fc31fd98-f9bd-3d3c-9057-20e1c84b5836")]
   public abstract class DiffieHellman : System.Security.Cryptography.AsymmetricAlgorithm
   {
       public new static DiffieHellman Create() { throw new NotImplementedException(); }
       public new static DiffieHellman Create(string algName) { throw new NotImplementedException(); }
       public abstract byte[] CreateKeyExchange() { throw new NotImplementedException(); }
       public abstract byte[] DecryptKeyExchange(byte[] keyex) { throw new NotImplementedException(); }
       public abstract DHParameters ExportParameters(bool includePrivate) { throw new NotImplementedException(); }
       public abstract void ImportParameters(Mono.Security.Cryptography.DHParameters parameters) {}
       public override void FromXmlString(string xmlString) {}
       public override string ToXmlString(bool includePrivateParameters) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public override void Clear() {}
       protected virtual override void Dispose(bool disposing) {}
      //ctor: 
      protected DiffieHellman () {}
      public virtual int KeySize { get; set; }
      public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw new NotImplementedException(); } }
      public virtual string SignatureAlgorithm { get { throw new NotImplementedException(); } }
      public virtual string KeyExchangeAlgorithm { get { throw new NotImplementedException(); } }
       // Field: 
       protected int KeySizeValue;
       // Field: 
       protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
   }
}
