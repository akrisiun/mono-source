
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("ce745aea-854a-364f-9f1c-a17fe6275ffb")]
   public class TextEntryBackend : ViewBackend<AppKit.NSView,Xwt.Backends.ITextEntryEventSink> Xwt.Backends.ITextEntryBackend
   {
       public override void Initialize() {}
       protected override void OnSizeToFit() {}
       protected override Xwt.Size GetNaturalSize() { throw new NotImplementedException(); }
       public virtual void SetCompletions(string[] completions) {}
       public virtual void SetCompletionMatchFunc(Func<string,string,bool> matchFunc) {}
       public override void SetFocus() {}
       public override void SetAutosizeMode(bool autosize) {}
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
       public virtual override Xwt.Size GetPreferredSize(Xwt.SizeConstraint widthConstraint, Xwt.SizeConstraint heightConstraint) { throw new NotImplementedException(); }
       public virtual override void SetMinSize(double width, double height) {}
       protected override void ResetFittingSize() {}
       public override void SizeToFit() {}
       protected virtual override Xwt.Size CalcFittingSize() { throw new NotImplementedException(); }
       public virtual override void SetSizeRequest(double width, double height) {}
       public virtual override void UpdateLayout() {}
      // public virtual override void EnableEvent(object eventId) {}
      // public virtual override void DisableEvent(object eventId) {}
       public virtual override void DragStart(Xwt.Backends.DragStartData sdata) {}
       public virtual override void SetDragSource(Xwt.TransferDataType[] types, Xwt.DragDropAction dragAction) {}
       public virtual override void SetDragTarget(Xwt.TransferDataType[] types, Xwt.DragDropAction dragAction) {}
       protected virtual override void OnDragOverCheck(AppKit.NSDraggingInfo di, Xwt.DragOverCheckEventArgs args) {}
       protected virtual override void OnDragOver(AppKit.NSDraggingInfo di, Xwt.DragOverEventArgs args) {}
      //ctor: 
      public TextEntryBackend () {}
      public new AppKit.NSTextField Widget { get { throw new NotImplementedException(); } }
      public virtual string Text { get; set; }
      public virtual Xwt.Alignment TextAlignment { get; set; }
      public virtual bool ReadOnly { get; set; }
      public virtual bool ShowFrame { get; set; }
      public virtual string PlaceholderText { get; set; }
      public virtual bool MultiLine { get; set; }
      public virtual int CursorPosition { get; set; }
      public virtual int SelectionStart { get; set; }
      public virtual int SelectionLength { get; set; }
      public virtual string SelectedText { get; set; }
      public virtual bool HasCompletions { get { throw new NotImplementedException(); } }
      public override bool CanGetFocus { get; set; }
      public override bool HasFocus { get { throw new NotImplementedException(); } }
      public override Xwt.Drawing.Color BackgroundColor { get; set; }
      public Xwt.Backends.ITextEntryEventSink EventSink { get { throw new NotImplementedException(); } }
      public Xwt.Widget Frontend { get { throw new NotImplementedException(); } }
      public Xwt.Backends.ApplicationContext ApplicationContext { get { throw new NotImplementedException(); } }
      public virtual object NativeWidget { get { throw new NotImplementedException(); } }
      public IViewObject ViewObject { get; set; }
      public virtual string Name { get; set; }
      public virtual bool Visible { get; set; }
      public virtual double Opacity { get; set; }
      public virtual bool Sensitive { get; set; }
      public virtual string TooltipText { get; set; }
      public virtual object Font { get; set; }
       // Field: 
       protected double minWidth;
       // Field: 
       protected double minHeight;
   }
}
