using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LaneEffectSpriteRenderer                 ModelClassType KeyBeam KeyBeam KeyBeam Pointer
    // 028 LaneSprites                              ModelClassListType SpriteRenderer[] SpriteRenderer[] List<SpriteRenderer> Pointer
    // 030 LaneEffectSpriteRenderers                ModelClassListType List`1<KeyBeam> List`1<KeyBeam> List<KeyBeam> Pointer
    // 038 LaneBaseColors                           ModelEnumListType Color[] Color[] List<Color> Pointer
    public partial class Lane : DataModel
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
            var value   = new Lane() { Pointer= p0 };

            value.LaneEffectSpriteRenderer                  = GetObject<KeyBeam>(new IntPtr(p + 0x020), ReversePrism.DataModels.KeyBeam.FromPointer); // 0x20 LaneEffectSpriteRenderer    ( ModelClassType KeyBeam KeyBeam KeyBeam Pointer )
            value.LaneSprites                               = GetObjectList<SpriteRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0x28 LaneSprites                 ( ModelClassListType SpriteRenderer[] SpriteRenderer[] List<SpriteRenderer> Pointer )
            value.LaneEffectSpriteRenderers                 = GetObjectList<KeyBeam>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeyBeam.FromPointer); // 0x30 LaneEffectSpriteRenderers   ( ModelClassListType List`1<KeyBeam> List`1<KeyBeam> List<KeyBeam> Pointer )
            value.LaneBaseColors                            = GetEnumList<Color>(new IntPtr(p + 0x038)); // 0x38 LaneBaseColors              ( ModelEnumListType Color[] Color[] List<Color> Pointer )

            return value;
        }
    }
}
