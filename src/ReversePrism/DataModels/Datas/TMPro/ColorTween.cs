using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Target                                 0001867767D0 ModelClassType ColorTweenCallback ColorTweenCallback ColorTweenCallback Pointer
    // 018 M_StartColor                             0001865AA8E0 ModelEnumType Color Color Color Int32
    // 028 M_TargetColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 038 M_TweenMode                              000186776D10 ModelEnumType ColorTweenMode ColorTweenMode ColorTweenMode Int32
    // 03C M_Duration                               0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_IgnoreTimeScale                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ColorTween
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
            var value   = new ColorTween();

            value.M_Target                                  = GetObject<ColorTweenCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.ColorTweenCallback.FromPointer); // 0270DA6115C8 0x10 M_Target                    ( 0001867767D0 ModelClassType ColorTweenCallback ColorTweenCallback ColorTweenCallback Pointer )
            value.M_StartColor                              = (Color)GetInt32(new IntPtr(p + 0x018)); // 0270DA6115E8 0x18 M_StartColor                ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_TargetColor                             = (Color)GetInt32(new IntPtr(p + 0x028)); // 0270DA611608 0x28 M_TargetColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_TweenMode                               = (ColorTweenMode)GetInt32(new IntPtr(p + 0x038)); // 0270DA611628 0x38 M_TweenMode                 ( 000186776D10 ModelEnumType ColorTweenMode ColorTweenMode ColorTweenMode Int32 )
            value.M_Duration                                = GetSingle(new IntPtr(p + 0x03C)); // 0270DA611648 0x3C M_Duration                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_IgnoreTimeScale                         = GetBool(new IntPtr(p + 0x040)); // 0270DA611668 0x40 M_IgnoreTimeScale           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
