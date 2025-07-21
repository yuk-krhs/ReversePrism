using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 RewardItem                               ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer
    public partial class SpecialMissionCompleteRewardListViewCell : DataModel
    {
        public ReceiveRewardItem?                       RewardItem                              { get; set; }

        public static SpecialMissionCompleteRewardListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionCompleteRewardListViewCell() { Pointer= p0 };

            value.RewardItem                                = GetObject<ReceiveRewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.ReceiveRewardItem.FromPointer); // 0x40 RewardItem                  ( ModelClassType ReceiveRewardItem ReceiveRewardItem ReceiveRewardItem Pointer )

            return value;
        }
    }
}
