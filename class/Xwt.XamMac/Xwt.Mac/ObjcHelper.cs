
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("33715eb1-665d-3229-9e1a-5b5b1c0bbf9e")]
   public static class ObjcHelper
   {
       public static ObjCRuntime.Class GetObjectClass(this IntPtr obj) { throw new NotImplementedException(); }
       public static ObjCRuntime.Class GetMetaClass(this string name) { throw new NotImplementedException(); }
       public static void InstanceMethodExchange(this ObjCRuntime.Class cls, IntPtr sel1, IntPtr sel2) {}
       public static void MethodExchange(this ObjCRuntime.Class cls, IntPtr sel1, IntPtr sel2) {}
      // public static IntPtr SetMethodImplementation(this ObjCRuntime.Class cls, IntPtr method, delegate impl) { throw new NotImplementedException(); }
       public static IntPtr GetMethod(this ObjCRuntime.Class cls, IntPtr sel) { throw new NotImplementedException(); }
      // public static bool AddMethod(this ObjCRuntime.Class cls, IntPtr sel, delegate method, string argTypes) { throw new NotImplementedException(); }
       public static IntPtr GetProtocol(this string name) { throw new NotImplementedException(); }
       public static bool ConformsToProtocol(this ObjCRuntime.Class cls, IntPtr protocol) { throw new NotImplementedException(); }
       public static bool AddProtocol(this ObjCRuntime.Class cls, IntPtr protocol) { throw new NotImplementedException(); }
   }
}
