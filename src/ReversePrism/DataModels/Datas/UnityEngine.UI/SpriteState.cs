using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_HighlightedSprite                      ModelClassType Sprite Sprite Sprite Pointer
    // 018 M_PressedSprite                          ModelClassType Sprite Sprite Sprite Pointer
    // 020 M_SelectedSprite                         ModelClassType Sprite Sprite Sprite Pointer
    // 028 M_DisabledSprite                         ModelClassType Sprite Sprite Sprite Pointer
    public partial class SpriteState : DataModel
    {
        public Sprite?                                  M_HighlightedSprite                     { get; set; }
        public Sprite?                                  M_PressedSprite                         { get; set; }
        public Sprite?                                  M_SelectedSprite                        { get; set; }
        public Sprite?                                  M_DisabledSprite                        { get; set; }

        public static SpriteState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteState() { Pointer= p0 };

            value.M_HighlightedSprite                       = GetObject<Sprite>(new IntPtr(p + 0x010), ReversePrism.DataModels.Sprite.FromPointer); // 0x10 M_HighlightedSprite         ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_PressedSprite                           = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0x18 M_PressedSprite             ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_SelectedSprite                          = GetObject<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 0x20 M_SelectedSprite            ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_DisabledSprite                          = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0x28 M_DisabledSprite            ( ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
