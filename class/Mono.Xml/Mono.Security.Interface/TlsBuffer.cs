
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("e5d8ee0d-f9c4-3daf-8e58-6ab425b64e08")]
   public class TlsBuffer : SecretParameters
   {
       public byte ReadByte() { throw new NotImplementedException(); }
       public short ReadInt16() { throw new NotImplementedException(); }
       public int ReadInt24() { throw new NotImplementedException(); }
       public int ReadInt32() { throw new NotImplementedException(); }
       public TlsBuffer ReadBuffer(int length) { throw new NotImplementedException(); }
       public IBufferOffsetSize GetRemaining() { throw new NotImplementedException(); }
       protected virtual void MakeRoomInternal(int size) {}
       public void Write(byte value) {}
       public void Write(short value) {}
       public static void WriteInt16(byte[] buffer, int offset, short value) {}
       public void Write(int value) {}
       public void WriteInt24(int value) {}
       public void Write(ulong value) {}
       public static void WriteInt24(byte[] buffer, int offset, int value) {}
       public static void WriteInt32(byte[] buffer, int offset, int value) {}
       public static void WriteInt64(byte[] buffer, int offset, ulong value) {}
       public void Write(byte[] buffer) {}
       public void Write(byte[] buffer, int offset, int size) {}
       public void Write(Mono.Security.Interface.IBufferOffsetSize buffer) {}
       public SecureBuffer ReadSecureBuffer(int count) { throw new NotImplementedException(); }
       public byte[] ReadBytes(int count) { throw new NotImplementedException(); }
       public static bool Compare(Mono.Security.Interface.IBufferOffsetSize buffer1, IBufferOffsetSize buffer2) { throw new NotImplementedException(); }
       public static bool Compare(byte[] buffer1, byte[] buffer2) { throw new NotImplementedException(); }
       public static bool Compare(byte[] buffer1, int offset1, int size1, byte[] buffer2, int offset2, int size2) { throw new NotImplementedException(); }
       public static int ConstantTimeCompare(byte[] buffer1, int offset1, int size1, byte[] buffer2, int offset2, int size2) { throw new NotImplementedException(); }
       protected void SetBuffer(byte[] buffer, int offset, int size) {}
       protected override void Clear() {}
       protected override void CheckDisposed() {}
       protected static override void Clear(byte[] array) {}
       public virtual override void Dispose() {}
      //ctor: 
      protected TlsBuffer () {}
      //ctor: 
      public TlsBuffer (Mono.Security.Interface.IBufferOffsetSize bos) {}
      //ctor: 
      public TlsBuffer (byte[] buffer, int offset, int size) {}
      //ctor: 
      public TlsBuffer (byte[] buffer) {}
      //ctor: 
      public TlsBuffer (int size) {}
      public int Position { get; set; }
      public int Remaining { get { throw new NotImplementedException(); } }
      public Byte[] Buffer { get { throw new NotImplementedException(); } }
      public int Offset { get { throw new NotImplementedException(); } }
      public int Size { get { throw new NotImplementedException(); } }
      public int EndOffset { get { throw new NotImplementedException(); } }
       // Field: 
       public static readonly byte[] EmptyArray;
   }
}
