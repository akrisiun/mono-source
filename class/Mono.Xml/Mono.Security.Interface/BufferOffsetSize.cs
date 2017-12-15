
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("67088598-4b38-3979-8320-00caa7a02d1d")]
   public class BufferOffsetSize : SecretParameters IBufferOffsetSize
   {
       public byte[] GetBuffer() { throw new NotImplementedException(); }
       public void TruncateTo(int newSize) {}
       protected void SetBuffer(byte[] buffer, int offset, int size) {}
       protected override void Clear() {}
       protected override void CheckDisposed() {}
       protected static override void Clear(byte[] array) {}
       public virtual override void Dispose() {}
      //ctor: 
      public BufferOffsetSize (byte[] buffer, int offset, int size) {}
      //ctor: 
      public BufferOffsetSize (byte[] buffer) {}
      //ctor: 
      public BufferOffsetSize (int size) {}
      public virtual Byte[] Buffer { get { throw new NotImplementedException(); } }
      public virtual int Offset { get { throw new NotImplementedException(); } }
      public virtual int Size { get { throw new NotImplementedException(); } }
      public int EndOffset { get { throw new NotImplementedException(); } }
   }
}
