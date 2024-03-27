using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetRankingListArgs      Marshaller`1<GetRankingListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetRankingListReply     Marshaller`1<GetRankingListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetRankingArgs          Marshaller`1<GetRankingArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetRankingReply         Marshaller`1<GetRankingReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetSelfRankingArgs      Marshaller`1<GetSelfRankingArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetSelfRankingReply     Marshaller`1<GetSelfRankingReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_EditRankingCommentArgs  Marshaller`1<EditRankingCommentArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_EditRankingCommentReply Marshaller`1<EditRankingCommentReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetPvpRankingArgs       Marshaller`1<GetPvpRankingArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetPvpRankingReply      Marshaller`1<GetPvpRankingReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetRankingList                  Method`2<GetRankingListArgs, GetRankingListReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_GetRanking                      Method`2<GetRankingArgs, GetRankingReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_GetSelfRanking                  Method`2<GetSelfRankingArgs, GetSelfRankingReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_EditRankingComment              Method`2<EditRankingCommentArgs, EditRankingCommentReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_GetPvpRanking                   Method`2<GetPvpRankingArgs, GetPvpRankingReply> IL2CPP_TYPE_GENERICINST
    public partial class EventRankingService
    {

        public static EventRankingService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankingService();


            return value;
        }
    }
}
