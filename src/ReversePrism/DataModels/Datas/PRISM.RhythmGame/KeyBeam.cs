using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpriteRenderer                           000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 FadeOutSeconds                           0001866656B0 ModelPrimitiveType float float float Single
    // 030 tweener                                  TweenerCore`3<Color, Color, ColorOptions> IL2CPP_TYPE_GENERICINST
    public partial class KeyBeam : DataModel
    {
        public SpriteRenderer?                          SpriteRenderer                          { get; set; }
        public float                                    FadeOutSeconds                          { get; set; }

        public static KeyBeam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyBeam() { Pointer= p0 };

            value.SpriteRenderer                            = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 024665029BD0 0x20 SpriteRenderer              ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.FadeOutSeconds                            = GetSingle(new IntPtr(p + 0x028)); // 024665029BF0 0x28 FadeOutSeconds              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
