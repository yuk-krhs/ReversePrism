using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartLocation                            ModelClassType Transform Transform Transform Pointer
    // 018 EndLocation                              ModelClassType Transform Transform Transform Pointer
    // 020 ShouldTweenPosition                      ModelPrimitiveType bool bool bool Bool
    // 021 ShouldTweenRotation                      ModelPrimitiveType bool bool bool Bool
    // 028 Curve                                    ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class TweenBehaviour : DataModel
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
            var value   = new TweenBehaviour() { Pointer= p0 };

            value.StartLocation                             = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 0x10 StartLocation               ( ModelClassType Transform Transform Transform Pointer )
            value.EndLocation                               = GetObject<Transform>(new IntPtr(p + 0x018), ReversePrism.DataModels.Transform.FromPointer); // 0x18 EndLocation                 ( ModelClassType Transform Transform Transform Pointer )
            value.ShouldTweenPosition                       = GetBool(new IntPtr(p + 0x020)); // 0x20 ShouldTweenPosition         ( ModelPrimitiveType bool bool bool Bool )
            value.ShouldTweenRotation                       = GetBool(new IntPtr(p + 0x021)); // 0x21 ShouldTweenRotation         ( ModelPrimitiveType bool bool bool Bool )
            value.Curve                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x28 Curve                       ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
