
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("740e2aa4-e51f-3b90-96db-903e93d7100f")]
   public class CellViewBackend : Xwt.Backends.ICanvasCellViewBackend
   {
       public virtual void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
      // public virtual void EnableEvent(object eventId) {}
      // public virtual void DisableEvent(object eventId) {}
       public virtual void QueueDraw() {}
      //ctor: 
      public CellViewBackend (AppKit.NSTableView table, int column) {}
      public Xwt.Backends.ICellViewFrontend Frontend { get { throw new NotImplementedException(); } }
      public AppKit.NSCell CurrentCell { get; set; }
      public int Column { get { throw new NotImplementedException(); } }
      public int CurrentRow { get; set; }
      public virtual Xwt.Rectangle CellBounds { get { throw new NotImplementedException(); } }
      public virtual Xwt.Rectangle BackgroundBounds { get { throw new NotImplementedException(); } }
      public virtual bool Selected { get { throw new NotImplementedException(); } }
      public virtual bool HasFocus { get { throw new NotImplementedException(); } }
   }
}
