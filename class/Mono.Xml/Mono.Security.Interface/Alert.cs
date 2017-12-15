
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("f8f332e4-0428-371b-ba29-28848af99054")]
   public class Alert
   {
       public override string ToString() { throw new NotImplementedException(); }
       public static string GetAlertMessage(Mono.Security.Interface.AlertDescription description) { throw new NotImplementedException(); }
      //ctor: 
      public Alert (Mono.Security.Interface.AlertDescription description) {}
      //ctor: 
      public Alert (Mono.Security.Interface.AlertLevel level, AlertDescription description) {}
      public AlertLevel Level { get { throw new NotImplementedException(); } }
      public AlertDescription Description { get { throw new NotImplementedException(); } }
      public string Message { get { throw new NotImplementedException(); } }
      public bool IsWarning { get { throw new NotImplementedException(); } }
      public bool IsCloseNotify { get { throw new NotImplementedException(); } }
   }
}
