
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Authenticode
{  

   [Guid("dcef9f74-00fc-3f46-bf4a-90f18ae792ed")]
   public class PrivateKey
   {
       public void Save(string filename) {}
       public void Save(string filename, string password) {}
       public static PrivateKey CreateFromFile(string filename) { throw new NotImplementedException(); }
       public static PrivateKey CreateFromFile(string filename, string password) { throw new NotImplementedException(); }
      //ctor: 
      public PrivateKey () {}
      //ctor: 
      public PrivateKey (byte[] data, string password) {}
      public bool Encrypted { get { throw new NotImplementedException(); } }
      public int KeyType { get; set; }
      public System.Security.Cryptography.RSA RSA { get; set; }
      public bool Weak { get; set; }
   }
}
