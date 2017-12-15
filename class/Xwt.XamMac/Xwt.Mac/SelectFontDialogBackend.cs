
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("14eec28f-8d65-3536-93c1-46b4de2aa272")]
   public class SelectFontDialogBackend : Xwt.Backends.ISelectFontDialogBackend
   {
       public virtual bool Run(Xwt.Backends.IWindowFrameBackend parent) { throw new NotImplementedException(); }
       public virtual void Dispose() {}
      //ctor: 
      public SelectFontDialogBackend () {}
      public virtual string Title { get; set; }
      public virtual Xwt.Drawing.Font SelectedFont { get; set; }
      public virtual string PreviewText { get; set; }
   }
}
