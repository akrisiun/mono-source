
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("f5c8a6d1-a9e7-3b24-8ee4-95fe4831c254")]
   public class StatusIconBackend : Xwt.Backends.IStatusIconBackend
   {
       public virtual void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
       public virtual void SetMenu(object menuBackend) {}
       public virtual void SetImage(Xwt.Backends.ImageDescription image) {}
      // public virtual void EnableEvent(object eventId) {}
      // public virtual void DisableEvent(object eventId) {}
       public virtual void Dispose() {}
      //ctor: 
      public StatusIconBackend () {}
   }
}
