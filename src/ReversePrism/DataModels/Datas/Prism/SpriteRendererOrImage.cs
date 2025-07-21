using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpriteRenderer                           ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 Image                                    ModelClassType Image Image Image Pointer
    public partial class SpriteRendererOrImage : DataModel
    {
        public SpriteRenderer?                          SpriteRenderer                          { get; set; }
        public Image?                                   Image                                   { get; set; }

        public static SpriteRendererOrImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteRendererOrImage() { Pointer= p0 };

            value.SpriteRenderer                            = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0x20 SpriteRenderer              ( ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 Image                       ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
