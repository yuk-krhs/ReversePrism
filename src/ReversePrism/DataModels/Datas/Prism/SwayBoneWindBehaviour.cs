using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WindCurveX                               ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 018 WindCurveY                               ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 WindCurveZ                               ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class SwayBoneWindBehaviour : DataModel
    {
        public AnimationCurve?                          WindCurveX                              { get; set; }
        public AnimationCurve?                          WindCurveY                              { get; set; }
        public AnimationCurve?                          WindCurveZ                              { get; set; }

        public static SwayBoneWindBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneWindBehaviour() { Pointer= p0 };

            value.WindCurveX                                = GetObject<AnimationCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x10 WindCurveX                  ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.WindCurveY                                = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x18 WindCurveY                  ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.WindCurveZ                                = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x20 WindCurveZ                  ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
