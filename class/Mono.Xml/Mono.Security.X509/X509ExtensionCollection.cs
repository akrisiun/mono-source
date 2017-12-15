
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("b087892f-5f5c-38c8-af94-78143e966926")]
   public sealed class X509ExtensionCollection : System.Collections.CollectionBase
   {
       public int Add(Mono.Security.X509.X509Extension extension) { throw new NotImplementedException(); }
       public void AddRange(Mono.Security.X509.X509Extension[] extension) {}
       public void AddRange(Mono.Security.X509.X509ExtensionCollection collection) {}
       public bool Contains(Mono.Security.X509.X509Extension extension) { throw new NotImplementedException(); }
       public bool Contains(string oid) { throw new NotImplementedException(); }
       public void CopyTo(Mono.Security.X509.X509Extension[] extensions, int index) {}
       public int IndexOf(Mono.Security.X509.X509Extension extension) { throw new NotImplementedException(); }
       public int IndexOf(string oid) { throw new NotImplementedException(); }
       public void Insert(int index, X509Extension extension) {}
       public void Remove(Mono.Security.X509.X509Extension extension) {}
       public void Remove(string oid) {}
       public byte[] GetBytes() { throw new NotImplementedException(); }
       public virtual override void Clear() {}
       public virtual override void RemoveAt(int index) {}
       public virtual override System.Collections.IEnumerator GetEnumerator() { throw new NotImplementedException(); }
       protected virtual override void OnSet(int index, object oldValue, object newValue) {}
       protected virtual override void OnInsert(int index, object value) {}
       protected virtual override void OnClear() {}
       protected virtual override void OnRemove(int index, object value) {}
       protected virtual override void OnValidate(object value) {}
       protected virtual override void OnSetComplete(int index, object oldValue, object newValue) {}
       protected virtual override void OnInsertComplete(int index, object value) {}
       protected virtual override void OnClearComplete() {}
       protected virtual override void OnRemoveComplete(int index, object value) {}
      //ctor: 
      public X509ExtensionCollection () {}
      //ctor: 
      public X509ExtensionCollection (Mono.Security.ASN1 asn1) {}
      public X509Extension this [int index] { get { throw new NotImplementedException(); } }
      public X509Extension this [string oid] { get { throw new NotImplementedException(); } }
      protected System.Collections.ArrayList InnerList { }
      protected System.Collections.IList List { }
      public int Capacity { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
   }
}
