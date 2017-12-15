
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Accessibility
{  

   [Guid("6ca1ed9e-e7b4-34bf-87ef-23265401cef1")]
   public interface IAccessibleBackend
   {
       string Label { get; set; }
       string Identifier { get; set; }
       string Title { get; set; }
       string Description { get; set; }
       bool IsAccessible { get; set; }
       string Value { get; set; }
   }
}
