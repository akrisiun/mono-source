
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("c4e891f2-6708-306a-b239-655126798d24")]
   public class FontData
   {
       public static FontData FromFamily(string family, AppKit.NSFontTraitMask traits, int weight, float size) { throw new NotImplementedException(); }
       public static FontData FromFont(AppKit.NSFont font) { throw new NotImplementedException(); }
       public FontData Copy() { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
      //ctor: 
      public FontData () {}
       // Field: 
       public AppKit.NSFont Font;
       // Field: 
       public Xwt.Drawing.FontStyle Style;
       // Field: 
       public Xwt.Drawing.FontWeight Weight;
       // Field: 
       public Xwt.Drawing.FontStretch Stretch;
   }
}
