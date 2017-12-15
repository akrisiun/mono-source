
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("22dfd1fa-0be9-3e91-ad9f-2a960deaf15c")]
   public class ShowDockMenuArgs : System.EventArgs
   {
      //ctor: 
      public ShowDockMenuArgs () {}
      public AppKit.NSMenu DockMenu { get; set; }
       // Field: 
       public static readonly EventArgs Empty;
   }
}
