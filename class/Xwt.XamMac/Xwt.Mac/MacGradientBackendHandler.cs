
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("fd998df0-cb73-3b89-8052-28a3939a46b4")]
   public class MacGradientBackendHandler : Xwt.Backends.GradientBackendHandler
   {
       public override object CreateLinear(double x0, double y0, double x1, double y1) { throw new NotImplementedException(); }
       public override void Dispose(object backend) {}
       public override object CreateRadial(double cx0, double cy0, double radius0, double cx1, double cy1, double radius1) { throw new NotImplementedException(); }
       public override void AddColorStop(object backend, double position, Xwt.Drawing.Color color) {}
      //ctor: 
      public MacGradientBackendHandler () {}
      public virtual bool DisposeHandleOnUiThread { get { throw new NotImplementedException(); } }
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
