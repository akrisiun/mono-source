
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("567da6b2-614b-387d-a1b7-220cd23f94d3")]
   public enum AlertDescription 
   {
       // Field: 
       CloseNotify = 0,
       // Field: 
       UnexpectedMessage = 10,
       // Field: 
       BadRecordMAC = 20,
       // Field: 
       DecryptionFailed_RESERVED = 21,
       // Field: 
       RecordOverflow = 22,
       // Field: 
       DecompressionFailure = 30,
       // Field: 
       HandshakeFailure = 40,
       // Field: 
       NoCertificate_RESERVED = 41,
       // Field: 
       BadCertificate = 42,
       // Field: 
       UnsupportedCertificate = 43,
       // Field: 
       CertificateRevoked = 44,
       // Field: 
       CertificateExpired = 45,
       // Field: 
       CertificateUnknown = 46,
       // Field: 
       IlegalParameter = 47,
       // Field: 
       UnknownCA = 48,
       // Field: 
       AccessDenied = 49,
       // Field: 
       DecodeError = 50,
       // Field: 
       DecryptError = 51,
       // Field: 
       ExportRestriction = 60,
       // Field: 
       ProtocolVersion = 70,
       // Field: 
       InsuficientSecurity = 71,
       // Field: 
       InternalError = 80,
       // Field: 
       UserCancelled = 90,
       // Field: 
       NoRenegotiation = 100,
       // Field: 
       UnsupportedExtension = 110,
   }
}
