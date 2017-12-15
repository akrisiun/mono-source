
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("aee7262f-1fdf-3544-8254-b17537d1bef9")]
   public class MenuItemBackend : Xwt.Backends.IMenuItemBackend
   {
      // public virtual void Initialize(Xwt.Backends.IMenuItemEventSink eventSink) {}
       public virtual void SetSubmenu(Xwt.Backends.IMenuBackend menu) {}
       public virtual void SetImage(Xwt.Backends.ImageDescription image) {}
       public virtual void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
      // public virtual void EnableEvent(object eventId) {}
      // public virtual void DisableEvent(object eventId) {}
      //ctor: 
      public MenuItemBackend () {}
      //ctor: 
      public MenuItemBackend (AppKit.NSMenuItem item) {}
      public AppKit.NSMenuItem Item { get { throw new NotImplementedException(); } }
      public virtual string Label { get; set; }
      public virtual bool UseMnemonic { get; set; }
      public virtual bool Visible { get; set; }
      public virtual bool Sensitive { get; set; }
      public virtual bool Checked { get; set; }
   }
}
