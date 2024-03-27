using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sprite                                   00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    // 018 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class ImageStateInfo
    {
        public Sprite?                                  Sprite                                  { get; set; }
        public Color                                    Color                                   { get; set; }

        public static ImageStateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImageStateInfo();

            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x010), ReversePrism.DataModels.Sprite.FromPointer); // 0270DB0474C0 0x10 Sprite                      ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x018)); // 0270DB0474E0 0x18 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
