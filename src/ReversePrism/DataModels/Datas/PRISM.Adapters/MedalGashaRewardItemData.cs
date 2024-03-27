using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RewardStatus                             0001865ABE60 ModelClassType IMedalGashaRewardStatus IMedalGashaRewardStatus IMedalGashaRewardStatus Pointer
    // 018 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class MedalGashaRewardItemData
    {
        public IMedalGashaRewardStatus?                 RewardStatus                            { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static MedalGashaRewardItemData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardItemData();

            value.RewardStatus                              = GetObject<IMedalGashaRewardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMedalGashaRewardStatus.FromPointer); // 0270D629E348 0x10 RewardStatus                ( 0001865ABE60 ModelClassType IMedalGashaRewardStatus IMedalGashaRewardStatus IMedalGashaRewardStatus Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D629E368 0x18 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
