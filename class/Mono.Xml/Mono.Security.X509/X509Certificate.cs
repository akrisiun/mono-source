
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("e59272ec-906d-3df8-bd50-40934a8975bc")]
   public class X509Certificate : System.Runtime.Serialization.ISerializable
   {
       public bool WasCurrent(DateTime instant) { throw new NotImplementedException(); }
       public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw new NotImplementedException(); }
       public bool CheckSignature(byte[] hash, string hashAlgorithm, byte[] signature) { throw new NotImplementedException(); }
       public Mono.Security.ASN1 GetIssuerName() { throw new NotImplementedException(); }
       public Mono.Security.ASN1 GetSubjectName() { throw new NotImplementedException(); }
       public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
      //ctor: 
      public X509Certificate (byte[] data) {}
      //ctor: 
      protected X509Certificate (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
      public System.Security.Cryptography.DSA DSA { get; set; }
      public X509ExtensionCollection Extensions { get { throw new NotImplementedException(); } }
      public Byte[] Hash { get { throw new NotImplementedException(); } }
      public virtual string IssuerName { get { throw new NotImplementedException(); } }
      public virtual string KeyAlgorithm { get { throw new NotImplementedException(); } }
      public virtual Byte[] KeyAlgorithmParameters { get; set; }
      public virtual Byte[] PublicKey { get { throw new NotImplementedException(); } }
      public virtual System.Security.Cryptography.RSA RSA { get; set; }
      public virtual Byte[] RawData { get { throw new NotImplementedException(); } }
      public virtual Byte[] SerialNumber { get { throw new NotImplementedException(); } }
      public virtual Byte[] Signature { get { throw new NotImplementedException(); } }
      public virtual string SignatureAlgorithm { get { throw new NotImplementedException(); } }
      public virtual Byte[] SignatureAlgorithmParameters { get { throw new NotImplementedException(); } }
      public virtual string SubjectName { get { throw new NotImplementedException(); } }
      public virtual DateTime ValidFrom { get { throw new NotImplementedException(); } }
      public virtual DateTime ValidUntil { get { throw new NotImplementedException(); } }
      public int Version { get { throw new NotImplementedException(); } }
      public bool IsCurrent { get { throw new NotImplementedException(); } }
      public Byte[] IssuerUniqueIdentifier { get { throw new NotImplementedException(); } }
      public Byte[] SubjectUniqueIdentifier { get { throw new NotImplementedException(); } }
      public bool IsSelfSigned { get { throw new NotImplementedException(); } }
   }
}
