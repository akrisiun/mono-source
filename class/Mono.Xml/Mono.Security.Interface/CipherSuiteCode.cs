
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Interface
{  

   [Guid("40713fc5-a521-376e-88f8-6125dd45e32e")]
   public enum CipherSuiteCode 
   {
       // Field: 
       TLS_NULL_WITH_NULL_NULL = 0,
       // Field: 
       TLS_RSA_WITH_NULL_MD5 = 1,
       // Field: 
       TLS_RSA_WITH_NULL_SHA = 2,
       // Field: 
       TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3,
       // Field: 
       TLS_RSA_WITH_RC4_128_MD5 = 4,
       // Field: 
       TLS_RSA_WITH_RC4_128_SHA = 5,
       // Field: 
       TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6,
       // Field: 
       TLS_RSA_WITH_IDEA_CBC_SHA = 7,
       // Field: 
       TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8,
       // Field: 
       TLS_RSA_WITH_DES_CBC_SHA = 9,
       // Field: 
       TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10,
       // Field: 
       TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11,
       // Field: 
       TLS_DH_DSS_WITH_DES_CBC_SHA = 12,
       // Field: 
       TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13,
       // Field: 
       TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14,
       // Field: 
       TLS_DH_RSA_WITH_DES_CBC_SHA = 15,
       // Field: 
       TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16,
       // Field: 
       TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17,
       // Field: 
       TLS_DHE_DSS_WITH_DES_CBC_SHA = 18,
       // Field: 
       TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19,
       // Field: 
       TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20,
       // Field: 
       TLS_DHE_RSA_WITH_DES_CBC_SHA = 21,
       // Field: 
       TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22,
       // Field: 
       TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
       // Field: 
       TLS_DH_anon_WITH_RC4_128_MD5 = 24,
       // Field: 
       TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
       // Field: 
       TLS_DH_anon_WITH_DES_CBC_SHA = 26,
       // Field: 
       TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
       // Field: 
       TLS_RSA_WITH_AES_128_CBC_SHA = 47,
       // Field: 
       TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48,
       // Field: 
       TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49,
       // Field: 
       TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50,
       // Field: 
       TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51,
       // Field: 
       TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
       // Field: 
       TLS_RSA_WITH_AES_256_CBC_SHA = 53,
       // Field: 
       TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54,
       // Field: 
       TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55,
       // Field: 
       TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56,
       // Field: 
       TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57,
       // Field: 
       TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
       // Field: 
       TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
       // Field: 
       TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66,
       // Field: 
       TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67,
       // Field: 
       TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68,
       // Field: 
       TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69,
       // Field: 
       TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70,
       // Field: 
       TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
       // Field: 
       TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133,
       // Field: 
       TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134,
       // Field: 
       TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135,
       // Field: 
       TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136,
       // Field: 
       TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137,
       // Field: 
       TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
       // Field: 
       TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187,
       // Field: 
       TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188,
       // Field: 
       TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189,
       // Field: 
       TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190,
       // Field: 
       TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191,
       // Field: 
       TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192,
       // Field: 
       TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193,
       // Field: 
       TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194,
       // Field: 
       TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195,
       // Field: 
       TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196,
       // Field: 
       TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197,
       // Field: 
       TLS_RSA_WITH_SEED_CBC_SHA = 150,
       // Field: 
       TLS_DH_DSS_WITH_SEED_CBC_SHA = 151,
       // Field: 
       TLS_DH_RSA_WITH_SEED_CBC_SHA = 152,
       // Field: 
       TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153,
       // Field: 
       TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154,
       // Field: 
       TLS_DH_anon_WITH_SEED_CBC_SHA = 155,
       // Field: 
       TLS_PSK_WITH_RC4_128_SHA = 138,
       // Field: 
       TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139,
       // Field: 
       TLS_PSK_WITH_AES_128_CBC_SHA = 140,
       // Field: 
       TLS_PSK_WITH_AES_256_CBC_SHA = 141,
       // Field: 
       TLS_DHE_PSK_WITH_RC4_128_SHA = 142,
       // Field: 
       TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143,
       // Field: 
       TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144,
       // Field: 
       TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145,
       // Field: 
       TLS_RSA_PSK_WITH_RC4_128_SHA = 146,
       // Field: 
       TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147,
       // Field: 
       TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148,
       // Field: 
       TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149,
       // Field: 
       TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
       // Field: 
       TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154,
       // Field: 
       TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155,
       // Field: 
       TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156,
       // Field: 
       TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162,
       // Field: 
       TLS_ECDH_RSA_WITH_NULL_SHA = 49163,
       // Field: 
       TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164,
       // Field: 
       TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165,
       // Field: 
       TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166,
       // Field: 
       TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167,
       // Field: 
       TLS_ECDHE_RSA_WITH_NULL_SHA = 49168,
       // Field: 
       TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169,
       // Field: 
       TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170,
       // Field: 
       TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171,
       // Field: 
       TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172,
       // Field: 
       TLS_ECDH_anon_WITH_NULL_SHA = 49173,
       // Field: 
       TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
       // Field: 
       TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
       // Field: 
       TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
       // Field: 
       TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
       // Field: 
       TLS_PSK_WITH_NULL_SHA = 44,
       // Field: 
       TLS_DHE_PSK_WITH_NULL_SHA = 45,
       // Field: 
       TLS_RSA_PSK_WITH_NULL_SHA = 46,
       // Field: 
       TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
       // Field: 
       TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179,
       // Field: 
       TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180,
       // Field: 
       TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181,
       // Field: 
       TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182,
       // Field: 
       TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183,
       // Field: 
       TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184,
       // Field: 
       TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185,
       // Field: 
       TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186,
       // Field: 
       TLS_RSA_WITH_NULL_SHA256 = 59,
       // Field: 
       TLS_RSA_WITH_AES_128_CBC_SHA256 = 60,
       // Field: 
       TLS_RSA_WITH_AES_256_CBC_SHA256 = 61,
       // Field: 
       TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62,
       // Field: 
       TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63,
       // Field: 
       TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64,
       // Field: 
       TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
       // Field: 
       TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104,
       // Field: 
       TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105,
       // Field: 
       TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106,
       // Field: 
       TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107,
       // Field: 
       TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
       // Field: 
       TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
       // Field: 
       TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
       // Field: 
       TLS_RSA_WITH_AES_256_GCM_SHA384 = 157,
       // Field: 
       TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158,
       // Field: 
       TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159,
       // Field: 
       TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160,
       // Field: 
       TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161,
       // Field: 
       TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162,
       // Field: 
       TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163,
       // Field: 
       TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164,
       // Field: 
       TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165,
       // Field: 
       TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
       // Field: 
       TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188,
       // Field: 
       TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189,
       // Field: 
       TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190,
       // Field: 
       TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191,
       // Field: 
       TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192,
       // Field: 
       TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193,
       // Field: 
       TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196,
       // Field: 
       TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197,
       // Field: 
       TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198,
       // Field: 
       TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199,
       // Field: 
       TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200,
       // Field: 
       TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201,
       // Field: 
       TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202,
       // Field: 
       TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
       // Field: 
       TLS_PSK_WITH_AES_256_GCM_SHA384 = 169,
       // Field: 
       TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170,
       // Field: 
       TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171,
       // Field: 
       TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172,
       // Field: 
       TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173,
       // Field: 
       TLS_PSK_WITH_AES_128_CBC_SHA256 = 174,
       // Field: 
       TLS_PSK_WITH_AES_256_CBC_SHA384 = 175,
       // Field: 
       TLS_PSK_WITH_NULL_SHA256 = 176,
       // Field: 
       TLS_PSK_WITH_NULL_SHA384 = 177,
       // Field: 
       TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178,
       // Field: 
       TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179,
       // Field: 
       TLS_DHE_PSK_WITH_NULL_SHA256 = 180,
       // Field: 
       TLS_DHE_PSK_WITH_NULL_SHA384 = 181,
       // Field: 
       TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182,
       // Field: 
       TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183,
       // Field: 
       TLS_RSA_PSK_WITH_NULL_SHA256 = 184,
       // Field: 
       TLS_RSA_PSK_WITH_NULL_SHA384 = 185,
       // Field: 
       TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
       // Field: 
       TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204,
       // Field: 
       TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205,
       // Field: 
       TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206,
       // Field: 
       TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207,
       // Field: 
       TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208,
       // Field: 
       TLS_ECDHE_PSK_WITH_NULL_SHA = 49209,
       // Field: 
       TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210,
       // Field: 
       TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211,
       // Field: 
       TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267,
       // Field: 
       TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268,
       // Field: 
       TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269,
       // Field: 
       TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270,
       // Field: 
       TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271,
       // Field: 
       TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272,
       // Field: 
       TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273,
       // Field: 
       TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274,
       // Field: 
       TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275,
       // Field: 
       TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276,
       // Field: 
       TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277,
       // Field: 
       TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278,
       // Field: 
       TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279,
       // Field: 
       TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280,
       // Field: 
       TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281,
       // Field: 
       TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282,
       // Field: 
       TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283,
       // Field: 
       TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284,
       // Field: 
       TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287,
       // Field: 
       TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288,
       // Field: 
       TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289,
       // Field: 
       TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290,
       // Field: 
       TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291,
       // Field: 
       TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292,
       // Field: 
       TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293,
       // Field: 
       TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294,
       // Field: 
       TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295,
       // Field: 
       TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296,
       // Field: 
       TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297,
       // Field: 
       TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298,
       // Field: 
       TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299,
       // Field: 
       TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300,
       // Field: 
       TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301,
       // Field: 
       TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302,
       // Field: 
       TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303,
       // Field: 
       TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304,
       // Field: 
       TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305,
       // Field: 
       TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306,
       // Field: 
       TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307,
       // Field: 
       TLS_RSA_WITH_AES_128_CCM = 49308,
       // Field: 
       TLS_RSA_WITH_AES_256_CCM = 49309,
       // Field: 
       TLS_DHE_RSA_WITH_AES_128_CCM = 49310,
       // Field: 
       TLS_DHE_RSA_WITH_AES_256_CCM = 49311,
       // Field: 
       TLS_RSA_WITH_AES_128_CCM_8 = 49312,
       // Field: 
       TLS_RSA_WITH_AES_256_CCM_8 = 49313,
       // Field: 
       TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314,
       // Field: 
       TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315,
       // Field: 
       TLS_PSK_WITH_AES_128_CCM = 49316,
       // Field: 
       TLS_PSK_WITH_AES_256_CCM = 49317,
       // Field: 
       TLS_DHE_PSK_WITH_AES_128_CCM = 49318,
       // Field: 
       TLS_DHE_PSK_WITH_AES_256_CCM = 49319,
       // Field: 
       TLS_PSK_WITH_AES_128_CCM_8 = 49320,
       // Field: 
       TLS_PSK_WITH_AES_256_CCM_8 = 49321,
       // Field: 
       TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322,
       // Field: 
       TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323,
       // Field: 
       TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244,
       // Field: 
       TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245,
       // Field: 
       TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
       // Field: 
       TLS_RSA_WITH_SALSA20_SHA1 = 58385,
       // Field: 
       TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386,
       // Field: 
       TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388,
       // Field: 
       TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389,
       // Field: 
       TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390,
       // Field: 
       TLS_PSK_WITH_SALSA20_SHA1 = 58391,
       // Field: 
       TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392,
       // Field: 
       TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393,
       // Field: 
       TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394,
       // Field: 
       TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395,
       // Field: 
       TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396,
       // Field: 
       TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397,
       // Field: 
       TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398,
       // Field: 
       TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399,
       // Field: 
       TLS_FALLBACK_SCSV = 22016,
   }
}
