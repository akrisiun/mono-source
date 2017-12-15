
// Source:  /Src2/cslib/xam/Mono.Security.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Mono.Security.Protocol.Tls
{  

   [Guid("42163b2f-7837-3e22-ab81-8fb0d6ef82f8")]
   public sealed delegate CertificateSelectionCallback : System.MulticastDelegate
   {
       public virtual System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates) { throw new NotImplementedException(); }
       public virtual IAsyncResult BeginInvoke(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates, AsyncCallback callback, object object) { throw new NotImplementedException(); }
       public virtual System.Security.Cryptography.X509Certificates.X509Certificate EndInvoke(IAsyncResult result) { throw new NotImplementedException(); }
       public virtual override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
      // protected virtual override delegate CombineImpl(delegate follow) { throw new NotImplementedException(); }
      // protected virtual override delegate RemoveImpl(delegate value) { throw new NotImplementedException(); }
      // public virtual override delegate[] GetInvocationList() { throw new NotImplementedException(); }
       protected virtual override System.Reflection.MethodInfo GetMethodImpl() { throw new NotImplementedException(); }
       public override object DynamicInvoke(object[] args) { throw new NotImplementedException(); }
       protected virtual override object DynamicInvokeImpl(object[] args) { throw new NotImplementedException(); }
      // public static override delegate Combine(delegate a, delegate b) { throw new NotImplementedException(); }
      // public static override delegate Combine(delegate[] delegates) { throw new NotImplementedException(); }
      // public static override delegate Remove(delegate source, delegate value) { throw new NotImplementedException(); }
      // public static override delegate RemoveAll(delegate source, delegate value) { throw new NotImplementedException(); }
       public virtual override object Clone() { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object target, string method) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, Type target, string method) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw new NotImplementedException(); }
      // public static override delegate CreateDelegate(Type type, System.Reflection.MethodInfo method) { throw new NotImplementedException(); }
      //ctor: 
      public CertificateSelectionCallback (object object, IntPtr method) {}
      public System.Reflection.MethodInfo Method { get { throw new NotImplementedException(); } }
      public object Target { get { throw new NotImplementedException(); } }
   }
}
