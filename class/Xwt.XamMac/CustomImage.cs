
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("3479e302-319d-3234-b5f0-bb4f60342adf")]
   public class CustomImage : AppKit.NSImage
   {
       public void DrawIt(Foundation.NSObject ob) {}
       public CustomImage Clone() { throw new NotImplementedException(); }
       public override Foundation.NSObject Copy(Foundation.NSZone zone) { throw new NotImplementedException(); }
       public virtual override void AddRepresentation(AppKit.NSImageRep imageRep) {}
       public virtual override void AddRepresentations(AppKit.NSImageRep[] imageReps) {}
       public virtual override CoreGraphics.CGImage AsCGImage(CoreGraphics.CGRect proposedDestRect, AppKit.NSGraphicsContext referenceContext, Foundation.NSDictionary hints) { throw new NotImplementedException(); }
       public virtual override Foundation.NSData AsTiff() { throw new NotImplementedException(); }
       public virtual override Foundation.NSData AsTiff(AppKit.NSTiffCompression comp, float aFloat) { throw new NotImplementedException(); }
       public virtual override AppKit.NSImageRep BestRepresentation(CoreGraphics.CGRect rect, AppKit.NSGraphicsContext referenceContext, Foundation.NSDictionary hints) { throw new NotImplementedException(); }
       public virtual override AppKit.NSImageRep BestRepresentationForDevice(Foundation.NSDictionary deviceDescription) { throw new NotImplementedException(); }
       public static override bool CanInitWithPasteboard(AppKit.NSPasteboard pasteboard) { throw new NotImplementedException(); }
       public virtual override void CancelIncrementalLoad() {}
       public virtual override void Draw(CoreGraphics.CGPoint point, CoreGraphics.CGRect fromRect, AppKit.NSCompositingOperation op, nfloat delta) {}
       public virtual override void Draw(CoreGraphics.CGRect rect, CoreGraphics.CGRect fromRect, AppKit.NSCompositingOperation op, nfloat delta) {}
       public virtual override void Draw(CoreGraphics.CGRect dstSpacePortionRect, CoreGraphics.CGRect srcSpacePortionRect, AppKit.NSCompositingOperation op, nfloat requestedAlpha, bool respectContextIsFlipped, Foundation.NSDictionary hints) {}
       public virtual override void Draw(CoreGraphics.CGRect rect) {}
       public virtual override bool Draw(AppKit.NSImageRep imageRep, CoreGraphics.CGRect rect) { throw new NotImplementedException(); }
       public override void DrawInRect(CoreGraphics.CGRect dstRect, CoreGraphics.CGRect srcRect, AppKit.NSCompositingOperation operation, nfloat delta) {}
       public virtual override void EncodeTo(Foundation.NSCoder encoder) {}
       public virtual override Foundation.NSObject GetLayerContentsForContentsScale(nfloat layerContentsScale) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject GetPasteboardPropertyListForType(string type) { throw new NotImplementedException(); }
       public static override string[] GetReadableTypesForPasteboard(AppKit.NSPasteboard pasteboard) { throw new NotImplementedException(); }
       public static override AppKit.NSPasteboardReadingOptions GetReadingOptionsForType(string type, AppKit.NSPasteboard pasteboard) { throw new NotImplementedException(); }
       public virtual override nfloat GetRecommendedLayerContentsScale(nfloat preferredContentsScale) { throw new NotImplementedException(); }
       public virtual override string[] GetWritableTypesForPasteboard(AppKit.NSPasteboard pasteboard) { throw new NotImplementedException(); }
       public virtual override AppKit.NSPasteboardWritingOptions GetWritingOptionsForType(string type, AppKit.NSPasteboard pasteboard) { throw new NotImplementedException(); }
       public virtual override bool HitTestRect(CoreGraphics.CGRect testRectDestSpace, CoreGraphics.CGRect imageRectDestSpace, AppKit.NSGraphicsContext context, Foundation.NSDictionary hints, bool flipped) { throw new NotImplementedException(); }
       public static override AppKit.NSImage ImageNamed(string name) { throw new NotImplementedException(); }
       public static override Foundation.NSObject[] ImageUnfilteredFileTypes() { throw new NotImplementedException(); }
       public static override string[] ImageUnfilteredPasteboardTypes() { throw new NotImplementedException(); }
       public static override AppKit.NSImage ImageWithSize(CoreGraphics.CGSize size, bool flipped, AppKit.NSCustomImageRepDrawingHandler drawingHandler) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject InitWithPasteboardPropertyList(Foundation.NSObject propertyList, string type) { throw new NotImplementedException(); }
       public virtual override void LockFocus() {}
       public virtual override void LockFocusFlipped(bool flipped) {}
       public virtual override void Recache() {}
       public virtual override void RemoveRepresentation(AppKit.NSImageRep imageRep) {}
       public virtual override AppKit.NSImageRep[] Representations() { throw new NotImplementedException(); }
       public virtual override void UnlockFocus() {}
       protected virtual override void Dispose(bool disposing) {}
       public static override AppKit.NSImage FromStream(System.IO.Stream stream) { throw new NotImplementedException(); }
       public static override AppKit.NSImage ImageNamed(AppKit.NSImageName name) { throw new NotImplementedException(); }
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
      public CustomImage (Xwt.Backends.ApplicationContext actx, Xwt.Backends.ImageDrawCallback drawCallback) {}
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
      public virtual string AccessibilityDescription { get; set; }
      public virtual CoreGraphics.CGRect AlignmentRect { get; set; }
      public virtual AppKit.NSColor BackgroundColor { get; set; }
      public virtual AppKit.NSImageCacheMode CacheMode { get; set; }
      public virtual AppKit.NSEdgeInsets CapInsets { get; set; }
      public AppKit.INSImageDelegate Delegate { get; set; }
      public virtual bool Flipped { get; set; }
      public static String[] ImageFileTypes { get { throw new NotImplementedException(); } }
      public static String[] ImagePasteboardTypes { get { throw new NotImplementedException(); } }
      public static String[] ImageTypes { get { throw new NotImplementedException(); } }
      public static String[] ImageUnfilteredTypes { get { throw new NotImplementedException(); } }
      public virtual bool IsValid { get { throw new NotImplementedException(); } }
      public virtual bool MatchesOnMultipleResolution { get; set; }
      public virtual bool MatchesOnlyOnBestFittingAxis { get; set; }
      public virtual bool PrefersColorMatch { get; set; }
      public virtual AppKit.NSImageResizingMode ResizingMode { get; set; }
      public virtual CoreGraphics.CGSize Size { get; set; }
      public virtual bool Template { get; set; }
      public virtual bool UsesEpsOnResolutionMismatch { get; set; }
      public virtual Foundation.NSObject WeakDelegate { get; set; }
      public AppKit.NSImageRect ImageDidNotDraw { get; set; }
      public CoreGraphics.CGImage CGImage { get { throw new NotImplementedException(); } }
      public string Name { get; set; }
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
   // public event EventHandler<AppKit.NSImagePartialEventArgs> DidLoadPartOfRepresentation;
      // Event: 
   // public event EventHandler<AppKit.NSImageLoadRepresentationEventArgs> DidLoadRepresentation;
      // Event: 
   // public event EventHandler<AppKit.NSImageLoadEventArgs> DidLoadRepresentationHeader;
      // Event: 
   // public event EventHandler<AppKit.NSImageLoadEventArgs> WillLoadRepresentation;
       // Field: 
       public static readonly System.Reflection.Assembly PlatformAssembly;
       // Field: 
       public static readonly System.Reflection.Assembly MonoMacAssembly;
   }
}
