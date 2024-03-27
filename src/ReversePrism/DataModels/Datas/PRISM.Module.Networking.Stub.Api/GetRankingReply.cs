using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetRankingReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankingFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Ranking                                  000186762860 ModelClassType EventRankingStatus EventRankingStatus EventRankingStatus Pointer
    // 000 RankedUserListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_rankedUserList_codec           FieldCodec`1<RankedUserStatus> IL2CPP_TYPE_GENERICINST
    // 020 RankedUserList                           000185CEE9F8 ModelClassListType RepeatedField`1<RankedUserStatus> RepeatedField`1<RankedUserStatus> List<RankedUserStatus> Pointer
    public partial class GetRankingReply
    {
        public EventRankingStatus?                      Ranking                                 { get; set; }
        public List<RankedUserStatus>?                  RankedUserList                          { get; set; }

        public static GetRankingReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetRankingReply();

            value.Ranking                                   = GetObject<EventRankingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventRankingStatus.FromPointer); // 0270D1015000 0x18 Ranking                     ( 000186762860 ModelClassType EventRankingStatus EventRankingStatus EventRankingStatus Pointer )
            value.RankedUserList                            = GetObjectList<RankedUserStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RankedUserStatus.FromPointer); // 0270D1015060 0x20 RankedUserList              ( 000185CEE9F8 ModelClassListType RepeatedField`1<RankedUserStatus> RepeatedField`1<RankedUserStatus> List<RankedUserStatus> Pointer )

            return value;
        }
    }
}
