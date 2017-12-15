
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("01829c02-58b1-3769-95f5-23e27c6fd0c6")]
   public class X509Crl
   {
       public bool WasCurrent(DateTime instant) { throw new NotImplementedException(); }
       public byte[] GetBytes() { throw new NotImplementedException(); }
       public X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509) { throw new NotImplementedException(); }
       public X509CrlEntry GetCrlEntry(byte[] serialNumber) { throw new NotImplementedException(); }
       public bool VerifySignature(Mono.Security.X509.X509Certificate x509) { throw new NotImplementedException(); }
       public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw new NotImplementedException(); }
       public static X509Crl CreateFromFile(string filename) { throw new NotImplementedException(); }
      //ctor: 
      public X509Crl (byte[] crl) {}
      public System.Collections.ArrayList Entries { get { throw new NotImplementedException(); } }
      public X509CrlEntry this [int index] { get { throw new NotImplementedException(); } }
      public X509CrlEntry this [byte[] serialNumber] { get { throw new NotImplementedException(); } }
      public X509ExtensionCollection Extensions { get { throw new NotImplementedException(); } }
      public Byte[] Hash { get { throw new NotImplementedException(); } }
      public string IssuerName { get { throw new NotImplementedException(); } }
      public DateTime NextUpdate { get { throw new NotImplementedException(); } }
      public DateTime ThisUpdate { get { throw new NotImplementedException(); } }
      public string SignatureAlgorithm { get { throw new NotImplementedException(); } }
      public Byte[] Signature { get { throw new NotImplementedException(); } }
      public Byte[] RawData { get { throw new NotImplementedException(); } }
      public byte Version { get { throw new NotImplementedException(); } }
      public bool IsCurrent { get { throw new NotImplementedException(); } }
   public class X509CrlEntry.X509CrlEntry
   }
}
