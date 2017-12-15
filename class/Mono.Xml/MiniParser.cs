
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Xml
{  

   [Guid("637ea9f5-d5bc-3dce-be68-4971bee93adb")]
   public class MiniParser
   {
       public void Reset() {}
       protected static bool StrEquals(string str, System.Text.StringBuilder sb, int sbStart, int len) { throw new NotImplementedException(); }
       protected void FatalErr(string descr) {}
       protected static int Xlat(int charCode, int state) { throw new NotImplementedException(); }
       public void Parse(Mono.Xml.IReader reader, IHandler handler) {}
      //ctor: 
      public MiniParser () {}
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
   public interface IReader.IReader
   public interface IAttrList.IAttrList
   public interface IMutableAttrList.IMutableAttrList
   public interface IHandler.IHandler
   public class HandlerAdapter.HandlerAdapter
   public class AttrListImpl.AttrListImpl
   public class XMLError.XMLError
   }
}
