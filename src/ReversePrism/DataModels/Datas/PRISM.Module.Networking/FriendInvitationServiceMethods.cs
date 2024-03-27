using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetFriendInvitationTop                   Method`2<IGetFriendInvitationTopArgs, IGetFriendInvitationTopReply> IL2CPP_TYPE_GENERICINST
    // 018 IssueInviteCode                          Method`2<IIssueInviteCodeArgs, IIssueInviteCodeReply> IL2CPP_TYPE_GENERICINST
    // 030 ReceiveInviteCode                        Method`2<IReceiveInviteCodeArgs, IReceiveInviteCodeReply> IL2CPP_TYPE_GENERICINST
    public partial class FriendInvitationServiceMethods
    {

        public static FriendInvitationServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendInvitationServiceMethods();


            return value;
        }
    }
}
