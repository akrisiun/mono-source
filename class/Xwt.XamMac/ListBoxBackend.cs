
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("3ca6f1a7-e664-37f5-ad24-4be822bc8c87")]
   public class ListBoxBackend : ListViewBackend Xwt.Backends.IListBoxBackend
   {
       public override void Initialize() {}
       public virtual void SetViews(Xwt.CellViewCollection views) {}
       public override void SetSource(Xwt.IListDataSource source, Xwt.Backends.IBackend sourceBackend) {}
       protected virtual override AppKit.NSTableView CreateView() { throw new NotImplementedException(); }
      // public virtual override void EnableEvent(object eventId) {}
      // public virtual override void DisableEvent(object eventId) {}
       public virtual override void SelectRow(int pos) {}
       public virtual override void UnselectRow(int pos) {}
       public virtual override object GetValue(object pos, int nField) { throw new NotImplementedException(); }
       public virtual override void SetValue(object pos, int nField, object value) {}
       public virtual override void SetCurrentEventRow(object pos) {}
       public virtual override int GetRowAtPosition(Xwt.Point p) { throw new NotImplementedException(); }
       public virtual override Xwt.Backends.IScrollControlBackend CreateVerticalScrollControl() { throw new NotImplementedException(); }
       public virtual override Xwt.Backends.IScrollControlBackend CreateHorizontalScrollControl() { throw new NotImplementedException(); }
       protected virtual override Xwt.Size GetNaturalSize() { throw new NotImplementedException(); }
       public virtual override void SetSelectionMode(Xwt.SelectionMode mode) {}
       public virtual override AppKit.NSTableColumn AddColumn(Xwt.ListViewColumn col) { throw new NotImplementedException(); }
       public virtual override void RemoveColumn(Xwt.ListViewColumn col, object handle) {}
       public virtual override void UpdateColumn(Xwt.ListViewColumn col, object handle, Xwt.Backends.ListViewColumnChange change) {}
       public virtual override Xwt.Rectangle GetCellBounds(int row, Xwt.CellView cell, bool includeMargin) { throw new NotImplementedException(); }
       public virtual override Xwt.Rectangle GetRowBounds(int row, bool includeMargin) { throw new NotImplementedException(); }
       public virtual override void SelectAll() {}
       public virtual override void UnselectAll() {}
       public virtual override void ScrollToRow(int row) {}
       public virtual override void StartEditingCell(int row, Xwt.CellView cell) {}
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
       public virtual override Xwt.Size GetPreferredSize(Xwt.SizeConstraint widthConstraint, Xwt.SizeConstraint heightConstraint) { throw new NotImplementedException(); }
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
      public ListBoxBackend () {}
      public new virtual bool GridLinesVisible { get; set; }
      protected virtual string SelectionChangeEventName { }
      public virtual Int32[] SelectedRows { get { throw new NotImplementedException(); } }
      public virtual int FocusedRow { get; set; }
      public virtual int CurrentEventRow { get { throw new NotImplementedException(); } }
      public virtual Xwt.ScrollPolicy VerticalScrollPolicy { get; set; }
      public virtual Xwt.ScrollPolicy HorizontalScrollPolicy { get; set; }
      public virtual bool BorderVisible { get; set; }
      public virtual bool HeadersVisible { get; set; }
      public Xwt.Backends.IListViewEventSink EventSink { get { throw new NotImplementedException(); } }
      public AppKit.NSScrollView Widget { get { throw new NotImplementedException(); } }
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
       protected AppKit.NSTableView Table;
       // Field: 
       protected double minWidth;
       // Field: 
       protected double minHeight;
   }
}
