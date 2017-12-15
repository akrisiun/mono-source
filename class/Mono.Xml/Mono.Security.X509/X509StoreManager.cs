
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("3dc8e37f-8a91-32b7-8e47-e1eef039b66f")]
   public sealed class X509StoreManager
   {
      public static X509Stores CurrentUser { get { throw new NotImplementedException(); } }
      public static X509Stores LocalMachine { get { throw new NotImplementedException(); } }
      public static X509Stores NewCurrentUser { get { throw new NotImplementedException(); } }
      public static X509Stores NewLocalMachine { get { throw new NotImplementedException(); } }
      public static X509CertificateCollection IntermediateCACertificates { get { throw new NotImplementedException(); } }
      public static System.Collections.ArrayList IntermediateCACrls { get { throw new NotImplementedException(); } }
      public static X509CertificateCollection TrustedRootCertificates { get { throw new NotImplementedException(); } }
      public static System.Collections.ArrayList TrustedRootCACrls { get { throw new NotImplementedException(); } }
      public static X509CertificateCollection UntrustedCertificates { get { throw new NotImplementedException(); } }
   }
}
