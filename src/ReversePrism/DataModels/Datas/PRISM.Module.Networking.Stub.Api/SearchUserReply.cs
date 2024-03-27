using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SearchUserReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SearchUserStatusFieldNumber              int IL2CPP_TYPE_I4
    // 018 SearchUserStatus                         0001865CB790 ModelClassType FriendStatus FriendStatus FriendStatus Pointer
    public partial class SearchUserReply
    {
        public FriendStatus?                            SearchUserStatus                        { get; set; }

        public static SearchUserReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SearchUserReply();

            value.SearchUserStatus                          = GetObject<FriendStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FriendStatus.FromPointer); // 0270D2D20718 0x18 SearchUserStatus            ( 0001865CB790 ModelClassType FriendStatus FriendStatus FriendStatus Pointer )

            return value;
        }
    }
}
