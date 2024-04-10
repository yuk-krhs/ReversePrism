using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PerformanceBottleneck                    000186730BA0 ModelEnumType PerformanceBottleneck PerformanceBottleneck PerformanceBottleneck Int32
    public partial class PerformanceBottleneckChangeEventArgs : DataModel
    {
        public PerformanceBottleneck                    PerformanceBottleneck                   { get; set; }

        public static PerformanceBottleneckChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceBottleneckChangeEventArgs() { Pointer= p0 };

            value.PerformanceBottleneck                     = (PerformanceBottleneck)GetInt32(new IntPtr(p + 0x010)); // 02466B6F1450 0x10 PerformanceBottleneck       ( 000186730BA0 ModelEnumType PerformanceBottleneck PerformanceBottleneck PerformanceBottleneck Int32 )

            return value;
        }
    }
}
