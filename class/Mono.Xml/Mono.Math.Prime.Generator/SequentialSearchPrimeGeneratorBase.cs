
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Math.Prime.Generator
{  

   [Guid("c7df9480-ab90-304e-9128-845511c132ff")]
   public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
   {
       protected virtual Mono.Math.BigInteger GenerateSearchBase(int bits, object context) { throw new NotImplementedException(); }
       public override Mono.Math.BigInteger GenerateNewPrime(int bits) { throw new NotImplementedException(); }
       public virtual Mono.Math.BigInteger GenerateNewPrime(int bits, object context) { throw new NotImplementedException(); }
       protected virtual bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context) { throw new NotImplementedException(); }
       protected override bool PostTrialDivisionTests(Mono.Math.BigInteger bi) { throw new NotImplementedException(); }
      //ctor: 
      public SequentialSearchPrimeGeneratorBase () {}
      public virtual Mono.Math.Prime.ConfidenceFactor Confidence { get { throw new NotImplementedException(); } }
      public virtual Mono.Math.Prime.PrimalityTest PrimalityTest { get { throw new NotImplementedException(); } }
      public virtual int TrialDivisionBounds { get { throw new NotImplementedException(); } }
   }
}
