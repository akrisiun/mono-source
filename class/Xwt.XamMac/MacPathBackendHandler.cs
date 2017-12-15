
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("1de1204f-c16e-3526-8444-e14d00ed1ede")]
   public class MacPathBackendHandler : Xwt.Backends.DrawingPathBackendHandler
   {
       public override void Arc(object backend, double xc, double yc, double radius, double angle1, double angle2) {}
       public override void ArcNegative(object backend, double xc, double yc, double radius, double angle1, double angle2) {}
       public override void ClosePath(object backend) {}
       public override void CurveTo(object backend, double x1, double y1, double x2, double y2, double x3, double y3) {}
       public override void LineTo(object backend, double x, double y) {}
       public override void MoveTo(object backend, double x, double y) {}
       public override void Rectangle(object backend, double x, double y, double width, double height) {}
       public override void RelCurveTo(object backend, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3) {}
       public override void RelLineTo(object backend, double dx, double dy) {}
       public override void RelMoveTo(object backend, double dx, double dy) {}
       public override object CreatePath() { throw new NotImplementedException(); }
       public override object CopyPath(object backend) { throw new NotImplementedException(); }
       public override void AppendPath(object backend, object otherBackend) {}
       public override bool IsPointInFill(object backend, double x, double y) { throw new NotImplementedException(); }
       public override void Dispose(object backend) {}
      //ctor: 
      public MacPathBackendHandler () {}
      public virtual bool DisposeHandleOnUiThread { get { throw new NotImplementedException(); } }
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
