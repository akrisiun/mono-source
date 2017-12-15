
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("c24f9077-aa3a-3fdc-bcad-62213e4918e4")]
   public class AccessibleBackend : Xwt.Accessibility.IAccessibleBackend
   {
      // public void Initialize(Xwt.Backends.IWidgetBackend parentWidget, Xwt.Accessibility.IAccessibleEventSink eventSink) {}
      // public void Initialize(object parentWidget, Xwt.Accessibility.IAccessibleEventSink eventSink) {}
       public void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
      // public void EnableEvent(object eventId) {}
      // public void DisableEvent(object eventId) {}
      //ctor: 
      public AccessibleBackend () {}
   }
}
