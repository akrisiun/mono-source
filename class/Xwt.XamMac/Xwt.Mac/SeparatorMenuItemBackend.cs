
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("683e3e7b-7f29-31e3-a3c4-3dc4d48703d9")]
   public class SeparatorMenuItemBackend : MenuItemBackend Xwt.Backends.ISeparatorMenuItemBackend
   {
      // public virtual override void Initialize(Xwt.Backends.IMenuItemEventSink eventSink) {}
       public virtual override void SetSubmenu(Xwt.Backends.IMenuBackend menu) {}
       public virtual override void SetImage(Xwt.Backends.ImageDescription image) {}
       public virtual override void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
      // public virtual override void EnableEvent(object eventId) {}
      // public virtual override void DisableEvent(object eventId) {}
      //ctor: 
      public SeparatorMenuItemBackend () {}
      public AppKit.NSMenuItem Item { get { throw new NotImplementedException(); } }
      public virtual string Label { get; set; }
      public virtual bool UseMnemonic { get; set; }
      public virtual bool Visible { get; set; }
      public virtual bool Sensitive { get; set; }
      public virtual bool Checked { get; set; }
   }
}
