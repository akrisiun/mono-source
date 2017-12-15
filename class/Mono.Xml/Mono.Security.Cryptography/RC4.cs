
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("144ba4cb-49c3-37d5-8c6e-fc856d6b45ca")]
   public abstract class RC4 : System.Security.Cryptography.SymmetricAlgorithm
   {
       public new static RC4 Create() { throw new NotImplementedException(); }
       public new static RC4 Create(string algName) { throw new NotImplementedException(); }
       public override bool ValidKeySize(int bitLength) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public override void Clear() {}
       protected virtual override void Dispose(bool disposing) {}
       public virtual override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw new NotImplementedException(); }
       public abstract override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw new NotImplementedException(); }
       public virtual override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw new NotImplementedException(); }
       public abstract override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw new NotImplementedException(); }
       public abstract override void GenerateKey() {}
       public abstract override void GenerateIV() {}
      //ctor: 
      public RC4 () {}
      public override Byte[] IV { get; set; }
      public virtual int BlockSize { get; set; }
      public virtual int FeedbackSize { get; set; }
      public virtual Byte[] Key { get; set; }
      public virtual System.Security.Cryptography.KeySizes[] LegalBlockSizes { get { throw new NotImplementedException(); } }
      public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw new NotImplementedException(); } }
      public virtual int KeySize { get; set; }
      public virtual System.Security.Cryptography.CipherMode Mode { get; set; }
      public virtual System.Security.Cryptography.PaddingMode Padding { get; set; }
       // Field: 
       protected int BlockSizeValue;
       // Field: 
       protected int FeedbackSizeValue;
       // Field: 
       protected byte[] IVValue;
       // Field: 
       protected byte[] KeyValue;
       // Field: 
       protected System.Security.Cryptography.KeySizes[] LegalBlockSizesValue;
       // Field: 
       protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
       // Field: 
       protected int KeySizeValue;
       // Field: 
       protected System.Security.Cryptography.CipherMode ModeValue;
       // Field: 
       protected System.Security.Cryptography.PaddingMode PaddingValue;
   }
}
