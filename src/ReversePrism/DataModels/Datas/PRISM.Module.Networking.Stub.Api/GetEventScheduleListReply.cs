using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetEventScheduleListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 EventScheduleListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_eventScheduleList_codec        FieldCodec`1<EventScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 018 EventScheduleList                        ModelClassListType RepeatedField`1<EventScheduleStatus> RepeatedField`1<EventScheduleStatus> List<EventScheduleStatus> Pointer
    public partial class GetEventScheduleListReply : DataModel
    {
        public List<EventScheduleStatus>?               EventScheduleList                       { get; set; }

        public static GetEventScheduleListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetEventScheduleListReply() { Pointer= p0 };

            value.EventScheduleList                         = GetObjectList<EventScheduleStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventScheduleStatus.FromPointer); // 0x18 EventScheduleList           ( ModelClassListType RepeatedField`1<EventScheduleStatus> RepeatedField`1<EventScheduleStatus> List<EventScheduleStatus> Pointer )

            return value;
        }
    }
}
