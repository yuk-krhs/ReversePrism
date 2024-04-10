using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Target                                 000186777470 ModelClassType ColorTweenCallback ColorTweenCallback ColorTweenCallback Pointer
    // 018 M_StartColor                             0001865AA8E0 ModelEnumType Color Color Color Int32
    // 028 M_TargetColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 038 M_TweenMode                              000186777960 ModelEnumType ColorTweenMode ColorTweenMode ColorTweenMode Int32
    // 03C M_Duration                               0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_IgnoreTimeScale                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ColorTween : DataModel
    {
        public ColorTweenCallback?                      M_Target                                { get; set; }
        public Color                                    M_StartColor                            { get; set; }
        public Color                                    M_TargetColor                           { get; set; }
        public ColorTweenMode                           M_TweenMode                             { get; set; }
        public float                                    M_Duration                              { get; set; }
        public bool                                     M_IgnoreTimeScale                       { get; set; }

        public static ColorTween? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorTween() { Pointer= p0 };

            value.M_Target                                  = GetObject<ColorTweenCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.ColorTweenCallback.FromPointer); // 0245A3F930F0 0x10 M_Target                    ( 000186777470 ModelClassType ColorTweenCallback ColorTweenCallback ColorTweenCallback Pointer )
            value.M_StartColor                              = (Color)GetInt32(new IntPtr(p + 0x018)); // 0245A3F93110 0x18 M_StartColor                ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_TargetColor                             = (Color)GetInt32(new IntPtr(p + 0x028)); // 0245A3F93130 0x28 M_TargetColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_TweenMode                               = (ColorTweenMode)GetInt32(new IntPtr(p + 0x038)); // 0245A3F93150 0x38 M_TweenMode                 ( 000186777960 ModelEnumType ColorTweenMode ColorTweenMode ColorTweenMode Int32 )
            value.M_Duration                                = GetSingle(new IntPtr(p + 0x03C)); // 0245A3F93170 0x3C M_Duration                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_IgnoreTimeScale                         = GetBool(new IntPtr(p + 0x040)); // 0245A3F93190 0x40 M_IgnoreTimeScale           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
