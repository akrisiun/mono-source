
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("fa8f92c2-2092-3f3a-8ad0-8782add880b6")]
   public class MacKeyboardHandler : Xwt.Backends.KeyboardHandler
   {
      //ctor: 
      public MacKeyboardHandler () {}
      public override Xwt.ModifierKeys CurrentModifiers { get { throw new NotImplementedException(); } }
   }
}
