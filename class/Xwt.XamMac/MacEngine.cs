
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("84f1a4b4-77e9-3831-8add-552971fac2f6")]
   public class MacEngine : Xwt.Backends.ToolkitEngineBackend
   {
       public override void InitializeApplication() {}
       public override void InitializeBackends() {}
       public override void RunApplication() {}
       public override void ExitApplication() {}
       public override void InvokeAsync(Action action) {}
       public override object TimerInvoke(Func<bool> action, TimeSpan timeSpan) { throw new NotImplementedException(); }
       public override void CancelTimerInvoke(object id) {}
       public override object GetNativeWidget(Xwt.Widget w) { throw new NotImplementedException(); }
       public override object GetNativeImage(Xwt.Drawing.Image image) { throw new NotImplementedException(); }
       public override bool HasNativeParent(Xwt.Widget w) { throw new NotImplementedException(); }
       public ViewBackend GetNativeBackend(Xwt.Widget w) { throw new NotImplementedException(); }
       public override Xwt.Backends.IWindowFrameBackend GetBackendForWindow(object nativeWindow) { throw new NotImplementedException(); }
       public override object GetNativeWindow(Xwt.Backends.IWindowFrameBackend backend) { throw new NotImplementedException(); }
       public override object GetBackendForContext(object nativeWidget, object nativeContext) { throw new NotImplementedException(); }
       public override void DispatchPendingEvents() {}
       public override object RenderWidget(Xwt.Widget w) { throw new NotImplementedException(); }
       public Xwt.Rectangle GetScreenBounds(object nativeWidget) { throw new NotImplementedException(); }
       public static override GetToolkitBackend() { throw new NotImplementedException(); }
       public virtual override void Dispose() {}
       public virtual override object GetNativeWindow(Xwt.WindowFrame window) { throw new NotImplementedException(); }
       public virtual override object GetNativeParentWindow(Xwt.Widget w) { throw new NotImplementedException(); }
       public virtual override object GetBackendForImage(object nativeImage) { throw new NotImplementedException(); }
       protected virtual override Type GetBackendImplementationType(Type backendType) { throw new NotImplementedException(); }
       public override void RegisterBackend() {}
       public override CreateFrontend(object backend) { throw new NotImplementedException(); }
       public virtual override void InvokeBeforeMainLoop(Action action) {}
       public virtual override void RenderImage(object nativeWidget, object nativeContext, Xwt.Backends.ImageDescription img, double x, double y) {}
      //ctor: 
      public MacEngine () {}
      public static AppDelegate App { get { throw new NotImplementedException(); } }
      public Xwt.Backends.ApplicationContext ApplicationContext { get { throw new NotImplementedException(); } }
      public bool IsGuest { get { throw new NotImplementedException(); } }
      public virtual bool HandlesSizeNegotiation { get { throw new NotImplementedException(); } }
      public virtual Xwt.ToolkitFeatures SupportedFeatures { get { throw new NotImplementedException(); } }
   }
}
