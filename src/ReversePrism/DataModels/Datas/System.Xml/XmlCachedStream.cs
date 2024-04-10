using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Uri                                      0001866A4270 ModelClassType Uri Uri Uri Pointer
    public partial class XmlCachedStream : DataModel
    {
        public Uri?                                     Uri                                     { get; set; }

        public static XmlCachedStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlCachedStream() { Pointer= p0 };

            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x050), ReversePrism.DataModels.Uri.FromPointer); // 0246674FCCA8 0x50 Uri                         ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )

            return value;
        }
    }
}
