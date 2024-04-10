using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetPvpRankingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankingFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Ranking                                  000186762860 ModelClassType EventRankingStatus EventRankingStatus EventRankingStatus Pointer
    // 000 RankedUserListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_rankedUserList_codec           FieldCodec`1<PvpRankedUserStatus> IL2CPP_TYPE_GENERICINST
    // 020 RankedUserList                           000185CEE0D8 ModelClassListType RepeatedField`1<PvpRankedUserStatus> RepeatedField`1<PvpRankedUserStatus> List<PvpRankedUserStatus> Pointer
    public partial class GetPvpRankingReply : DataModel
    {
        public EventRankingStatus?                      Ranking                                 { get; set; }
        public List<PvpRankedUserStatus>?               RankedUserList                          { get; set; }

        public static GetPvpRankingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPvpRankingReply() { Pointer= p0 };

            value.Ranking                                   = GetObject<EventRankingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventRankingStatus.FromPointer); // 024660FA6AE0 0x18 Ranking                     ( 000186762860 ModelClassType EventRankingStatus EventRankingStatus EventRankingStatus Pointer )
            value.RankedUserList                            = GetObjectList<PvpRankedUserStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpRankedUserStatus.FromPointer); // 024660FA6B40 0x20 RankedUserList              ( 000185CEE0D8 ModelClassListType RepeatedField`1<PvpRankedUserStatus> RepeatedField`1<PvpRankedUserStatus> List<PvpRankedUserStatus> Pointer )

            return value;
        }
    }
}
