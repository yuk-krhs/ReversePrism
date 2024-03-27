using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Metrics                                  000185CF3768 ModelEnumListType List`1<Metric> List`1<Metric> List<Metric> Pointer
    // 018 CommonTags                               Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 020 MetricsCommonTags                        Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class MetricsPayload
    {
        public List<Metric>?                            Metrics                                 { get; set; }

        public static MetricsPayload? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricsPayload();

            value.Metrics                                   = GetEnumList<Metric>(new IntPtr(p + 0x010)); // 0270066AA310 0x10 Metrics                     ( 000185CF3768 ModelEnumListType List`1<Metric> List`1<Metric> List<Metric> Pointer )

            return value;
        }
    }
}
