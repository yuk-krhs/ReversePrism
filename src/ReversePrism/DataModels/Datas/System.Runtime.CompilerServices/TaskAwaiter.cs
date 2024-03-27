using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_task                                   000186681890 ModelClassType Task Task Task Pointer
    public partial class TaskAwaiter
    {
        public Task?                                    M_task                                  { get; set; }

        public static TaskAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskAwaiter();

            value.M_task                                    = GetObject<Task>(new IntPtr(p + 0x010), ReversePrism.DataModels.Task.FromPointer); // 027003C2DDB8 0x10 M_task                      ( 000186681890 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
