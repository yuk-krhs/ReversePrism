using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetFriendSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FriendSupportListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_friendSupportList_codec        FieldCodec`1<FriendSupportStatus> IL2CPP_TYPE_GENERICINST
    // 018 FriendSupportList                        ModelClassListType RepeatedField`1<FriendSupportStatus> RepeatedField`1<FriendSupportStatus> List<FriendSupportStatus> Pointer
    public partial class GetFriendSupportCharacterListReply : DataModel
    {
        public List<FriendSupportStatus>?               FriendSupportList                       { get; set; }

        public static GetFriendSupportCharacterListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFriendSupportCharacterListReply() { Pointer= p0 };

            value.FriendSupportList                         = GetObjectList<FriendSupportStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FriendSupportStatus.FromPointer); // 0x18 FriendSupportList           ( ModelClassListType RepeatedField`1<FriendSupportStatus> RepeatedField`1<FriendSupportStatus> List<FriendSupportStatus> Pointer )

            return value;
        }
    }
}
