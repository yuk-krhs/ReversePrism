using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveEventAllSongRewardListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MedalExchangeRewardListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_medalExchangeRewardList_codec  FieldCodec`1<MedalExchangeFeaturedRewardStatus> IL2CPP_TYPE_GENERICINST
    // 018 MedalExchangeRewardList                  ModelClassListType RepeatedField`1<MedalExchangeFeaturedRewardStatus> RepeatedField`1<MedalExchangeFeaturedRewardStatus> List<MedalExchangeFeaturedRewardStatus> Pointer
    // 000 TotalPointRankingRewardListFieldNumber   int IL2CPP_TYPE_I4
    // 010 _repeated_totalPointRankingRewardList_codec FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 TotalPointRankingRewardList              ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    // 000 IdolPointRankingRewardListFieldNumber    int IL2CPP_TYPE_I4
    // 018 _repeated_idolPointRankingRewardList_codec FieldCodec`1<EventIdolRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 028 IdolPointRankingRewardList               ModelClassListType RepeatedField`1<EventIdolRankRewardStatus> RepeatedField`1<EventIdolRankRewardStatus> List<EventIdolRankRewardStatus> Pointer
    // 000 HighScoreRankingRewardListFieldNumber    int IL2CPP_TYPE_I4
    // 020 _repeated_highScoreRankingRewardList_codec FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 030 HighScoreRankingRewardList               ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    public partial class GetLiveEventAllSongRewardListReply : DataModel
    {
        public List<MedalExchangeFeaturedRewardStatus>? MedalExchangeRewardList                 { get; set; }
        public List<EventRankRewardStatus>?             TotalPointRankingRewardList             { get; set; }
        public List<EventIdolRankRewardStatus>?         IdolPointRankingRewardList              { get; set; }
        public List<EventRankRewardStatus>?             HighScoreRankingRewardList              { get; set; }

        public static GetLiveEventAllSongRewardListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveEventAllSongRewardListReply() { Pointer= p0 };

            value.MedalExchangeRewardList                   = GetObjectList<MedalExchangeFeaturedRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MedalExchangeFeaturedRewardStatus.FromPointer); // 0x18 MedalExchangeRewardList     ( ModelClassListType RepeatedField`1<MedalExchangeFeaturedRewardStatus> RepeatedField`1<MedalExchangeFeaturedRewardStatus> List<MedalExchangeFeaturedRewardStatus> Pointer )
            value.TotalPointRankingRewardList               = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0x20 TotalPointRankingRewardList ( ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )
            value.IdolPointRankingRewardList                = GetObjectList<EventIdolRankRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventIdolRankRewardStatus.FromPointer); // 0x28 IdolPointRankingRewardList  ( ModelClassListType RepeatedField`1<EventIdolRankRewardStatus> RepeatedField`1<EventIdolRankRewardStatus> List<EventIdolRankRewardStatus> Pointer )
            value.HighScoreRankingRewardList                = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0x30 HighScoreRankingRewardList  ( ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )

            return value;
        }
    }
}
