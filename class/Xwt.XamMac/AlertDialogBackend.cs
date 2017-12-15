
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("eed47c92-bb18-37a6-888c-b4d020932e5a")]
   public class AlertDialogBackend : AppKit.NSAlert Xwt.Backends.IAlertDialogBackend
   {
       public virtual void Initialize(Xwt.Backends.ApplicationContext actx) {}
       public virtual Xwt.Command Run(Xwt.WindowFrame transientFor, Xwt.MessageDescription message) { throw new NotImplementedException(); }
       public virtual override AppKit.NSButton AddButton(string title) { throw new NotImplementedException(); }
       public virtual override void BeginSheet(AppKit.NSWindow window, Foundation.NSObject modalDelegate, ObjCRuntime.Selector didEndSelector, IntPtr contextInfo) {}
       public virtual override void BeginSheet(AppKit.NSWindow Window, Action<AppKit.NSModalResponse> handler) {}
       public virtual override System.Threading.Tasks.Task<AppKit.NSModalResponse> BeginSheetAsync(AppKit.NSWindow Window) { throw new NotImplementedException(); }
       public virtual override void Layout() {}
       public virtual override nint RunModal() { throw new NotImplementedException(); }
       public static override AppKit.NSAlert WithError(Foundation.NSError error) { throw new NotImplementedException(); }
       public static override AppKit.NSAlert WithMessage(string message, string defaultButton, string alternateButton, string otherButton, string full) { throw new NotImplementedException(); }
       protected virtual override void Dispose(bool disposing) {}
       public override void BeginSheet(AppKit.NSWindow window) {}
       public override void BeginSheet(AppKit.NSWindow window, Action onEnded) {}
       public override void BeginSheetForResponse(AppKit.NSWindow window, Action<nint> onEnded) {}
       public override nint RunSheetModal(AppKit.NSWindow window) { throw new NotImplementedException(); }
       public override nint RunSheetModal(AppKit.NSWindow window, AppKit.NSApplication application) { throw new NotImplementedException(); }
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
      public AlertDialogBackend () {}
      //ctor: 
      public AlertDialogBackend (IntPtr intptr) {}
      public virtual bool ApplyToAll { get; set; }
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSView AccessoryView { get; set; }
      public virtual AppKit.NSAlertStyle AlertStyle { get; set; }
      public virtual AppKit.NSButton[] Buttons { get { throw new NotImplementedException(); } }
      public AppKit.INSAlertDelegate Delegate { get; set; }
      public virtual string HelpAnchor { get; set; }
      public virtual AppKit.NSImage Icon { get; set; }
      public virtual string InformativeText { get; set; }
      public virtual string MessageText { get; set; }
      public virtual bool ShowsHelp { get; set; }
      public virtual bool ShowsSuppressionButton { get; set; }
      public virtual AppKit.NSButton SuppressionButton { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject WeakDelegate { get; set; }
      public virtual AppKit.NSPanel Window { get { throw new NotImplementedException(); } }
      public AppKit.NSAlertPredicate ShowHelp { get; set; }
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
