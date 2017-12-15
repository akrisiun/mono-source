
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("591b0073-87d4-302a-93cd-a719f0944389")]
   public class KeyPairPersistence
   {
       public bool Load() { throw new NotImplementedException(); }
       public void Save() {}
       public void Remove() {}
      //ctor: 
      public KeyPairPersistence (System.Security.Cryptography.CspParameters parameters) {}
      //ctor: 
      public KeyPairPersistence (System.Security.Cryptography.CspParameters parameters, string keyPair) {}
      public string Filename { get { throw new NotImplementedException(); } }
      public string KeyValue { get; set; }
      public System.Security.Cryptography.CspParameters Parameters { get { throw new NotImplementedException(); } }
   }
}
