
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Ntlm
{  

   [Guid("538207ff-b6d6-349a-baaf-720ab5e64e05")]
   public enum NtlmFlags 
   {
       // Field: 
       NegotiateUnicode = 1,
       // Field: 
       NegotiateOem = 2,
       // Field: 
       RequestTarget = 4,
       // Field: 
       NegotiateNtlm = 512,
       // Field: 
       NegotiateDomainSupplied = 4096,
       // Field: 
       NegotiateWorkstationSupplied = 8192,
       // Field: 
       NegotiateAlwaysSign = 32768,
       // Field: 
       NegotiateNtlm2Key = 524288,
       // Field: 
       Negotiate128 = 536870912,
       // Field: 
       Negotiate56 = -2147483648,
   }
}
