using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Texture                                ModelClassType Texture2D Texture2D Texture2D Pointer
    // 018 M_Sprite                                 ModelClassType Sprite Sprite Sprite Pointer
    // 020 M_RenderTexture                          ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 028 M_VectorImage                            ModelClassType VectorImage VectorImage VectorImage Pointer
    public partial class Background : DataModel
    {
        public Texture2D?                               M_Texture                               { get; set; }
        public Sprite?                                  M_Sprite                                { get; set; }
        public RenderTexture?                           M_RenderTexture                         { get; set; }
        public VectorImage?                             M_VectorImage                           { get; set; }

        public static Background? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Background() { Pointer= p0 };

            value.M_Texture                                 = GetObject<Texture2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture2D.FromPointer); // 0x10 M_Texture                   ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_Sprite                                  = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0x18 M_Sprite                    ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_RenderTexture                           = GetObject<RenderTexture>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x20 M_RenderTexture             ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_VectorImage                             = GetObject<VectorImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.VectorImage.FromPointer); // 0x28 M_VectorImage               ( ModelClassType VectorImage VectorImage VectorImage Pointer )

            return value;
        }
    }
}
