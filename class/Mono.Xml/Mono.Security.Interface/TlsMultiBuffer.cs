
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("025897a2-f08f-3742-a5cf-8e7cdcc1cef5")]
   public class TlsMultiBuffer
   {
       public void Add(Mono.Security.Interface.TlsBuffer buffer) {}
       public void Add(byte[] buffer) {}
       public void Add(byte[] buffer, int offset, int size) {}
       public BufferOffsetSize[] GetBufferArray() { throw new NotImplementedException(); }
       public void Clear() {}
       public BufferOffsetSize GetBuffer() { throw new NotImplementedException(); }
       public BufferOffsetSize StealBuffer() { throw new NotImplementedException(); }
      //ctor: 
      public TlsMultiBuffer () {}
      public bool IsEmpty { get { throw new NotImplementedException(); } }
      public bool IsSingle { get { throw new NotImplementedException(); } }
   }
}
