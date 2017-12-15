
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("46ccb942-e9e2-3984-ada3-926ec5120ef2")]
   public sealed class ARC4Managed : RC4 System.Security.Cryptography.ICryptoTransform
   {
       protected override void Finalize() {}
       protected override void Dispose(bool disposing) {}
       public override void GenerateIV() {}
       public override void GenerateKey() {}
       public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw new NotImplementedException(); }
       public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw new NotImplementedException(); }
       public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw new NotImplementedException(); }
       public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw new NotImplementedException(); }
       public static override RC4 Create() { throw new NotImplementedException(); }
       public static override RC4 Create(string algName) { throw new NotImplementedException(); }
       public override bool ValidKeySize(int bitLength) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public override void Clear() {}
       public static override System.Security.Cryptography.SymmetricAlgorithm Create() { throw new NotImplementedException(); }
       public static override System.Security.Cryptography.SymmetricAlgorithm Create(string algName) { throw new NotImplementedException(); }
       public virtual override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw new NotImplementedException(); }
       public virtual override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw new NotImplementedException(); }
      //ctor: 
      public ARC4Managed () {}
      public virtual bool CanReuseTransform { get { throw new NotImplementedException(); } }
      public virtual bool CanTransformMultipleBlocks { get { throw new NotImplementedException(); } }
      public virtual int InputBlockSize { get { throw new NotImplementedException(); } }
      public virtual int OutputBlockSize { get { throw new NotImplementedException(); } }
      public override Byte[] Key { get; set; }
      public virtual Byte[] IV { get; set; }
      public virtual int BlockSize { get; set; }
      public virtual int FeedbackSize { get; set; }
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
