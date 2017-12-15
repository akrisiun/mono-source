
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("1d5d874f-a9ec-323f-91bc-695746d15320")]
   public class MacImagePatternBackendHandler : Xwt.Backends.ImagePatternBackendHandler
   {
       public override object Create(Xwt.Backends.ImageDescription img) { throw new NotImplementedException(); }
       public override void Dispose(object img) {}
      //ctor: 
      public MacImagePatternBackendHandler () {}
      public virtual bool DisposeHandleOnUiThread { get { throw new NotImplementedException(); } }
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
