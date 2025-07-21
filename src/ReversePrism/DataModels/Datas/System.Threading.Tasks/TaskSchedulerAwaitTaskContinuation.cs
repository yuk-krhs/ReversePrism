using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_scheduler                              ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer
    public partial class TaskSchedulerAwaitTaskContinuation : DataModel
    {
        public TaskScheduler?                           M_scheduler                             { get; set; }

        public static TaskSchedulerAwaitTaskContinuation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskSchedulerAwaitTaskContinuation() { Pointer= p0 };

            value.M_scheduler                               = GetObject<TaskScheduler>(new IntPtr(p + 0x020), ReversePrism.DataModels.TaskScheduler.FromPointer); // 0x20 M_scheduler                 ( ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer )

            return value;
        }
    }
}
