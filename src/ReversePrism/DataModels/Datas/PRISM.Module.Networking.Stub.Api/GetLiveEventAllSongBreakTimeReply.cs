using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveEventAllSongBreakTimeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BreakTimeFieldNumber                     int IL2CPP_TYPE_I4
    // 018 BreakTime                                ModelClassType EventBreakTimeStatus EventBreakTimeStatus EventBreakTimeStatus Pointer
    public partial class GetLiveEventAllSongBreakTimeReply : DataModel
    {
        public EventBreakTimeStatus?                    BreakTime                               { get; set; }

        public static GetLiveEventAllSongBreakTimeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveEventAllSongBreakTimeReply() { Pointer= p0 };

            value.BreakTime                                 = GetObject<EventBreakTimeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventBreakTimeStatus.FromPointer); // 0x18 BreakTime                   ( ModelClassType EventBreakTimeStatus EventBreakTimeStatus EventBreakTimeStatus Pointer )

            return value;
        }
    }
}
