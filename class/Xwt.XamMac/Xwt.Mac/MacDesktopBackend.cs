
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("d638a487-f692-3cc2-9aae-2f9c303e4f29")]
   public class MacDesktopBackend : Xwt.Backends.DesktopBackend
   {
       public override Xwt.Point GetMouseLocation() { throw new NotImplementedException(); }
       public override System.Collections.Generic.IEnumerable<object> GetScreens() { throw new NotImplementedException(); }
       public override bool IsPrimaryScreen(object backend) { throw new NotImplementedException(); }
       public static Xwt.Point ToDesktopPoint(CoreGraphics.CGPoint loc) { throw new NotImplementedException(); }
       public static Xwt.Rectangle ToDesktopRect(CoreGraphics.CGRect r) { throw new NotImplementedException(); }
       public static CoreGraphics.CGRect FromDesktopRect(Xwt.Rectangle r) { throw new NotImplementedException(); }
       public override Xwt.Rectangle GetScreenBounds(object backend) { throw new NotImplementedException(); }
       public override Xwt.Rectangle GetScreenVisibleBounds(object backend) { throw new NotImplementedException(); }
       public override string GetScreenDeviceName(object backend) { throw new NotImplementedException(); }
       public override double GetScaleFactor(object backend) { throw new NotImplementedException(); }
       public override void OnScreensChanged() {}
       public virtual override void OpenFile(string filename) {}
       public virtual override void OpenFolder(string folderPath) {}
       public virtual override void OpenUrl(string url) {}
       public virtual override object GetFileIcon(string fileName) { throw new NotImplementedException(); }
      //ctor: 
      public MacDesktopBackend () {}
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
