
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("6ba20016-2dc2-3591-9813-52c121910437")]
   public class MacTextLayoutBackendHandler : Xwt.Backends.TextLayoutBackendHandler
   {
       public override object Create() { throw new NotImplementedException(); }
       public override void SetText(object backend, string text) {}
       public override void SetFont(object backend, Xwt.Drawing.Font font) {}
       public override void SetWidth(object backend, double value) {}
       public override void SetHeight(object backend, double value) {}
       public override void SetTrimming(object backend, Xwt.Drawing.TextTrimming value) {}
       public override Xwt.Size GetSize(object backend) { throw new NotImplementedException(); }
       public override double GetBaseline(object backend) { throw new NotImplementedException(); }
       public override double GetMeanline(object backend) { throw new NotImplementedException(); }
       public override void AddAttribute(object backend, Xwt.Drawing.TextAttribute attribute) {}
       public override void ClearAttributes(object backend) {}
       public override int GetIndexFromCoordinates(object backend, double x, double y) { throw new NotImplementedException(); }
       public override Xwt.Point GetCoordinateFromIndex(object backend, int index) { throw new NotImplementedException(); }
       public override void Dispose(object backend) {}
      //ctor: 
      public MacTextLayoutBackendHandler () {}
      public virtual bool DisposeHandleOnUiThread { get { throw new NotImplementedException(); } }
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
