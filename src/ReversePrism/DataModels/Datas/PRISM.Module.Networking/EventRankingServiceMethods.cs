using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetRankingList                           Method`2<IGetRankingListArgs, IGetRankingListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetRanking                               Method`2<IGetRankingArgs, IGetRankingReply> IL2CPP_TYPE_GENERICINST
    // 030 GetSelfRanking                           Method`2<IGetSelfRankingArgs, IGetSelfRankingReply> IL2CPP_TYPE_GENERICINST
    // 048 EditRankingComment                       Method`2<IEditRankingCommentArgs, IEditRankingCommentReply> IL2CPP_TYPE_GENERICINST
    // 060 GetPvpRanking                            Method`2<IGetPvpRankingArgs, IGetPvpRankingReply> IL2CPP_TYPE_GENERICINST
    public partial class EventRankingServiceMethods : DataModel
    {

        public static EventRankingServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankingServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
