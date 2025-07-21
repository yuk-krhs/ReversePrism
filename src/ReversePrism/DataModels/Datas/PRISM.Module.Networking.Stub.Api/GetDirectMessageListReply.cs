using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetDirectMessageListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DirectMessageListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_directMessageList_codec        FieldCodec`1<DirectMessageStatus> IL2CPP_TYPE_GENERICINST
    // 018 DirectMessageList                        ModelClassListType RepeatedField`1<DirectMessageStatus> RepeatedField`1<DirectMessageStatus> List<DirectMessageStatus> Pointer
    public partial class GetDirectMessageListReply : DataModel
    {
        public List<DirectMessageStatus>?               DirectMessageList                       { get; set; }

        public static GetDirectMessageListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetDirectMessageListReply() { Pointer= p0 };

            value.DirectMessageList                         = GetObjectList<DirectMessageStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.DirectMessageStatus.FromPointer); // 0x18 DirectMessageList           ( ModelClassListType RepeatedField`1<DirectMessageStatus> RepeatedField`1<DirectMessageStatus> List<DirectMessageStatus> Pointer )

            return value;
        }
    }
}
