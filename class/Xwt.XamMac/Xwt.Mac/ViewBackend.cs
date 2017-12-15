
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("f8dcaa40-5867-3aec-b503-dfe50e047bbd")]
   public abstract class ViewBackend : Xwt.Backends.IWidgetBackend
   {
       public void SetAutosizeMode(bool autosize) {}
       public virtual void Initialize() {}
       public virtual void SetFocus() {}
       public void NotifyPreferredSizeChanged() {}
       public virtual void SetCursor(Xwt.CursorType cursor) {}
       protected override void Finalize() {}
       public virtual void Dispose() {}
       protected virtual void Dispose(bool disposing) {}
       public static AppKit.NSView GetWidget(Xwt.Backends.IWidgetBackend w) { throw new NotImplementedException(); }
       public static AppKit.NSView GetWidget(Xwt.Widget w) { throw new NotImplementedException(); }
       public static AppKit.NSView GetWidgetWithPlacement(Xwt.Backends.IWidgetBackend childBackend) { throw new NotImplementedException(); }
       public static AppKit.NSView SetChildPlacement(Xwt.Backends.IWidgetBackend childBackend) { throw new NotImplementedException(); }
       public static void RemoveChildPlacement(AppKit.NSView w) {}
       public virtual void UpdateChildPlacement(Xwt.Backends.IWidgetBackend childBackend) {}
       public static void ReplaceSubview(AppKit.NSView oldChild, AppKit.NSView newChild) {}
       public virtual void ReplaceChild(AppKit.NSView oldChild, AppKit.NSView newChild) {}
       public Xwt.Point ConvertToParentCoordinates(Xwt.Point widgetCoordinates) { throw new NotImplementedException(); }
       public Xwt.Point ConvertToWindowCoordinates(Xwt.Point widgetCoordinates) { throw new NotImplementedException(); }
       public virtual Xwt.Point ConvertToScreenCoordinates(Xwt.Point widgetCoordinates) { throw new NotImplementedException(); }
       protected virtual Xwt.Size GetNaturalSize() { throw new NotImplementedException(); }
       public virtual Xwt.Size GetPreferredSize(Xwt.SizeConstraint widthConstraint, Xwt.SizeConstraint heightConstraint) { throw new NotImplementedException(); }
       public virtual void SetMinSize(double width, double height) {}
       protected void ResetFittingSize() {}
       public void SizeToFit() {}
       protected virtual Xwt.Size CalcFittingSize() { throw new NotImplementedException(); }
       protected virtual void OnSizeToFit() {}
       public virtual void SetSizeRequest(double width, double height) {}
       public virtual void UpdateLayout() {}
      // public virtual void EnableEvent(object eventId) {}
      // public virtual void DisableEvent(object eventId) {}
       public virtual void DragStart(Xwt.Backends.DragStartData sdata) {}
       public virtual void SetDragSource(Xwt.TransferDataType[] types, Xwt.DragDropAction dragAction) {}
       public virtual void SetDragTarget(Xwt.TransferDataType[] types, Xwt.DragDropAction dragAction) {}
       protected virtual void OnDragOverCheck(AppKit.NSDraggingInfo di, Xwt.DragOverCheckEventArgs args) {}
       protected virtual void OnDragOver(AppKit.NSDraggingInfo di, Xwt.DragOverEventArgs args) {}
      //ctor: 
      protected ViewBackend () {}
      public Xwt.Backends.IWidgetEventSink EventSink { get { throw new NotImplementedException(); } }
      public AppKit.NSView Widget { get { throw new NotImplementedException(); } }
      public Xwt.Widget Frontend { get { throw new NotImplementedException(); } }
      public Xwt.Backends.ApplicationContext ApplicationContext { get { throw new NotImplementedException(); } }
      public virtual object NativeWidget { get { throw new NotImplementedException(); } }
      public IViewObject ViewObject { get; set; }
      public virtual string Name { get; set; }
      public virtual bool Visible { get; set; }
      public virtual double Opacity { get; set; }
      public virtual bool Sensitive { get; set; }
      public virtual bool CanGetFocus { get; set; }
      public virtual bool HasFocus { get { throw new NotImplementedException(); } }
      public virtual string TooltipText { get; set; }
      public virtual object Font { get; set; }
      public virtual Xwt.Drawing.Color BackgroundColor { get; set; }
       // Field: 
       protected double minWidth;
       // Field: 
       protected double minHeight;
   }
}
