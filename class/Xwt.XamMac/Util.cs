
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("f90a2d5a-a8ac-3237-85cd-559a811c472f")]
   public static class Util
   {
       public static double WidgetX(this AppKit.NSView v) { throw new NotImplementedException(); }
       public static double WidgetY(this AppKit.NSView v) { throw new NotImplementedException(); }
       public static double WidgetWidth(this AppKit.NSView v) { throw new NotImplementedException(); }
       public static double WidgetHeight(this AppKit.NSView v) { throw new NotImplementedException(); }
       public static Xwt.Rectangle WidgetBounds(this AppKit.NSView v) { throw new NotImplementedException(); }
       public static Xwt.Point WidgetLocation(this AppKit.NSView v) { throw new NotImplementedException(); }
       public static void SetWidgetBounds(this AppKit.NSView v, Xwt.Rectangle rect) {}
       public static Xwt.Alignment ToAlignment(this AppKit.NSTextAlignment align) { throw new NotImplementedException(); }
       public static AppKit.NSTextAlignment ToNSTextAlignment(this Xwt.Alignment align) { throw new NotImplementedException(); }
       public static AppKit.NSColor ToNSColor(this Xwt.Drawing.Color col) { throw new NotImplementedException(); }
       public static CoreGraphics.CGColor ToCGColor(this Xwt.Drawing.Color col) { throw new NotImplementedException(); }
       public static Xwt.Drawing.Color ToXwtColor(this AppKit.NSColor col) { throw new NotImplementedException(); }
       public static Xwt.Drawing.Color ToXwtColor(this CoreGraphics.CGColor col) { throw new NotImplementedException(); }
       public static CoreGraphics.CGSize ToCGSize(this Xwt.Size s) { throw new NotImplementedException(); }
       public static Xwt.Size ToXwtSize(this CoreGraphics.CGSize s) { throw new NotImplementedException(); }
       public static CoreGraphics.CGRect ToCGRect(this Xwt.Rectangle r) { throw new NotImplementedException(); }
       public static Xwt.Rectangle ToXwtRect(this CoreGraphics.CGRect r) { throw new NotImplementedException(); }
       public static CoreGraphics.CGPoint ToCGPoint(this Xwt.Point r) { throw new NotImplementedException(); }
       public static Xwt.Point ToXwtPoint(this CoreGraphics.CGPoint p) { throw new NotImplementedException(); }
       public static int ToIconType(this string id) { throw new NotImplementedException(); }
       public static CoreGraphics.CGSize ToIconSize(this Xwt.IconSize size) { throw new NotImplementedException(); }
       public static string ToUTI(this Xwt.TransferDataType dt) { throw new NotImplementedException(); }
       public static AppKit.NSBitmapImageFileType ToMacFileType(this Xwt.Drawing.ImageFileType type) { throw new NotImplementedException(); }
       public static AppKit.NSImage ToNSImage(this Xwt.Backends.ImageDescription idesc) { throw new NotImplementedException(); }
       public static int ToUnderlineStyle(this Xwt.Drawing.FontStyle style) { throw new NotImplementedException(); }
       public static int ToMacValue(this Xwt.Drawing.FontWeight weight) { throw new NotImplementedException(); }
       public static AppKit.NSFont WithWeight(this AppKit.NSFont font, Xwt.Drawing.FontWeight weight) { throw new NotImplementedException(); }
       public static Foundation.NSMutableAttributedString ToAttributedString(this Xwt.FormattedText ft) { throw new NotImplementedException(); }
       public static Foundation.NSMutableAttributedString WithAlignment(this Foundation.NSMutableAttributedString ns, AppKit.NSTextAlignment alignment) { throw new NotImplementedException(); }
       public static string RemoveMnemonic(this string str) { throw new NotImplementedException(); }
       public static Xwt.CheckBoxState ToXwtState(this AppKit.NSCellStateValue state) { throw new NotImplementedException(); }
       public static AppKit.NSCellStateValue ToMacState(this Xwt.CheckBoxState state) { throw new NotImplementedException(); }
       public static Xwt.ModifierKeys ToXwtValue(this AppKit.NSEventModifierMask e) { throw new NotImplementedException(); }
       public static AppKit.NSTableViewGridStyle ToMacValue(this Xwt.GridLines value) { throw new NotImplementedException(); }
       public static Xwt.GridLines ToXwtValue(this AppKit.NSTableViewGridStyle value) { throw new NotImplementedException(); }
       public static AppKit.NSDatePickerElementFlags ToMacValue(this Xwt.DatePickerStyle style) { throw new NotImplementedException(); }
       public static Xwt.DatePickerStyle ToXwtValue(this AppKit.NSDatePickerElementFlags flags) { throw new NotImplementedException(); }
       public static void DrawWithColorTransform(this AppKit.NSView view, Nullable<Xwt.Drawing.Color> color, Action drawDelegate) {}
       public static CoreGraphics.CGPoint ConvertPointFromEvent(this AppKit.NSView view, AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
      public static CoreGraphics.CGColorSpace DeviceRGBColorSpace { get { throw new NotImplementedException(); } }
      public static CoreGraphics.CGColorSpace PatternColorSpace { get { throw new NotImplementedException(); } }
       // Field: 
       public static readonly string DeviceRGBString;
   }
}
