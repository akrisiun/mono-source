
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("f33277e3-2526-3ab4-821b-49e1005dbec2")]
   public class OpenUrlEventArgs : System.EventArgs
   {
      //ctor: 
      public OpenUrlEventArgs (string url) {}
      public string Url { get; set; }
       // Field: 
       public static readonly EventArgs Empty;
   }
}
