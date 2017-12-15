
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("1e4d7d37-59ce-39b9-9694-0f997f794a0a")]
   public class RSAManaged : System.Security.Cryptography.RSA
   {
       protected override void Finalize() {}
       public override byte[] DecryptValue(byte[] rgb) { throw new NotImplementedException(); }
       public override byte[] EncryptValue(byte[] rgb) { throw new NotImplementedException(); }
       public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { throw new NotImplementedException(); }
       public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) {}
       protected override void Dispose(bool disposing) {}
       public override string ToXmlString(bool includePrivateParameters) { throw new NotImplementedException(); }
       public static override System.Security.Cryptography.RSA Create() { throw new NotImplementedException(); }
       public static override System.Security.Cryptography.RSA Create(string algName) { throw new NotImplementedException(); }
       public virtual override byte[] Encrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw new NotImplementedException(); }
       public virtual override byte[] Decrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw new NotImplementedException(); }
       public virtual override byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       public virtual override bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       protected virtual override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw new NotImplementedException(); }
       protected virtual override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw new NotImplementedException(); }
       public override byte[] SignData(byte[] data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       public virtual override byte[] SignData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       public virtual override byte[] SignData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       public override bool VerifyData(byte[] data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       public virtual override bool VerifyData(byte[] data, int offset, int count, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       public override bool VerifyData(System.IO.Stream data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw new NotImplementedException(); }
       public virtual override void FromXmlString(string xmlString) {}
       public virtual override void Dispose() {}
       public override void Clear() {}
       public static override System.Security.Cryptography.AsymmetricAlgorithm Create() { throw new NotImplementedException(); }
       public static override System.Security.Cryptography.AsymmetricAlgorithm Create(string algName) { throw new NotImplementedException(); }
      //ctor: 
      public RSAManaged () {}
      //ctor: 
      public RSAManaged (int keySize) {}
      public override int KeySize { get { throw new NotImplementedException(); } }
      public override string KeyExchangeAlgorithm { get { throw new NotImplementedException(); } }
      public bool PublicOnly { get { throw new NotImplementedException(); } }
      public override string SignatureAlgorithm { get { throw new NotImplementedException(); } }
      public bool UseKeyBlinding { get; set; }
      public bool IsCrtPossible { get { throw new NotImplementedException(); } }
      public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw new NotImplementedException(); } }
      // Event: 
   // public event KeyGeneratedEventHandler KeyGenerated;
       // Field: 
       protected int KeySizeValue;
       // Field: 
       protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
      // public sealed delegate KeyGeneratedEventHandler.KeyGeneratedEventHandler
   }
}
