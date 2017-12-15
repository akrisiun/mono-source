
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("fc9ae447-5bac-349b-b898-235e69804e1f")]
   public class MenuBackend : AppKit.NSMenu Xwt.Backends.IMenuBackend
   {
       public virtual void InitializeBackend(object frontend, Xwt.Backends.ApplicationContext context) {}
       public virtual void InsertItem(int index, Xwt.Backends.IMenuItemBackend menuItem) {}
       public virtual void RemoveItem(Xwt.Backends.IMenuItemBackend menuItem) {}
       public void SetMainMenuMode() {}
      // public virtual void EnableEvent(object eventId) {}
      // public virtual void DisableEvent(object eventId) {}
       public virtual void Popup() {}
       public virtual void Popup(Xwt.Backends.IWidgetBackend widget, double x, double y) {}
       protected virtual override void Dispose(bool disposing) {}
       public virtual override void AccessibilityAddChildElement(AppKit.NSAccessibilityElement childElement) {}
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
       public virtual override void AddItem(AppKit.NSMenuItem newItem) {}
       public virtual override AppKit.NSMenuItem AddItem(string title, ObjCRuntime.Selector action, string charCode) { throw new NotImplementedException(); }
       public virtual override void CancelTracking() {}
       public virtual override void CancelTrackingWithoutAnimation() {}
       public virtual override Foundation.NSObject Copy(Foundation.NSZone zone) { throw new NotImplementedException(); }
       public static override Foundation.NSObject CreateElement(Foundation.NSString role, CoreGraphics.CGRect frame, Foundation.NSString label, Foundation.NSObject parent) { throw new NotImplementedException(); }
       public virtual override void EncodeTo(Foundation.NSCoder encoder) {}
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
      // public virtual override void HelpRequested(AppKit.NSEvent eventPtr) {}
       public virtual override nint IndexOf(AppKit.NSMenuItem index) { throw new NotImplementedException(); }
       public virtual override nint IndexOf(string aTitle) { throw new NotImplementedException(); }
       public virtual override nint IndexOf(nint itemTag) { throw new NotImplementedException(); }
       public virtual override nint IndexOfItem(Foundation.NSObject obj) { throw new NotImplementedException(); }
       public virtual override nint IndexOfItem(AppKit.NSMenu submenu) { throw new NotImplementedException(); }
       public virtual override nint IndexOfItem(Foundation.NSObject target, ObjCRuntime.Selector actionSelector) { throw new NotImplementedException(); }
       public virtual override void InsertItem(AppKit.NSMenuItem newItem, nint index) {}
       public virtual override AppKit.NSMenuItem InsertItem(string title, ObjCRuntime.Selector action, string charCode, nint index) { throw new NotImplementedException(); }
       public virtual override bool IsAccessibilitySelectorAllowed(ObjCRuntime.Selector selector) { throw new NotImplementedException(); }
       public virtual override AppKit.NSMenuItem[] ItemArray() { throw new NotImplementedException(); }
       public virtual override AppKit.NSMenuItem ItemAt(nint index) { throw new NotImplementedException(); }
       public virtual override void ItemChanged(AppKit.NSMenuItem item) {}
       public virtual override AppKit.NSMenuItem ItemWithTag(nint tag) { throw new NotImplementedException(); }
       public virtual override AppKit.NSMenuItem ItemWithTitle(string title) { throw new NotImplementedException(); }
       public virtual override void PerformActionForItem(nint index) {}
       public virtual override bool PerformKeyEquivalent(AppKit.NSEvent theEvent) { throw new NotImplementedException(); }
       public static override void PopUpContextMenu(AppKit.NSMenu menu, AppKit.NSEvent theEvent, AppKit.NSView view) {}
       public static override void PopUpContextMenu(AppKit.NSMenu menu, AppKit.NSEvent theEvent, AppKit.NSView view, AppKit.NSFont font) {}
       public virtual override bool PopUpMenu(AppKit.NSMenuItem item, CoreGraphics.CGPoint location, AppKit.NSView view) { throw new NotImplementedException(); }
       public virtual override AppKit.NSMenuProperty PropertiesToUpdate() { throw new NotImplementedException(); }
       public virtual override void RemoveAllItems() {}
       public virtual override void RemoveItem(AppKit.NSMenuItem item) {}
       public virtual override void RemoveItemAt(nint index) {}
       public virtual override void SetSubmenu(AppKit.NSMenu aMenu, AppKit.NSMenuItem anItem) {}
       public virtual override void Update() {}
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
      public MenuBackend () {}
      public virtual IntPtr ClassHandle { get { throw new NotImplementedException(); } }
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
      public virtual CoreGraphics.CGRect AccessibilityFrameInParentSpace { get; set; }
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
      public virtual bool AllowsContextMenuPlugIns { get; set; }
      public virtual bool AutoEnablesItems { get; set; }
      public virtual nint Count { get { throw new NotImplementedException(); } }
      public AppKit.INSMenuDelegate Delegate { get; set; }
      public virtual AppKit.NSFont Font { get; set; }
      public virtual AppKit.NSMenuItem HighlightedItem { get { throw new NotImplementedException(); } }
      public virtual string Identifier { get; set; }
      public virtual bool IsTornOff { get { throw new NotImplementedException(); } }
      public virtual nfloat MenuBarHeight { get { throw new NotImplementedException(); } }
      public static bool MenuBarVisible { get; set; }
      public virtual bool MenuChangedMessagesEnabled { get; set; }
      public static Foundation.NSZone MenuZone { get { throw new NotImplementedException(); } }
      public virtual nfloat MinimumWidth { get; set; }
      public virtual bool ShowsStateColumn { get; set; }
      public virtual CoreGraphics.CGSize Size { get { throw new NotImplementedException(); } }
      public virtual AppKit.NSMenu Supermenu { get; set; }
      public virtual string Title { get; set; }
      public virtual AppKit.NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection { get; set; }
      public virtual Foundation.NSObject WeakDelegate { get; set; }
      public static Foundation.NSString AnnouncementRequestedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationActivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationDeactivatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationHiddenNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString ApplicationShownNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString CreatedNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidAddItemNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidBeginTrackingNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidChangeItemNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidEndTrackingNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidRemoveItemNotification { get { throw new NotImplementedException(); } }
      public static Foundation.NSString DidSendActionNotification { get { throw new NotImplementedException(); } }
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
      public static Foundation.NSString WillSendActionNotification { get { throw new NotImplementedException(); } }
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
       // Field: 
       public static readonly System.Reflection.Assembly PlatformAssembly;
       // Field: 
       public static readonly System.Reflection.Assembly MonoMacAssembly;
   }
}
