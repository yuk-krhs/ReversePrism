using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_task                                   ModelClassType Task Task Task Pointer
    // 018 M_options                                ModelEnumType TaskContinuationOptions TaskContinuationOptions TaskContinuationOptions Int32
    // 020 M_taskScheduler                          ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer
    public partial class StandardTaskContinuation : DataModel
    {
        public Task?                                    M_task                                  { get; set; }
        public TaskContinuationOptions                  M_options                               { get; set; }
        public TaskScheduler?                           M_taskScheduler                         { get; set; }

        public static StandardTaskContinuation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StandardTaskContinuation() { Pointer= p0 };

            value.M_task                                    = GetObject<Task>(new IntPtr(p + 0x010), ReversePrism.DataModels.Task.FromPointer); // 0x10 M_task                      ( ModelClassType Task Task Task Pointer )
            value.M_options                                 = (TaskContinuationOptions)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_options                   ( ModelEnumType TaskContinuationOptions TaskContinuationOptions TaskContinuationOptions Int32 )
            value.M_taskScheduler                           = GetObject<TaskScheduler>(new IntPtr(p + 0x020), ReversePrism.DataModels.TaskScheduler.FromPointer); // 0x20 M_taskScheduler             ( ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer )

            return value;
        }
    }
}
