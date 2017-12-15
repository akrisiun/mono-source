
// Source:  /Src2/cslib/xam/Xwt.XamMac.DLL  Build 
using System;
using System.Runtime.InteropServices;

namespace Xwt.Mac
{  

   [Guid("2f0c4868-0256-3592-89d8-b6b2ddba0efe")]
   public class ImageHandler : Xwt.Backends.ImageBackendHandler
   {
       public override object LoadFromStream(System.IO.Stream stream) { throw new NotImplementedException(); }
       public override object LoadFromFile(string file) { throw new NotImplementedException(); }
       public override object CreateMultiResolutionImage(System.Collections.Generic.IEnumerable<object> images) { throw new NotImplementedException(); }
       public override object CreateMultiSizeIcon(System.Collections.Generic.IEnumerable<object> images) { throw new NotImplementedException(); }
       public override object CreateCustomDrawn(Xwt.Backends.ImageDrawCallback drawCallback) { throw new NotImplementedException(); }
       public Xwt.Size GetSize(string file) { throw new NotImplementedException(); }
       public override Xwt.Drawing.Image GetStockIcon(string id) { throw new NotImplementedException(); }
       public override void SaveToStream(object backend, System.IO.Stream stream, Xwt.Drawing.ImageFileType fileType) {}
       public override bool IsBitmap(object handle) { throw new NotImplementedException(); }
       public override object ConvertToBitmap(Xwt.Backends.ImageDescription idesc, double scaleFactor, Xwt.Drawing.ImageFormat format) { throw new NotImplementedException(); }
       public override Xwt.Drawing.Color GetBitmapPixel(object handle, int x, int y) { throw new NotImplementedException(); }
       public override void SetBitmapPixel(object handle, int x, int y, Xwt.Drawing.Color color) {}
       public override bool HasMultipleSizes(object handle) { throw new NotImplementedException(); }
       public override Xwt.Size GetSize(object handle) { throw new NotImplementedException(); }
       public override object CopyBitmap(object handle) { throw new NotImplementedException(); }
       public override void CopyBitmapArea(object backend, int srcX, int srcY, int width, int height, object dest, int destX, int destY) {}
       public override object CropBitmap(object backend, int srcX, int srcY, int width, int height) { throw new NotImplementedException(); }
       public virtual override object CreateBackend() { throw new NotImplementedException(); }
       public virtual override object LoadFromResource(System.Reflection.Assembly asm, string name) { throw new NotImplementedException(); }
       public virtual override void Dispose(object backend) {}
      //ctor: 
      public ImageHandler () {}
      public String[] ResourceNames { get { throw new NotImplementedException(); } }
      public virtual bool DisposeHandleOnUiThread { get { throw new NotImplementedException(); } }
      protected Xwt.Backends.ApplicationContext ApplicationContext { }
   }
}
