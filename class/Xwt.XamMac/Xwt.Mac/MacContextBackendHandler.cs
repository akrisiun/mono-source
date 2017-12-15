
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("76afdab7-2eb9-3e91-ad2a-a6baa9489100")]
   public class MacContextBackendHandler : Xwt.Backends.ContextBackendHandler
   {
       public override double GetScaleFactor(object backend) { throw new NotImplementedException(); }
       public override void Save(object backend) {}
       public override void Restore(object backend) {}
       public override void SetGlobalAlpha(object backend, double alpha) {}
       public override void SetStyles(object backend, Xwt.Drawing.StyleSet styles) {}
       public override void Arc(object backend, double xc, double yc, double radius, double angle1, double angle2) {}
       public override void ArcNegative(object backend, double xc, double yc, double radius, double angle1, double angle2) {}
       public override void Clip(object backend) {}
       public override void ClipPreserve(object backend) {}
       public override void ClosePath(object backend) {}
       public override void CurveTo(object backend, double x1, double y1, double x2, double y2, double x3, double y3) {}
       public override void Fill(object backend) {}
       public override void FillPreserve(object backend) {}
       public override void LineTo(object backend, double x, double y) {}
       public override void MoveTo(object backend, double x, double y) {}
       public override void NewPath(object backend) {}
       public override void Rectangle(object backend, double x, double y, double width, double height) {}
       public override void RelCurveTo(object backend, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3) {}
       public override void RelLineTo(object backend, double dx, double dy) {}
       public override void RelMoveTo(object backend, double dx, double dy) {}
       public override void Stroke(object backend) {}
       public override void StrokePreserve(object backend) {}
       public override void SetColor(object backend, Xwt.Drawing.Color color) {}
       public override void SetLineWidth(object backend, double width) {}
       public override void SetLineDash(object backend, double offset, double[] pattern) {}
       public override void SetPattern(object backend, object p) {}
       public override void DrawTextLayout(object backend, Xwt.Drawing.TextLayout layout, double x, double y) {}
       public override void DrawImage(object backend, Xwt.Backends.ImageDescription img, double x, double y) {}
       public override void DrawImage(object backend, Xwt.Backends.ImageDescription img, Xwt.Rectangle srcRect, Xwt.Rectangle destRect) {}
       public override void Rotate(object backend, double angle) {}
       public override void Scale(object backend, double scaleX, double scaleY) {}
       public override void Translate(object backend, double tx, double ty) {}
       public override void ModifyCTM(object backend, Xwt.Drawing.Matrix m) {}
       public override Xwt.Drawing.Matrix GetCTM(object backend) { throw new NotImplementedException(); }
       public override object CreatePath() { throw new NotImplementedException(); }
       public override object CopyPath(object backend) { throw new NotImplementedException(); }
       public override void AppendPath(object backend, object otherBackend) {}
       public override bool IsPointInFill(object backend, double x, double y) { throw new NotImplementedException(); }
       public override bool IsPointInStroke(object backend, double x, double y) { throw new NotImplementedException(); }
       public override void Dispose(object backend) {}
      //ctor: 
      public MacContextBackendHandler () {}
      public virtual bool DisposeHandleOnUiThread { get { throw new NotImplementedException(); } }
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
