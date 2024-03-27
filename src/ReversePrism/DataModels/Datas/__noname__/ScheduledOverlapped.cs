using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nativeOverlapped                         IntPtr IL2CPP_TYPE_PTR
    // 018 Scheduler                                0001865C7570 ModelClassType IOThreadScheduler IOThreadScheduler IOThreadScheduler Pointer
    public partial class ScheduledOverlapped
    {
        public IOThreadScheduler?                       Scheduler                               { get; set; }

        public static ScheduledOverlapped? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduledOverlapped();

            value.Scheduler                                 = GetObject<IOThreadScheduler>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOThreadScheduler.FromPointer); // 0270DBA2B128 0x18 Scheduler                   ( 0001865C7570 ModelClassType IOThreadScheduler IOThreadScheduler IOThreadScheduler Pointer )

            return value;
        }
    }
}
