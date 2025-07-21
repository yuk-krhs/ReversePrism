using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FastSlowRenderer                         ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 FastSprite                               ModelClassType Sprite Sprite Sprite Pointer
    // 030 SlowSprite                               ModelClassType Sprite Sprite Sprite Pointer
    // 038 ReverseSprite                            ModelClassType Sprite Sprite Sprite Pointer
    public partial class JudgeFastSlowView : DataModel
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
            var value   = new JudgeFastSlowView() { Pointer= p0 };

            value.FastSlowRenderer                          = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0x20 FastSlowRenderer            ( ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.FastSprite                                = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0x28 FastSprite                  ( ModelClassType Sprite Sprite Sprite Pointer )
            value.SlowSprite                                = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0x30 SlowSprite                  ( ModelClassType Sprite Sprite Sprite Pointer )
            value.ReverseSprite                             = GetObject<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0x38 ReverseSprite               ( ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
