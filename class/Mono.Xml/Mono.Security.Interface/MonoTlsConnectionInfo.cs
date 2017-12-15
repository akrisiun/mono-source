
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("19a372e8-f61f-3a3f-aa99-dad51ebdae1e")]
   public class MonoTlsConnectionInfo
   {
       public override string ToString() { throw new NotImplementedException(); }
      //ctor: 
      public MonoTlsConnectionInfo () {}
      public CipherSuiteCode CipherSuiteCode { get; set; }
      public TlsProtocols ProtocolVersion { get; set; }
      public CipherAlgorithmType CipherAlgorithmType { get; set; }
      public HashAlgorithmType HashAlgorithmType { get; set; }
      public ExchangeAlgorithmType ExchangeAlgorithmType { get; set; }
      public string PeerDomainName { get; set; }
   }
}
