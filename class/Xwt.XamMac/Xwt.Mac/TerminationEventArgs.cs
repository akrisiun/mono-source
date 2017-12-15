
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("77dc193f-6612-3c87-9ed9-80fbdb541e43")]
   public class TerminationEventArgs : System.EventArgs
   {
      //ctor: 
      public TerminationEventArgs () {}
      public AppKit.NSApplicationTerminateReply Reply { get; set; }
       // Field: 
       public static readonly EventArgs Empty;
   }
}
