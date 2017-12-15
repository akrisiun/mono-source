
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("dbc12bb4-ecbe-3770-b7a6-91500de0f9c5")]
   public interface ICertificateValidator
   {
       bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, out System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
       ValidationResult ValidateCertificate(string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates);
       MonoTlsSettings Settings { get; }
   }
}
