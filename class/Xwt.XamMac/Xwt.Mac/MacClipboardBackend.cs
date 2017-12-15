
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("373907d4-6b39-304f-87f2-1e2ceff2283f")]
   public class MacClipboardBackend : Xwt.Backends.ClipboardBackend
   {
       public override void Clear() {}
       public override void SetData(Xwt.TransferDataType type, Func<object> dataSource) {}
       public override bool IsTypeAvailable(Xwt.TransferDataType type) { throw new NotImplementedException(); }
       public override object GetData(Xwt.TransferDataType type) { throw new NotImplementedException(); }
       public override IAsyncResult BeginGetData(Xwt.TransferDataType type, AsyncCallback callback, object state) { throw new NotImplementedException(); }
       public override object EndGetData(IAsyncResult ares) { throw new NotImplementedException(); }
      //ctor: 
      public MacClipboardBackend () {}
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
