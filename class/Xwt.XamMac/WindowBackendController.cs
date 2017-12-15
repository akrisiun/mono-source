
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("095bebe6-fe98-307d-992c-71938116ab43")]
   public class WindowBackendController : AppKit.NSWindowController
   {
       public virtual override void Close() {}
       public virtual override void DismissController(Foundation.NSObject sender) {}
       public virtual override void EncodeTo(Foundation.NSCoder encoder) {}
       public virtual override void LoadWindow() {}
       public virtual override void PerformSegue(string identifier, Foundation.NSObject sender) {}
       public virtual override void PrepareForSegue(AppKit.NSStoryboardSegue segue, Foundation.NSObject sender) {}
       public virtual override void SetDocumentEdited(bool dirtyFlag) {}
       public virtual override bool ShouldPerformSegue(string identifier, Foundation.NSObject sender) { throw new NotImplementedException(); }
       public virtual override void ShowWindow(Foundation.NSObject sender) {}
       public virtual override void SynchronizeWindowTitleWithDocumentName() {}
       public virtual override void WindowDidLoad() {}
       public virtual override string WindowTitleForDocumentDisplayName(string displayName) { throw new NotImplementedException(); }
       public virtual override void WindowWillLoad() {}
       public virtual override bool AcceptsFirstResponder() { throw new NotImplementedException(); }
       public virtual override bool BecomeFirstResponder() { throw new NotImplementedException(); }
       public virtual override void BeginGestureWithEvent(AppKit.NSEvent theEvent) {}
       public virtual override void CursorUpdate(AppKit.NSEvent theEvent) {}
       public virtual override void EncodeRestorableState(Foundation.NSCoder coder) {}
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
       protected virtual override void Dispose(bool disposing) {}
       public override IDisposable AddObserver(string key, Foundation.NSKeyValueObservingOptions options, Action<Foundation.NSObservedChange> observer) { throw new NotImplementedException(); }
       public override IDisposable AddObserver(Foundation.NSString key, Foundation.NSKeyValueObservingOptions options, Action<Foundation.NSObservedChange> observer) { throw new NotImplementedException(); }
      //ctor: 
      public WindowBackendController () {}
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSViewController ContentViewController { get; set; }
      public virtual AppKit.NSDocument Document { get; set; }
      public virtual bool IsWindowLoaded { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject Owner { get { throw new NotImplementedException(); } }
      public virtual bool ShouldCascadeWindows { get; set; }
      public virtual bool ShouldCloseDocument { get; set; }
      public virtual AppKit.NSStoryboard Storyboard { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSWindow Window { get; set; }
      public virtual string WindowFrameAutosaveName { get; set; }
      public virtual string WindowNibName { get { throw new NotImplementedException(); } }
      public virtual string WindowNibPath { get { throw new NotImplementedException(); } }
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
       // Field: 
       public static readonly System.Reflection.Assembly PlatformAssembly;
       // Field: 
       public static readonly System.Reflection.Assembly MonoMacAssembly;
   }
}
