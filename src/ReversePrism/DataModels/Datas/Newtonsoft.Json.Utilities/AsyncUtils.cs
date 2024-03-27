using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 False                                    Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 True                                     Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 010 CompletedTask                            000186681D40 ModelClassType Task Task Task Pointer
    public partial class AsyncUtils
    {
        public Task?                                    CompletedTask                           { get; set; }

        public static AsyncUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncUtils();

            value.CompletedTask                             = GetObject<Task>(new IntPtr(p + 0x010), ReversePrism.DataModels.Task.FromPointer); // 0270D86E9808 0x10 CompletedTask               ( 000186681D40 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
