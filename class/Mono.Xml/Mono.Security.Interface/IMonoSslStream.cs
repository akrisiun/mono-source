
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("7dc0b88f-b12e-3bb9-b0a0-33457dab722c")]
   public interface IMonoSslStream : System.IDisposable
   {
       void AuthenticateAsClient(string targetHost);
       void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
       IAsyncResult BeginAuthenticateAsClient(string targetHost, AsyncCallback asyncCallback, object asyncState);
       IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState);
       void EndAuthenticateAsClient(IAsyncResult asyncResult);
       void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate);
       void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
       IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, AsyncCallback asyncCallback, object asyncState);
       IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState);
       void EndAuthenticateAsServer(IAsyncResult asyncResult);
       System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost);
       System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
       System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate);
       System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
       void Flush();
       int Read(byte[] buffer, int offset, int count);
       void Write(byte[] buffer);
       void Write(byte[] buffer, int offset, int count);
       IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);
       int EndRead(IAsyncResult asyncResult);
       IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);
       void EndWrite(IAsyncResult asyncResult);
       void SetLength(long value);
       MonoTlsConnectionInfo GetConnectionInfo();
       System.Net.TransportContext TransportContext { get; }
       bool IsAuthenticated { get; }
       bool IsMutuallyAuthenticated { get; }
       bool IsEncrypted { get; }
       bool IsSigned { get; }
       bool IsServer { get; }
       System.Security.Authentication.CipherAlgorithmType CipherAlgorithm { get; }
       int CipherStrength { get; }
       System.Security.Authentication.HashAlgorithmType HashAlgorithm { get; }
       int HashStrength { get; }
       System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm { get; }
       int KeyExchangeStrength { get; }
       bool CanRead { get; }
       bool CanTimeout { get; }
       bool CanWrite { get; }
       long Length { get; }
       long Position { get; }
       System.Net.Security.AuthenticatedStream AuthenticatedStream { get; }
       int ReadTimeout { get; set; }
       int WriteTimeout { get; set; }
       bool CheckCertRevocationStatus { get; }
       System.Security.Cryptography.X509Certificates.X509Certificate InternalLocalCertificate { get; }
       System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificate { get; }
       System.Security.Cryptography.X509Certificates.X509Certificate RemoteCertificate { get; }
       System.Security.Authentication.SslProtocols SslProtocol { get; }
       MonoTlsProvider Provider { get; }
   }
}
