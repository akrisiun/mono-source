
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("44f7ab3d-5326-36df-9ac0-1e80d8bc1cba")]
   public sealed class MD2Managed : MD2
   {
       protected override void Finalize() {}
       protected override void Dispose(bool disposing) {}
       public override void Initialize() {}
       protected override void HashCore(byte[] data, int start, int length) {}
       protected override byte[] HashFinal() { throw new NotImplementedException(); }
       public static override MD2 Create() { throw new NotImplementedException(); }
       public static override MD2 Create(string hashName) { throw new NotImplementedException(); }
       public static override System.Security.Cryptography.HashAlgorithm Create() { throw new NotImplementedException(); }
       public static override System.Security.Cryptography.HashAlgorithm Create(string hashName) { throw new NotImplementedException(); }
       public override byte[] ComputeHash(System.IO.Stream inputStream) { throw new NotImplementedException(); }
       public override byte[] ComputeHash(byte[] buffer) { throw new NotImplementedException(); }
       public override byte[] ComputeHash(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
       public virtual override int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw new NotImplementedException(); }
       public virtual override byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public override void Clear() {}
      //ctor: 
      public MD2Managed () {}
      public virtual int HashSize { get { throw new NotImplementedException(); } }
      public virtual Byte[] Hash { get { throw new NotImplementedException(); } }
      public virtual int InputBlockSize { get { throw new NotImplementedException(); } }
      public virtual int OutputBlockSize { get { throw new NotImplementedException(); } }
      public virtual bool CanTransformMultipleBlocks { get { throw new NotImplementedException(); } }
      public virtual bool CanReuseTransform { get { throw new NotImplementedException(); } }
       // Field: 
       protected int HashSizeValue;
       // Field: 
       protected int State;
   }
}
