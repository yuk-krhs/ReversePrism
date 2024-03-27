using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 EffectDuration                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class MusicRateRewardListView
    {
        public float                                    EffectDuration                          { get; set; }

        public static MusicRateRewardListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListView();

            value.EffectDuration                            = GetSingle(new IntPtr(p + 0x090)); // 0270DB3F25D0 0x90 EffectDuration              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
