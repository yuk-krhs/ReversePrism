using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProducerEventInfoListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 EventStatusListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_eventStatusList_codec          FieldCodec`1<UserProfileEventStatus> IL2CPP_TYPE_GENERICINST
    // 018 EventStatusList                          ModelClassListType RepeatedField`1<UserProfileEventStatus> RepeatedField`1<UserProfileEventStatus> List<UserProfileEventStatus> Pointer
    public partial class GetProducerEventInfoListReply : DataModel
    {
        public List<UserProfileEventStatus>?            EventStatusList                         { get; set; }

        public static GetProducerEventInfoListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProducerEventInfoListReply() { Pointer= p0 };

            value.EventStatusList                           = GetObjectList<UserProfileEventStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.UserProfileEventStatus.FromPointer); // 0x18 EventStatusList             ( ModelClassListType RepeatedField`1<UserProfileEventStatus> RepeatedField`1<UserProfileEventStatus> List<UserProfileEventStatus> Pointer )

            return value;
        }
    }
}
