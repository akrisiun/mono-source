
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security
{  

   [Guid("146e1e3f-df68-37ce-b337-f10067a07920")]
   public class ASN1
   {
       public bool Equals(byte[] asn1) { throw new NotImplementedException(); }
       public bool CompareValue(byte[] value) { throw new NotImplementedException(); }
       public ASN1 Add(Mono.Security.ASN1 asn1) { throw new NotImplementedException(); }
       public virtual byte[] GetBytes() { throw new NotImplementedException(); }
       protected void Decode(byte[] asn1, int anPos, int anLength) {}
       protected void DecodeTLV(byte[] asn1, int pos, out byte tag, out int length, out byte[] content) {}
       public ASN1 Element(int index, byte anTag) { throw new NotImplementedException(); }
       public override string ToString() { throw new NotImplementedException(); }
       public void SaveToFile(string filename) {}
      //ctor: 
      public ASN1 () {}
      //ctor: 
      public ASN1 (byte tag) {}
      //ctor: 
      public ASN1 (byte tag, byte[] data) {}
      //ctor: 
      public ASN1 (byte[] data) {}
      public int Count { get { throw new NotImplementedException(); } }
      public byte Tag { get { throw new NotImplementedException(); } }
      public int Length { get { throw new NotImplementedException(); } }
      public Byte[] Value { get; set; }
      public ASN1 this [int index] { get { throw new NotImplementedException(); } }
   }
}
