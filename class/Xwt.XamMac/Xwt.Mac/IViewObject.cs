
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("a312a5f1-6d5d-37dc-a1d5-4cc51b0236ed")]
   public interface IViewObject
   {
       AppKit.NSView View { get; }
       ViewBackend Backend { get; set; }
   }
}
