
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Tls
{  

   [Guid("1f751e73-c3ce-3630-b1f9-435d7d3bc375")]
   public class SslClientStream : SslStreamBase
   {
       protected override void Finalize() {}
       protected override void Dispose(bool disposing) {}
       public virtual override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { throw new NotImplementedException(); }
       public virtual override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { throw new NotImplementedException(); }
       public virtual override int EndRead(IAsyncResult asyncResult) { throw new NotImplementedException(); }
       public virtual override void EndWrite(IAsyncResult asyncResult) {}
       public virtual override void Close() {}
       public virtual override void Flush() {}
       public override int Read(byte[] buffer) { throw new NotImplementedException(); }
       public virtual override int Read(byte[] buffer, int offset, int count) { throw new NotImplementedException(); }
       public virtual override long Seek(long offset, System.IO.SeekOrigin origin) { throw new NotImplementedException(); }
       public virtual override void SetLength(long value) {}
       public override void Write(byte[] buffer) {}
       public virtual override void Write(byte[] buffer, int offset, int count) {}
       public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { throw new NotImplementedException(); }
       public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { throw new NotImplementedException(); }
       public virtual override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw new NotImplementedException(); }
       public override void CopyTo(System.IO.Stream destination) {}
       public override void CopyTo(System.IO.Stream destination, int bufferSize) {}
       public virtual override void Dispose() {}
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
      public SslClientStream (System.IO.Stream stream, string targetHost, bool ownsStream) {}
      //ctor: 
      public SslClientStream (System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate) {}
      //ctor: 
      public SslClientStream (System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) {}
      //ctor: 
      public SslClientStream (System.IO.Stream stream, string targetHost, bool ownsStream, SecurityProtocolType securityProtocolType) {}
      //ctor: 
      public SslClientStream (System.IO.Stream stream, string targetHost, bool ownsStream, SecurityProtocolType securityProtocolType, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) {}
      public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw new NotImplementedException(); } }
      public System.Security.Cryptography.X509Certificates.X509Certificate SelectedClientCertificate { get { throw new NotImplementedException(); } }
      public CertificateValidationCallback ServerCertValidationDelegate { get; set; }
      public CertificateSelectionCallback ClientCertSelectionDelegate { get; set; }
      public PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get; set; }
      public bool CheckCertRevocationStatus { get; set; }
      public CipherAlgorithmType CipherAlgorithm { get { throw new NotImplementedException(); } }
      public int CipherStrength { get { throw new NotImplementedException(); } }
      public HashAlgorithmType HashAlgorithm { get { throw new NotImplementedException(); } }
      public int HashStrength { get { throw new NotImplementedException(); } }
      public int KeyExchangeStrength { get { throw new NotImplementedException(); } }
      public ExchangeAlgorithmType KeyExchangeAlgorithm { get { throw new NotImplementedException(); } }
      public SecurityProtocolType SecurityProtocol { get { throw new NotImplementedException(); } }
      public System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get { throw new NotImplementedException(); } }
      public virtual bool CanRead { get { throw new NotImplementedException(); } }
      public virtual bool CanSeek { get { throw new NotImplementedException(); } }
      public virtual bool CanWrite { get { throw new NotImplementedException(); } }
      public virtual long Length { get { throw new NotImplementedException(); } }
      public virtual long Position { get; set; }
      public virtual bool CanTimeout { get { throw new NotImplementedException(); } }
      public virtual int ReadTimeout { get; set; }
      public virtual int WriteTimeout { get; set; }
      // Event: 
   // public event CertificateValidationCallback2 ServerCertValidation2;
       // Field: 
       public static readonly System.IO.Stream Null;
   }
}
