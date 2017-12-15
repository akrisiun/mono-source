
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("f8beb6ef-4ea7-31b7-aad4-b7fff599e26b")]
   public class Type3Message : MessageBase
   {
       protected override void Finalize() {}
       protected override void Decode(byte[] message) {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
       protected override byte[] PrepareMessage(int messageSize) { throw new NotImplementedException(); }
       protected override bool CheckHeader(byte[] message) { throw new NotImplementedException(); }
      //ctor: 
      public Type3Message () {}
      //ctor: 
      public Type3Message (byte[] message) {}
      //ctor: 
      public Type3Message (Mono.Security.Protocol.Ntlm.Type2Message type2) {}
      public static NtlmAuthLevel DefaultAuthLevel { get; set; }
      public NtlmAuthLevel Level { get; set; }
      public Byte[] Challenge { get; set; }
      public string Domain { get; set; }
      public string Host { get; set; }
      public string Password { get; set; }
      public string Username { get; set; }
      public Byte[] LM { get { throw new NotImplementedException(); } }
      public Byte[] NT { get; set; }
      public NtlmFlags Flags { get; set; }
      public int Type { get { throw new NotImplementedException(); } }
   }
}
