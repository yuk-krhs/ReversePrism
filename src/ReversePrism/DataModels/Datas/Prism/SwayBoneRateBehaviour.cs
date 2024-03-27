using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RateCurve                                000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class SwayBoneRateBehaviour
    {
        public AnimationCurve?                          RateCurve                               { get; set; }

        public static SwayBoneRateBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneRateBehaviour();

            value.RateCurve                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4DFF820 0x10 RateCurve                   ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
