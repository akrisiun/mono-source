
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("43f08028-d048-3321-9b85-1117253309f6")]
   public class PKCS12 : System.ICloneable
   {
       protected override void Finalize() {}
       public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { throw new NotImplementedException(); }
       public byte[] Decrypt(Mono.Security.EncryptedData ed) { throw new NotImplementedException(); }
       public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { throw new NotImplementedException(); }
       public byte[] GetBytes() { throw new NotImplementedException(); }
       public void AddCertificate(Mono.Security.X509.X509Certificate cert) {}
       public void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes) {}
       public void RemoveCertificate(Mono.Security.X509.X509Certificate cert) {}
       public void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs) {}
       public void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) {}
       public void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) {}
       public void RemovePkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) {}
       public void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) {}
       public void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) {}
       public void RemoveKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) {}
       public void AddSecretBag(byte[] secret) {}
       public void AddSecretBag(byte[] secret, System.Collections.IDictionary attributes) {}
       public void RemoveSecretBag(byte[] secret) {}
       public System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(System.Collections.IDictionary attrs) { throw new NotImplementedException(); }
       public byte[] GetSecret(System.Collections.IDictionary attrs) { throw new NotImplementedException(); }
       public X509Certificate GetCertificate(System.Collections.IDictionary attrs) { throw new NotImplementedException(); }
       public System.Collections.IDictionary GetAttributes(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw new NotImplementedException(); }
       public System.Collections.IDictionary GetAttributes(Mono.Security.X509.X509Certificate cert) { throw new NotImplementedException(); }
       public void SaveToFile(string filename) {}
       public virtual object Clone() { throw new NotImplementedException(); }
       public static PKCS12 LoadFromFile(string filename) { throw new NotImplementedException(); }
       public static PKCS12 LoadFromFile(string filename, string password) { throw new NotImplementedException(); }
      //ctor: 
      public PKCS12 () {}
      //ctor: 
      public PKCS12 (byte[] data) {}
      //ctor: 
      public PKCS12 (byte[] data, string password) {}
      //ctor: 
      public PKCS12 (byte[] data, byte[] password) {}
      string Password { set; }
      public int IterationCount { get; set; }
      public System.Collections.ArrayList Keys { get { throw new NotImplementedException(); } }
      public System.Collections.ArrayList Secrets { get { throw new NotImplementedException(); } }
      public X509CertificateCollection Certificates { get { throw new NotImplementedException(); } }
      public static int MaximumPasswordLength { get; set; }
       // Field: 
       public static const string pbeWithSHAAnd128BitRC4 = "1.2.840.113549.1.12.1.1";
       // Field: 
       public static const string pbeWithSHAAnd40BitRC4 = "1.2.840.113549.1.12.1.2";
       // Field: 
       public static const string pbeWithSHAAnd3KeyTripleDESCBC = "1.2.840.113549.1.12.1.3";
       // Field: 
       public static const string pbeWithSHAAnd2KeyTripleDESCBC = "1.2.840.113549.1.12.1.4";
       // Field: 
       public static const string pbeWithSHAAnd128BitRC2CBC = "1.2.840.113549.1.12.1.5";
       // Field: 
       public static const string pbeWithSHAAnd40BitRC2CBC = "1.2.840.113549.1.12.1.6";
       // Field: 
       public static const string keyBag = "1.2.840.113549.1.12.10.1.1";
       // Field: 
       public static const string pkcs8ShroudedKeyBag = "1.2.840.113549.1.12.10.1.2";
       // Field: 
       public static const string certBag = "1.2.840.113549.1.12.10.1.3";
       // Field: 
       public static const string crlBag = "1.2.840.113549.1.12.10.1.4";
       // Field: 
       public static const string secretBag = "1.2.840.113549.1.12.10.1.5";
       // Field: 
       public static const string safeContentsBag = "1.2.840.113549.1.12.10.1.6";
       // Field: 
       public static const string x509Certificate = "1.2.840.113549.1.9.22.1";
       // Field: 
       public static const string sdsiCertificate = "1.2.840.113549.1.9.22.2";
       // Field: 
       public static const string x509Crl = "1.2.840.113549.1.9.23.1";
       // Field: 
       public static const int CryptoApiPasswordLimit = 32;
   public class DeriveBytes.DeriveBytes
   }
}
