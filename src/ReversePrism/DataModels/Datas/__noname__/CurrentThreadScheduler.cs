using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF s_threadLocalQueue                       SchedulerQueue IL2CPP_TYPE_CLASS
    // FFFFFFFF s_clock                                  Stopwatch IL2CPP_TYPE_CLASS
    public partial class CurrentThreadScheduler : DataModel
    {

        public static CurrentThreadScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CurrentThreadScheduler() { Pointer= p0 };


            return value;
        }
    }
}
