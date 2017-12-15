
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Math
{  

   [Guid("9f08ad5a-025c-33cc-9001-2def7260122d")]
   public class BigInteger
   {
       public static BigInteger Parse(string number) { throw new NotImplementedException(); }
       public static BigInteger Add(Mono.Math.BigInteger bi1, BigInteger bi2) { throw new NotImplementedException(); }
       public static BigInteger Subtract(Mono.Math.BigInteger bi1, BigInteger bi2) { throw new NotImplementedException(); }
       public static int Modulus(Mono.Math.BigInteger bi, int i) { throw new NotImplementedException(); }
       public static uint Modulus(Mono.Math.BigInteger bi, uint ui) { throw new NotImplementedException(); }
       public static BigInteger Modulus(Mono.Math.BigInteger bi1, BigInteger bi2) { throw new NotImplementedException(); }
       public static BigInteger Divid(Mono.Math.BigInteger bi, int i) { throw new NotImplementedException(); }
       public static BigInteger Divid(Mono.Math.BigInteger bi1, BigInteger bi2) { throw new NotImplementedException(); }
       public static BigInteger Multiply(Mono.Math.BigInteger bi1, BigInteger bi2) { throw new NotImplementedException(); }
       public static BigInteger Multiply(Mono.Math.BigInteger bi, int i) { throw new NotImplementedException(); }
       public static BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng) { throw new NotImplementedException(); }
       public static BigInteger GenerateRandom(int bits) { throw new NotImplementedException(); }
       public void Randomize(System.Security.Cryptography.RandomNumberGenerator rng) {}
       public void Randomize() {}
       public int BitCount() { throw new NotImplementedException(); }
       public bool TestBit(uint bitNum) { throw new NotImplementedException(); }
       public bool TestBit(int bitNum) { throw new NotImplementedException(); }
       public void SetBit(uint bitNum) {}
       public void ClearBit(uint bitNum) {}
       public void SetBit(uint bitNum, bool value) {}
       public int LowestSetBit() { throw new NotImplementedException(); }
       public byte[] GetBytes() { throw new NotImplementedException(); }
       public Sign Compare(Mono.Math.BigInteger bi) { throw new NotImplementedException(); }
       public string ToString(uint radix) { throw new NotImplementedException(); }
       public string ToString(uint radix, string characterSet) { throw new NotImplementedException(); }
       public void Clear() {}
       public override int GetHashCode() { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
       public override bool Equals(object o) { throw new NotImplementedException(); }
       public BigInteger GCD(Mono.Math.BigInteger bi) { throw new NotImplementedException(); }
       public BigInteger ModInverse(Mono.Math.BigInteger modulus) { throw new NotImplementedException(); }
       public BigInteger ModPow(Mono.Math.BigInteger exp, BigInteger n) { throw new NotImplementedException(); }
       public bool IsProbablePrime() { throw new NotImplementedException(); }
       public static BigInteger NextHighestPrime(Mono.Math.BigInteger bi) { throw new NotImplementedException(); }
       public static BigInteger GeneratePseudoPrime(int bits) { throw new NotImplementedException(); }
       public void Incr2() {}
      //ctor: 
      public BigInteger () {}
      //ctor: 
      public BigInteger (Mono.Math.Sign sign, uint len) {}
      //ctor: 
      public BigInteger (Mono.Math.BigInteger bi) {}
      //ctor: 
      public BigInteger (Mono.Math.BigInteger bi, uint len) {}
      //ctor: 
      public BigInteger (byte[] inData) {}
      //ctor: 
      public BigInteger (uint[] inData) {}
      //ctor: 
      public BigInteger (uint ui) {}
      //ctor: 
      public BigInteger (ulong ul) {}
   public sealed enum Sign.Sign
   public sealed class ModulusRing.ModulusRing
   }
}
