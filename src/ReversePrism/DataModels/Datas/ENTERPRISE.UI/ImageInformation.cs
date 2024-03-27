using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001866CD270 ModelClassType Image Image Image Pointer
    // 018 Sprite                                   00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 020 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class ImageInformation
    {
        public Image?                                   Target                                  { get; set; }
        public Sprite?                                  Sprite                                  { get; set; }
        public Color                                    Color                                   { get; set; }

        public static ImageInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImageInformation();

            value.Target                                    = GetObject<Image>(new IntPtr(p + 0x010), ReversePrism.DataModels.Image.FromPointer); // 0270D0C9EAB0 0x10 Target                      ( 0001866CD270 ModelClassType Image Image Image Pointer )
            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0270D0C9EAD0 0x18 Sprite                      ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270D0C9EAF0 0x20 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
