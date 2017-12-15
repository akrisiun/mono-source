
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("f0748d4b-5c81-3d9d-9b12-3d7542ec443c")]
   public class ChallengeResponse : System.IDisposable
   {
       protected override void Finalize() {}
       public virtual void Dispose() {}
      //ctor: 
      public ChallengeResponse () {}
      //ctor: 
      public ChallengeResponse (string password, byte[] challenge) {}
      public string Password { get; set; }
      public Byte[] Challenge { get; set; }
      public Byte[] LM { get { throw new NotImplementedException(); } }
      public Byte[] NT { get { throw new NotImplementedException(); } }
   }
}
