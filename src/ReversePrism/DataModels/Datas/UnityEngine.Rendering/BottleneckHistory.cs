using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Bottlenecks                            000185CF8E18 ModelEnumListType List`1<PerformanceBottleneck> List`1<PerformanceBottleneck> List<PerformanceBottleneck> Pointer
    // 018 Histogram                                00018676D7E0 ModelEnumType BottleneckHistogram BottleneckHistogram BottleneckHistogram Int32
    public partial class BottleneckHistory
    {
        public List<PerformanceBottleneck>?             M_Bottlenecks                           { get; set; }
        public BottleneckHistogram                      Histogram                               { get; set; }

        public static BottleneckHistory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BottleneckHistory();

            value.M_Bottlenecks                             = GetEnumList<PerformanceBottleneck>(new IntPtr(p + 0x010)); // 0270D9161D68 0x10 M_Bottlenecks               ( 000185CF8E18 ModelEnumListType List`1<PerformanceBottleneck> List`1<PerformanceBottleneck> List<PerformanceBottleneck> Pointer )
            value.Histogram                                 = (BottleneckHistogram)GetInt32(new IntPtr(p + 0x018)); // 0270D9161D88 0x18 Histogram                   ( 00018676D7E0 ModelEnumType BottleneckHistogram BottleneckHistogram BottleneckHistogram Int32 )

            return value;
        }
    }
}
