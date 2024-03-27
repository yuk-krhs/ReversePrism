using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveInviteCodeArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstFriendInvitationIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstFriendInvitationId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FriendInvitationCodeFieldNumber          int IL2CPP_TYPE_I4
    // 020 FriendInvitationCode                     000186671910 ModelPrimitiveType string string string String
    public partial class ReceiveInviteCodeArgs
    {
        public int                                      MstFriendInvitationId                   { get; set; }
        public string                                   FriendInvitationCode                    { get; set; }

        public static ReceiveInviteCodeArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveInviteCodeArgs();

            value.MstFriendInvitationId                     = GetInt32(new IntPtr(p + 0x018)); // 0270D1558870 0x18 MstFriendInvitationId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FriendInvitationCode                      = GetString(new IntPtr(p + 0x020)); // 0270D15588B0 0x20 FriendInvitationCode        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
