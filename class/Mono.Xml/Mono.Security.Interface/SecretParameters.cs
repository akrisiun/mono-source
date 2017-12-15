
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("e355a340-7873-39f1-850e-81d6dc231b50")]
   public abstract class SecretParameters : System.IDisposable
   {
       protected abstract void Clear() {}
       protected void CheckDisposed() {}
       protected static void Clear(byte[] array) {}
       public virtual void Dispose() {}
       protected override void Finalize() {}
      //ctor: 
      protected SecretParameters () {}
   }
}
