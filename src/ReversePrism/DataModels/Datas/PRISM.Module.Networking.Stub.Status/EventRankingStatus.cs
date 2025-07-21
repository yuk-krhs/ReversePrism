using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RankingViewTypeList                      ModelEnumListType List<EventRankingViewType> List<EventRankingViewType> List<EventRankingViewType> Pointer
    // 000 _parser                                  MessageParser`1<EventRankingStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 RankingTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 024 RankingType                              ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 RankingViewTypeListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_rankingViewTypeList_codec      FieldCodec`1<EventRankingViewType> IL2CPP_TYPE_GENERICINST
    // 028 RankingViewTypeList                      ModelEnumListType RepeatedField`1<EventRankingViewType> RepeatedField`1<EventRankingViewType> List<EventRankingViewType> Pointer
    // 000 MstEventRankingIdFieldNumber             int IL2CPP_TYPE_I4
    // 030 MstEventRankingId                        ModelPrimitiveType int int int Int32
    public partial class EventRankingStatus : DataModel
    {
        public List<EventRankingViewType>?              RankingViewTypeList                     { get; set; }
        public int                                      MstEventId                              { get; set; }
        public EventRankingType                         RankingType                             { get; set; }
        public int                                      MstEventRankingId                       { get; set; }

        public static EventRankingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankingStatus() { Pointer= p0 };

            value.RankingViewTypeList                       = GetEnumList<EventRankingViewType>(new IntPtr(p + 0x028)); // 0x28 RankingViewTypeList         ( ModelEnumListType RepeatedField`1<EventRankingViewType> RepeatedField`1<EventRankingViewType> List<EventRankingViewType> Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x024)); // 0x24 RankingType                 ( ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.MstEventRankingId                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstEventRankingId           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
