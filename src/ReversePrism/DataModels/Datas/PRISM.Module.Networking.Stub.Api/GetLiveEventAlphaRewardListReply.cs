using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveEventAlphaRewardListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PointRankingRewardListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_pointRankingRewardList_codec   FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 018 PointRankingRewardList                   ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    // 000 RankRewardListFieldNumber                int IL2CPP_TYPE_I4
    // 010 _repeated_rankRewardList_codec           FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 RankRewardList                           ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    // 000 MedalGashaBoxListFieldNumber             int IL2CPP_TYPE_I4
    // 018 _repeated_medalGashaBoxList_codec        FieldCodec`1<FeaturedMedalGashaBoxStatus> IL2CPP_TYPE_GENERICINST
    // 028 MedalGashaBoxList                        ModelClassListType RepeatedField`1<FeaturedMedalGashaBoxStatus> RepeatedField`1<FeaturedMedalGashaBoxStatus> List<FeaturedMedalGashaBoxStatus> Pointer
    public partial class GetLiveEventAlphaRewardListReply : DataModel
    {
        public List<EventRankRewardStatus>?             PointRankingRewardList                  { get; set; }
        public List<EventRankRewardStatus>?             RankRewardList                          { get; set; }
        public List<FeaturedMedalGashaBoxStatus>?       MedalGashaBoxList                       { get; set; }

        public static GetLiveEventAlphaRewardListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveEventAlphaRewardListReply() { Pointer= p0 };

            value.PointRankingRewardList                    = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0x18 PointRankingRewardList      ( ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )
            value.RankRewardList                            = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0x20 RankRewardList              ( ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )
            value.MedalGashaBoxList                         = GetObjectList<FeaturedMedalGashaBoxStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.FeaturedMedalGashaBoxStatus.FromPointer); // 0x28 MedalGashaBoxList           ( ModelClassListType RepeatedField`1<FeaturedMedalGashaBoxStatus> RepeatedField`1<FeaturedMedalGashaBoxStatus> List<FeaturedMedalGashaBoxStatus> Pointer )

            return value;
        }
    }
}
