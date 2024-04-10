using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetFriendInvitationTopArgs Marshaller`1<GetFriendInvitationTopArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetFriendInvitationTopReply Marshaller`1<GetFriendInvitationTopReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_IssueInviteCodeArgs     Marshaller`1<IssueInviteCodeArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_IssueInviteCodeReply    Marshaller`1<IssueInviteCodeReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ReceiveInviteCodeArgs   Marshaller`1<ReceiveInviteCodeArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ReceiveInviteCodeReply  Marshaller`1<ReceiveInviteCodeReply> IL2CPP_TYPE_GENERICINST
    // 038 __Method_GetFriendInvitationTop          Method`2<GetFriendInvitationTopArgs, GetFriendInvitationTopReply> IL2CPP_TYPE_GENERICINST
    // 040 __Method_IssueInviteCode                 Method`2<IssueInviteCodeArgs, IssueInviteCodeReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_ReceiveInviteCode               Method`2<ReceiveInviteCodeArgs, ReceiveInviteCodeReply> IL2CPP_TYPE_GENERICINST
    public partial class FriendInvitationService : DataModel
    {

        public static FriendInvitationService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendInvitationService() { Pointer= p0 };


            return value;
        }
    }
}
