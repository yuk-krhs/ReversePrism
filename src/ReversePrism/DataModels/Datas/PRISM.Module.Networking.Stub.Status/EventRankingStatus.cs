using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RankingViewTypeList                      000185D18188 ModelEnumListType IReadOnlyList`1<EventRankingViewType> IReadOnlyList`1<EventRankingViewType> List<EventRankingViewType> Pointer
    // 000 _parser                                  MessageParser`1<EventRankingStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RankingTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 024 RankingType                              000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 RankingViewTypeListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_rankingViewTypeList_codec      FieldCodec`1<EventRankingViewType> IL2CPP_TYPE_GENERICINST
    // 028 RankingViewTypeList                      000185CD5B38 ModelEnumListType RepeatedField`1<EventRankingViewType> RepeatedField`1<EventRankingViewType> List<EventRankingViewType> Pointer
    public partial class EventRankingStatus
    {
        public List<EventRankingViewType>?              RankingViewTypeList                     { get; set; }
        public int                                      MstEventId                              { get; set; }
        public EventRankingType                         RankingType                             { get; set; }

        public static EventRankingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankingStatus();

            value.RankingViewTypeList                       = GetEnumList<EventRankingViewType>(new IntPtr(p + 0x028)); // 0270D101B2C0 0x28 RankingViewTypeList         ( 000185CD5B38 ModelEnumListType RepeatedField`1<EventRankingViewType> RepeatedField`1<EventRankingViewType> List<EventRankingViewType> Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x020)); // 0270D101B220 0x20 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x024)); // 0270D101B260 0x24 RankingType                 ( 000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )

            return value;
        }
    }
}
