
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("03890c7d-1372-3c05-9454-8cedd523a25a")]
   public class MacSliderCell : AppKit.NSSliderCell
   {
       public override double TickMarkValue(nint index) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect BarRectFlipped(bool flipped) { throw new NotImplementedException(); }
       public virtual override double ClosestTickMarkValue(double value) { throw new NotImplementedException(); }
       public virtual override void DrawBar(CoreGraphics.CGRect aRect, bool flipped) {}
       public virtual override void DrawKnob(CoreGraphics.CGRect knobRect) {}
       public virtual override void DrawKnob() {}
       public virtual override nint IndexOfTickMark(CoreGraphics.CGPoint point) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect KnobRectFlipped(bool flipped) { throw new NotImplementedException(); }
       public static override bool PrefersTrackingUntilMouseUp() { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect RectOfTickMark(nint index) { throw new NotImplementedException(); }
       protected virtual override void Dispose(bool disposing) {}
       public override void DrawThreePartImage(CoreGraphics.CGRect frame, AppKit.NSImage startCap, AppKit.NSImage centerFill, AppKit.NSImage endCap, bool vertical, AppKit.NSCompositingOperation op, nfloat alphaFraction, bool flipped) {}
       public override void DrawNinePartImage(CoreGraphics.CGRect frame, AppKit.NSImage topLeftCorner, AppKit.NSImage topEdgeFill, AppKit.NSImage topRightCorner, AppKit.NSImage leftEdgeFill, AppKit.NSImage centerFill, AppKit.NSImage rightEdgeFill, AppKit.NSImage bottomLeftCorner, AppKit.NSImage bottomEdgeFill, AppKit.NSImage bottomRightCorner, AppKit.NSCompositingOperation op, nfloat alphaFraction, bool flipped) {}
       public virtual override bool AcceptsFirstResponder() { throw new NotImplementedException(); }
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
       public virtual override void CalcDrawInfo(CoreGraphics.CGRect aRect) {}
       public virtual override nint CellAttribute(AppKit.NSCellAttribute aParameter) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGSize CellSizeForBounds(CoreGraphics.CGRect bounds) { throw new NotImplementedException(); }
       public virtual override Foundation.NSComparisonResult Compare(Foundation.NSObject otherCell) { throw new NotImplementedException(); }
       public virtual override bool ContinueTracking(CoreGraphics.CGPoint lastPoint, CoreGraphics.CGPoint currentPoint, AppKit.NSView inView) { throw new NotImplementedException(); }
       public virtual override Foundation.NSObject Copy(Foundation.NSZone zone) { throw new NotImplementedException(); }
       public virtual override void DrawFocusRing(CoreGraphics.CGRect cellFrameMask, AppKit.NSView inControlView) {}
       public virtual override void DrawInteriorWithFrame(CoreGraphics.CGRect cellFrame, AppKit.NSView inView) {}
       public virtual override void DrawWithExpansionFrame(CoreGraphics.CGRect cellFrame, AppKit.NSView inView) {}
       public virtual override void DrawWithFrame(CoreGraphics.CGRect cellFrame, AppKit.NSView inView) {}
       public virtual override CoreGraphics.CGRect DrawingRectForBounds(CoreGraphics.CGRect theRect) { throw new NotImplementedException(); }
      // public virtual override void EditWithFrame(CoreGraphics.CGRect aRect, AppKit.NSView inView, AppKit.NSText editor, Foundation.NSObject delegateObject, AppKit.NSEvent theEvent) {}
       public virtual override void EncodeTo(Foundation.NSCoder encoder) {}
       public virtual override void EndEditing(AppKit.NSText textObj) {}
       public virtual override CoreGraphics.CGRect ExpansionFrame(CoreGraphics.CGRect withFrame, AppKit.NSView inView) { throw new NotImplementedException(); }
       public virtual override AppKit.NSTextView FieldEditorForView(AppKit.NSView aControlView) { throw new NotImplementedException(); }
       public virtual override AppKit.NSDraggingImageComponent[] GenerateDraggingImageComponents(CoreGraphics.CGRect frame, AppKit.NSView view) { throw new NotImplementedException(); }
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
       public virtual override CoreGraphics.CGRect GetFocusRingMaskBounds(CoreGraphics.CGRect cellFrame, AppKit.NSView controlView) { throw new NotImplementedException(); }
       public virtual override void GetPeriodicDelay(float delay, float interval) {}
       public virtual override void Highlight(bool highlight, CoreGraphics.CGRect withFrame, AppKit.NSView inView) {}
       public virtual override AppKit.NSColor HighlightColor(CoreGraphics.CGRect cellFrame, AppKit.NSView controlView) { throw new NotImplementedException(); }
       public virtual override AppKit.NSCellHit HitTest(AppKit.NSEvent forEvent, CoreGraphics.CGRect inRect, AppKit.NSView ofView) { throw new NotImplementedException(); }
       public virtual override CoreGraphics.CGRect ImageRectForBounds(CoreGraphics.CGRect theRect) { throw new NotImplementedException(); }
       public virtual override bool IsAccessibilityAttributeSettable(Foundation.NSString attribute) { throw new NotImplementedException(); }
       public virtual override bool IsAccessibilitySelectorAllowed(ObjCRuntime.Selector selector) { throw new NotImplementedException(); }
       public virtual override bool IsEntryAcceptable(string aString) { throw new NotImplementedException(); }
       public virtual override AppKit.NSMenu MenuForEvent(AppKit.NSEvent theEvent, CoreGraphics.CGRect cellFrame, AppKit.NSView view) { throw new NotImplementedException(); }
       public virtual override void PerformClick(Foundation.NSObject sender) {}
       public virtual override bool RefusesFirstResponder() { throw new NotImplementedException(); }
       public virtual override void ResetCursorRect(CoreGraphics.CGRect cellFrame, AppKit.NSView inView) {}
      // public virtual override void SelectWithFrame(CoreGraphics.CGRect aRect, AppKit.NSView inView, AppKit.NSText editor, Foundation.NSObject delegateObject, nint selStart, nint selLength) {}
       public virtual override nint SendActionOn(AppKit.NSEventType mask) { throw new NotImplementedException(); }
       public virtual override bool SendsActionOnEndEditing() { throw new NotImplementedException(); }
       public virtual override void SetAccessibilityValue(Foundation.NSString attribute, Foundation.NSObject value) {}
       public virtual override void SetCellAttribute(AppKit.NSCellAttribute aParameter, nint value) {}
       public virtual override void SetNextState() {}
       public virtual override void SetSendsActionOnEndEditing(bool flag) {}
       public virtual override void SetTitleWithMnemonic(string stringWithAmpersand) {}
       public virtual override AppKit.NSText SetUpFieldEditorAttributes(AppKit.NSText textObj) { throw new NotImplementedException(); }
       public virtual override bool StartTracking(CoreGraphics.CGPoint startPoint, AppKit.NSView inView) { throw new NotImplementedException(); }
       public virtual override void StopTracking(CoreGraphics.CGPoint lastPoint, CoreGraphics.CGPoint stopPoint, AppKit.NSView inView, bool mouseIsUp) {}
       public virtual override void TakeDoubleValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeFloatValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeIntValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeIntegerValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeObjectValueFrom(Foundation.NSObject sender) {}
       public virtual override void TakeStringValueFrom(Foundation.NSObject sender) {}
       public virtual override CoreGraphics.CGRect TitleRectForBounds(CoreGraphics.CGRect theRect) { throw new NotImplementedException(); }
       public virtual override bool TrackMouse(AppKit.NSEvent theEvent, CoreGraphics.CGRect cellFrame, AppKit.NSView controlView, bool untilMouseUp) { throw new NotImplementedException(); }
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
      public MacSliderCell () {}
      public override double MaxValue { get; set; }
      public override double MinValue { get; set; }
      public double StepIncrement { get; set; }
      public override bool AllowsTickMarkValuesOnly { get; set; }
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
      public virtual double AltIncrementValue { get; set; }
      public virtual nint IsVertical { get; set; }
      public virtual nfloat KnobThickness { get; set; }
      public virtual AppKit.NSSliderType SliderType { get; set; }
      public virtual AppKit.NSTickMarkPosition TickMarkPosition { get; set; }
      public virtual nint TickMarks { get; set; }
      public virtual string Title { get; set; }
      public virtual Foundation.NSObject TitleCell { get; set; }
      public virtual AppKit.NSColor TitleColor { get; set; }
      public virtual AppKit.NSFont TitleFont { get; set; }
      public virtual CoreGraphics.CGRect TrackRect { get { throw new NotImplementedException(); } }
      public virtual ObjCRuntime.Selector Action { get; set; }
      public virtual nint Tag { get; set; }
      public virtual Foundation.NSObject Target { get; set; }
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
      public virtual bool AccessibilityIsIgnored { get { throw new NotImplementedException(); } }
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
      public virtual bool AccessibilityNotifiesWhenDestroyed { get { throw new NotImplementedException(); } }
      public virtual nint AccessibilityNumberOfCharacters { get; set; }
      public virtual bool AccessibilityOrderedByRow { get; set; }
      public virtual AppKit.NSAccessibilityOrientation AccessibilityOrientation { get; set; }
      public virtual Foundation.NSObject AccessibilityOverflowButton { get; set; }
      public virtual Foundation.NSArray AccessibilityParameterizedAttributeNames { get { throw new NotImplementedException(); } }
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
      public virtual AppKit.NSTextAlignment Alignment { get; set; }
      public virtual bool AllowsEditingTextAttributes { get; set; }
      public virtual bool AllowsMixedState { get; set; }
      public virtual bool AllowsUndo { get; set; }
      public virtual Foundation.NSAttributedString AttributedStringValue { get; set; }
      public virtual AppKit.NSBackgroundStyle BackgroundStyle { get; set; }
      public virtual AppKit.NSWritingDirection BaseWritingDirection { get; set; }
      public virtual bool Bezeled { get; set; }
      public virtual bool Bordered { get; set; }
      public virtual CoreGraphics.CGSize CellSize { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSCellType CellType { get; set; }
      public virtual AppKit.NSControlSize ControlSize { get; set; }
      public virtual AppKit.NSControlTint ControlTint { get; set; }
      public virtual AppKit.NSView ControlView { get; set; }
      public static AppKit.NSFocusRingType DefaultFocusRingType { get { throw new NotImplementedException(); } }
      public static AppKit.NSMenu DefaultMenu { get { throw new NotImplementedException(); } }
      public virtual double DoubleValue { get; set; }
      public virtual bool Editable { get; set; }
      public virtual bool Enabled { get; set; }
      public virtual float FloatValue { get; set; }
      public virtual AppKit.NSFocusRingType FocusRingType { get; set; }
      public virtual AppKit.NSFont Font { get; set; }
      public virtual Foundation.NSFormatter Formatter { get; set; }
      public virtual bool HasValidObjectValue { get { throw new NotImplementedException(); } }
      public virtual bool Highlighted { get; set; }
      public virtual string Identifier { get; set; }
      public virtual AppKit.NSImage Image { get; set; }
      public virtual bool ImportsGraphics { get; set; }
      public virtual int IntValue { get; set; }
      public virtual nint IntegerValue { get; set; }
      public virtual AppKit.NSBackgroundStyle InteriorBackgroundStyle { get { throw new NotImplementedException(); } }
      public virtual bool IsContinuous { get; set; }
      public virtual bool IsOpaque { get { throw new NotImplementedException(); } }
      public virtual string KeyEquivalent { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSLineBreakMode LineBreakMode { get; set; }
      public virtual AppKit.NSMenu Menu { get; set; }
      public virtual string Mnemonic { get { throw new NotImplementedException(); } }
      public virtual nint MnemonicLocation { get; set; }
      public virtual nint MouseDownFlags { get { throw new NotImplementedException(); } }
      public virtual nint NextState { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject ObjectValue { get; set; }
      public static bool PrefersTrackingUntilMouseUp { get { throw new NotImplementedException(); } }
      public virtual Foundation.NSObject RepresentedObject { get; set; }
      public virtual bool Scrollable { get; set; }
      public virtual bool Selectable { get; set; }
      public virtual bool ShowsFirstResponder { get; set; }
      public virtual AppKit.NSCellStateValue State { get; set; }
      public virtual string StringValue { get; set; }
      public virtual bool TruncatesLastVisibleLine { get; set; }
      public virtual AppKit.NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection { get; set; }
      public virtual bool UsesSingleLineMode { get; set; }
      public virtual bool WantsNotificationForMarkedText { get; set; }
      public virtual bool Wraps { get; set; }
      public static Foundation.NSString AnnouncementRequestedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationActivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationDeactivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationHiddenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationShownNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ControlTintChangedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString CreatedNotification { get { throw new NotImplementedException(); } }
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
      public static Foundation.NSString WindowCreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowDeminiaturizedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowMiniaturizedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowMovedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString WindowResizedNotification { get { throw new NotImplementedException(); } }
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
   // public event EventHandler Activated;
       // Field: 
       public static readonly System.Reflection.Assembly PlatformAssembly;
       // Field: 
       public static readonly System.Reflection.Assembly MonoMacAssembly;
   }
}
