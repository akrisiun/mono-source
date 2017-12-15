
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("9ffc4ba4-ff63-3d76-a2d3-3fc69052f4ca")]
   public sealed class MonoTlsSettings
   {
       public static MonoTlsSettings CopyDefaultSettings() { throw new NotImplementedException(); }
       public MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator) { throw new NotImplementedException(); }
       public MonoTlsSettings Clone() { throw new NotImplementedException(); }
      //ctor: 
      public MonoTlsSettings () {}
      public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
      public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
      public bool CheckCertificateName { get; set; }
      public bool CheckCertificateRevocationStatus { get; set; }
      public System.Nullable<System.Boolean> UseServicePointManagerCallback { get; set; }
      public bool SkipSystemValidators { get; set; }
      public bool CallbackNeedsCertificateChain { get; set; }
      public System.Security.Cryptography.X509Certificates.X509CertificateCollection TrustAnchors { get; set; }
      public object UserSettings { get; set; }
      public System.Nullable<Mono.Security.Interface.TlsProtocols> EnabledProtocols { get; set; }
      public CipherSuiteCode[] EnabledCiphers { get; set; }
      public static MonoTlsSettings DefaultSettings { get; set; }
      public ICertificateValidator CertificateValidator { get { throw new NotImplementedException(); } }
   }
}
