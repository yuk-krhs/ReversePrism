using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveSeasonMissionRankRewardReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SeasonRewardListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_seasonRewardList_codec         FieldCodec`1<SeasonRewardStatus> IL2CPP_TYPE_GENERICINST
    // 018 SeasonRewardList                         000185CF0608 ModelClassListType RepeatedField`1<SeasonRewardStatus> RepeatedField`1<SeasonRewardStatus> List<SeasonRewardStatus> Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 010 _repeated_rewardList_codec               FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ReceiveSeasonMissionRankRewardReply : DataModel
    {
        public List<SeasonRewardStatus>?                SeasonRewardList                        { get; set; }
        public List<RewardProductStatus>?               RewardList                              { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ReceiveSeasonMissionRankRewardReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveSeasonMissionRankRewardReply() { Pointer= p0 };

            value.SeasonRewardList                          = GetObjectList<SeasonRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonRewardStatus.FromPointer); // 0246626E3660 0x18 SeasonRewardList            ( 000185CF0608 ModelClassListType RepeatedField`1<SeasonRewardStatus> RepeatedField`1<SeasonRewardStatus> List<SeasonRewardStatus> Pointer )
            value.RewardList                                = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0246626E36C0 0x20 RewardList                  ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0246626E3700 0x28 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
