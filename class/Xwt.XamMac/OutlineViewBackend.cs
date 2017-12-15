
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("6b28d375-6406-3e85-96e3-907a153c20e5")]
   public class OutlineViewBackend : AppKit.NSOutlineView
   {
       public override void AddColumn(AppKit.NSTableColumn tableColumn) {}
       public override void ExpandItem(Foundation.NSObject item) {}
       public override void ExpandItem(Foundation.NSObject item, bool expandChildren) {}
       public override void CollapseItem(Foundation.NSObject item) {}
       public override void CollapseItem(Foundation.NSObject item, bool collapseChildren) {}
       public override void ReloadData() {}
       public override void ReloadData(Foundation.NSIndexSet rowIndexes, Foundation.NSIndexSet columnIndexes) {}
       public override void ReloadItem(Foundation.NSObject item) {}
       public override void ReloadItem(Foundation.NSObject item, bool reloadChildren) {}
       public override void UpdateTrackingAreas() {}
       public override void RightMouseDown(AppKit.NSEvent theEvent) {}
       public override void RightMouseUp(AppKit.NSEvent theEvent) {}
       public override void MouseDown(AppKit.NSEvent theEvent) {}
       public override void MouseUp(AppKit.NSEvent theEvent) {}
       public override void MouseEntered(AppKit.NSEvent theEvent) {}
       public override void MouseExited(AppKit.NSEvent theEvent) {}
       public override void MouseMoved(AppKit.NSEvent theEvent) {}
       public override void MouseDragged(AppKit.NSEvent theEvent) {}
       public virtual override CoreGraphics.CGRect FrameOfOutlineCellAtRow(nint row) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetChild(nint index, Foundation.NSObject parentItem) { throw new NotImplementedException(); }
       public virtual override nint GetChildIndex(Foundation.NSObject item) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetParent(Foundation.NSObject item) { throw new NotImplementedException(); }
       public virtual override void InsertItems(Foundation.NSIndexSet indexes, Foundation.NSObject parent, AppKit.NSTableViewAnimation animationOptions) {}
       public virtual override void InsertRows(Foundation.NSIndexSet indexes, AppKit.NSTableViewAnimation animationOptions) {}
       public virtual override bool IsExpandable(Foundation.NSObject item) { throw new NotImplementedException(); }
       public virtual override bool IsItemExpanded(Foundation.NSObject item) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject ItemAtRow(nint row) { throw new NotImplementedException(); }
       public virtual override nint LevelForItem(Foundation.NSObject item) { throw new NotImplementedException(); }
       public virtual override nint LevelForRow(nint row) { throw new NotImplementedException(); }
       public virtual override void MoveItem(nint fromIndex, Foundation.NSObject oldParent, nint toIndex, Foundation.NSObject newParent) {}
       public virtual override void MoveRow(nint oldIndex, nint newIndex) {}
       public virtual override nint NumberOfChildren(Foundation.NSObject item) { throw new NotImplementedException(); }
       public virtual override void RemoveItems(Foundation.NSIndexSet indexes, Foundation.NSObject parent, AppKit.NSTableViewAnimation animationOptions) {}
       public virtual override void RemoveRows(Foundation.NSIndexSet indexes, AppKit.NSTableViewAnimation animationOptions) {}
       public virtual override nint RowForItem(Foundation.NSObject item) { throw new NotImplementedException(); }
       public virtual override void SetDropItem(Foundation.NSObject item, nint index) {}
       public virtual override bool ShouldCollapseAutoExpandedItems(bool forDeposited) { throw new NotImplementedException(); }
       protected virtual override void Dispose(bool disposing) {}
       public override void SelectRow(nint row, bool byExtendingSelection) {}
       public override void SelectColumn(nint column, bool byExtendingSelection) {}
       public virtual override void BeginUpdates() {}
       public virtual override bool CanDragRows(Foundation.NSIndexSet rowIndexes, CoreGraphics.CGPoint mouseDownPoint) { throw new NotImplementedException(); }
       public virtual override nint ColumnForView(AppKit.NSView view) { throw new NotImplementedException(); }
       public virtual override void DeselectAll(Foundation.NSObject sender) {}
       public virtual override void DeselectColumn(nint column) {}
       public virtual override void DeselectRow(nint row) {}
      // public virtual override AppKit.NSImage DragImageForRowsWithIndexestableColumnseventoffset(Foundation.NSIndexSet dragRows, AppKit.NSTableColumn[] tableColumns, AppKit.NSEvent dragEvent, CoreGraphics.CGPoint dragImageOffset) { throw new NotImplementedException(); }
       public virtual override void DraggedImageBeganAt(AppKit.NSImage image, CoreGraphics.CGPoint screenPoint) {}
       public virtual override void DraggedImageEndedAtDeposited(AppKit.NSImage image, CoreGraphics.CGPoint screenPoint, bool deposited) {}
       public virtual override void DraggedImageEndedAtOperation(AppKit.NSImage image, CoreGraphics.CGPoint screenPoint, AppKit.NSDragOperation operation) {}
       public virtual override void DraggedImageMovedTo(AppKit.NSImage image, CoreGraphics.CGPoint screenPoint) {}
       public virtual override AppKit.NSDragOperation DraggingSourceOperationMaskForLocal(bool flag) { throw new NotImplementedException(); }
       public virtual override void DrawBackground(CoreGraphics.CGRect clipRect) {}
       public virtual override void DrawGrid(CoreGraphics.CGRect clipRect) {}
       public virtual override void DrawRow(nint row, CoreGraphics.CGRect clipRect) {}
       public virtual override void EditColumn(nint column, nint row, AppKit.NSEvent theEvent, bool select) {}
       public virtual override void EndUpdates() {}
       public virtual override void EnumerateAvailableRowViews(AppKit.NSTableViewRowHandler callback) {}
       public virtual override nint FindColumn(Foundation.NSString identifier) { throw new NotImplementedException(); }
       public virtual override AppKit.NSTableColumn FindTableColumn(Foundation.NSString identifier) { throw new NotImplementedException(); }
       public virtual override AppKit.NSCell GetCell(nint column, nint row) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect GetCellFrame(nint column, nint row) { throw new NotImplementedException(); }
       public virtual override nint GetColumn(CoreGraphics.CGPoint point) { throw new NotImplementedException(); }
       public virtual override Foundation.NSIndexSet GetColumnIndexesInRect(CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public virtual override AppKit.NSImage GetIndicatorImage(AppKit.NSTableColumn tableColumn) { throw new NotImplementedException(); }
       public virtual override nint GetRow(CoreGraphics.CGPoint point) { throw new NotImplementedException(); }
       public virtual override AppKit.NSTableRowView GetRowView(nint row, bool makeIfNecessary) { throw new NotImplementedException(); }
       public virtual override AppKit.NSView GetView(nint column, nint row, bool makeIfNecessary) { throw new NotImplementedException(); }
       public virtual override void HideRows(Foundation.NSIndexSet indexes, AppKit.NSTableViewAnimation rowAnimation) {}
       public virtual override void HighlightSelection(CoreGraphics.CGRect clipRect) {}
       public virtual override bool IsColumnSelected(nint column) { throw new NotImplementedException(); }
       public virtual override bool IsRowSelected(nint row) { throw new NotImplementedException(); }
       public virtual override AppKit.NSView MakeView(string identifier, Foundation.NSObject owner) { throw new NotImplementedException(); }
       public virtual override void MoveColumn(nint oldIndex, nint newIndex) {}
       public virtual override string[] NamesOfPromisedFilesDroppedAtDestination(Foundation.NSUrl dropDestination) { throw new NotImplementedException(); }
       public virtual override void NoteHeightOfRowsWithIndexesChanged(Foundation.NSIndexSet indexSet) {}
       public virtual override void NoteNumberOfRowsChanged() {}
       public virtual override void PerformClick(nint column, nint row) {}
       public virtual override CoreGraphics.CGRect RectForColumn(nint column) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect RectForRow(nint row) { throw new NotImplementedException(); }
       public virtual override void RegisterNib(AppKit.NSNib nib, string identifier) {}
       public virtual override void RemoveColumn(AppKit.NSTableColumn tableColumn) {}
       public virtual override nint RowForView(AppKit.NSView view) { throw new NotImplementedException(); }
       public virtual override void RowViewAdded(AppKit.NSTableRowView rowView, nint row) {}
       public virtual override void RowViewRemoved(AppKit.NSTableRowView rowView, nint row) {}
       public virtual override Foundation.NSRange RowsInRect(CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public virtual override void ScrollColumnToVisible(nint column) {}
       public virtual override void ScrollRowToVisible(nint row) {}
       public virtual override void SelectAll(Foundation.NSObject sender) {}
       public virtual override void SelectColumns(Foundation.NSIndexSet indexes, bool byExtendingSelection) {}
       public virtual override void SelectRows(Foundation.NSIndexSet indexes, bool byExtendingSelection) {}
       public virtual override void SetDraggingSourceOperationMask(AppKit.NSDragOperation mask, bool isLocal) {}
       public virtual override void SetDropRowDropOperation(nint row, AppKit.NSTableViewDropOperation dropOperation) {}
       public virtual override void SetIndicatorImage(AppKit.NSImage anImage, AppKit.NSTableColumn tableColumn) {}
       public virtual override bool ShouldFocusCell(AppKit.NSCell cell, nint column, nint row) { throw new NotImplementedException(); }
       public virtual override void SizeLastColumnToFit() {}
       public virtual override void SizeToFit() {}
       public virtual override AppKit.NSTableColumn[] TableColumns() { throw new NotImplementedException(); }
       public virtual override void TextDidBeginEditing(Foundation.NSNotification notification) {}
       public virtual override void TextDidChange(Foundation.NSNotification notification) {}
       public virtual override void TextDidEndEditing(Foundation.NSNotification notification) {}
       public virtual override bool TextShouldBeginEditing(AppKit.NSText textObject) { throw new NotImplementedException(); }
       public virtual override bool TextShouldEndEditing(AppKit.NSText textObject) { throw new NotImplementedException(); }
       public virtual override void Tile() {}
       public virtual override void UnhideRows(Foundation.NSIndexSet indexes, AppKit.NSTableViewAnimation rowAnimation) {}
       public virtual override bool AbortEditing() { throw new NotImplementedException(); }
       public virtual override void CalcSize() {}
       public virtual override void DrawCell(AppKit.NSCell aCell) {}
       public virtual override void DrawCellInside(AppKit.NSCell aCell) {}
       public virtual override void DrawWithExpansionFrame(CoreGraphics.CGRect cellFrame, AppKit.NSView view) {}
       public virtual override void EditWithFrame(CoreGraphics.CGRect aRect, AppKit.NSText textObj, Foundation.NSObject anObject, AppKit.NSEvent theEvent) {}
       public virtual override void EndEditing(AppKit.NSText textObj) {}
       public virtual override void InvalidateIntrinsicContentSizeForCell(AppKit.NSCell cell) {}
       public virtual override void PerformClick(Foundation.NSObject sender) {}
       public virtual override void SelectCell(AppKit.NSCell aCell) {}
       public virtual override void SelectWithFrame(CoreGraphics.CGRect aRect, AppKit.NSText textObj, Foundation.NSObject anObject, nint selStart, nint selLength) {}
       public virtual override bool SendAction(ObjCRuntime.Selector theAction, Foundation.NSObject theTarget) { throw new NotImplementedException(); }
       public virtual override nint SendActionOn(AppKit.NSEventType mask) { throw new NotImplementedException(); }
       public virtual override void SetNeedsDisplay() {}
       public virtual override CoreGraphics.CGSize SizeThatFits(CoreGraphics.CGSize size) { throw new NotImplementedException(); }
       public virtual override void TakeDoubleValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeFloatValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeIntValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeIntegerValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeObjectValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeStringValueFrom(Foundation.NSObject sender) {}
       public virtual override void UpdateCell(AppKit.NSCell aCell) {}
       public virtual override void UpdateCellInside(AppKit.NSCell aCell) {}
       public virtual override void ValidateEditing() {}
       public virtual override bool AcceptsFirstMouse(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override void AccessibilityPerformAction(Foundation.NSString action) {}
       public virtual override bool AccessibilityPerformCancel() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformConfirm() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformDecrement() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformDelete() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformIncrement() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformPick() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformPress() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformRaise() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformShowAlternateUI() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformShowDefaultUI() { throw new NotImplementedException(); }
       public virtual override bool AccessibilityPerformShowMenu() { throw new NotImplementedException(); }
       public virtual override void AddConstraint(AppKit.NSLayoutConstraint constraint) {}
       public virtual override void AddConstraints(AppKit.NSLayoutConstraint[] constraints) {}
       public virtual override void AddCursorRect(CoreGraphics.CGRect aRect, AppKit.NSCursor cursor) {}
       public virtual override void AddGestureRecognizer(AppKit.NSGestureRecognizer gestureRecognizer) {}
       public virtual override void AddLayoutGuide(AppKit.NSLayoutGuide guide) {}
       public virtual override void AddSubview(AppKit.NSView aView) {}
       public virtual override void AddSubview(AppKit.NSView aView, AppKit.NSWindowOrderingMode place, AppKit.NSView otherView) {}
       public virtual override nint AddToolTip(CoreGraphics.CGRect aRect, Foundation.NSObject anObject, IntPtr data) { throw new NotImplementedException(); }
       public virtual override void AddTrackingArea(AppKit.NSTrackingArea trackingArea) {}
       public virtual override nint AddTrackingRect(CoreGraphics.CGRect aRect, Foundation.NSObject anObject, IntPtr data, bool assumeInside) { throw new NotImplementedException(); }
       public virtual override void AdjustPageHeightNew(nfloat newBottom, nfloat top, nfloat proposedBottom, nfloat bottomLimit) {}
       public virtual override void AdjustPageWidthNew(nfloat newRight, nfloat left, nfloat proposedRight, nfloat rightLimit) {}
       public virtual override CoreGraphics.CGRect AdjustScroll(CoreGraphics.CGRect newVisible) { throw new NotImplementedException(); }
       public virtual override void AllocateGState() {}
       public virtual override AppKit.NSView AncestorSharedWithView(AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject AnimationFor(Foundation.NSString key) { throw new NotImplementedException(); }
       public virtual override bool Autoscroll(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect BackingAlignedRect(CoreGraphics.CGRect aRect, Foundation.NSAlignmentOptions options) { throw new NotImplementedException(); }
       public virtual override void BeginDocument() {}
       public virtual override AppKit.NSDraggingSession BeginDraggingSession(AppKit.NSDraggingItem[] items, AppKit.NSEvent evnt, AppKit.INSDraggingSource source) { throw new NotImplementedException(); }
       public virtual override void BeginPage(CoreGraphics.CGRect rect, CoreGraphics.CGPoint placement) {}
       public virtual override AppKit.NSBitmapImageRep BitmapImageRepForCachingDisplayInRect(CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public virtual override void CacheDisplay(CoreGraphics.CGRect rect, AppKit.NSBitmapImageRep bitmapImageRep) {}
       public virtual override bool CanDraw() { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect CenterScanRect(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override void ConcludeDragOperation(AppKit.NSDraggingInfo sender) {}
       public virtual override CoreGraphics.CGPoint ConvertPointFromBacking(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertPointFromBase(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertPointFromLayer(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertPointFromView(CoreGraphics.CGPoint aPoint, AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertPointToBacking(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertPointToBase(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertPointToLayer(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertPointToView(CoreGraphics.CGPoint aPoint, AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectFromBacking(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectFromBase(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectFromLayer(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectFromView(CoreGraphics.CGRect aRect, AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectToBacking(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectToBase(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectToLayer(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectToView(CoreGraphics.CGRect aRect, AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeFromBacking(CoreGraphics.CGSize aSize) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeFromBase(CoreGraphics.CGSize aSize) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeFromLayer(CoreGraphics.CGSize aSize) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeFromView(CoreGraphics.CGSize aSize, AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeToBacking(CoreGraphics.CGSize aSize) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeToBase(CoreGraphics.CGSize aSize) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeToLayer(CoreGraphics.CGSize aSize) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize ConvertSizeToView(CoreGraphics.CGSize aSize, AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override Foundation.NSData DataWithEpsInsideRect(CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public virtual override Foundation.NSData DataWithPdfInsideRect(CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public static override Foundation.NSObject DefaultAnimationFor(Foundation.NSString key) { throw new NotImplementedException(); }
       public static override AppKit.NSMenu DefaultMenu() { throw new NotImplementedException(); }
       public virtual override void DidAddSubview(AppKit.NSView subview) {}
       public virtual override void DidChangeBackingProperties() {}
       public virtual override void DidCloseMenu(AppKit.NSMenu menu, AppKit.NSEvent theEvent) {}
       public virtual override void DiscardCursorRects() {}
       public virtual override void Display() {}
       public virtual override void DisplayIfNeeded() {}
       public virtual override void DisplayIfNeededIgnoringOpacity() {}
       public virtual override void DisplayIfNeededInRect(CoreGraphics.CGRect rect) {}
       public virtual override void DisplayIfNeededInRectIgnoringOpacity(CoreGraphics.CGRect rect) {}
       public virtual override void DisplayRect(CoreGraphics.CGRect rect) {}
       public virtual override void DisplayRectIgnoringOpacity(CoreGraphics.CGRect rect) {}
       public virtual override void DisplayRectIgnoringOpacity(CoreGraphics.CGRect aRect, AppKit.NSGraphicsContext context) {}
       public virtual override bool DragFile(string filename, CoreGraphics.CGRect aRect, bool slideBack, AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override void DragImage(AppKit.NSImage anImage, CoreGraphics.CGPoint viewLocation, CoreGraphics.CGSize initialOffset, AppKit.NSEvent theEvent, AppKit.NSPasteboard pboard, Foundation.NSObject sourceObj, bool slideFlag) {}
       public virtual override bool DragPromisedFilesOfTypes(string[] typeArray, CoreGraphics.CGRect aRect, Foundation.NSObject sourceObject, bool slideBack, AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override void DraggingEnded(AppKit.NSDraggingInfo sender) {}
       public virtual override AppKit.NSDragOperation DraggingEntered(AppKit.NSDraggingInfo sender) { throw new NotImplementedException(); }
       public virtual override void DraggingExited(AppKit.NSDraggingInfo sender) {}
       public virtual override AppKit.NSDragOperation DraggingUpdated(AppKit.NSDraggingInfo sender) { throw new NotImplementedException(); }
       public virtual override void DrawFocusRingMask() {}
       public virtual override void DrawPageBorder(CoreGraphics.CGSize borderSize) {}
       public virtual override void DrawRect(CoreGraphics.CGRect dirtyRect) {}
       public virtual override void DrawSheetBorder(CoreGraphics.CGSize borderSize) {}
       public virtual override void EndDocument() {}
       public virtual override void EndPage() {}
       public virtual override bool EnterFullscreenModeWithOptions(AppKit.NSScreen screen, Foundation.NSDictionary options) { throw new NotImplementedException(); }
       public virtual override void ExerciseAmbiguityInLayout() {}
       public virtual override void ExitFullscreenModeWithOptions(Foundation.NSDictionary options) {}
       public static override AppKit.NSView FocusView() { throw new NotImplementedException(); }
       public virtual override nint GState() { throw new NotImplementedException(); }
       public virtual override Foundation.NSString GetAccessibilityActionDescription(Foundation.NSString action) { throw new NotImplementedException(); }
       public virtual override nuint GetAccessibilityArrayAttributeCount(Foundation.NSString attribute) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject[] GetAccessibilityArrayAttributeValues(Foundation.NSString attribute, nuint index, nuint maxCount) { throw new NotImplementedException(); }
       public virtual override Foundation.NSAttributedString GetAccessibilityAttributedString(Foundation.NSRange range) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetAccessibilityCellForColumn(nint column, nint row) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetAccessibilityFocusedUIElement() { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect GetAccessibilityFrame(Foundation.NSRange range) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetAccessibilityHitTest(CoreGraphics.CGPoint point) { throw new NotImplementedException(); }
       public virtual override nuint GetAccessibilityIndexOfChild(Foundation.NSObject child) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint GetAccessibilityLayoutForScreen(CoreGraphics.CGPoint point) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize GetAccessibilityLayoutForScreen(CoreGraphics.CGSize size) { throw new NotImplementedException(); }
       public virtual override nint GetAccessibilityLine(nint index) { throw new NotImplementedException(); }
       public virtual override Foundation.NSRange GetAccessibilityRange(CoreGraphics.CGPoint point) { throw new NotImplementedException(); }
       public virtual override Foundation.NSRange GetAccessibilityRange(nint index) { throw new NotImplementedException(); }
       public virtual override Foundation.NSRange GetAccessibilityRangeForLine(nint line) { throw new NotImplementedException(); }
       public virtual override Foundation.NSData GetAccessibilityRtf(Foundation.NSRange range) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint GetAccessibilityScreenForLayout(CoreGraphics.CGPoint point) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize GetAccessibilityScreenForLayout(CoreGraphics.CGSize size) { throw new NotImplementedException(); }
       public virtual override string GetAccessibilityString(Foundation.NSRange range) { throw new NotImplementedException(); }
       public virtual override Foundation.NSRange GetAccessibilityStyleRange(nint index) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetAccessibilityValue(Foundation.NSString attribute) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetAccessibilityValue(Foundation.NSString attribute, Foundation.NSObject parameter) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect GetAlignmentRectForFrame(CoreGraphics.CGRect frame) { throw new NotImplementedException(); }
       public virtual override AppKit.NSLayoutConstraint[] GetConstraintsAffectingLayout(AppKit.NSLayoutConstraintOrientation orientation) { throw new NotImplementedException(); }
       public virtual override float GetContentCompressionResistancePriority(AppKit.NSLayoutConstraintOrientation orientation) { throw new NotImplementedException(); }
       public virtual override float GetContentHuggingPriorityForOrientation(AppKit.NSLayoutConstraintOrientation orientation) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect GetFrameForAlignmentRect(CoreGraphics.CGRect alignmentRect) { throw new NotImplementedException(); }
       public virtual override AppKit.NSView HitTest(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override void InvalidateIntrinsicContentSize() {}
       public virtual override bool IsAccessibilityAttributeSettable(Foundation.NSString attribute) { throw new NotImplementedException(); }
       public virtual override bool IsAccessibilitySelectorAllowed(ObjCRuntime.Selector selector) { throw new NotImplementedException(); }
       public virtual override bool IsDescendantOf(AppKit.NSView aView) { throw new NotImplementedException(); }
       public virtual override bool IsMouseInRect(CoreGraphics.CGPoint aPoint, CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override bool KnowsPageRange(Foundation.NSRange aRange) { throw new NotImplementedException(); }
       public virtual override void Layout() {}
       public virtual override void LayoutSubtreeIfNeeded() {}
       public virtual override CoreGraphics.CGPoint LocationOfPrintRect(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override void LockFocus() {}
       public virtual override bool LockFocusIfCanDraw() { throw new NotImplementedException(); }
       public virtual override bool LockFocusIfCanDrawInContext(AppKit.NSGraphicsContext context) { throw new NotImplementedException(); }
       public virtual override CoreAnimation.CALayer MakeBackingLayer() { throw new NotImplementedException(); }
       public virtual override AppKit.NSMenu MenuForEvent(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override bool NeedsToDraw(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override void NoteFocusRingMaskChanged() {}
       public virtual override bool PerformDragOperation(AppKit.NSDraggingInfo sender) { throw new NotImplementedException(); }
       public virtual override bool PerformKeyEquivalent(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override bool PerformMnemonic(string mnemonic) { throw new NotImplementedException(); }
       public virtual override void PrepareContentInRect(CoreGraphics.CGRect rect) {}
       public virtual override bool PrepareForDragOperation(AppKit.NSDraggingInfo sender) { throw new NotImplementedException(); }
       public virtual override void PrepareForReuse() {}
       public virtual override void Print(Foundation.NSObject sender) {}
       public virtual override CoreGraphics.CGRect RectForPage(nint pageNumber) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect RectForSmartMagnificationAtPoint(CoreGraphics.CGPoint atPoint, CoreGraphics.CGRect inRect) { throw new NotImplementedException(); }
       public virtual override void RegisterForDraggedTypes(string[] newTypes) {}
       public virtual override string[] RegisteredDragTypes() { throw new NotImplementedException(); }
       public virtual override void ReleaseGState() {}
       public virtual override void RemoveAllToolTips() {}
       public virtual override void RemoveConstraint(AppKit.NSLayoutConstraint constraint) {}
       public virtual override void RemoveConstraints(AppKit.NSLayoutConstraint[] constraints) {}
       public virtual override void RemoveCursorRect(CoreGraphics.CGRect aRect, AppKit.NSCursor cursor) {}
       public virtual override void RemoveFromSuperview() {}
       public virtual override void RemoveFromSuperviewWithoutNeedingDisplay() {}
       public virtual override void RemoveGestureRecognizer(AppKit.NSGestureRecognizer gestureRecognizer) {}
       public virtual override void RemoveLayoutGuide(AppKit.NSLayoutGuide guide) {}
       public virtual override void RemoveToolTip(nint tag) {}
       public virtual override void RemoveTrackingArea(AppKit.NSTrackingArea trackingArea) {}
       public virtual override void RemoveTrackingRect(nint tag) {}
       public virtual override void RenewGState() {}
       public virtual override void ReplaceSubviewWith(AppKit.NSView oldView, AppKit.NSView newView) {}
       public static override bool RequiresConstraintBasedLayout() { throw new NotImplementedException(); }
       public virtual override void ResetCursorRects() {}
       public virtual override void ResizeSubviewsWithOldSize(CoreGraphics.CGSize oldSize) {}
       public virtual override void ResizeWithOldSuperviewSize(CoreGraphics.CGSize oldSize) {}
       public virtual override void RotateByAngle(nfloat angle) {}
       public virtual override void ScaleUnitSquareToSize(CoreGraphics.CGSize newUnitSize) {}
       public virtual override void ScrollPoint(CoreGraphics.CGPoint aPoint) {}
       public virtual override void ScrollRect(CoreGraphics.CGRect aRect, CoreGraphics.CGSize delta) {}
       public virtual override bool ScrollRectToVisible(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override void SetAccessibilityValue(Foundation.NSString attribute, Foundation.NSObject value) {}
       public virtual override void SetBoundsOrigin(CoreGraphics.CGPoint newOrigin) {}
       public virtual override void SetBoundsSize(CoreGraphics.CGSize newSize) {}
       public virtual override void SetContentCompressionResistancePriority(float priority, AppKit.NSLayoutConstraintOrientation orientation) {}
       public virtual override void SetContentHuggingPriorityForOrientation(float priority, AppKit.NSLayoutConstraintOrientation orientation) {}
       public virtual override void SetFrameOrigin(CoreGraphics.CGPoint newOrigin) {}
       public virtual override void SetFrameSize(CoreGraphics.CGSize newSize) {}
       public virtual override void SetKeyboardFocusRingNeedsDisplay(CoreGraphics.CGRect rect) {}
       public virtual override void SetNeedsDisplayInRect(CoreGraphics.CGRect invalidRect) {}
       public virtual override void SetUpGState() {}
       public virtual override bool ShouldDelayWindowOrderingForEvent(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override AppKit.NSTrackingArea[] TrackingAreas() { throw new NotImplementedException(); }
       public virtual override void TranslateOriginToPoint(CoreGraphics.CGPoint translation) {}
       public virtual override void TranslateRectsNeedingDisplay(CoreGraphics.CGRect clipRect, CoreGraphics.CGSize delta) {}
       public virtual override void UnlockFocus() {}
       public virtual override void UnregisterDraggedTypes() {}
       public virtual override void UpdateConstraints() {}
       public virtual override void UpdateConstraintsForSubtreeIfNeeded() {}
       public virtual override void UpdateLayer() {}
       public virtual override void ViewDidEndLiveResize() {}
       public virtual override void ViewDidHide() {}
       public virtual override void ViewDidMoveToSuperview() {}
       public virtual override void ViewDidMoveToWindow() {}
       public virtual override void ViewDidUnhide() {}
       public virtual override void ViewWillDraw() {}
       public virtual override void ViewWillMoveToSuperview(AppKit.NSView newSuperview) {}
       public virtual override void ViewWillMoveToWindow(AppKit.NSWindow newWindow) {}
       public virtual override void ViewWillStartLiveResize() {}
       public virtual override Foundation.NSObject ViewWithTag(nint aTag) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect VisibleRect() { throw new NotImplementedException(); }
       public virtual override void WillOpenMenu(AppKit.NSMenu menu, AppKit.NSEvent theEvent) {}
       public virtual override void WillRemoveSubview(AppKit.NSView subview) {}
       public virtual override void WriteEpsInsideRect(CoreGraphics.CGRect rect, AppKit.NSPasteboard pboard) {}
       public virtual override void WritePdfInsideRect(CoreGraphics.CGRect rect, AppKit.NSPasteboard pboard) {}
       public virtual override bool AcceptsFirstResponder() { throw new NotImplementedException(); }
       public virtual override bool BecomeFirstResponder() { throw new NotImplementedException(); }
       public virtual override void BeginGestureWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void CursorUpdate(AppKit.NSEvent theEvent) {}
       public virtual override void EncodeRestorableState(Foundation.NSCoder coder) {}
       public virtual override void EncodeTo(Foundation.NSCoder encoder) {}
       public virtual override void EndGestureWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void FlagsChanged(AppKit.NSEvent theEvent) {}
       public virtual override void FlushBufferedKeyEvents() {}
       public virtual override void GetNewWindowForTab(Foundation.NSObject sender) {}
       public virtual override void HelpRequested(AppKit.NSEvent theEventPtr) {}
      // public virtual override void InterpretKeyEvents(AppKit.NSEvent[] eventArray) {}
       public virtual override void InvalidateRestorableState() {}
       public virtual override void KeyDown(AppKit.NSEvent theEvent) {}
       public virtual override void KeyUp(AppKit.NSEvent theEvent) {}
       public virtual override void MagnifyWithEvent(AppKit.NSEvent theEvent) {}
      // public virtual override void NoResponderFor(ObjCRuntime.Selector eventSelector) {}
       public virtual override void OtherMouseDown(AppKit.NSEvent theEvent) {}
       public virtual override void OtherMouseDragged(AppKit.NSEvent theEvent) {}
       public virtual override void OtherMouseUp(AppKit.NSEvent theEvent) {}
       public virtual override bool PresentError(Foundation.NSError error) { throw new NotImplementedException(); }
      // public override void PresentError(Foundation.NSError error, AppKit.NSWindow window, Foundation.NSObject delegate, ObjCRuntime.Selector didPresentSelector, IntPtr contextInfo) {}
       public virtual override void PressureChange(AppKit.NSEvent pressureChangeEvent) {}
       public virtual override void QuickLook(AppKit.NSEvent withEvent) {}
       public virtual override bool ResignFirstResponder() { throw new NotImplementedException(); }
       public static override string[] RestorableStateKeyPaths() { throw new NotImplementedException(); }
       public virtual override void RestoreState(Foundation.NSCoder coder) {}
       public virtual override void RestoreUserActivityState(Foundation.NSUserActivity userActivity) {}
       public virtual override void RightMouseDragged(AppKit.NSEvent theEvent) {}
       public virtual override void RotateWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void ScrollWheel(AppKit.NSEvent theEvent) {}
       public virtual override bool ShouldBeTreatedAsInkEvent(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override void ShowContextHelp(Foundation.NSObject sender) {}
       public virtual override void SmartMagnify(AppKit.NSEvent withEvent) {}
       public virtual override Foundation.NSObject SupplementalTargetForAction(ObjCRuntime.Selector action, Foundation.NSObject sender) { throw new NotImplementedException(); }
       public virtual override void SwipeWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void TabletPoint(AppKit.NSEvent theEvent) {}
       public virtual override void TabletProximity(AppKit.NSEvent theEvent) {}
       public virtual override void TouchesBeganWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void TouchesCancelledWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void TouchesEndedWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void TouchesMovedWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override bool TryToPerformwith(ObjCRuntime.Selector anAction, Foundation.NSObject anObject) { throw new NotImplementedException(); }
       public virtual override void UpdateUserActivityState(Foundation.NSUserActivity userActivity) {}
       public virtual override Foundation.NSObject ValidRequestorForSendType(string sendType, string returnType) { throw new NotImplementedException(); }
       public virtual override bool WantsForwardedScrollEventsForAxis(AppKit.NSEventGestureAxis axis) { throw new NotImplementedException(); }
       public virtual override bool WantsScrollEventsForSwipeTrackingOnAxis(AppKit.NSEventGestureAxis axis) { throw new NotImplementedException(); }
       public virtual override Foundation.NSError WillPresentError(Foundation.NSError error) { throw new NotImplementedException(); }
       public virtual override void AddObserver(Foundation.NSObject observer, Foundation.NSString keyPath, Foundation.NSKeyValueObservingOptions options, IntPtr context) {}
       public override void AddObserver(Foundation.NSObject observer, string keyPath, Foundation.NSKeyValueObservingOptions options, IntPtr context) {}
       public static override bool AutomaticallyNotifiesObserversForKey(string key) { throw new NotImplementedException(); }
       public virtual override void AwakeFromNib() {}
       public virtual override void Bind(string binding, Foundation.NSObject observable, string keyPath, Foundation.NSDictionary options) {}
       public override void Bind(Foundation.NSString binding, Foundation.NSObject observable, string keyPath, Foundation.NSDictionary options) {}
       public virtual override Foundation.NSDictionary BindingInfo(string binding) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject[] BindingOptionDescriptions(string aBinding) { throw new NotImplementedException(); }
       public virtual override ObjCRuntime.Class BindingValueClass(string binding) { throw new NotImplementedException(); }
       public static override void CancelPreviousPerformRequest(Foundation.NSObject aTarget) {}
       public static override void CancelPreviousPerformRequest(Foundation.NSObject aTarget, ObjCRuntime.Selector selector, Foundation.NSObject argument) {}
       public virtual override bool CommitEditing() { throw new NotImplementedException(); }
       public virtual override void CommitEditing(Foundation.NSObject objDelegate, ObjCRuntime.Selector didCommitSelector, IntPtr contextInfo) {}
       public virtual override Foundation.NSObject Copy() { throw new NotImplementedException(); }
       public virtual override void DidChange(Foundation.NSKeyValueChange changeKind, Foundation.NSIndexSet indexes, Foundation.NSString forKey) {}
       public virtual override void DidChange(Foundation.NSString forKey, Foundation.NSKeyValueSetMutationKind mutationKind, Foundation.NSSet objects) {}
       public virtual override void DidChangeValue(string forKey) {}
       public virtual override void DoesNotRecognizeSelector(ObjCRuntime.Selector sel) {}
       public virtual override Foundation.NSString[] ExposedBindings() { throw new NotImplementedException(); }
       public override Foundation.NSDictionary GetBindingInfo(Foundation.NSString binding) { throw new NotImplementedException(); }
       public override Foundation.NSObject[] GetBindingOptionDescriptions(Foundation.NSString aBinding) { throw new NotImplementedException(); }
       public override ObjCRuntime.Class GetBindingValueClass(Foundation.NSString binding) { throw new NotImplementedException(); }
       public static override Foundation.NSObject GetDefaultPlaceholder(Foundation.NSObject marker, string binding) { throw new NotImplementedException(); }
       public static override Foundation.NSObject GetDefaultPlaceholder(Foundation.NSObject marker, Foundation.NSString binding) { throw new NotImplementedException(); }
       public virtual override Foundation.NSDictionary GetDictionaryOfValuesFromKeys(Foundation.NSString[] keys) { throw new NotImplementedException(); }
       public static override Foundation.NSSet GetKeyPathsForValuesAffecting(Foundation.NSString key) { throw new NotImplementedException(); }
       public virtual override IntPtr GetMethodForSelector(ObjCRuntime.Selector sel) { throw new NotImplementedException(); }
       public virtual override nuint GetNativeHash() { throw new NotImplementedException(); }
       public virtual override bool IsEqual(Foundation.NSObject anObject) { throw new NotImplementedException(); }
       public virtual override bool IsKindOfClass(ObjCRuntime.Class aClass) { throw new NotImplementedException(); }
       public virtual override bool IsMemberOfClass(ObjCRuntime.Class aClass) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject MutableCopy() { throw new NotImplementedException(); }
       public virtual override void ObjectDidEndEditing(Foundation.NSObject editor) {}
       public virtual override void ObserveValue(Foundation.NSString keyPath, Foundation.NSObject ofObject, Foundation.NSDictionary change, IntPtr context) {}
       public virtual override void PerformSelector(ObjCRuntime.Selector selector, Foundation.NSObject withObject, double afterDelay, Foundation.NSString[] nsRunLoopModes) {}
       public virtual override void PerformSelector(ObjCRuntime.Selector selector, Foundation.NSObject withObject, double delay) {}
       public virtual override void PerformSelector(ObjCRuntime.Selector selector, Foundation.NSThread onThread, Foundation.NSObject withObject, bool waitUntilDone) {}
       public virtual override void PerformSelector(ObjCRuntime.Selector selector, Foundation.NSThread onThread, Foundation.NSObject withObject, bool waitUntilDone, Foundation.NSString[] nsRunLoopModes) {}
       public virtual override Foundation.NSObject PerformSelector(ObjCRuntime.Selector aSelector) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject PerformSelector(ObjCRuntime.Selector aSelector, Foundation.NSObject anObject) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject PerformSelector(ObjCRuntime.Selector aSelector, Foundation.NSObject object1, Foundation.NSObject object2) { throw new NotImplementedException(); }
       public virtual override void PrepareForInterfaceBuilder() {}
       public virtual override void RemoveObserver(Foundation.NSObject observer, Foundation.NSString keyPath, IntPtr context) {}
       public override void RemoveObserver(Foundation.NSObject observer, string keyPath, IntPtr context) {}
       public virtual override void RemoveObserver(Foundation.NSObject observer, Foundation.NSString keyPath) {}
       public override void RemoveObserver(Foundation.NSObject observer, string keyPath) {}
       public virtual override bool RespondsToSelector(ObjCRuntime.Selector sel) { throw new NotImplementedException(); }
       public static override void SetDefaultPlaceholder(Foundation.NSObject placeholder, Foundation.NSObject marker, string binding) {}
       public static override void SetDefaultPlaceholder(Foundation.NSObject placeholder, Foundation.NSObject marker, Foundation.NSString binding) {}
       public virtual override void SetNilValueForKey(Foundation.NSString key) {}
       public virtual override void SetValueForKey(Foundation.NSObject value, Foundation.NSString key) {}
       public virtual override void SetValueForKeyPath(Foundation.NSObject value, Foundation.NSString keyPath) {}
       public virtual override void SetValueForUndefinedKey(Foundation.NSObject value, Foundation.NSString undefinedKey) {}
       public virtual override void SetValuesForKeysWithDictionary(Foundation.NSDictionary keyedValues) {}
       public virtual override void Unbind(string binding) {}
       public override void Unbind(Foundation.NSString binding) {}
       public virtual override Foundation.NSObject ValueForKey(Foundation.NSString key) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject ValueForKeyPath(Foundation.NSString keyPath) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject ValueForUndefinedKey(Foundation.NSString key) { throw new NotImplementedException(); }
       public virtual override void WillChange(Foundation.NSKeyValueChange changeKind, Foundation.NSIndexSet indexes, Foundation.NSString forKey) {}
       public virtual override void WillChange(Foundation.NSString forKey, Foundation.NSKeyValueSetMutationKind mutationKind, Foundation.NSSet objects) {}
       public virtual override void WillChangeValue(string forKey) {}
       public virtual override void Dispose() {}
       public static override bool IsNewRefcountEnabled() { throw new NotImplementedException(); }
       protected override void MarkDirty() {}
       public virtual override bool ConformsToProtocol(IntPtr protocol) { throw new NotImplementedException(); }
       public virtual override void DangerousRelease() {}
       public virtual override Foundation.NSObject DangerousRetain() { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject DangerousAutorelease() { throw new NotImplementedException(); }
       protected override void InitializeHandle(IntPtr handle) {}
       protected override void InitializeHandle(IntPtr handle, string initSelector) {}
       public override Foundation.NSObject GetNativeField(string name) { throw new NotImplementedException(); }
       public override void SetNativeField(string name, Foundation.NSObject value) {}
       public override void BeginInvokeOnMainThread(ObjCRuntime.Selector sel, Foundation.NSObject obj) {}
       public override void InvokeOnMainThread(ObjCRuntime.Selector sel, Foundation.NSObject obj) {}
       public override void BeginInvokeOnMainThread(Action action) {}
       public override void InvokeOnMainThread(Action action) {}
       public static override Foundation.NSObject FromObject(object obj) { throw new NotImplementedException(); }
       public override void SetValueForKeyPath(IntPtr handle, Foundation.NSString keyPath) {}
       public virtual override bool Equals(Foundation.NSObject obj) { throw new NotImplementedException(); }
       public virtual override void Invoke(Action action, double delay) {}
       public virtual override void Invoke(Action action, TimeSpan delay) {}
       public override IDisposable AddObserver(string key, Foundation.NSKeyValueObservingOptions options, Action<Foundation.NSObservedChange> observer) { throw new NotImplementedException(); }
       public override IDisposable AddObserver(Foundation.NSString key, Foundation.NSKeyValueObservingOptions options, Action<Foundation.NSObservedChange> observer) { throw new NotImplementedException(); }
      // ctor: 
   // public OutlineViewBackend (Xwt.Backends.ITreeViewEventSink eventSink, Xwt.Backends.ApplicationContext context) {}
      public AppKit.NSOutlineView View { get { throw new NotImplementedException(); } }
      public override Foundation.NSObject WeakDataSource { get; set; }
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject[] AccessibilityColumnHeaderUIElements { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject[] AccessibilityColumns { get { throw new NotImplementedException(); } }
      public virtual bool AccessibilityFocused { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGRect AccessibilityFrame { get { throw new NotImplementedException(); } }
      public virtual string AccessibilityHeaderGroup { get { throw new NotImplementedException(); } }
      public virtual string AccessibilityIdentifier { get { throw new NotImplementedException(); } }
      public virtual string AccessibilityLabel { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject AccessibilityParent { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject[] AccessibilityRowHeaderUIElements { get { throw new NotImplementedException(); } }
      public virtual AppKit.INSAccessibilityRow[] AccessibilityRows { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject[] AccessibilitySelectedCells { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject[] AccessibilitySelectedColumns { get { throw new NotImplementedException(); } }
      public virtual AppKit.INSAccessibilityRow[] AccessibilitySelectedRows { get; set; }
      public virtual Foundation.NSObject[] AccessibilityVisibleCells { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject[] AccessibilityVisibleColumns { get { throw new NotImplementedException(); } }
      public virtual AppKit.INSAccessibilityRow[] AccessibilityVisibleRows { get { throw new NotImplementedException(); } }
      public virtual bool AutoresizesOutlineColumn { get; set; }
      public virtual bool AutosaveExpandedItems { get; set; }
      public AppKit.INSOutlineViewDataSource DataSource { get; set; }
      public AppKit.INSOutlineViewDelegate Delegate { get; set; }
      public virtual bool IndentationMarkerFollowsCell { get; set; }
      public virtual nfloat IndentationPerLevel { get; set; }
      public virtual AppKit.NSTableColumn OutlineTableColumn { get; set; }
      public virtual bool StronglyReferencesItems { get; set; }
      public virtual AppKit.NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection { get; set; }
      public virtual Foundation.NSObject WeakDelegate { get; set; }
      public static Foundation.NSString ColumnDidMoveNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ColumnDidResizeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ItemDidCollapseNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ItemDidExpandNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ItemWillCollapseNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ItemWillExpandNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectionDidChangeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectionIsChangingNotification { get { throw new NotImplementedException(); } }
      public AppKit.NSTableViewSource Source { get; set; }
      public virtual bool AllowsColumnReordering { get; set; }
      public virtual bool AllowsColumnResizing { get; set; }
      public virtual bool AllowsColumnSelection { get; set; }
      public virtual bool AllowsEmptySelection { get; set; }
      public virtual bool AllowsMultipleSelection { get; set; }
      public virtual bool AllowsTypeSelect { get; set; }
      public virtual string AutosaveName { get; set; }
      public virtual bool AutosaveTableColumns { get; set; }
      public virtual AppKit.NSColor BackgroundColor { get; set; }
      public virtual nint ClickedColumn { get { throw new NotImplementedException(); } }
      public virtual nint ClickedRow { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSTableViewColumnAutoresizingStyle ColumnAutoresizingStyle { get; set; }
      public virtual nint ColumnCount { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSView CornerView { get; set; }
      public virtual ObjCRuntime.Selector DoubleAction { get; set; }
      public virtual AppKit.NSTableViewDraggingDestinationFeedbackStyle DraggingDestinationFeedbackStyle { get; set; }
      public virtual nint EditedColumn { get { throw new NotImplementedException(); } }
      public virtual nint EditedRow { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSTableViewRowSizeStyle EffectiveRowSizeStyle { get { throw new NotImplementedException(); } }
      public virtual bool FloatsGroupRows { get; set; }
      public virtual nint FocusedColumn { get; set; }
      public virtual AppKit.NSColor GridColor { get; set; }
      public virtual AppKit.NSTableViewGridStyle GridStyleMask { get; set; }
      public virtual AppKit.NSTableHeaderView HeaderView { get; set; }
      public virtual Foundation.NSIndexSet HiddenRowIndexes { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSTableColumn HighlightedTableColumn { get; set; }
      public virtual bool IgnoreModifierKeysWhileDragging { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGSize IntercellSpacing { get; set; }
      public virtual Foundation.NSDictionary RegisteredNibsByIdentifier { get { throw new NotImplementedException(); } }
      public virtual bool RowActionsVisible { get; set; }
      public virtual nint RowCount { get { throw new NotImplementedException(); } }
      public virtual nfloat RowHeight { get; set; }
      public virtual AppKit.NSTableViewRowSizeStyle RowSizeStyle { get; set; }
      public virtual nint SelectedColumn { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSIndexSet SelectedColumns { get { throw new NotImplementedException(); } }
      public virtual nint SelectedColumnsCount { get { throw new NotImplementedException(); } }
      public virtual nint SelectedRow { get { throw new NotImplementedException(); } }
      public virtual nint SelectedRowCount { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSIndexSet SelectedRows { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSTableViewSelectionHighlightStyle SelectionHighlightStyle { get; set; }
      public virtual Foundation.NSSortDescriptor[] SortDescriptors { get; set; }
      public virtual bool UsesAlternatingRowBackgroundColors { get; set; }
      public virtual bool UsesStaticContents { get; set; }
      public virtual bool VerticalMotionCanBeginDrag { get; set; }
      public static Foundation.NSString RowViewKey { get { throw new NotImplementedException(); } }
      public AppKit.NSTableViewRowGetter CoreGetRowView { get; set; }
      public AppKit.NSTableViewCellGetter GetDataCell { get; set; }
      public AppKit.NSTableViewSearchString GetNextTypeSelectMatch { get; set; }
      public AppKit.NSTableViewRowHeight GetRowHeight { get; set; }
      public AppKit.NSTableViewColumnRowString GetSelectString { get; set; }
      public AppKit.NSTableViewIndexFilter GetSelectionIndexes { get; set; }
      public AppKit.NSTableViewColumnWidth GetSizeToFitColumnWidth { get; set; }
      public AppKit.NSTableViewToolTip GetToolTip { get; set; }
      public AppKit.NSTableViewViewGetter GetViewForItem { get; set; }
      public AppKit.NSTableViewRowPredicate IsGroupRow { get; set; }
      public AppKit.NSTableViewRowActionsGetter RowActions { get; set; }
      public AppKit.NSTableViewPredicate SelectionShouldChange { get; set; }
      public AppKit.NSTableViewColumnRowPredicate ShouldEditTableColumn { get; set; }
      public AppKit.NSTableReorder ShouldReorder { get; set; }
      public AppKit.NSTableViewRowPredicate ShouldSelectRow { get; set; }
      public AppKit.NSTableViewColumnPredicate ShouldSelectTableColumn { get; set; }
      public AppKit.NSTableViewColumnRowPredicate ShouldShowCellExpansion { get; set; }
      public AppKit.NSTableViewCell ShouldTrackCell { get; set; }
      public AppKit.NSTableViewEventString ShouldTypeSelect { get; set; }
      public virtual ObjCRuntime.Selector Action { get; set; }
      public virtual AppKit.NSTextAlignment Alignment { get; set; }
      public virtual bool AllowsExpansionToolTips { get; set; }
      public virtual Foundation.NSAttributedString AttributedStringValue { get; set; }
      public virtual AppKit.NSWritingDirection BaseWritingDirection { get; set; }
      public virtual AppKit.NSCell Cell { get; set; }
      public static ObjCRuntime.Class CellClass { get; set; }
      public virtual bool Continuous { get; set; }
      public virtual AppKit.NSControlSize ControlSize { get; set; }
      public virtual AppKit.NSText CurrentEditor { get { throw new NotImplementedException(); } }
      public virtual double DoubleValue { get; set; }
      public virtual bool Enabled { get; set; }
      public virtual float FloatValue { get; set; }
      public virtual AppKit.NSFont Font { get; set; }
      public virtual Foundation.NSObject Formatter { get; set; }
      public virtual bool Highlighted { get; set; }
      public virtual bool IgnoresMultiClick { get; set; }
      public virtual int IntValue { get; set; }
      public virtual AppKit.NSLineBreakMode LineBreakMode { get; set; }
      public virtual nint NIntValue { get; set; }
      public virtual Foundation.NSObject ObjectValue { get; set; }
      public virtual bool RefusesFirstResponder { get; set; }
      public virtual AppKit.NSCell SelectedCell { get { throw new NotImplementedException(); } }
      public virtual nint SelectedTag { get { throw new NotImplementedException(); } }
      public virtual string StringValue { get; set; }
      public virtual nint Tag { get; set; }
      public virtual Foundation.NSObject Target { get; set; }
      public virtual bool UsesSingleLineMode { get; set; }
      public static Foundation.NSString TextDidBeginEditingNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString TextDidChangeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString TextDidEndEditingNotification { get { throw new NotImplementedException(); } }
      public virtual bool AcceptsTouchEvents { get; set; }
      public virtual Foundation.NSArray AccessibilityActionNames { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGPoint AccessibilityActivationPoint { get; set; }
      public virtual Foundation.NSNumber[] AccessibilityAllowedValues { get; set; }
      public virtual bool AccessibilityAlternateUIVisible { get; set; }
      public virtual Foundation.NSObject AccessibilityApplicationFocusedUIElement { get; set; }
      public virtual Foundation.NSArray AccessibilityAttributeNames { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject AccessibilityCancelButton { get; set; }
      public virtual Foundation.NSObject[] AccessibilityChildren { get; set; }
      public virtual Foundation.NSObject AccessibilityClearButton { get; set; }
      public virtual Foundation.NSObject AccessibilityCloseButton { get; set; }
      public virtual nint AccessibilityColumnCount { get; set; }
      public virtual Foundation.NSRange AccessibilityColumnIndexRange { get; set; }
      public virtual Foundation.NSObject[] AccessibilityColumnTitles { get; set; }
      public virtual Foundation.NSObject[] AccessibilityContents { get; set; }
      public virtual Foundation.NSObject AccessibilityCriticalValue { get; set; }
      public virtual Foundation.NSObject AccessibilityDecrementButton { get; set; }
      public virtual Foundation.NSObject AccessibilityDefaultButton { get; set; }
      public virtual bool AccessibilityDisclosed { get; set; }
      public virtual Foundation.NSObject AccessibilityDisclosedByRow { get; set; }
      public virtual Foundation.NSObject AccessibilityDisclosedRows { get; set; }
      public virtual nint AccessibilityDisclosureLevel { get; set; }
      public virtual string AccessibilityDocument { get; set; }
      public virtual bool AccessibilityEdited { get; set; }
      public virtual bool AccessibilityElement { get; set; }
      public virtual bool AccessibilityEnabled { get; set; }
      public virtual bool AccessibilityExpanded { get; set; }
      public virtual Foundation.NSObject AccessibilityExtrasMenuBar { get; set; }
      public virtual string AccessibilityFilename { get; set; }
      public virtual Foundation.NSObject AccessibilityFocusedWindow { get; set; }
      public virtual bool AccessibilityFrontmost { get; set; }
      public virtual Foundation.NSObject AccessibilityFullScreenButton { get; set; }
      public virtual Foundation.NSObject AccessibilityGrowArea { get; set; }
      public virtual Foundation.NSObject[] AccessibilityHandles { get; set; }
      public virtual Foundation.NSObject AccessibilityHeader { get; set; }
      public virtual string AccessibilityHelp { get; set; }
      public virtual bool AccessibilityHidden { get; set; }
      public virtual Foundation.NSObject AccessibilityHorizontalScrollBar { get; set; }
      public virtual string AccessibilityHorizontalUnitDescription { get; set; }
      public virtual AppKit.NSAccessibilityUnits AccessibilityHorizontalUnits { get; set; }
      public virtual Foundation.NSObject AccessibilityIncrementButton { get; set; }
      public virtual nint AccessibilityIndex { get; set; }
      public virtual nint AccessibilityInsertionPointLineNumber { get; set; }
      public virtual bool AccessibilityIsIgnored { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject[] AccessibilityLabelUIElements { get; set; }
      public virtual float AccessibilityLabelValue { get; set; }
      public virtual Foundation.NSObject[] AccessibilityLinkedUIElements { get; set; }
      public virtual bool AccessibilityMain { get; set; }
      public virtual Foundation.NSObject AccessibilityMainWindow { get; set; }
      public virtual Foundation.NSObject AccessibilityMarkerGroupUIElement { get; set; }
      public virtual string AccessibilityMarkerTypeDescription { get; set; }
      public virtual Foundation.NSObject[] AccessibilityMarkerUIElements { get; set; }
      public virtual Foundation.NSObject AccessibilityMarkerValues { get; set; }
      public virtual Foundation.NSObject AccessibilityMaxValue { get; set; }
      public virtual Foundation.NSObject AccessibilityMenuBar { get; set; }
      public virtual Foundation.NSObject AccessibilityMinValue { get; set; }
      public virtual Foundation.NSObject AccessibilityMinimizeButton { get; set; }
      public virtual bool AccessibilityMinimized { get; set; }
      public virtual bool AccessibilityModal { get; set; }
      public virtual Foundation.NSObject[] AccessibilityNextContents { get; set; }
      public virtual bool AccessibilityNotifiesWhenDestroyed { get { throw new NotImplementedException(); } }
      public virtual nint AccessibilityNumberOfCharacters { get; set; }
      public virtual bool AccessibilityOrderedByRow { get; set; }
      public virtual AppKit.NSAccessibilityOrientation AccessibilityOrientation { get; set; }
      public virtual Foundation.NSObject AccessibilityOverflowButton { get; set; }
      public virtual Foundation.NSArray AccessibilityParameterizedAttributeNames { get { throw new NotImplementedException(); } }
      public virtual string AccessibilityPlaceholderValue { get; set; }
      public virtual Foundation.NSObject[] AccessibilityPreviousContents { get; set; }
      public virtual bool AccessibilityProtectedContent { get; set; }
      public virtual Foundation.NSObject AccessibilityProxy { get; set; }
      public virtual bool AccessibilityRequired { get; set; }
      public virtual string AccessibilityRole { get; set; }
      public virtual string AccessibilityRoleDescription { get; set; }
      public virtual nint AccessibilityRowCount { get; set; }
      public virtual Foundation.NSRange AccessibilityRowIndexRange { get; set; }
      public virtual AppKit.NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType { get; set; }
      public virtual Foundation.NSObject AccessibilitySearchButton { get; set; }
      public virtual Foundation.NSObject AccessibilitySearchMenu { get; set; }
      public virtual bool AccessibilitySelected { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySelectedChildren { get; set; }
      public virtual string AccessibilitySelectedText { get; set; }
      public virtual Foundation.NSRange AccessibilitySelectedTextRange { get; set; }
      public virtual Foundation.NSValue[] AccessibilitySelectedTextRanges { get; set; }
      public virtual Foundation.NSObject[] AccessibilityServesAsTitleForUIElements { get; set; }
      public virtual Foundation.NSRange AccessibilitySharedCharacterRange { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySharedFocusElements { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySharedTextUIElements { get; set; }
      public virtual Foundation.NSObject AccessibilityShownMenu { get; set; }
      public virtual AppKit.NSAccessibilitySortDirection AccessibilitySortDirection { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySplitters { get; set; }
      public virtual string AccessibilitySubrole { get; set; }
      public virtual Foundation.NSObject[] AccessibilityTabs { get; set; }
      public virtual string AccessibilityTitle { get; set; }
      public virtual Foundation.NSObject AccessibilityTitleUIElement { get; set; }
      public virtual Foundation.NSObject AccessibilityToolbarButton { get; set; }
      public virtual Foundation.NSObject AccessibilityTopLevelUIElement { get; set; }
      public virtual string AccessibilityUnitDescription { get; set; }
      public virtual AppKit.NSAccessibilityUnits AccessibilityUnits { get; set; }
      public virtual Foundation.NSUrl AccessibilityUrl { get; set; }
      public virtual Foundation.NSObject AccessibilityValue { get; set; }
      public virtual string AccessibilityValueDescription { get; set; }
      public virtual Foundation.NSObject AccessibilityVerticalScrollBar { get; set; }
      public virtual string AccessibilityVerticalUnitDescription { get; set; }
      public virtual AppKit.NSAccessibilityUnits AccessibilityVerticalUnits { get; set; }
      public virtual Foundation.NSRange AccessibilityVisibleCharacterRange { get; set; }
      public virtual Foundation.NSObject[] AccessibilityVisibleChildren { get; set; }
      public virtual Foundation.NSObject AccessibilityWarningValue { get; set; }
      public virtual Foundation.NSObject AccessibilityWindow { get; set; }
      public virtual Foundation.NSObject[] AccessibilityWindows { get; set; }
      public virtual Foundation.NSObject AccessibilityZoomButton { get; set; }
      public virtual AppKit.NSEdgeInsets AlignmentRectInsets { get { throw new NotImplementedException(); } }
      public virtual bool AllowsVibrancy { get { throw new NotImplementedException(); } }
      public virtual nfloat AlphaValue { get; set; }
      public virtual Foundation.NSDictionary Animations { get; set; }
      public virtual Foundation.NSObject Animator { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSAppearance Appearance { get; set; }
      public virtual bool AutoresizesSubviews { get; set; }
      public virtual AppKit.NSViewResizingMask AutoresizingMask { get; set; }
      public virtual CoreImage.CIFilter[] BackgroundFilters { get; set; }
      public virtual nfloat BaselineOffsetFromBottom { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutYAxisAnchor BottomAnchor { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGRect Bounds { get; set; }
      public virtual nfloat BoundsRotation { get; set; }
      public virtual bool CanBecomeKeyView { get { throw new NotImplementedException(); } }
      public virtual bool CanDrawConcurrently { get; set; }
      public virtual bool CanDrawSubviewsIntoLayer { get; set; }
      public virtual AppKit.NSLayoutXAxisAnchor CenterXAnchor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutYAxisAnchor CenterYAnchor { get { throw new NotImplementedException(); } }
      public virtual CoreImage.CIFilter CompositingFilter { get; set; }
      public virtual AppKit.NSLayoutConstraint[] Constraints { get { throw new NotImplementedException(); } }
      public virtual CoreImage.CIFilter[] ContentFilters { get; set; }
      public static AppKit.NSFocusRingType DefaultFocusRingType { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSAppearance EffectiveAppearance { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSScrollView EnclosingScrollView { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutYAxisAnchor FirstBaselineAnchor { get { throw new NotImplementedException(); } }
      public virtual nfloat FirstBaselineOffsetFromTop { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGSize FittingSize { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGRect FocusRingMaskBounds { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSFocusRingType FocusRingType { get; set; }
      public virtual CoreGraphics.CGRect Frame { get; set; }
      public virtual nfloat FrameCenterRotation { get; set; }
      public virtual nfloat FrameRotation { get; set; }
      public virtual AppKit.NSGestureRecognizer[] GestureRecognizers { get; set; }
      public virtual bool HasAmbiguousLayout { get { throw new NotImplementedException(); } }
      public virtual nfloat HeightAdjustLimit { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutDimension HeightAnchor { get { throw new NotImplementedException(); } }
      public virtual bool Hidden { get; set; }
      public virtual string Identifier { get; set; }
      public virtual bool InLiveResize { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSTextInputContext InputContext { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGSize IntrinsicContentSize { get { throw new NotImplementedException(); } }
      public static bool IsCompatibleWithResponsiveScrolling { get { throw new NotImplementedException(); } }
      public virtual bool IsDrawingFindIndicator { get { throw new NotImplementedException(); } }
      public virtual bool IsFlipped { get { throw new NotImplementedException(); } }
      public virtual bool IsHiddenOrHasHiddenAncestor { get { throw new NotImplementedException(); } }
      public virtual bool IsInFullscreenMode { get { throw new NotImplementedException(); } }
      public virtual bool IsOpaque { get { throw new NotImplementedException(); } }
      public virtual bool IsRotatedFromBase { get { throw new NotImplementedException(); } }
      public virtual bool IsRotatedOrScaledFromBase { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutYAxisAnchor LastBaselineAnchor { get { throw new NotImplementedException(); } }
      public virtual nfloat LastBaselineOffsetFromBottom { get { throw new NotImplementedException(); } }
      public virtual CoreAnimation.CALayer Layer { get; set; }
      public virtual AppKit.NSViewLayerContentsPlacement LayerContentsPlacement { get; set; }
      public virtual AppKit.NSViewLayerContentsRedrawPolicy LayerContentsRedrawPolicy { get; set; }
      public virtual bool LayerUsesCoreImageFilters { get; set; }
      public virtual AppKit.NSLayoutGuide[] LayoutGuides { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutXAxisAnchor LeadingAnchor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutXAxisAnchor LeftAnchor { get { throw new NotImplementedException(); } }
      public virtual bool MouseDownCanMoveWindow { get { throw new NotImplementedException(); } }
      public virtual bool NeedsDisplay { get; set; }
      public virtual bool NeedsLayout { get; set; }
      public virtual bool NeedsPanelToBecomeKey { get { throw new NotImplementedException(); } }
      public virtual bool NeedsUpdateConstraints { get; set; }
      public virtual AppKit.NSView NextKeyView { get; set; }
      public virtual AppKit.NSView NextValidKeyView { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSView OpaqueAncestor { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSAttributedString PageFooter { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSAttributedString PageHeader { get { throw new NotImplementedException(); } }
      public virtual bool PostsBoundsChangedNotifications { get; set; }
      public virtual bool PostsFrameChangedNotifications { get; set; }
      public virtual CoreGraphics.CGRect PreparedContentRect { get; set; }
      public virtual bool PreservesContentDuringLiveResize { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSPressureConfiguration PressureConfiguration { get; set; }
      public virtual AppKit.NSView PreviousKeyView { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSView PreviousValidKeyView { get { throw new NotImplementedException(); } }
      public virtual string PrintJobTitle { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGRect RectPreservedDuringLiveResize { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutXAxisAnchor RightAnchor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSShadow Shadow { get; set; }
      public virtual bool ShouldDrawColor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSView[] Subviews { get; set; }
      public virtual AppKit.NSView Superview { get { throw new NotImplementedException(); } }
      public virtual string ToolTip { get; set; }
      public virtual AppKit.NSLayoutYAxisAnchor TopAnchor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutXAxisAnchor TrailingAnchor { get { throw new NotImplementedException(); } }
      public virtual bool TranslatesAutoresizingMaskIntoConstraints { get; set; }
      public virtual bool WantsBestResolutionOpenGLSurface { get; set; }
      public virtual bool WantsDefaultClipping { get { throw new NotImplementedException(); } }
      public virtual bool WantsLayer { get; set; }
      public virtual bool WantsPeriodicDraggingUpdates { get { throw new NotImplementedException(); } }
      public virtual bool WantsRestingTouches { get; set; }
      public virtual bool WantsUpdateLayer { get { throw new NotImplementedException(); } }
      public virtual nfloat WidthAdjustLimit { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLayoutDimension WidthAnchor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindow Window { get { throw new NotImplementedException(); } }
      public static Foundation.NSString AnnouncementRequestedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationActivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationDeactivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationHiddenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationShownNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString BoundsChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString CreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DrawerCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString FocusChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString FocusedWindowChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString FrameChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString GlobalFrameChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString HelpTagCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString LayoutChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString MainWindowChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString MovedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString NSFullScreenModeAllScreens { get { throw new NotImplementedException(); } }
      public static Foundation.NSString NSFullScreenModeApplicationPresentationOptions { get { throw new NotImplementedException(); } }
      public static Foundation.NSString NSFullScreenModeSetting { get { throw new NotImplementedException(); } }
      public static Foundation.NSString NSFullScreenModeWindowLevel { get { throw new NotImplementedException(); } }
      public static nfloat NoIntrinsicMetric { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ResizedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString RowCollapsedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString RowCountChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString RowExpandedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectedCellsChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectedChildrenChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectedChildrenMovedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectedColumnsChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectedRowsChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SelectedTextChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString SheetCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString TitleChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString UIElementDestroyedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString UIElementFocusedChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString UnitsChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString UpdatedTrackingAreasNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ValueChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowDeminiaturizedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowMiniaturizedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowMovedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowResizedNotification { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSMenu Menu { get; set; }
      public virtual AppKit.NSResponder NextResponder { get; set; }
      public virtual AppKit.NSTouchBar TouchBar { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSUserActivity UserActivity { get; set; }
      public virtual ObjCRuntime.Class Class { get { throw new NotImplementedException(); } }
      public virtual string DebugDescription { get { throw new NotImplementedException(); } }
      public virtual string Description { get { throw new NotImplementedException(); } }
      public virtual bool IsProxy { get { throw new NotImplementedException(); } }
      public virtual nuint RetainCount { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject Self { get { throw new NotImplementedException(); } }
      public virtual ObjCRuntime.Class Superclass { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSZone Zone { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ChangeIndexesKey { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ChangeKindKey { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ChangeNewKey { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ChangeNotificationIsPriorKey { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ChangeOldKey { get { throw new NotImplementedException(); } }
      public IntPtr SuperHandle { get { throw new NotImplementedException(); } }
      public virtual IntPtr Handle { get; set; }
      // Event: 
   // public event EventHandler DoubleClick;
      // Event: 
   // public event EventHandler ColumnDidMove;
      // Event: 
   // public event EventHandler ColumnDidResize;
      // Event: 
   // public event EventHandler<AppKit.NSTableViewRowEventArgs> DidAddRowView;
      // Event: 
   // public event EventHandler<AppKit.NSTableViewTableEventArgs> DidClickTableColumn;
      // Event: 
   // public event EventHandler<AppKit.NSTableViewTableEventArgs> DidDragTableColumn;
      // Event: 
   // public event EventHandler<AppKit.NSTableViewRowEventArgs> DidRemoveRowView;
      // Event: 
   // public event EventHandler<AppKit.NSTableViewTableEventArgs> MouseDownInHeaderOfTableColumn;
      // Event: 
   // public event EventHandler SelectionDidChange;
      // Event: 
   // public event EventHandler SelectionIsChanging;
      // Event: 
   // public event EventHandler<AppKit.NSTableViewCellEventArgs> WillDisplayCell;
      // Event: 
   // public event EventHandler Activated;
       // Field: 
       protected Xwt.Backends.ApplicationContext context;
       // Field: 
       public static readonly System.Reflection.Assembly PlatformAssembly;
       // Field: 
       public static readonly System.Reflection.Assembly MonoMacAssembly;
   }
}
