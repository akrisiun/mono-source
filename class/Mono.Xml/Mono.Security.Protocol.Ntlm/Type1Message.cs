
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("2bdbad4c-c117-388d-adf5-0c18672ccd0a")]
   public class Type1Message : MessageBase
   {
       protected override void Decode(byte[] message) {}
       public override byte[] GetBytes() { throw new NotImplementedException(); }
       protected override byte[] PrepareMessage(int messageSize) { throw new NotImplementedException(); }
       protected override bool CheckHeader(byte[] message) { throw new NotImplementedException(); }
      //ctor: 
      public Type1Message () {}
      //ctor: 
      public Type1Message (byte[] message) {}
      public string Domain { get; set; }
      public string Host { get; set; }
      public NtlmFlags Flags { get; set; }
      public int Type { get { throw new NotImplementedException(); } }
   }
}
