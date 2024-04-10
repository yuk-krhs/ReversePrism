using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetPhoneCallListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PhoneInfoListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_phoneInfoList_codec            FieldCodec`1<PhoneInfoStatus> IL2CPP_TYPE_GENERICINST
    // 018 PhoneInfoList                            000185CE8CA8 ModelClassListType RepeatedField`1<PhoneInfoStatus> RepeatedField`1<PhoneInfoStatus> List<PhoneInfoStatus> Pointer
    public partial class GetPhoneCallListReply : DataModel
    {
        public List<PhoneInfoStatus>?                   PhoneInfoList                           { get; set; }

        public static GetPhoneCallListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPhoneCallListReply() { Pointer= p0 };

            value.PhoneInfoList                             = GetObjectList<PhoneInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PhoneInfoStatus.FromPointer); // 02466226BC70 0x18 PhoneInfoList               ( 000185CE8CA8 ModelClassListType RepeatedField`1<PhoneInfoStatus> RepeatedField`1<PhoneInfoStatus> List<PhoneInfoStatus> Pointer )

            return value;
        }
    }
}
