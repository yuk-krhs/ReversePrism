using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_FollowUserArgs          Marshaller`1<FollowUserArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_FollowUserReply         Marshaller`1<FollowUserReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_RemoveFollowArgs        Marshaller`1<RemoveFollowArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_RemoveFollowReply       Marshaller`1<RemoveFollowReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_RemoveFollowerArgs      Marshaller`1<RemoveFollowerArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_RemoveFollowerReply     Marshaller`1<RemoveFollowerReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetFollowListArgs       Marshaller`1<GetFollowListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetFollowListReply      Marshaller`1<GetFollowListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetFollowerListArgs     Marshaller`1<GetFollowerListArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetFollowerListReply    Marshaller`1<GetFollowerListReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetRecommendedUserListArgs Marshaller`1<GetRecommendedUserListArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetRecommendedUserListReply Marshaller`1<GetRecommendedUserListReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_FollowUser                      Method`2<FollowUserArgs, FollowUserReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_RemoveFollow                    Method`2<RemoveFollowArgs, RemoveFollowReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_RemoveFollower                  Method`2<RemoveFollowerArgs, RemoveFollowerReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_GetFollowList                   Method`2<GetFollowListArgs, GetFollowListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_GetFollowerList                 Method`2<GetFollowerListArgs, GetFollowerListReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_GetRecommendedUserList          Method`2<GetRecommendedUserListArgs, GetRecommendedUserListReply> IL2CPP_TYPE_GENERICINST
    public partial class FriendService
    {

        public static FriendService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendService();


            return value;
        }
    }
}
