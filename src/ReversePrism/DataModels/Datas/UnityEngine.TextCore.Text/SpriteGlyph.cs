using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Sprite                                   00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    public partial class SpriteGlyph : DataModel
    {
        public Sprite?                                  Sprite                                  { get; set; }

        public static SpriteGlyph? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteGlyph() { Pointer= p0 };

            value.Sprite                                    = GetObject<Sprite>(new IntPtr(p + 0x048), ReversePrism.DataModels.Sprite.FromPointer); // 0245A68AD710 0x48 Sprite                      ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
