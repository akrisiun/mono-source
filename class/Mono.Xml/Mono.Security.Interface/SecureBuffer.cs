
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("85f4c691-dbc4-35a2-87d0-9be0b2b76609")]
   public class SecureBuffer : SecretParameters IBufferOffsetSize
   {
       public byte[] StealBuffer() { throw new NotImplementedException(); }
       public static SecureBuffer CreateCopy(byte[] buffer) { throw new NotImplementedException(); }
       protected override void Clear() {}
       protected override void CheckDisposed() {}
       protected static override void Clear(byte[] array) {}
       public virtual override void Dispose() {}
      //ctor: 
      public SecureBuffer (int size) {}
      //ctor: 
      public SecureBuffer (byte[] buffer) {}
      public virtual Byte[] Buffer { get { throw new NotImplementedException(); } }
      public virtual int Size { get { throw new NotImplementedException(); } }
   }
}
