
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security
{  

   [Guid("5838b034-291d-3f24-8cbf-08e2252145ff")]
   public sealed class StrongName
   {
       public byte[] GetBytes() { throw new NotImplementedException(); }
       public byte[] Hash(string fileName) { throw new NotImplementedException(); }
       public bool Sign(string fileName) { throw new NotImplementedException(); }
       public bool Verify(string fileName) { throw new NotImplementedException(); }
       public bool Verify(System.IO.Stream stream) { throw new NotImplementedException(); }
      //ctor: 
      public StrongName () {}
      //ctor: 
      public StrongName (int keySize) {}
      //ctor: 
      public StrongName (byte[] data) {}
      //ctor: 
      public StrongName (System.Security.Cryptography.RSA rsa) {}
      public bool CanSign { get { throw new NotImplementedException(); } }
      public System.Security.Cryptography.RSA RSA { get; set; }
      public Byte[] PublicKey { get { throw new NotImplementedException(); } }
      public Byte[] PublicKeyToken { get { throw new NotImplementedException(); } }
      public string TokenAlgorithm { get; set; }
   }
}
