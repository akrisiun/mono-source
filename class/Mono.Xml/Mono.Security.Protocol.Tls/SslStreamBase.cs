
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Tls
{  

   [Guid("3f95fd82-0d6f-371f-8f3d-1692b3c599db")]
   public abstract class SslStreamBase : System.IO.Stream
   {
       protected override void Finalize() {}
       protected override void Dispose(bool disposing) {}
       public virtual override void Dispose() {}
       public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { throw new NotImplementedException(); }
       public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { throw new NotImplementedException(); }
       public override int EndRead(IAsyncResult asyncResult) { throw new NotImplementedException(); }
       public override void EndWrite(IAsyncResult asyncResult) {}
       public override void Close() {}
       public override void Flush() {}
       public int Read(byte[] buffer) { throw new NotImplementedException(); }
       public virtual int Read(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
       public override long Seek(long offset, System.IO.SeekOrigin origin) { throw new NotImplementedException(); }
       public override void SetLength(long value) {}
       public void Write(byte[] buffer) {}
       public override void Write(byte[] buffer, int offset, int count) {}
       public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { throw new NotImplementedException(); }
       public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       public override void CopyTo(System.IO.Stream destination) {}
       public override void CopyTo(System.IO.Stream destination, int bufferSize) {}
       public override System.Threading.Tasks.Task FlushAsync() { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       protected virtual override System.Threading.WaitHandle CreateWaitHandle() { throw new NotImplementedException(); }
       public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       public virtual override int ReadByte() { throw new NotImplementedException(); }
       public virtual override void WriteByte(byte value) {}
       public static override System.IO.Stream Synchronized(System.IO.Stream stream) { throw new NotImplementedException(); }
       protected virtual override void ObjectInvariant() {}
       protected override MarshalByRefObject MemberwiseClone(bool cloneIdentity) { throw new NotImplementedException(); }
       public virtual override object GetLifetimeService() { throw new NotImplementedException(); }
       public virtual override object InitializeLifetimeService() { throw new NotImplementedException(); }
       public virtual override System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) { throw new NotImplementedException(); }
      //ctor: 
      protected SslStreamBase (System.IO.Stream stream, bool ownsStream) {}
      public bool CheckCertRevocationStatus { get; set; }
      public CipherAlgorithmType CipherAlgorithm { get { throw new NotImplementedException(); } }
      public int CipherStrength { get { throw new NotImplementedException(); } }
      public HashAlgorithmType HashAlgorithm { get { throw new NotImplementedException(); } }
      public int HashStrength { get { throw new NotImplementedException(); } }
      public int KeyExchangeStrength { get { throw new NotImplementedException(); } }
      public ExchangeAlgorithmType KeyExchangeAlgorithm { get { throw new NotImplementedException(); } }
      public SecurityProtocolType SecurityProtocol { get { throw new NotImplementedException(); } }
      public System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get { throw new NotImplementedException(); } }
      public override bool CanRead { get { throw new NotImplementedException(); } }
      public override bool CanSeek { get { throw new NotImplementedException(); } }
      public override bool CanWrite { get { throw new NotImplementedException(); } }
      public override long Length { get { throw new NotImplementedException(); } }
      public override long Position { get; set; }
      public virtual bool CanTimeout { get { throw new NotImplementedException(); } }
      public virtual int ReadTimeout { get; set; }
      public virtual int WriteTimeout { get; set; }
       // Field: 
       public static readonly System.IO.Stream Null;
   }
}
