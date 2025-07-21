using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetEventListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 EventListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_eventList_codec                FieldCodec`1<GameEventStatus> IL2CPP_TYPE_GENERICINST
    // 018 EventList                                ModelClassListType RepeatedField`1<GameEventStatus> RepeatedField`1<GameEventStatus> List<GameEventStatus> Pointer
    public partial class GetEventListReply : DataModel
    {
        public List<GameEventStatus>?                   EventList                               { get; set; }

        public static GetEventListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetEventListReply() { Pointer= p0 };

            value.EventList                                 = GetObjectList<GameEventStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameEventStatus.FromPointer); // 0x18 EventList                   ( ModelClassListType RepeatedField`1<GameEventStatus> RepeatedField`1<GameEventStatus> List<GameEventStatus> Pointer )

            return value;
        }
    }
}
