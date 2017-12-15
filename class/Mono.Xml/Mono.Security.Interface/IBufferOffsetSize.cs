
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("516aab71-547e-3b94-a821-71b02b509822")]
   public interface IBufferOffsetSize
   {
       Byte[] Buffer { get; }
       int Offset { get; }
       int Size { get; }
   }
}
