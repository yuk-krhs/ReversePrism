using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnimCurve                                000186587470 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class EaseCurve : DataModel
    {
        public AnimationCurve?                          AnimCurve                               { get; set; }

        public static EaseCurve? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EaseCurve() { Pointer= p0 };

            value.AnimCurve                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationCurve.FromPointer); // 02466B148D88 0x10 AnimCurve                   ( 000186587470 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
