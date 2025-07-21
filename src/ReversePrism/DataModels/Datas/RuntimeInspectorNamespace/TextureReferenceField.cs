using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0B0 ReferencePreview                         ModelClassType RawImage RawImage RawImage Pointer
    public partial class TextureReferenceField : DataModel
    {
        public RawImage?                                ReferencePreview                        { get; set; }

        public static TextureReferenceField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureReferenceField() { Pointer= p0 };

            value.ReferencePreview                          = GetObject<RawImage>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.RawImage.FromPointer); // 0xB0 ReferencePreview            ( ModelClassType RawImage RawImage RawImage Pointer )

            return value;
        }
    }
}
