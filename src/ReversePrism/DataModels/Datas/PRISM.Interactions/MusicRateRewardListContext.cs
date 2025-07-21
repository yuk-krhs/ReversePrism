using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 EffectNormalizedTime                     ModelPrimitiveType float float float Single
    public partial class MusicRateRewardListContext : DataModel
    {
        public float                                    EffectNormalizedTime                    { get; set; }

        public static MusicRateRewardListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListContext() { Pointer= p0 };

            value.EffectNormalizedTime                      = GetSingle(new IntPtr(p + 0x040)); // 0x40 EffectNormalizedTime        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
