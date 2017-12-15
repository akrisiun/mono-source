
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("fdbfb404-e7e1-31ce-a92f-bd0a5016309a")]
   public class MacImageBuilderBackendHandler : Xwt.Backends.ImageBuilderBackendHandler
   {
       public override object CreateImageBuilder(int width, int height, Xwt.Drawing.ImageFormat format) { throw new NotImplementedException(); }
       public override object CreateContext(object backend) { throw new NotImplementedException(); }
       public override object CreateImage(object backend) { throw new NotImplementedException(); }
       public override void Dispose(object backend) {}
      //ctor: 
      public MacImageBuilderBackendHandler () {}
      public virtual bool DisposeHandleOnUiThread { get { throw new NotImplementedException(); } }
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
