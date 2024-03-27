using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProfileReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProfileStatusFieldNumber                 int IL2CPP_TYPE_I4
    // 018 ProfileStatus                            0001865C39B0 ModelClassType ProfileStatus ProfileStatus ProfileStatus Pointer
    // 000 FriendStateFieldNumber                   int IL2CPP_TYPE_I4
    // 020 FriendState                              0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32
    public partial class GetProfileReply
    {
        public ProfileStatus?                           ProfileStatus                           { get; set; }
        public FriendState                              FriendState                             { get; set; }

        public static GetProfileReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProfileReply();

            value.ProfileStatus                             = GetObject<ProfileStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileStatus.FromPointer); // 0270D2D1A9B0 0x18 ProfileStatus               ( 0001865C39B0 ModelClassType ProfileStatus ProfileStatus ProfileStatus Pointer )
            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x020)); // 0270D2D1A9F0 0x20 FriendState                 ( 0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32 )

            return value;
        }
    }
}
