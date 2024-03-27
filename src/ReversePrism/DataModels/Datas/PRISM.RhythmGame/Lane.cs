using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LaneEffectSpriteRenderer                 00018676CF60 ModelClassType KeyBeam KeyBeam KeyBeam Pointer
    // 028 LaneSprites                              000185CA4A88 ModelClassListType SpriteRenderer[] SpriteRenderer[] List<SpriteRenderer> Pointer
    // 030 LaneEffectSpriteRenderers                000185CEF6A8 ModelClassListType List`1<KeyBeam> List`1<KeyBeam> List<KeyBeam> Pointer
    // 038 LaneBaseColors                           000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    public partial class Lane
    {
        public KeyBeam?                                 LaneEffectSpriteRenderer                { get; set; }
        public List<SpriteRenderer>?                    LaneSprites                             { get; set; }
        public List<KeyBeam>?                           LaneEffectSpriteRenderers               { get; set; }
        public List<Color>?                             LaneBaseColors                          { get; set; }

        public static Lane? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Lane();

            value.LaneEffectSpriteRenderer                  = GetObject<KeyBeam>(new IntPtr(p + 0x020), ReversePrism.DataModels.KeyBeam.FromPointer); // 0270D4EC2240 0x20 LaneEffectSpriteRenderer    ( 00018676CF60 ModelClassType KeyBeam KeyBeam KeyBeam Pointer )
            value.LaneSprites                               = GetObjectList<SpriteRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D4EC2260 0x28 LaneSprites                 ( 000185CA4A88 ModelClassListType SpriteRenderer[] SpriteRenderer[] List<SpriteRenderer> Pointer )
            value.LaneEffectSpriteRenderers                 = GetObjectList<KeyBeam>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeyBeam.FromPointer); // 0270D4EC2280 0x30 LaneEffectSpriteRenderers   ( 000185CEF6A8 ModelClassListType List`1<KeyBeam> List`1<KeyBeam> List<KeyBeam> Pointer )
            value.LaneBaseColors                            = GetEnumList<Color>(new IntPtr(p + 0x038)); // 0270D4EC22A0 0x38 LaneBaseColors              ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )

            return value;
        }
    }
}
