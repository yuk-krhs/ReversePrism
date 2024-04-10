using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_RenderThreadCpuTime                    00018665EDA0 ModelClassType RenderThreadCpuTime RenderThreadCpuTime RenderThreadCpuTime Pointer
    // 018 M_MainThreadCpuTime                      0001865CC3A0 ModelClassType MainThreadCpuTime MainThreadCpuTime MainThreadCpuTime Pointer
    public partial class CpuTimeProvider : DataModel
    {
        public RenderThreadCpuTime?                     M_RenderThreadCpuTime                   { get; set; }
        public MainThreadCpuTime?                       M_MainThreadCpuTime                     { get; set; }

        public static CpuTimeProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CpuTimeProvider() { Pointer= p0 };

            value.M_RenderThreadCpuTime                     = GetObject<RenderThreadCpuTime>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderThreadCpuTime.FromPointer); // 02466B6EFF60 0x10 M_RenderThreadCpuTime       ( 00018665EDA0 ModelClassType RenderThreadCpuTime RenderThreadCpuTime RenderThreadCpuTime Pointer )
            value.M_MainThreadCpuTime                       = GetObject<MainThreadCpuTime>(new IntPtr(p + 0x018), ReversePrism.DataModels.MainThreadCpuTime.FromPointer); // 02466B6EFF80 0x18 M_MainThreadCpuTime         ( 0001865CC3A0 ModelClassType MainThreadCpuTime MainThreadCpuTime MainThreadCpuTime Pointer )

            return value;
        }
    }
}
