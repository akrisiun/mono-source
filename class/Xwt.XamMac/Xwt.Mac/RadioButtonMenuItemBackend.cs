
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("76afacd7-3815-38c9-b02e-a0fdecb28ae0")]
   public class RadioButtonMenuItemBackend : MenuItemBackend Xwt.Backends.IRadioButtonMenuItemBackend
   {
      // public virtual override void Initialize(Xwt.Backends.IMenuItemEventSink eventSink) {}
       public virtual override void SetSubmenu(Xwt.Backends.IMenuBackend menu) {}
       public virtual override void SetImage(Xwt.Backends.ImageDescription image) {}
       public virtual override void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
      // public virtual override void EnableEvent(object eventId) {}
      // public virtual override void DisableEvent(object eventId) {}
      //ctor: 
      public RadioButtonMenuItemBackend () {}
      public AppKit.NSMenuItem Item { get { throw new NotImplementedException(); } }
      public virtual string Label { get; set; }
      public virtual bool UseMnemonic { get; set; }
      public virtual bool Visible { get; set; }
      public virtual bool Sensitive { get; set; }
      public virtual bool Checked { get; set; }
   }
}
