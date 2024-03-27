using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetEventScheduleList                     Method`2<IGetEventScheduleListArgs, IGetEventScheduleListReply> IL2CPP_TYPE_GENERICINST
    public partial class EventScheduleServiceMethods
    {

        public static EventScheduleServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleServiceMethods();


            return value;
        }
    }
}
