
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("bfacc4cd-72df-3be1-84fe-97e73cccdeed")]
   public static class MonoTlsProviderFactory
   {
       public static MonoTlsProvider GetProvider() { throw new NotImplementedException(); }
       public static void Initialize() {}
       public static void Initialize(string provider) {}
       public static bool IsProviderSupported(string provider) { throw new NotImplementedException(); }
       public static MonoTlsProvider GetProvider(string provider) { throw new NotImplementedException(); }
       public static System.Net.HttpWebRequest CreateHttpsRequest(Uri requestUri, MonoTlsProvider provider, MonoTlsSettings settings) { throw new NotImplementedException(); }
       public static System.Net.HttpListener CreateHttpListener(System.Security.Cryptography.X509Certificates.X509Certificate certificate, MonoTlsProvider provider, MonoTlsSettings settings) { throw new NotImplementedException(); }
       public static IMonoSslStream GetMonoSslStream(System.Net.Security.SslStream stream) { throw new NotImplementedException(); }
       public static MonoTlsProvider GetDefaultProvider() { throw new NotImplementedException(); }
       public static void SetDefaultProvider(string name) {}
      public static bool IsInitialized { get { throw new NotImplementedException(); } }
   }
}
