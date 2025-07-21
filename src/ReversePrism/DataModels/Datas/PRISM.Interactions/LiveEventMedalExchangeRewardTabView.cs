using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardGridView                           ModelClassType LiveEventMedalExchangeRewardGridView LiveEventMedalExchangeRewardGridView LiveEventMedalExchangeRewardGridView Pointer
    public partial class LiveEventMedalExchangeRewardTabView : DataModel
    {
        public LiveEventMedalExchangeRewardGridView?    RewardGridView                          { get; set; }

        public static LiveEventMedalExchangeRewardTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventMedalExchangeRewardTabView() { Pointer= p0 };

            value.RewardGridView                            = GetObject<LiveEventMedalExchangeRewardGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveEventMedalExchangeRewardGridView.FromPointer); // 0x20 RewardGridView              ( ModelClassType LiveEventMedalExchangeRewardGridView LiveEventMedalExchangeRewardGridView LiveEventMedalExchangeRewardGridView Pointer )

            return value;
        }
    }
}
