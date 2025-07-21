using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 RewardIcon                               ModelClassType MedalGashaRewardIcon MedalGashaRewardIcon MedalGashaRewardIcon Pointer
    public partial class LiveEventMedalExchangeRewardGridCell : DataModel
    {
        public MedalGashaRewardIcon?                    RewardIcon                              { get; set; }

        public static LiveEventMedalExchangeRewardGridCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventMedalExchangeRewardGridCell() { Pointer= p0 };

            value.RewardIcon                                = GetObject<MedalGashaRewardIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.MedalGashaRewardIcon.FromPointer); // 0x40 RewardIcon                  ( ModelClassType MedalGashaRewardIcon MedalGashaRewardIcon MedalGashaRewardIcon Pointer )

            return value;
        }
    }
}
