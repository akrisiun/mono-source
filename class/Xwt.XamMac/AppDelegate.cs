
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("324278d8-6036-3f45-bd8b-67df1a9db0e9")]
   public class AppDelegate : AppKit.NSApplicationDelegate
   {
       public override void DidFinishLaunching(Foundation.NSNotification notification) {}
       public override void WillFinishLaunching(Foundation.NSNotification notification) {}
       public override void ScreenParametersChanged(Foundation.NSNotification notification) {}
       public override AppKit.NSApplicationTerminateReply ApplicationShouldTerminate(AppKit.NSApplication sender) { throw new NotImplementedException(); }
       public override void DidUnhide(Foundation.NSNotification notification) {}
       public override void OpenFiles(AppKit.NSApplication sender, string[] filenames) {}
       public override AppKit.NSMenu ApplicationDockMenu(AppKit.NSApplication sender) { throw new NotImplementedException(); }
       public virtual override bool ApplicationOpenUntitledFile(AppKit.NSApplication sender) { throw new NotImplementedException(); }
       public virtual override bool ApplicationShouldHandleReopen(AppKit.NSApplication sender, bool hasVisibleWindows) { throw new NotImplementedException(); }
       public virtual override bool ApplicationShouldOpenUntitledFile(AppKit.NSApplication sender) { throw new NotImplementedException(); }
       public virtual override bool ApplicationShouldTerminateAfterLastWindowClosed(AppKit.NSApplication sender) { throw new NotImplementedException(); }
       public virtual override bool ContinueUserActivity(AppKit.NSApplication application, Foundation.NSUserActivity userActivity, AppKit.ContinueUserActivityRestorationHandler restorationHandler) { throw new NotImplementedException(); }
       public virtual override void DecodedRestorableState(AppKit.NSApplication app, Foundation.NSCoder state) {}
       public virtual override void DidBecomeActive(Foundation.NSNotification notification) {}
       public virtual override void DidHide(Foundation.NSNotification notification) {}
       public virtual override void DidResignActive(Foundation.NSNotification notification) {}
       public virtual override void DidUpdate(Foundation.NSNotification notification) {}
       public virtual override void FailedToContinueUserActivity(AppKit.NSApplication application, string userActivityType, Foundation.NSError error) {}
       public virtual override void FailedToRegisterForRemoteNotifications(AppKit.NSApplication application, Foundation.NSError error) {}
       public virtual override bool OpenFile(AppKit.NSApplication sender, string filename) { throw new NotImplementedException(); }
       public virtual override bool OpenFileWithoutUI(Foundation.NSObject sender, string filename) { throw new NotImplementedException(); }
       public virtual override bool OpenTempFile(AppKit.NSApplication sender, string filename) { throw new NotImplementedException(); }
       public virtual override void OrderFrontStandardAboutPanel(Foundation.NSObject sender) {}
       public virtual override void OrderFrontStandardAboutPanelWithOptions(Foundation.NSDictionary optionsDictionary) {}
       public virtual override bool PrintFile(AppKit.NSApplication sender, string filename) { throw new NotImplementedException(); }
       public virtual override AppKit.NSApplicationPrintReply PrintFiles(AppKit.NSApplication application, string[] fileNames, Foundation.NSDictionary printSettings, bool showPrintPanels) { throw new NotImplementedException(); }
       public virtual override bool ReadSelectionFromPasteboard(AppKit.NSPasteboard pboard) { throw new NotImplementedException(); }
       public virtual override void ReceivedRemoteNotification(AppKit.NSApplication application, Foundation.NSDictionary userInfo) {}
       public virtual override void RegisterServicesMenu(string[] sendTypes, string[] returnTypes) {}
       public virtual override void RegisteredForRemoteNotifications(AppKit.NSApplication application, Foundation.NSData deviceToken) {}
       public virtual override void UpdatedUserActivity(AppKit.NSApplication application, Foundation.NSUserActivity userActivity) {}
       public virtual override void UserDidAcceptCloudKitShare(AppKit.NSApplication application, CloudKit.CKShareMetadata metadata) {}
       public virtual override void WillBecomeActive(Foundation.NSNotification notification) {}
       public virtual override bool WillContinueUserActivity(AppKit.NSApplication application, string userActivityType) { throw new NotImplementedException(); }
       public virtual override void WillEncodeRestorableState(AppKit.NSApplication app, Foundation.NSCoder encoder) {}
       public virtual override void WillHide(Foundation.NSNotification notification) {}
       public virtual override Foundation.NSError WillPresentError(AppKit.NSApplication application, Foundation.NSError error) { throw new NotImplementedException(); }
       public virtual override void WillResignActive(Foundation.NSNotification notification) {}
       public virtual override void WillTerminate(Foundation.NSNotification notification) {}
       public virtual override void WillUnhide(Foundation.NSNotification notification) {}
       public virtual override void WillUpdate(Foundation.NSNotification notification) {}
       public virtual override bool WriteSelectionToPasteboard(AppKit.NSPasteboard board, string[] types) { throw new NotImplementedException(); }
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
      public AppDelegate (bool launched) {}
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
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
   // public event EventHandler<Xwt.Mac.TerminationEventArgs> Terminating;
      // Event: 
   // public event EventHandler Unhidden;
      // Event: 
   // public event EventHandler<Xwt.Mac.OpenFilesEventArgs> OpenFilesRequest;
      // Event: 
   // public event EventHandler<Xwt.Mac.OpenUrlEventArgs> OpenUrl;
      // Event: 
   // public event EventHandler<Xwt.Mac.ShowDockMenuArgs> ShowDockMenu;
       // Field: 
       public static readonly System.Reflection.Assembly PlatformAssembly;
       // Field: 
       public static readonly System.Reflection.Assembly MonoMacAssembly;
   }
}
