
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("7d783829-8c28-3e6c-9ebf-96343a19469e")]
   public class LinkLabelBackend : LabelBackend Xwt.Backends.ILinkLabelBackend
   {
       public override void Initialize() {}
      // public override void EnableEvent(object eventId) {}
      // public override void DisableEvent(object eventId) {}
       public virtual override Xwt.Size GetPreferredSize(Xwt.SizeConstraint widthConstraint, Xwt.SizeConstraint heightConstraint) { throw new NotImplementedException(); }
       public virtual override void SetFormattedText(Xwt.FormattedText text) {}
       public override void SetAutosizeMode(bool autosize) {}
       public virtual override void SetFocus() {}
       public override void NotifyPreferredSizeChanged() {}
       public virtual override void SetCursor(Xwt.CursorType cursor) {}
       public virtual override void Dispose() {}
       protected virtual override void Dispose(bool disposing) {}
       public static override AppKit.NSView GetWidget(Xwt.Backends.IWidgetBackend w) { throw new NotImplementedException(); }
       public static override AppKit.NSView GetWidget(Xwt.Widget w) { throw new NotImplementedException(); }
       public static override AppKit.NSView GetWidgetWithPlacement(Xwt.Backends.IWidgetBackend childBackend) { throw new NotImplementedException(); }
       public static override AppKit.NSView SetChildPlacement(Xwt.Backends.IWidgetBackend childBackend) { throw new NotImplementedException(); }
       public static override void RemoveChildPlacement(AppKit.NSView w) {}
       public virtual override void UpdateChildPlacement(Xwt.Backends.IWidgetBackend childBackend) {}
       public static override void ReplaceSubview(AppKit.NSView oldChild, AppKit.NSView newChild) {}
       public virtual override void ReplaceChild(AppKit.NSView oldChild, AppKit.NSView newChild) {}
       public override Xwt.Point ConvertToParentCoordinates(Xwt.Point widgetCoordinates) { throw new NotImplementedException(); }
       public override Xwt.Point ConvertToWindowCoordinates(Xwt.Point widgetCoordinates) { throw new NotImplementedException(); }
       public virtual override Xwt.Point ConvertToScreenCoordinates(Xwt.Point widgetCoordinates) { throw new NotImplementedException(); }
       protected virtual override Xwt.Size GetNaturalSize() { throw new NotImplementedException(); }
       public virtual override void SetMinSize(double width, double height) {}
       protected override void ResetFittingSize() {}
       public override void SizeToFit() {}
       protected virtual override Xwt.Size CalcFittingSize() { throw new NotImplementedException(); }
       protected virtual override void OnSizeToFit() {}
       public virtual override void SetSizeRequest(double width, double height) {}
       public virtual override void UpdateLayout() {}
       public virtual override void DragStart(Xwt.Backends.DragStartData sdata) {}
       public virtual override void SetDragSource(Xwt.TransferDataType[] types, Xwt.DragDropAction dragAction) {}
       public virtual override void SetDragTarget(Xwt.TransferDataType[] types, Xwt.DragDropAction dragAction) {}
       protected virtual override void OnDragOverCheck(AppKit.NSDraggingInfo di, Xwt.DragOverCheckEventArgs args) {}
       protected virtual override void OnDragOver(AppKit.NSDraggingInfo di, Xwt.DragOverEventArgs args) {}
      //ctor: 
      public LinkLabelBackend () {}
      public virtual Uri Uri { get; set; }
      public override string Text { get; set; }
      public AppKit.NSTextField Widget { get { throw new NotImplementedException(); } }
      public virtual bool Selectable { get; set; }
      public virtual Xwt.Drawing.Color TextColor { get; set; }
      public virtual Xwt.Alignment TextAlignment { get; set; }
      public virtual Xwt.EllipsizeMode Ellipsize { get; set; }
      public virtual Xwt.Drawing.Color BackgroundColor { get; set; }
      public virtual Xwt.WrapMode Wrap { get; set; }
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
       // Field: 
       protected double minWidth;
       // Field: 
       protected double minHeight;
   }
}
