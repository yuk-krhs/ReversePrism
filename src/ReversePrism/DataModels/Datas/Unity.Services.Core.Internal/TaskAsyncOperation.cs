using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Scheduler                                TaskScheduler IL2CPP_TYPE_CLASS
    // 018 M_Task                                   000186680E70 ModelClassType Task Task Task Pointer
    public partial class TaskAsyncOperation : DataModel
    {
        public Task?                                    M_Task                                  { get; set; }

        public static TaskAsyncOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskAsyncOperation() { Pointer= p0 };

            value.M_Task                                    = GetObject<Task>(new IntPtr(p + 0x018), ReversePrism.DataModels.Task.FromPointer); // 0245A3B63E00 0x18 M_Task                      ( 000186680E70 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
