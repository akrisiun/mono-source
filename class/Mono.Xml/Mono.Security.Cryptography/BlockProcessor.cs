
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Cryptography
{  

   [Guid("0cc2585e-958f-3445-908b-111efef2d530")]
   public class BlockProcessor
   {
       protected override void Finalize() {}
       public void Initialize() {}
       public void Core(byte[] rgb) {}
       public void Core(byte[] rgb, int ib, int cb) {}
       public byte[] Final() { throw new NotImplementedException(); }
      //ctor: 
      public BlockProcessor (System.Security.Cryptography.ICryptoTransform transform) {}
      //ctor: 
      public BlockProcessor (System.Security.Cryptography.ICryptoTransform transform, int blockSize) {}
   }
}
