
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("d334bcb9-7090-32dc-8542-9465af1f9275")]
   public class SelectFolderDialogBackend : FileDialogBackend Xwt.Backends.ISelectFolderDialogBackend
   {
       public virtual void Initialize(bool multiselect) {}
       public virtual override void Initialize(System.Collections.Generic.IEnumerable<Xwt.FileDialogFilter> filters, bool multiselect, string initialFileName) {}
       public virtual override bool Run(Xwt.Backends.IWindowFrameBackend parent) { throw new NotImplementedException(); }
       public virtual override void Cleanup() {}
       public virtual override void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
      // public virtual override void EnableEvent(object eventId) {}
      // public virtual override void DisableEvent(object eventId) {}
       public override void BeginSheet(string directory, string fileName, string[] fileTypes, AppKit.NSWindow modalForWindow) {}
       public override void BeginSheet(string directory, string fileName, string[] fileTypes, AppKit.NSWindow modalForWindow, Action onEnded) {}
       public virtual override void Begin(string directory, string fileName, string[] fileTypes, Foundation.NSObject modelessDelegate, ObjCRuntime.Selector didEndSelector, IntPtr contextInfo) {}
       public virtual override void BeginSheet(string directory, string fileName, string[] fileTypes, AppKit.NSWindow modalForWindow, Foundation.NSObject modalDelegate, ObjCRuntime.Selector didEndSelector, IntPtr contextInfo) {}
       public virtual override nint RunModal(string directory, string fileName, string[] types) { throw new NotImplementedException(); }
       public virtual override nint RunModal(string[] types) { throw new NotImplementedException(); }
       public virtual override void Begin(AppKit.NSSavePanelComplete onComplete) {}
       public virtual override void Begin(string directory, string filename, AppKit.NSWindow docWindow, Foundation.NSObject modalDelegate, ObjCRuntime.Selector selector, IntPtr context) {}
       public virtual override void BeginSheet(AppKit.NSWindow window, AppKit.NSSavePanelComplete onComplete) {}
       public virtual override void Cancel(Foundation.NSObject sender) {}
       public virtual override void Ok(Foundation.NSObject sender) {}
       public virtual override nint RunModal() { throw new NotImplementedException(); }
       public virtual override nint RunModal(string directory, string filename) { throw new NotImplementedException(); }
       public virtual override void ValidateVisibleColumns() {}
       protected virtual override void Dispose(bool disposing) {}
       public static override AppKit.NSWindow FromWindowRef(IntPtr windowRef) { throw new NotImplementedException(); }
       public override void Close() {}
       public override AppKit.NSEvent NextEventMatchingMask(AppKit.NSEventMask mask) { throw new NotImplementedException(); }
       public override AppKit.NSEvent NextEventMatchingMask(AppKit.NSEventMask mask, Foundation.NSDate expiration, string mode, bool deqFlag) { throw new NotImplementedException(); }
       public override void DiscardEventsMatchingMask(AppKit.NSEventMask mask, AppKit.NSEvent beforeLastEvent) {}
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
       public virtual override void AddChildWindow(AppKit.NSWindow childWin, AppKit.NSWindowOrderingMode place) {}
       public virtual override void AddTabbedWindow(AppKit.NSWindow window, AppKit.NSWindowOrderingMode ordered) {}
       public virtual override void AddTitlebarAccessoryViewController(AppKit.NSTitlebarAccessoryViewController childViewController) {}
       public virtual override Foundation.NSObject AnimationFor(Foundation.NSString key) { throw new NotImplementedException(); }
       public virtual override double AnimationResizeTime(CoreGraphics.CGRect newFrame) { throw new NotImplementedException(); }
       public virtual override bool AutorecalculatesContentBorderThickness(AppKit.NSRectEdge forEdgeedge) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect BackingAlignedRect(CoreGraphics.CGRect aRect, Foundation.NSAlignmentOptions options) { throw new NotImplementedException(); }
       public virtual override void BecomeKeyWindow() {}
       public virtual override void BecomeMainWindow() {}
       public virtual override void BeginCriticalSheet(AppKit.NSWindow sheetWindow, Action<nint> completionHandler) {}
       public virtual override void BeginSheet(AppKit.NSWindow sheetWindow, Action<nint> completionHandler) {}
       public virtual override void CacheImageInRect(CoreGraphics.CGRect aRect) {}
       public virtual override bool CanRepresentDisplayGamut(AppKit.NSDisplayGamut displayGamut) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint CascadeTopLeftFromPoint(CoreGraphics.CGPoint topLeftPoint) { throw new NotImplementedException(); }
       public virtual override void Center() {}
       public virtual override CoreGraphics.CGRect ConstrainFrameRect(CoreGraphics.CGRect frameRect, AppKit.NSScreen screen) { throw new NotImplementedException(); }
       public virtual override nfloat ContentBorderThicknessForEdge(AppKit.NSRectEdge edge) { throw new NotImplementedException(); }
       public static override CoreGraphics.CGRect ContentRectFor(CoreGraphics.CGRect forFrameRect, AppKit.NSWindowStyle styleMask) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ContentRectFor(CoreGraphics.CGRect frameRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertBaseToScreen(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectFromBacking(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectFromScreen(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectToBacking(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ConvertRectToScreen(CoreGraphics.CGRect aRect) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGPoint ConvertScreenToBase(CoreGraphics.CGPoint aPoint) { throw new NotImplementedException(); }
       public virtual override AppKit.NSEvent CurrentEvent() { throw new NotImplementedException(); }
       public virtual override Foundation.NSData DataWithEpsInsideRect(CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public virtual override Foundation.NSData DataWithPdfInsideRect(CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public static override Foundation.NSObject DefaultAnimationFor(Foundation.NSString key) { throw new NotImplementedException(); }
       public virtual override void Deminiaturize(Foundation.NSObject sender) {}
       public virtual override void DisableCursorRects() {}
       public virtual override void DisableFlushWindow() {}
       public virtual override void DisableKeyEquivalentForDefaultButtonCell() {}
       public virtual override void DisableScreenUpdatesUntilFlush() {}
       public virtual override void DisableSnapshotRestoration() {}
       public virtual override void DiscardCachedImage() {}
       public virtual override void DiscardCursorRects() {}
       protected virtual override void DiscardEventsMatchingMask(nuint mask, AppKit.NSEvent beforeLastEvent) {}
       public virtual override void Display() {}
       public virtual override void DisplayIfNeeded() {}
       public virtual override void EnableCursorRects() {}
       public virtual override void EnableFlushWindow() {}
       public virtual override void EnableKeyEquivalentForDefaultButtonCell() {}
       public virtual override void EnableSnapshotRestoration() {}
       public virtual override void EndEditingFor(Foundation.NSObject anObject) {}
       public virtual override void EndSheet(AppKit.NSWindow sheetWindow) {}
       public virtual override void EndSheet(AppKit.NSWindow sheetWindow, nint returnCode) {}
       public virtual override AppKit.NSText FieldEditor(bool createFlag, Foundation.NSObject forObject) { throw new NotImplementedException(); }
       public virtual override void FlushWindow() {}
       public virtual override void FlushWindowIfNeeded() {}
       public static override CoreGraphics.CGRect FrameRectFor(CoreGraphics.CGRect contectRect, AppKit.NSWindowStyle styleMask) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect FrameRectFor(CoreGraphics.CGRect contentRect) { throw new NotImplementedException(); }
       public virtual override nint GState() { throw new NotImplementedException(); }
       public virtual override Foundation.NSAttributedString GetAccessibilityAttributedString(Foundation.NSRange range) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetAccessibilityCellForColumn(nint column, nint row) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect GetAccessibilityFrame(Foundation.NSRange range) { throw new NotImplementedException(); }
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
       protected virtual override string GetFrameAutosaveName() { throw new NotImplementedException(); }
       public static override AppKit.NSWindow GetWindowWithContentViewController(AppKit.NSViewController contentViewController) { throw new NotImplementedException(); }
       public virtual override void InsertTitlebarAccessoryViewController(AppKit.NSTitlebarAccessoryViewController childViewController, nint index) {}
       public virtual override void InvalidateCursorRectsForView(AppKit.NSView aView) {}
       public virtual override void InvalidateShadow() {}
       public virtual override bool IsAccessibilitySelectorAllowed(ObjCRuntime.Selector selector) { throw new NotImplementedException(); }
       public virtual override void KeyDown(AppKit.NSEvent theEvent) {}
       public virtual override AppKit.NSSelectionDirection KeyViewSelectionDirection() { throw new NotImplementedException(); }
       public virtual override void LayoutIfNeeded() {}
       public virtual override bool MakeFirstResponder(AppKit.NSResponder aResponder) { throw new NotImplementedException(); }
       public virtual override void MakeKeyAndOrderFront(Foundation.NSObject sender) {}
       public virtual override void MakeKeyWindow() {}
       public virtual override void MakeMainWindow() {}
       public static override void MenuChanged(AppKit.NSMenu menu) {}
       public virtual override void MergeAllWindows(Foundation.NSObject sender) {}
       public static override nfloat MinFrameWidthWithTitle(string aTitle, AppKit.NSWindowStyle aStyle) { throw new NotImplementedException(); }
       public virtual override void Miniaturize(Foundation.NSObject sender) {}
       public virtual override void MoveTabToNewWindow(Foundation.NSObject sender) {}
       protected virtual override AppKit.NSEvent NextEventMatchingMask(nuint mask) { throw new NotImplementedException(); }
       protected virtual override AppKit.NSEvent NextEventMatchingMask(nuint mask, Foundation.NSDate expiration, string mode, bool deqFlag) { throw new NotImplementedException(); }
       public virtual override void OrderBack(Foundation.NSObject sender) {}
       public virtual override void OrderFront(Foundation.NSObject sender) {}
       public virtual override void OrderFrontRegardless() {}
       public virtual override void OrderOut(Foundation.NSObject sender) {}
       public virtual override void OrderWindow(AppKit.NSWindowOrderingMode place, nint relativeTo) {}
       public virtual override void PerformClose(Foundation.NSObject sender) {}
       public virtual override void PerformMiniaturize(Foundation.NSObject sender) {}
       public virtual override void PerformWindowDrag(AppKit.NSEvent theEvent) {}
       public virtual override void PerformZoom(Foundation.NSObject sender) {}
       public virtual override void PostEvent(AppKit.NSEvent theEvent, bool atStart) {}
       public virtual override void Print(Foundation.NSObject sender) {}
       public virtual override void RecalculateKeyViewLoop() {}
       public virtual override void RegisterForDraggedTypes(string[] newTypes) {}
       public virtual override void RemoveChildWindow(AppKit.NSWindow childWin) {}
       public static override void RemoveFrameUsingName(string name) {}
       public virtual override void RemoveTitlebarAccessoryViewControllerAtIndex(nint index) {}
       public virtual override void ResetCursorRects() {}
       public virtual override void ResignKeyWindow() {}
       public virtual override void ResignMainWindow() {}
       public virtual override void RestoreCachedImage() {}
       public virtual override void RunToolbarCustomizationPalette(Foundation.NSObject sender) {}
       public virtual override void SaveFrameUsingName(string name) {}
       public virtual override void SelectKeyViewFollowingView(AppKit.NSView aView) {}
       public virtual override void SelectKeyViewPrecedingView(AppKit.NSView aView) {}
       public virtual override void SelectNextKeyView(Foundation.NSObject sender) {}
       public virtual override void SelectNextTab(Foundation.NSObject sender) {}
       public virtual override void SelectPreviousKeyView(Foundation.NSObject sender) {}
       public virtual override void SelectPreviousTab(Foundation.NSObject sender) {}
       public virtual override void SendEvent(AppKit.NSEvent theEvent) {}
       public virtual override void SetAnchorAttribute(AppKit.NSLayoutAttribute layoutAttribute, AppKit.NSLayoutConstraintOrientation forOrientation) {}
       public virtual override void SetAutorecalculatesContentBorderThickness(bool flag, AppKit.NSRectEdge forEdge) {}
       public virtual override void SetContentBorderThickness(nfloat thickness, AppKit.NSRectEdge edge) {}
       public virtual override void SetContentSize(CoreGraphics.CGSize aSize) {}
       public virtual override void SetExcludedFromWindowsMenu(bool flag) {}
       public virtual override void SetFrame(CoreGraphics.CGRect frameRect, bool display) {}
       public virtual override void SetFrame(CoreGraphics.CGRect frameRect, bool display, bool animate) {}
       protected virtual override bool SetFrameAutosaveName(string frameName) { throw new NotImplementedException(); }
       public virtual override void SetFrameFrom(string str) {}
       public virtual override void SetFrameOrigin(CoreGraphics.CGPoint aPoint) {}
       public virtual override void SetFrameTopLeftPoint(CoreGraphics.CGPoint aPoint) {}
       public virtual override bool SetFrameUsingName(string name, bool force) { throw new NotImplementedException(); }
       public virtual override bool SetFrameUsingName(string name) { throw new NotImplementedException(); }
       public virtual override void SetOneShot(bool flag) {}
       public virtual override void SetTitleWithRepresentedFilename(string filename) {}
       public static override AppKit.NSButton StandardWindowButton(AppKit.NSWindowButton b, AppKit.NSWindowStyle styleMask) { throw new NotImplementedException(); }
       public virtual override AppKit.NSButton StandardWindowButton(AppKit.NSWindowButton b) { throw new NotImplementedException(); }
       public virtual override string StringWithSavedFrame() { throw new NotImplementedException(); }
       public virtual override void ToggleFullScreen(Foundation.NSObject sender) {}
       public virtual override void ToggleTabBar(Foundation.NSObject sender) {}
       public virtual override void ToggleToolbarShown(Foundation.NSObject sender) {}
       public virtual override void TrackEventsMatching(AppKit.NSEventMask mask, double timeout, string mode, AppKit.NSWindowTrackEventsMatchingCompletionHandler trackingHandler) {}
       public virtual override bool TryToPerform(ObjCRuntime.Selector anAction, Foundation.NSObject anObject) { throw new NotImplementedException(); }
       public virtual override void UnregisterDraggedTypes() {}
       public virtual override void Update() {}
       public virtual override void UpdateConstraintsIfNeeded() {}
       public virtual override void UseOptimizedDrawing(bool flag) {}
       public virtual override Foundation.NSObject ValidRequestorForSendType(string sendType, string returnType) { throw new NotImplementedException(); }
       public virtual override void VisualizeConstraints(AppKit.NSLayoutConstraint[] constraints) {}
       public static override nint WindowNumberAtPoint(CoreGraphics.CGPoint point, nint windowNumber) { throw new NotImplementedException(); }
       public static override Foundation.NSArray WindowNumbersWithOptions(AppKit.NSWindowNumberListOptions options) { throw new NotImplementedException(); }
       public virtual override bool WorksWhenModal() { throw new NotImplementedException(); }
       public virtual override void Zoom(Foundation.NSObject sender) {}
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
       public virtual override void KeyUp(AppKit.NSEvent theEvent) {}
       public virtual override void MagnifyWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void MouseDown(AppKit.NSEvent theEvent) {}
       public virtual override void MouseDragged(AppKit.NSEvent theEvent) {}
       public virtual override void MouseEntered(AppKit.NSEvent theEvent) {}
       public virtual override void MouseExited(AppKit.NSEvent theEvent) {}
       public virtual override void MouseMoved(AppKit.NSEvent theEvent) {}
       public virtual override void MouseUp(AppKit.NSEvent theEvent) {}
      // public virtual override void NoResponderFor(ObjCRuntime.Selector eventSelector) {}
       public virtual override void OtherMouseDown(AppKit.NSEvent theEvent) {}
       public virtual override void OtherMouseDragged(AppKit.NSEvent theEvent) {}
       public virtual override void OtherMouseUp(AppKit.NSEvent theEvent) {}
       public virtual override bool PerformKeyEquivalent(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public virtual override bool PresentError(Foundation.NSError error) { throw new NotImplementedException(); }
      // public override void PresentError(Foundation.NSError error, AppKit.NSWindow window, Foundation.NSObject delegate, ObjCRuntime.Selector didPresentSelector, IntPtr contextInfo) {}
       public virtual override void PressureChange(AppKit.NSEvent pressureChangeEvent) {}
       public virtual override void QuickLook(AppKit.NSEvent withEvent) {}
       public virtual override bool ResignFirstResponder() { throw new NotImplementedException(); }
       public static override string[] RestorableStateKeyPaths() { throw new NotImplementedException(); }
       public virtual override void RestoreState(Foundation.NSCoder coder) {}
       public virtual override void RestoreUserActivityState(Foundation.NSUserActivity userActivity) {}
       public virtual override void RightMouseDown(AppKit.NSEvent theEvent) {}
       public virtual override void RightMouseDragged(AppKit.NSEvent theEvent) {}
       public virtual override void RightMouseUp(AppKit.NSEvent theEvent) {}
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
      //ctor: 
      public SelectFolderDialogBackend () {}
      public virtual bool CanCreateFolders { get; set; }
      public virtual string Folder { get { throw new NotImplementedException(); } }
      public virtual String[] Folders { get { throw new NotImplementedException(); } }
      public virtual string FileName { get { throw new NotImplementedException(); } }
      public virtual String[] FileNames { get { throw new NotImplementedException(); } }
      public virtual string CurrentFolder { get; set; }
      public virtual Xwt.FileDialogFilter ActiveFilter { get; set; }
      public static AppKit.NSOpenPanel OpenPanel { get { throw new NotImplementedException(); } }
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
      public virtual bool AllowsMultipleSelection { get; set; }
      public virtual bool CanChooseDirectories { get; set; }
      public virtual bool CanChooseFiles { get; set; }
      public virtual String[] Filenames { get { throw new NotImplementedException(); } }
      public virtual bool ResolvesAliases { get; set; }
      public virtual Foundation.NSUrl[] Urls { get { throw new NotImplementedException(); } }
      public static AppKit.NSSavePanel SavePanel { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSView AccessoryView { get; set; }
      public virtual String[] AllowedFileTypes { get; set; }
      public virtual bool AllowsOtherFileTypes { get; set; }
      public virtual bool CanCreateDirectories { get; set; }
      public virtual bool CanSelectHiddenExtension { get; set; }
      public AppKit.INSOpenSavePanelDelegate Delegate { get; set; }
      public virtual string Directory { get; set; }
      public virtual Foundation.NSUrl DirectoryUrl { get; set; }
      public virtual bool ExtensionHidden { get; set; }
      public virtual string Filename { get { throw new NotImplementedException(); } }
      public virtual bool IsExpanded { get { throw new NotImplementedException(); } }
      public virtual string Message { get; set; }
      public virtual string NameFieldLabel { get; set; }
      public virtual string NameFieldStringValue { get; set; }
      public virtual string Prompt { get; set; }
      public virtual string RequiredFileType { get; set; }
      public virtual bool ShowsHiddenFiles { get; set; }
      public virtual bool ShowsTagField { get; set; }
      public virtual String[] TagNames { get; set; }
      public virtual string Title { get; set; }
      public virtual bool TreatsFilePackagesAsDirectories { get; set; }
      public virtual Foundation.NSUrl Url { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject WeakDelegate { get; set; }
      public AppKit.NSOpenSaveCompare CompareFilenames { get; set; }
      public AppKit.NSOpenSaveFilename IsValidFilename { get; set; }
      public AppKit.NSOpenSavePanelUrl ShouldEnableUrl { get; set; }
      public AppKit.NSOpenSaveFilename ShouldShowFilename { get; set; }
      public AppKit.NSOpenSaveFilenameConfirmation UserEnteredFilename { get; set; }
      public AppKit.NSOpenSavePanelValidate ValidateUrl { get; set; }
      public virtual bool BecomesKeyOnlyIfNeeded { get; set; }
      public virtual bool FloatingPanel { get; set; }
      public virtual bool WorksWhenModal { get; set; }
      public string FrameAutosaveName { get; set; }
      public virtual bool AcceptsMouseMovedEvents { get; set; }
      public virtual CoreGraphics.CGPoint AccessibilityActivationPoint { get; set; }
      public virtual Foundation.NSNumber[] AccessibilityAllowedValues { get; set; }
      public virtual bool AccessibilityAlternateUIVisible { get; set; }
      public virtual Foundation.NSObject AccessibilityApplicationFocusedUIElement { get; set; }
      public virtual Foundation.NSObject AccessibilityCancelButton { get; set; }
      public virtual Foundation.NSObject[] AccessibilityChildren { get; set; }
      public virtual Foundation.NSObject AccessibilityClearButton { get; set; }
      public virtual Foundation.NSObject AccessibilityCloseButton { get; set; }
      public virtual nint AccessibilityColumnCount { get; set; }
      public virtual Foundation.NSObject[] AccessibilityColumnHeaderUIElements { get; set; }
      public virtual Foundation.NSRange AccessibilityColumnIndexRange { get; set; }
      public virtual Foundation.NSObject[] AccessibilityColumnTitles { get; set; }
      public virtual Foundation.NSObject[] AccessibilityColumns { get; set; }
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
      public virtual bool AccessibilityFocused { get; set; }
      public virtual Foundation.NSObject AccessibilityFocusedWindow { get; set; }
      public virtual CoreGraphics.CGRect AccessibilityFrame { get; set; }
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
      public virtual string AccessibilityIdentifier { get; set; }
      public virtual Foundation.NSObject AccessibilityIncrementButton { get; set; }
      public virtual nint AccessibilityIndex { get; set; }
      public virtual nint AccessibilityInsertionPointLineNumber { get; set; }
      public virtual string AccessibilityLabel { get; set; }
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
      public virtual nint AccessibilityNumberOfCharacters { get; set; }
      public virtual bool AccessibilityOrderedByRow { get; set; }
      public virtual AppKit.NSAccessibilityOrientation AccessibilityOrientation { get; set; }
      public virtual Foundation.NSObject AccessibilityOverflowButton { get; set; }
      public virtual Foundation.NSObject AccessibilityParent { get; set; }
      public virtual string AccessibilityPlaceholderValue { get; set; }
      public virtual Foundation.NSObject[] AccessibilityPreviousContents { get; set; }
      public virtual bool AccessibilityProtectedContent { get; set; }
      public virtual Foundation.NSObject AccessibilityProxy { get; set; }
      public virtual bool AccessibilityRequired { get; set; }
      public virtual string AccessibilityRole { get; set; }
      public virtual string AccessibilityRoleDescription { get; set; }
      public virtual nint AccessibilityRowCount { get; set; }
      public virtual Foundation.NSObject[] AccessibilityRowHeaderUIElements { get; set; }
      public virtual Foundation.NSRange AccessibilityRowIndexRange { get; set; }
      public virtual Foundation.NSObject[] AccessibilityRows { get; set; }
      public virtual AppKit.NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType { get; set; }
      public virtual Foundation.NSObject AccessibilitySearchButton { get; set; }
      public virtual Foundation.NSObject AccessibilitySearchMenu { get; set; }
      public virtual bool AccessibilitySelected { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySelectedCells { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySelectedChildren { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySelectedColumns { get; set; }
      public virtual Foundation.NSObject[] AccessibilitySelectedRows { get; set; }
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
      public virtual Foundation.NSObject[] AccessibilityVisibleCells { get; set; }
      public virtual Foundation.NSRange AccessibilityVisibleCharacterRange { get; set; }
      public virtual Foundation.NSObject[] AccessibilityVisibleChildren { get; set; }
      public virtual Foundation.NSObject[] AccessibilityVisibleColumns { get; set; }
      public virtual Foundation.NSObject[] AccessibilityVisibleRows { get; set; }
      public virtual Foundation.NSObject AccessibilityWarningValue { get; set; }
      public virtual Foundation.NSObject AccessibilityWindow { get; set; }
      public virtual Foundation.NSObject[] AccessibilityWindows { get; set; }
      public virtual Foundation.NSObject AccessibilityZoomButton { get; set; }
      public static bool AllowsAutomaticWindowTabbing { get; set; }
      public virtual bool AllowsConcurrentViewDrawing { get; set; }
      public virtual bool AllowsToolTipsWhenApplicationIsInactive { get; set; }
      public virtual nfloat AlphaValue { get; set; }
      public virtual AppKit.NSWindowAnimationBehavior AnimationBehavior { get; set; }
      public virtual Foundation.NSDictionary Animations { get; set; }
      public virtual Foundation.NSObject Animator { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSAppearance Appearance { get; set; }
      public virtual bool AreCursorRectsEnabled { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGSize AspectRatio { get; set; }
      public virtual AppKit.NSWindow AttachedSheet { get { throw new NotImplementedException(); } }
      public virtual bool Autodisplay { get; set; }
      public virtual bool AutorecalculatesKeyViewLoop { get; set; }
      public virtual AppKit.NSColor BackgroundColor { get; set; }
      public virtual AppKit.NSWindowBackingLocation BackingLocation { get { throw new NotImplementedException(); } }
      public virtual nfloat BackingScaleFactor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSBackingStore BackingType { get; set; }
      public virtual bool CanBecomeKeyWindow { get { throw new NotImplementedException(); } }
      public virtual bool CanBecomeMainWindow { get { throw new NotImplementedException(); } }
      public virtual bool CanBecomeVisibleWithoutLogin { get; set; }
      public virtual bool CanHide { get; set; }
      public virtual bool CanStoreColor { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindow[] ChildWindows { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindowCollectionBehavior CollectionBehavior { get; set; }
      public virtual AppKit.NSColorSpace ColorSpace { get; set; }
      public virtual CoreGraphics.CGSize ContentAspectRatio { get; set; }
      public virtual Foundation.NSObject ContentLayoutGuide { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGRect ContentLayoutRect { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGSize ContentMaxSize { get; set; }
      public virtual CoreGraphics.CGSize ContentMinSize { get; set; }
      public virtual CoreGraphics.CGSize ContentResizeIncrements { get; set; }
      public virtual AppKit.NSView ContentView { get; set; }
      public virtual AppKit.NSViewController ContentViewController { get; set; }
      public virtual AppKit.NSScreen DeepestScreen { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSButtonCell DefaultButtonCell { get; set; }
      public static AppKit.NSWindowDepth DefaultDepthLimit { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindowDepth DepthLimit { get; set; }
      public virtual Foundation.NSDictionary DeviceDescription { get { throw new NotImplementedException(); } }
      public virtual bool DisplaysWhenScreenProfileChanges { get; set; }
      public virtual AppKit.NSDockTile DockTile { get { throw new NotImplementedException(); } }
      public virtual bool DocumentEdited { get; set; }
      public virtual AppKit.NSAppearance EffectiveAppearance { get { throw new NotImplementedException(); } }
      public virtual bool ExcludedFromWindowsMenu { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSResponder FirstResponder { get { throw new NotImplementedException(); } }
      public virtual bool FlushWindowDisabled { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGRect Frame { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSGraphicsContext GraphicsContext { get { throw new NotImplementedException(); } }
      public virtual bool HasDynamicDepthLimit { get; set; }
      public virtual bool HasShadow { get; set; }
      public virtual bool HidesOnDeactivate { get; set; }
      public virtual string Identifier { get; set; }
      public virtual bool IgnoresMouseEvents { get; set; }
      public virtual bool InLiveResize { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSView InitialFirstResponder { get; set; }
      public virtual bool IsKeyWindow { get { throw new NotImplementedException(); } }
      public virtual bool IsMainWindow { get { throw new NotImplementedException(); } }
      public virtual bool IsMiniaturized { get; set; }
      public virtual bool IsMovable { get; set; }
      public virtual bool IsOnActiveSpace { get { throw new NotImplementedException(); } }
      public virtual bool IsOneShot { get { throw new NotImplementedException(); } }
      public virtual bool IsOpaque { get; set; }
      public virtual bool IsSheet { get { throw new NotImplementedException(); } }
      public virtual bool IsVisible { get; set; }
      public virtual bool IsZoomed { get; set; }
      public virtual AppKit.NSWindowLevel Level { get; set; }
      public virtual CoreGraphics.CGSize MaxFullScreenContentSize { get; set; }
      public virtual CoreGraphics.CGSize MaxSize { get; set; }
      public virtual CoreGraphics.CGSize MinFullScreenContentSize { get; set; }
      public virtual CoreGraphics.CGSize MinSize { get; set; }
      public virtual AppKit.NSImage MiniWindowImage { get; set; }
      public virtual string MiniWindowTitle { get; set; }
      public virtual CoreGraphics.CGPoint MouseLocationOutsideOfEventStream { get { throw new NotImplementedException(); } }
      public virtual bool MovableByWindowBackground { get; set; }
      public virtual AppKit.NSWindowOcclusionState OcclusionState { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindow ParentWindow { get; set; }
      public virtual AppKit.NSWindowBackingLocation PreferredBackingLocation { get; set; }
      public virtual bool PreservesContentDuringLiveResize { get; set; }
      // public virtual bool PreventsApplicationTerminationWhenModal { get; set; }
      public virtual bool ReleasedWhenClosed { get; set; }
      public virtual string RepresentedFilename { get; set; }
      public virtual Foundation.NSUrl RepresentedUrl { get; set; }
      public virtual nint ResizeFlags { get { throw new NotImplementedException(); } }
      public virtual CoreGraphics.CGSize ResizeIncrements { get; set; }
      public virtual bool Restorable { get; set; }
      public virtual ObjCRuntime.Class RestorationClass { get; set; }
      public virtual AppKit.NSScreen Screen { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindowSharingType SharingType { get; set; }
      public virtual AppKit.NSWindow SheetParent { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindow[] Sheets { get { throw new NotImplementedException(); } }
      public virtual bool ShowsResizeIndicator { get; set; }
      public virtual bool ShowsToolbarButton { get; set; }
      public virtual AppKit.NSWindowStyle StyleMask { get; set; }
      public virtual AppKit.NSWindow[] TabbedWindows { get { throw new NotImplementedException(); } }
      public virtual string TabbingIdentifier { get; set; }
      public virtual AppKit.NSWindowTabbingMode TabbingMode { get; set; }
      public virtual AppKit.NSWindowTitleVisibility TitleVisibility { get; set; }
      public virtual AppKit.NSTitlebarAccessoryViewController[] TitlebarAccessoryViewControllers { get { throw new NotImplementedException(); } }
      public virtual bool TitlebarAppearsTransparent { get; set; }
      public virtual AppKit.NSToolbar Toolbar { get; set; }
      public virtual nfloat UserSpaceScaleFactor { get { throw new NotImplementedException(); } }
      public static AppKit.NSWindowUserTabbingPreference UserTabbingPreference { get { throw new NotImplementedException(); } }
      public virtual bool ViewsNeedDisplay { get; set; }
      public virtual Foundation.NSObject WindowController { get; set; }
      public virtual nint WindowNumber { get { throw new NotImplementedException(); } }
      public virtual IntPtr WindowRef { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSUserInterfaceLayoutDirection WindowTitlebarLayoutDirection { get { throw new NotImplementedException(); } }
      public static Foundation.NSString AnnouncementRequestedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationActivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationDeactivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationHiddenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationShownNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString CreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidBecomeKeyNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidBecomeMainNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidChangeBackingPropertiesNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidChangeScreenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidChangeScreenProfileNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidDeminiaturizeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidEndLiveResizeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidEndSheetNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidEnterFullScreenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidEnterVersionBrowserNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidExitFullScreenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidExitVersionBrowserNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidExposeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidMiniaturizeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidMoveNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidResignKeyNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidResignMainNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidResizeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidUpdateNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DrawerCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString FocusedWindowChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString HelpTagCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString LayoutChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString MainWindowChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString MovedNotification { get { throw new NotImplementedException(); } }
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
      public static Foundation.NSString ValueChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillBeginSheetNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillCloseNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillEnterFullScreenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillEnterVersionBrowserNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillExitFullScreenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillExitVersionBrowserNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillMiniaturizeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillMoveNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WillStartLiveResizeNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowDeminiaturizedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowMiniaturizedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowMovedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowResizedNotification { get { throw new NotImplementedException(); } }
      public AppKit.NSWindowWindows CustomWindowsToEnterFullScreen { get; set; }
      public AppKit.NSWindowWindows CustomWindowsToExitFullScreen { get; set; }
      public AppKit.NSWindowDocumentDrag ShouldDragDocumentWithEvent { get; set; }
      public AppKit.NSWindowMenu ShouldPopUpDocumentPathMenu { get; set; }
      public AppKit.NSWindowFramePredicate ShouldZoom { get; set; }
      public AppKit.NSWindowSheetRect WillPositionSheet { get; set; }
      public AppKit.NSWindowResize WillResize { get; set; }
      public AppKit.NSWindowSizeSize WillResizeForVersionBrowser { get; set; }
      public AppKit.NSWindowClient WillReturnFieldEditor { get; set; }
      public AppKit.NSWindowUndoManager WillReturnUndoManager { get; set; }
      public AppKit.NSWindowSize WillUseFullScreenContentSize { get; set; }
      public AppKit.NSWindowApplicationPresentationOptions WillUseFullScreenPresentationOptions { get; set; }
      public AppKit.NSWindowFrame WillUseStandardFrame { get; set; }
      public AppKit.NSObjectPredicate WindowShouldClose { get; set; }
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
   // public event EventHandler<AppKit.NSOpenSavePanelUrlEventArgs> DidChangeToDirectory;
      // Event: 
   // public event EventHandler<AppKit.NSOpenSaveFilenameEventArgs> DirectoryDidChange;
      // Event: 
   // public event EventHandler SelectionDidChange;
      // Event: 
   // public event EventHandler<AppKit.NSOpenSaveExpandingEventArgs> WillExpand;
      // Event: 
   // public event EventHandler DidBecomeKey;
      // Event: 
   // public event EventHandler DidBecomeMain;
      // Event: 
   // public event EventHandler DidChangeBackingProperties;
      // Event: 
   // public event EventHandler DidChangeScreen;
      // Event: 
   // public event EventHandler DidChangeScreenProfile;
      // Event: 
   // public event EventHandler<AppKit.NSWindowCoderEventArgs> DidDecodeRestorableState;
      // Event: 
   // public event EventHandler DidDeminiaturize;
      // Event: 
   // public event EventHandler DidEndLiveResize;
      // Event: 
   // public event EventHandler DidEndSheet;
      // Event: 
   // public event EventHandler DidEnterFullScreen;
      // Event: 
   // public event EventHandler DidEnterVersionBrowser;
      // Event: 
   // public event EventHandler DidExitFullScreen;
      // Event: 
   // public event EventHandler DidExitVersionBrowser;
      // Event: 
   // public event EventHandler DidExpose;
      // Event: 
   // public event EventHandler DidFailToEnterFullScreen;
      // Event: 
   // public event EventHandler DidFailToExitFullScreen;
      // Event: 
   // public event EventHandler DidMiniaturize;
      // Event: 
   // public event EventHandler DidMove;
      // Event: 
   // public event EventHandler DidResignKey;
      // Event: 
   // public event EventHandler DidResignMain;
      // Event: 
   // public event EventHandler DidResize;
      // Event: 
   // public event EventHandler DidUpdate;
      // Event: 
   // public event EventHandler<AppKit.NSWindowDurationEventArgs> StartCustomAnimationToEnterFullScreen;
      // Event: 
   // public event EventHandler<AppKit.NSWindowDurationEventArgs> StartCustomAnimationToExitFullScreen;
      // Event: 
   // public event EventHandler WillBeginSheet;
      // Event: 
   // public event EventHandler WillClose;
      // Event: 
   // public event EventHandler<AppKit.NSWindowCoderEventArgs> WillEncodeRestorableState;
      // Event: 
   // public event EventHandler WillEnterFullScreen;
      // Event: 
   // public event EventHandler WillEnterVersionBrowser;
      // Event: 
   // public event EventHandler WillExitFullScreen;
      // Event: 
   // public event EventHandler WillExitVersionBrowser;
      // Event: 
   // public event EventHandler WillMiniaturize;
      // Event: 
   // public event EventHandler WillMove;
      // Event: 
   // public event EventHandler WillStartLiveResize;
       // Field: 
       public static bool DisableReleasedWhenClosedInConstructor;
       // Field: 
       public static readonly System.Reflection.Assembly PlatformAssembly;
       // Field: 
       public static readonly System.Reflection.Assembly MonoMacAssembly;
   }
}
