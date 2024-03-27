using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IssueInviteCodeArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstFriendInvitationIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstFriendInvitationId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IssueInviteCodeArgs
    {
        public int                                      MstFriendInvitationId                   { get; set; }

        public static IssueInviteCodeArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IssueInviteCodeArgs();

            value.MstFriendInvitationId                     = GetInt32(new IntPtr(p + 0x018)); // 0270D15561A0 0x18 MstFriendInvitationId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
