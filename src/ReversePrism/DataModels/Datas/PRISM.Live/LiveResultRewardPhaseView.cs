using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 RewardInfoView                           ModelClassType LiveResultRewardInfoView LiveResultRewardInfoView LiveResultRewardInfoView Pointer
    public partial class LiveResultRewardPhaseView : DataModel
    {
        public LiveResultRewardInfoView?                RewardInfoView                          { get; set; }

        public static LiveResultRewardPhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultRewardPhaseView() { Pointer= p0 };

            value.RewardInfoView                            = GetObject<LiveResultRewardInfoView>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveResultRewardInfoView.FromPointer); // 0x60 RewardInfoView              ( ModelClassType LiveResultRewardInfoView LiveResultRewardInfoView LiveResultRewardInfoView Pointer )

            return value;
        }
    }
}
