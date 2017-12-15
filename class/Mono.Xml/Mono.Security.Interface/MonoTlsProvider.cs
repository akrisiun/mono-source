
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("5a0b5865-fa45-3515-84de-c60f120e37f0")]
   public abstract class MonoTlsProvider
   {
       public abstract IMonoSslStream CreateSslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { throw new NotImplementedException(); }
      public abstract Guid ID { get { throw new NotImplementedException(); } }
      public abstract string Name { get { throw new NotImplementedException(); } }
      public abstract bool SupportsSslStream { get { throw new NotImplementedException(); } }
      public abstract bool SupportsConnectionInfo { get { throw new NotImplementedException(); } }
      public abstract bool SupportsMonoExtensions { get { throw new NotImplementedException(); } }
      public abstract System.Security.Authentication.SslProtocols SupportedProtocols { get { throw new NotImplementedException(); } }
   }
}
