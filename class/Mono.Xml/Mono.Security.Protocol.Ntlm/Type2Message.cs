
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("d7417b34-ed31-3a8e-a56f-df03050794df")]
   public class Type2Message : MessageBase
   {
       protected override void Finalize() {}
       protected override void Decode(byte[] message) {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
       protected override byte[] PrepareMessage(int messageSize) { throw new NotImplementedException(); }
       protected override bool CheckHeader(byte[] message) { throw new NotImplementedException(); }
      //ctor: 
      public Type2Message () {}
      //ctor: 
      public Type2Message (byte[] message) {}
      public Byte[] Nonce { get; set; }
      public string TargetName { get { throw new NotImplementedException(); } }
      public Byte[] TargetInfo { get { throw new NotImplementedException(); } }
      public NtlmFlags Flags { get; set; }
      public int Type { get { throw new NotImplementedException(); } }
   }
}
