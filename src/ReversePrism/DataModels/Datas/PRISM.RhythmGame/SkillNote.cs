using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpriteRenderer                           000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 EffectOuterSprite                        000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 030 OuterSpriteMarginUnit                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 EffectInnerSprite                        000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 040 InnerSpriteMarginUnit                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class SkillNote
    {
        public SpriteRenderer?                          SpriteRenderer                          { get; set; }
        public SpriteRenderer?                          EffectOuterSprite                       { get; set; }
        public Vector2                                  OuterSpriteMarginUnit                   { get; set; }
        public SpriteRenderer?                          EffectInnerSprite                       { get; set; }
        public Vector2                                  InnerSpriteMarginUnit                   { get; set; }

        public static SkillNote? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillNote();

            value.SpriteRenderer                            = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D4FB3438 0x20 SpriteRenderer              ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.EffectOuterSprite                         = GetObject<SpriteRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D4FB3458 0x28 EffectOuterSprite           ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.OuterSpriteMarginUnit                     = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0270D4FB3478 0x30 OuterSpriteMarginUnit       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.EffectInnerSprite                         = GetObject<SpriteRenderer>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D4FB3498 0x38 EffectInnerSprite           ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.InnerSpriteMarginUnit                     = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0270D4FB34B8 0x40 InnerSpriteMarginUnit       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
