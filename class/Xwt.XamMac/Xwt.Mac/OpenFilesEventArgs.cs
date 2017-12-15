
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("2683c914-8b62-3f49-884d-c067a6b0c04e")]
   public class OpenFilesEventArgs : System.EventArgs
   {
      //ctor: 
      public OpenFilesEventArgs (string[] filenames) {}
      public String[] Filenames { get; set; }
       // Field: 
       public static readonly EventArgs Empty;
   }
}
