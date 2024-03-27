using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartLocation                            0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 018 EndLocation                              0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 020 ShouldTweenPosition                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 021 ShouldTweenRotation                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 Curve                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class TweenBehaviour
    {
        public Transform?                               StartLocation                           { get; set; }
        public Transform?                               EndLocation                             { get; set; }
        public bool                                     ShouldTweenPosition                     { get; set; }
        public bool                                     ShouldTweenRotation                     { get; set; }
        public AnimationCurve?                          Curve                                   { get; set; }

        public static TweenBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenBehaviour();

            value.StartLocation                             = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 0270D4E16B00 0x10 StartLocation               ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.EndLocation                               = GetObject<Transform>(new IntPtr(p + 0x018), ReversePrism.DataModels.Transform.FromPointer); // 0270D4E16B20 0x18 EndLocation                 ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.ShouldTweenPosition                       = GetBool(new IntPtr(p + 0x020)); // 0270D4E16B40 0x20 ShouldTweenPosition         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShouldTweenRotation                       = GetBool(new IntPtr(p + 0x021)); // 0270D4E16B60 0x21 ShouldTweenRotation         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Curve                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4E16B80 0x28 Curve                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
