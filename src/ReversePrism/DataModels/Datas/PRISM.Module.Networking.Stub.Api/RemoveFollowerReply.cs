using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RemoveFollowerReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FriendStateFieldNumber                   int IL2CPP_TYPE_I4
    // 018 FriendState                              0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32
    public partial class RemoveFollowerReply : DataModel
    {
        public FriendState                              FriendState                             { get; set; }

        public static RemoveFollowerReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoveFollowerReply() { Pointer= p0 };

            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x018)); // 0246613ABDD0 0x18 FriendState                 ( 0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32 )

            return value;
        }
    }
}
