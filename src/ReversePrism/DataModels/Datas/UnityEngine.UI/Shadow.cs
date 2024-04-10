using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_EffectColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 038 M_EffectDistance                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 M_UseGraphicAlpha                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 kMaxEffectDistance                       float IL2CPP_TYPE_R4
    public partial class Shadow : DataModel
    {
        public Color                                    M_EffectColor                           { get; set; }
        public Vector2                                  M_EffectDistance                        { get; set; }
        public bool                                     M_UseGraphicAlpha                       { get; set; }

        public static Shadow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Shadow() { Pointer= p0 };

            value.M_EffectColor                             = (Color)GetInt32(new IntPtr(p + 0x028)); // 0245A68A4C40 0x28 M_EffectColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_EffectDistance                          = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0245A68A4C60 0x38 M_EffectDistance            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_UseGraphicAlpha                         = GetBool(new IntPtr(p + 0x040)); // 0245A68A4C80 0x40 M_UseGraphicAlpha           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
