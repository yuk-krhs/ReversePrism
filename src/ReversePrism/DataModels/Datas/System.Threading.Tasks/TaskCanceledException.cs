using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 CanceledTask                             000186682220 ModelClassType Task Task Task Pointer
    public partial class TaskCanceledException
    {
        public Task?                                    CanceledTask                            { get; set; }

        public static TaskCanceledException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskCanceledException();

            value.CanceledTask                              = GetObject<Task>(new IntPtr(p + 0x098), ReversePrism.DataModels.Task.FromPointer); // 0270D6AF3F18 0x98 CanceledTask                ( 000186682220 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
