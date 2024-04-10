using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Texture                                  000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 018 Sprite                                   00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 020 VectorImage                              0001866B03B0 ModelClassType VectorImage VectorImage VectorImage Pointer
    // 028 RenderTexture                            000186656460 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class ImageSource : DataModel
    {
        public Texture2D?                               Texture                                 { get; set; }
        public Sprite?                                  Sprite                                  { get; set; }
        public VectorImage?                             VectorImage                             { get; set; }
        public RenderTexture?                           RenderTexture                           { get; set; }

        public static ImageSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImageSource() { Pointer= p0 };

            value.Texture                                   = GetObject<Texture2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A6846808 0x10 Texture                     ( 000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0245A6846828 0x18 Sprite                      ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.VectorImage                               = GetObject<VectorImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.VectorImage.FromPointer); // 0245A6846848 0x20 VectorImage                 ( 0001866B03B0 ModelClassType VectorImage VectorImage VectorImage Pointer )
            value.RenderTexture                             = GetObject<RenderTexture>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A6846868 0x28 RenderTexture               ( 000186656460 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
