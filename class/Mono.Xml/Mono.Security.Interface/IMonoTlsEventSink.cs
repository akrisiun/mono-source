
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("3641f191-dcf4-3b62-8d4c-1dcb3fceee70")]
   public interface IMonoTlsEventSink
   {
       void Error(Exception exception);
       void ReceivedCloseNotify();
   }
}
