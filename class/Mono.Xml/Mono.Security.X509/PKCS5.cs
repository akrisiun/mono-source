
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("9a5a9367-6c3d-32d1-a234-75dc5a59e508")]
   public class PKCS5
   {
      //ctor: 
      public PKCS5 () {}
       // Field: 
       public static const string pbeWithMD2AndDESCBC = "1.2.840.113549.1.5.1";
       // Field: 
       public static const string pbeWithMD5AndDESCBC = "1.2.840.113549.1.5.3";
       // Field: 
       public static const string pbeWithMD2AndRC2CBC = "1.2.840.113549.1.5.4";
       // Field: 
       public static const string pbeWithMD5AndRC2CBC = "1.2.840.113549.1.5.6";
       // Field: 
       public static const string pbeWithSHA1AndDESCBC = "1.2.840.113549.1.5.10";
       // Field: 
       public static const string pbeWithSHA1AndRC2CBC = "1.2.840.113549.1.5.11";
   }
}
