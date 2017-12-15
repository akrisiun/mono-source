
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.X509
{  

   [Guid("c4779b99-66f4-31f1-a0c1-7a4ecfd46084")]
   public class X509CertificateCollection : System.Collections.CollectionBase
   {
       public int Add(Mono.Security.X509.X509Certificate value) { throw new NotImplementedException(); }
       public void AddRange(Mono.Security.X509.X509Certificate[] value) {}
       public void AddRange(Mono.Security.X509.X509CertificateCollection value) {}
       public bool Contains(Mono.Security.X509.X509Certificate value) { throw new NotImplementedException(); }
       public void CopyTo(Mono.Security.X509.X509Certificate[] array, int index) {}
       public new X509CertificateEnumerator GetEnumerator() { throw new NotImplementedException(); }
       public override int GetHashCode() { throw new NotImplementedException(); }
       public int IndexOf(Mono.Security.X509.X509Certificate value) { throw new NotImplementedException(); }
       public void Insert(int index, X509Certificate value) {}
       public void Remove(Mono.Security.X509.X509Certificate value) {}
       public virtual override void Clear() {}
       public virtual override void RemoveAt(int index) {}
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
      public X509CertificateCollection () {}
      //ctor: 
      public X509CertificateCollection (Mono.Security.X509.X509Certificate[] value) {}
      //ctor: 
      public X509CertificateCollection (Mono.Security.X509.X509CertificateCollection value) {}
      public X509Certificate this [int index] { get; set; }
      protected System.Collections.ArrayList InnerList { }
      protected System.Collections.IList List { }
      public int Capacity { get; set; }
      public virtual int Count { get { throw new NotImplementedException(); } }
   public class X509CertificateEnumerator.X509CertificateEnumerator
   }
}
