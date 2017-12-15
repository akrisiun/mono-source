
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("a221de61-d590-3055-93a0-e15530be0337")]
   public abstract class MessageBase
   {
       protected byte[] PrepareMessage(int messageSize) { throw new NotImplementedException(); }
       protected virtual void Decode(byte[] message) {}
       protected bool CheckHeader(byte[] message) { throw new NotImplementedException(); }
       public abstract byte[] GetBytes() { throw new NotImplementedException(); }
      //ctor: 
      protected MessageBase (int messageType) {}
      public NtlmFlags Flags { get; set; }
      public int Type { get { throw new NotImplementedException(); } }
   }
}
