
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("db9d0390-1b66-3321-9d33-825210f24d0f")]
   public class MacFontBackendHandler : Xwt.Backends.FontBackendHandler
   {
       public override object GetSystemDefaultFont() { throw new NotImplementedException(); }
       public override object GetSystemDefaultMonospaceFont() { throw new NotImplementedException(); }
       public override System.Collections.Generic.IEnumerable<string> GetInstalledFonts() { throw new NotImplementedException(); }
       public override System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair> GetAvailableFamilyFaces(string family) { throw new NotImplementedException(); }
       public override object Create(string fontName, double size, Xwt.Drawing.FontStyle style, Xwt.Drawing.FontWeight weight, Xwt.Drawing.FontStretch stretch) { throw new NotImplementedException(); }
       public override bool RegisterFontFromFile(string fontPath) { throw new NotImplementedException(); }
       public override object Copy(object handle) { throw new NotImplementedException(); }
       public override object SetSize(object handle, double size) { throw new NotImplementedException(); }
       public override object SetFamily(object handle, string family) { throw new NotImplementedException(); }
       public override object SetStyle(object handle, Xwt.Drawing.FontStyle style) { throw new NotImplementedException(); }
       public override object SetWeight(object handle, Xwt.Drawing.FontWeight weight) { throw new NotImplementedException(); }
       public override object SetStretch(object handle, Xwt.Drawing.FontStretch stretch) { throw new NotImplementedException(); }
       public override double GetSize(object handle) { throw new NotImplementedException(); }
       public override string GetFamily(object handle) { throw new NotImplementedException(); }
       public override Xwt.Drawing.FontStyle GetStyle(object handle) { throw new NotImplementedException(); }
       public override Xwt.Drawing.FontWeight GetWeight(object handle) { throw new NotImplementedException(); }
       public override Xwt.Drawing.FontStretch GetStretch(object handle) { throw new NotImplementedException(); }
       protected static override string GetDefaultMonospaceFontNames(Xwt.DesktopType forDesktop) { throw new NotImplementedException(); }
       protected static override string GetDefaultSerifFontNames(Xwt.DesktopType forDesktop) { throw new NotImplementedException(); }
       protected static override string GetDefaultSansSerifFontNames(Xwt.DesktopType forDesktop) { throw new NotImplementedException(); }
       public virtual override object GetSystemDefaultSerifFont() { throw new NotImplementedException(); }
       public virtual override object GetSystemDefaultSansSerifFont() { throw new NotImplementedException(); }
      //ctor: 
      public MacFontBackendHandler () {}
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
