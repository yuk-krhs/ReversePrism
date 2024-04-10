using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetEventScheduleListArgs Marshaller`1<GetEventScheduleListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetEventScheduleListReply Marshaller`1<GetEventScheduleListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_GetEventScheduleList            Method`2<GetEventScheduleListArgs, GetEventScheduleListReply> IL2CPP_TYPE_GENERICINST
    public partial class EventScheduleService : DataModel
    {

        public static EventScheduleService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleService() { Pointer= p0 };


            return value;
        }
    }
}
