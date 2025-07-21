using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventRewardTypeList                      ModelEnumListType IReadOnlyList`1<GameEventRewardType> IReadOnlyList`1<GameEventRewardType> List<GameEventRewardType> Pointer
    // 000 _parser                                  MessageParser`1<GetPvpEventRewardListReply> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 EventRewardTypeListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_eventRewardTypeList_codec      FieldCodec`1<GameEventRewardType> IL2CPP_TYPE_GENERICINST
    // 028 EventRewardTypeList                      ModelEnumListType RepeatedField`1<GameEventRewardType> RepeatedField`1<GameEventRewardType> List<GameEventRewardType> Pointer
    // 000 HighestRankUpdateRewardListFieldNumber   int IL2CPP_TYPE_I4
    // 010 _repeated_highestRankUpdateRewardList_codec FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 030 HighestRankUpdateRewardList              ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    // 000 FinalRankRewardListFieldNumber           int IL2CPP_TYPE_I4
    // 018 _repeated_finalRankRewardList_codec      FieldCodec`1<EventRankRewardStatus> IL2CPP_TYPE_GENERICINST
    // 038 FinalRankRewardList                      ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer
    // 000 HighestRankFieldNumber                   int IL2CPP_TYPE_I4
    // 040 HighestRank                              ModelPrimitiveType int int int Int32
    public partial class GetPvpEventRewardListReply : DataModel
    {
        public List<GameEventRewardType>?               EventRewardTypeList                     { get; set; }
        public int                                      MstEventId                              { get; set; }
        public List<EventRankRewardStatus>?             HighestRankUpdateRewardList             { get; set; }
        public List<EventRankRewardStatus>?             FinalRankRewardList                     { get; set; }
        public int                                      HighestRank                             { get; set; }

        public static GetPvpEventRewardListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPvpEventRewardListReply() { Pointer= p0 };

            value.EventRewardTypeList                       = GetEnumList<GameEventRewardType>(new IntPtr(p + 0x028)); // 0x28 EventRewardTypeList         ( ModelEnumListType RepeatedField`1<GameEventRewardType> RepeatedField`1<GameEventRewardType> List<GameEventRewardType> Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.HighestRankUpdateRewardList               = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0x30 HighestRankUpdateRewardList ( ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )
            value.FinalRankRewardList                       = GetObjectList<EventRankRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventRankRewardStatus.FromPointer); // 0x38 FinalRankRewardList         ( ModelClassListType RepeatedField`1<EventRankRewardStatus> RepeatedField`1<EventRankRewardStatus> List<EventRankRewardStatus> Pointer )
            value.HighestRank                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 HighestRank                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
