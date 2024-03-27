using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FeaturedMedalGashaBoxStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BoxNumberFieldNumber                     int IL2CPP_TYPE_I4
    // 018 BoxNumber                                0001865F7700 ModelPrimitiveType long long long Int64
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<FeaturedMedalGashaRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CD7AC8 ModelClassListType RepeatedField`1<FeaturedMedalGashaRewardStatus> RepeatedField`1<FeaturedMedalGashaRewardStatus> List<FeaturedMedalGashaRewardStatus> Pointer
    public partial class FeaturedMedalGashaBoxStatus
    {
        public long                                     BoxNumber                               { get; set; }
        public List<FeaturedMedalGashaRewardStatus>?    RewardList                              { get; set; }

        public static FeaturedMedalGashaBoxStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FeaturedMedalGashaBoxStatus();

            value.BoxNumber                                 = GetInt64(new IntPtr(p + 0x018)); // 0270D228DD50 0x18 BoxNumber                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.RewardList                                = GetObjectList<FeaturedMedalGashaRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.FeaturedMedalGashaRewardStatus.FromPointer); // 0270D228DDB0 0x20 RewardList                  ( 000185CD7AC8 ModelClassListType RepeatedField`1<FeaturedMedalGashaRewardStatus> RepeatedField`1<FeaturedMedalGashaRewardStatus> List<FeaturedMedalGashaRewardStatus> Pointer )

            return value;
        }
    }
}
