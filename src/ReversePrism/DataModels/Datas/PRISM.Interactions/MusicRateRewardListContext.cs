using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 EffectNormalizedTime                     0001866656B0 ModelPrimitiveType float float float Single
    public partial class MusicRateRewardListContext
    {
        public float                                    EffectNormalizedTime                    { get; set; }

        public static MusicRateRewardListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListContext();

            value.EffectNormalizedTime                      = GetSingle(new IntPtr(p + 0x038)); // 0270DB3F0090 0x38 EffectNormalizedTime        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
