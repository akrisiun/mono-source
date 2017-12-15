
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("75194f8b-b8d9-3983-a547-2bc1c30dedf7")]
   public sealed class PKCS1
   {
       public static byte[] I2OSP(int x, int size) { throw new NotImplementedException(); }
       public static byte[] I2OSP(byte[] x, int size) { throw new NotImplementedException(); }
       public static byte[] OS2IP(byte[] x) { throw new NotImplementedException(); }
       public static byte[] RSAEP(System.Security.Cryptography.RSA rsa, byte[] m) { throw new NotImplementedException(); }
       public static byte[] RSADP(System.Security.Cryptography.RSA rsa, byte[] c) { throw new NotImplementedException(); }
       public static byte[] RSASP1(System.Security.Cryptography.RSA rsa, byte[] m) { throw new NotImplementedException(); }
       public static byte[] RSAVP1(System.Security.Cryptography.RSA rsa, byte[] s) { throw new NotImplementedException(); }
       public static byte[] Encrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Security.Cryptography.RandomNumberGenerator rng, byte[] M) { throw new NotImplementedException(); }
       public static byte[] Decrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] C) { throw new NotImplementedException(); }
       public static byte[] Encrypt_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.RandomNumberGenerator rng, byte[] M) { throw new NotImplementedException(); }
       public static byte[] Decrypt_v15(System.Security.Cryptography.RSA rsa, byte[] C) { throw new NotImplementedException(); }
       public static byte[] Sign_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue) { throw new NotImplementedException(); }
       public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature) { throw new NotImplementedException(); }
       public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { throw new NotImplementedException(); }
       public static byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, int emLength) { throw new NotImplementedException(); }
       public static byte[] MGF1(System.Security.Cryptography.HashAlgorithm hash, byte[] mgfSeed, int maskLen) { throw new NotImplementedException(); }
   }
}
