using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 startLocation                            ExposedReference`1<Transform> IL2CPP_TYPE_GENERICINST
    // 028 endLocation                              ExposedReference`1<Transform> IL2CPP_TYPE_GENERICINST
    // 038 ShouldTweenPosition                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 039 ShouldTweenRotation                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 Curve                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class TweenClip
    {
        public bool                                     ShouldTweenPosition                     { get; set; }
        public bool                                     ShouldTweenRotation                     { get; set; }
        public AnimationCurve?                          Curve                                   { get; set; }

        public static TweenClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenClip();

            value.ShouldTweenPosition                       = GetBool(new IntPtr(p + 0x038)); // 0270D4E16C40 0x38 ShouldTweenPosition         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShouldTweenRotation                       = GetBool(new IntPtr(p + 0x039)); // 0270D4E16C60 0x39 ShouldTweenRotation         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Curve                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4E16C80 0x40 Curve                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
