
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("85045f30-e3b9-3bc5-8834-75505d4680c3")]
   public class PopoverBackend : Xwt.Backends.IPopoverBackend
   {
       public virtual void Initialize(Xwt.Backends.IPopoverEventSink sink) {}
       public virtual void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
      // public virtual void EnableEvent(object eventId) {}
      // public virtual void DisableEvent(object eventId) {}
       public virtual void Show(Xwt.Position orientation, Xwt.Widget referenceWidget, Xwt.Rectangle positionRect, Xwt.Widget child) {}
       public virtual void Hide() {}
       public virtual void Dispose() {}
       public static AppKit.NSRectEdge ToRectEdge(Xwt.Position pos) { throw new NotImplementedException(); }
      //ctor: 
      public PopoverBackend () {}
      public Xwt.Popover Frontend { get { throw new NotImplementedException(); } }
      public Xwt.Backends.ApplicationContext ApplicationContext { get; set; }
      public Xwt.Backends.IPopoverEventSink EventSink { get; set; }
      public virtual Xwt.Drawing.Color BackgroundColor { get; set; }
   public class NSAppearanceCustomizationPopover.NSAppearanceCustomizationPopover
   }
}
