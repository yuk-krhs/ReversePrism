using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Task                                     000186681620 ModelClassType Task Task Task Pointer
    public partial class ForceAsyncAwaiter : DataModel
    {
        public Task?                                    Task                                    { get; set; }

        public static ForceAsyncAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForceAsyncAwaiter() { Pointer= p0 };

            value.Task                                      = GetObject<Task>(new IntPtr(p + 0x010), ReversePrism.DataModels.Task.FromPointer); // 024666B6A5B0 0x10 Task                        ( 000186681620 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
