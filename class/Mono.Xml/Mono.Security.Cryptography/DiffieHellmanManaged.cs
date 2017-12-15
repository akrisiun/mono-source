
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("b88a6506-6d60-3574-b845-8bd6ecf5ce21")]
   public sealed class DiffieHellmanManaged : DiffieHellman
   {
       public override byte[] CreateKeyExchange() { throw new NotImplementedException(); }
       public override byte[] DecryptKeyExchange(byte[] keyEx) { throw new NotImplementedException(); }
       protected override void Dispose(bool disposing) {}
       public override DHParameters ExportParameters(bool includePrivateParameters) { throw new NotImplementedException(); }
       public override void ImportParameters(Mono.Security.Cryptography.DHParameters parameters) {}
       protected override void Finalize() {}
       public static override DiffieHellman Create() { throw new NotImplementedException(); }
       public static override DiffieHellman Create(string algName) { throw new NotImplementedException(); }
       public virtual override void FromXmlString(string xmlString) {}
       public virtual override string ToXmlString(bool includePrivateParameters) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public override void Clear() {}
       public static override System.Security.Cryptography.AsymmetricAlgorithm Create() { throw new NotImplementedException(); }
       public static override System.Security.Cryptography.AsymmetricAlgorithm Create(string algName) { throw new NotImplementedException(); }
      //ctor: 
      public DiffieHellmanManaged () {}
      //ctor: 
      public DiffieHellmanManaged (int bitLength, int l, DHKeyGeneration method) {}
      //ctor: 
      public DiffieHellmanManaged (byte[] p, byte[] g, byte[] x) {}
      //ctor: 
      public DiffieHellmanManaged (byte[] p, byte[] g, int l) {}
      public override string KeyExchangeAlgorithm { get { throw new NotImplementedException(); } }
      public override string SignatureAlgorithm { get { throw new NotImplementedException(); } }
      public virtual int KeySize { get; set; }
      public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw new NotImplementedException(); } }
       // Field: 
       protected int KeySizeValue;
       // Field: 
       protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
   }
}
