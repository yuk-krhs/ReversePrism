using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FollowUser                               Method`2<IFollowUserArgs, IFollowUserReply> IL2CPP_TYPE_GENERICINST
    // 018 RemoveFollow                             Method`2<IRemoveFollowArgs, IRemoveFollowReply> IL2CPP_TYPE_GENERICINST
    // 030 RemoveFollower                           Method`2<IRemoveFollowerArgs, IRemoveFollowerReply> IL2CPP_TYPE_GENERICINST
    // 048 GetFollowList                            Method`2<IGetFollowListArgs, IGetFollowListReply> IL2CPP_TYPE_GENERICINST
    // 060 GetFollowerList                          Method`2<IGetFollowerListArgs, IGetFollowerListReply> IL2CPP_TYPE_GENERICINST
    // 078 GetRecommendedUserList                   Method`2<IGetRecommendedUserListArgs, IGetRecommendedUserListReply> IL2CPP_TYPE_GENERICINST
    public partial class FriendServiceMethods : DataModel
    {

        public static FriendServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
