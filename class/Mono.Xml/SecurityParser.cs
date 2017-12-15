
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Xml
{  

   [Guid("df5d7bef-a80d-3289-adde-605e4b1631f9")]
   public class SecurityParser : MiniParser IHandler, IReader
   {
       public void LoadXml(string xml) {}
       public System.Security.SecurityElement ToXml() { throw new NotImplementedException(); }
       public virtual int Read() { throw new NotImplementedException(); }
       public virtual void OnStartParsing(Mono.Xml.MiniParser parser) {}
       public virtual void OnStartElement(string name, IAttrList attrs) {}
       public virtual void OnEndElement(string name) {}
       public virtual void OnChars(string ch) {}
       public virtual void OnEndParsing(Mono.Xml.MiniParser parser) {}
       public override void Reset() {}
       protected static override bool StrEquals(string str, System.Text.StringBuilder sb, int sbStart, int len) { throw new NotImplementedException(); }
       protected override void FatalErr(string descr) {}
       protected static override int Xlat(int charCode, int state) { throw new NotImplementedException(); }
       public override void Parse(Mono.Xml.IReader reader, IHandler handler) {}
      //ctor: 
      public SecurityParser () {}
       // Field: 
       protected int line;
       // Field: 
       protected int col;
       // Field: 
       protected int[] twoCharBuff;
       // Field: 
       protected bool splitCData;
       // Field: 
       protected static string[] errors;
   }
}
