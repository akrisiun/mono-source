
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Math.Prime.Generator
{  

   [Guid("8f2267a5-8094-3fb3-966b-fef917cbba1f")]
   public class NextPrimeFinder : SequentialSearchPrimeGeneratorBase
   {
       protected override Mono.Math.BigInteger GenerateSearchBase(int bits, object Context) { throw new NotImplementedException(); }
       public virtual override Mono.Math.BigInteger GenerateNewPrime(int bits) { throw new NotImplementedException(); }
       public virtual override Mono.Math.BigInteger GenerateNewPrime(int bits, object context) { throw new NotImplementedException(); }
       protected virtual override bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context) { throw new NotImplementedException(); }
       protected override bool PostTrialDivisionTests(Mono.Math.BigInteger bi) { throw new NotImplementedException(); }
      //ctor: 
      public NextPrimeFinder () {}
      public virtual Mono.Math.Prime.ConfidenceFactor Confidence { get { throw new NotImplementedException(); } }
      public virtual Mono.Math.Prime.PrimalityTest PrimalityTest { get { throw new NotImplementedException(); } }
      public virtual int TrialDivisionBounds { get { throw new NotImplementedException(); } }
   }
}
