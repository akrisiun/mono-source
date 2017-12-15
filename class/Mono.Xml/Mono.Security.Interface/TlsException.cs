
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("8e3a0822-cba2-3831-912b-2187184ff6ec")]
   public sealed class TlsException : System.Exception
   {
       public virtual override Exception GetBaseException() { throw new NotImplementedException(); }
       public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
       public virtual override Type GetType() { throw new NotImplementedException(); }
      //ctor: 
      public TlsException (Mono.Security.Interface.Alert alert) {}
      //ctor: 
      public TlsException (Mono.Security.Interface.Alert alert, string message) {}
      //ctor: 
      public TlsException (Mono.Security.Interface.AlertLevel level, AlertDescription description) {}
      //ctor: 
      public TlsException (Mono.Security.Interface.AlertDescription description) {}
      //ctor: 
      public TlsException (Mono.Security.Interface.AlertDescription description, string message) {}
      //ctor: 
      public TlsException (Mono.Security.Interface.AlertDescription description, string format, object[] args) {}
      public Alert Alert { get { throw new NotImplementedException(); } }
      public virtual string Message { get { throw new NotImplementedException(); } }
      public virtual System.Collections.IDictionary Data { get { throw new NotImplementedException(); } }
      public virtual Exception InnerException { get { throw new NotImplementedException(); } }
      public virtual System.Reflection.MethodBase TargetSite { get { throw new NotImplementedException(); } }
      public virtual string StackTrace { get { throw new NotImplementedException(); } }
      public virtual string HelpLink { get; set; }
      public virtual string Source { get; set; }
      public int HResult { get { throw new NotImplementedException(); } }
      // Event: 
   // protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState;
   }
}
