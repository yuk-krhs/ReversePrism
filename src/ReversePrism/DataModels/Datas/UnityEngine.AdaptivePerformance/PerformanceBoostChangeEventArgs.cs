using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CpuBoost                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 GpuBoost                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PerformanceBoostChangeEventArgs : DataModel
    {
        public bool                                     CpuBoost                                { get; set; }
        public bool                                     GpuBoost                                { get; set; }

        public static PerformanceBoostChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceBoostChangeEventArgs() { Pointer= p0 };

            value.CpuBoost                                  = GetBool(new IntPtr(p + 0x010)); // 02466B6F1628 0x10 CpuBoost                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GpuBoost                                  = GetBool(new IntPtr(p + 0x011)); // 02466B6F1648 0x11 GpuBoost                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
