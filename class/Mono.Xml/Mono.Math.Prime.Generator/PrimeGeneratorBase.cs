
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Math.Prime.Generator
{  

   [Guid("3c4c8d36-0b00-3081-a74c-9aa1cb3ca6e2")]
   public abstract class PrimeGeneratorBase
   {
       protected bool PostTrialDivisionTests(Mono.Math.BigInteger bi) { throw new NotImplementedException(); }
       public abstract Mono.Math.BigInteger GenerateNewPrime(int bits) { throw new NotImplementedException(); }
      //ctor: 
      protected PrimeGeneratorBase () {}
      public virtual Mono.Math.Prime.ConfidenceFactor Confidence { get { throw new NotImplementedException(); } }
      public virtual Mono.Math.Prime.PrimalityTest PrimalityTest { get { throw new NotImplementedException(); } }
      public virtual int TrialDivisionBounds { get { throw new NotImplementedException(); } }
   }
}
