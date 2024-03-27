using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FastSlowRenderer                         000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 FastSprite                               00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 030 SlowSprite                               00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 038 ReverseSprite                            00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    public partial class JudgeFastSlowView
    {
        public SpriteRenderer?                          FastSlowRenderer                        { get; set; }
        public Sprite?                                  FastSprite                              { get; set; }
        public Sprite?                                  SlowSprite                              { get; set; }
        public Sprite?                                  ReverseSprite                           { get; set; }

        public static JudgeFastSlowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgeFastSlowView();

            value.FastSlowRenderer                          = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D5047500 0x20 FastSlowRenderer            ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.FastSprite                                = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5047520 0x28 FastSprite                  ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.SlowSprite                                = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5047540 0x30 SlowSprite                  ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.ReverseSprite                             = GetObject<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5047560 0x38 ReverseSprite               ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
