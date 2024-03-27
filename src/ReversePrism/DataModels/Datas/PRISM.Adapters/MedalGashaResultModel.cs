using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RewardList                               000185D09208 ModelClassListType IReadOnlyList`1<IRewardProductStatus> IReadOnlyList`1<IRewardProductStatus> List<IRewardProductStatus> Pointer
    // 018 FeaturedList                             000185D02D28 ModelClassListType IReadOnlyList`1<IMedalGashaRewardStatus> IReadOnlyList`1<IMedalGashaRewardStatus> List<IMedalGashaRewardStatus> Pointer
    public partial class MedalGashaResultModel
    {
        public List<IRewardProductStatus>?              RewardList                              { get; set; }
        public List<IMedalGashaRewardStatus>?           FeaturedList                            { get; set; }

        public static MedalGashaResultModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaResultModel();

            value.RewardList                                = GetObjectList<IRewardProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 0270D6296028 0x10 RewardList                  ( 000185D09208 ModelClassListType IReadOnlyList`1<IRewardProductStatus> IReadOnlyList`1<IRewardProductStatus> List<IRewardProductStatus> Pointer )
            value.FeaturedList                              = GetObjectList<IMedalGashaRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMedalGashaRewardStatus.FromPointer); // 0270D6296048 0x18 FeaturedList                ( 000185D02D28 ModelClassListType IReadOnlyList`1<IMedalGashaRewardStatus> IReadOnlyList`1<IMedalGashaRewardStatus> List<IMedalGashaRewardStatus> Pointer )

            return value;
        }
    }
}
