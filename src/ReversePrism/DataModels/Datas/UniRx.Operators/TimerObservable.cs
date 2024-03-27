using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 dueTimeA                                 Nullable`1<DateTimeOffset> IL2CPP_TYPE_GENERICINST
    // 030 dueTimeB                                 Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 040 period                                   Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    // 050 Scheduler                                000186629600 ModelClassType IScheduler IScheduler IScheduler Pointer
    public partial class TimerObservable
    {
        public IScheduler?                              Scheduler                               { get; set; }

        public static TimerObservable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerObservable();

            value.Scheduler                                 = GetObject<IScheduler>(new IntPtr(p + 0x050), ReversePrism.DataModels.IScheduler.FromPointer); // 027003C0E570 0x50 Scheduler                   ( 000186629600 ModelClassType IScheduler IScheduler IScheduler Pointer )

            return value;
        }
    }
}
