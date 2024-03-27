using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 RewardInfoView                           000186573480 ModelClassType LiveResultRewardInfoView LiveResultRewardInfoView LiveResultRewardInfoView Pointer
    public partial class LiveResultRewardPhaseView
    {
        public LiveResultRewardInfoView?                RewardInfoView                          { get; set; }

        public static LiveResultRewardPhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultRewardPhaseView();

            value.RewardInfoView                            = GetObject<LiveResultRewardInfoView>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveResultRewardInfoView.FromPointer); // 0270D526A840 0x58 RewardInfoView              ( 000186573480 ModelClassType LiveResultRewardInfoView LiveResultRewardInfoView LiveResultRewardInfoView Pointer )

            return value;
        }
    }
}
