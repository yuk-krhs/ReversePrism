using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventRewardTypeList                      000185D183B8 ModelEnumListType IReadOnlyList`1<GameEventRewardType> IReadOnlyList`1<GameEventRewardType> List<GameEventRewardType> Pointer
    // 000 _parser                                  MessageParser`1<GetLiveEventAlphaRewardListReply> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EventRewardTypeListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_eventRewardTypeList_codec      FieldCodec`1<GameEventRewardType> IL2CPP_TYPE_GENERICINST
    // 028 EventRewardTypeList                      000185CDA3C8 ModelEnumListType RepeatedField`1<GameEventRewardType> RepeatedField`1<GameEventRewardType> List<GameEventRewardType> Pointer
    // 000 PointRankingRewardListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_pointRankingRewardList_codec   FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 030 PointRankingRewardList                   000185CD5708 ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    // 000 RankRewardListFieldNumber                int IL2CPP_TYPE_I4
    // 018 _repeated_rankRewardList_codec           FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 038 RankRewardList                           000185CD5708 ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    // 000 MedalGashaBoxListFieldNumber             int IL2CPP_TYPE_I4
    // 020 _repeated_medalGashaBoxList_codec        FieldCodec`1<FeaturedMedalGashaBoxStatus> IL2CPP_TYPE_GENERICINST
    // 040 MedalGashaBoxList                        000185CD7878 ModelClassListType RepeatedField`1<FeaturedMedalGashaBoxStatus> RepeatedField`1<FeaturedMedalGashaBoxStatus> List<FeaturedMedalGashaBoxStatus> Pointer
    public partial class GetLiveEventAlphaRewardListReply : DataModel
    {
        public List<GameEventRewardType>?               EventRewardTypeList                     { get; set; }
        public int                                      MstEventId                              { get; set; }
        public List<EventRankRewardStatus>?             PointRankingRewardList                  { get; set; }
        public List<EventRankRewardStatus>?             RankRewardList                          { get; set; }
        public List<FeaturedMedalGashaBoxStatus>?       MedalGashaBoxList                       { get; set; }

        public static GetLiveEventAlphaRewardListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveEventAlphaRewardListReply() { Pointer= p0 };

            value.EventRewardTypeList                       = GetEnumList<GameEventRewardType>(new IntPtr(p + 0x028)); // 024662152098 0x28 EventRewardTypeList         ( 000185CDA3C8 ModelEnumListType RepeatedField`1<GameEventRewardType> RepeatedField`1<GameEventRewardType> List<GameEventRewardType> Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x020)); // 024662152038 0x20 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PointRankingRewardList                    = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0246621520F8 0x30 PointRankingRewardList      ( 000185CD5708 ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )
            value.RankRewardList                            = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 024662152158 0x38 RankRewardList              ( 000185CD5708 ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )
            value.MedalGashaBoxList                         = GetObjectList<FeaturedMedalGashaBoxStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.FeaturedMedalGashaBoxStatus.FromPointer); // 0246621521B8 0x40 MedalGashaBoxList           ( 000185CD7878 ModelClassListType RepeatedField`1<FeaturedMedalGashaBoxStatus> RepeatedField`1<FeaturedMedalGashaBoxStatus> List<FeaturedMedalGashaBoxStatus> Pointer )

            return value;
        }
    }
}
