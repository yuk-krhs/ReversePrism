using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handler                                  000186616B60 ModelClassType MetricsHandler MetricsHandler MetricsHandler Pointer
    // 018 <PackageTags>k__BackingField             IDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class Metrics : DataModel
    {
        public MetricsHandler?                          Handler                                 { get; set; }

        public static Metrics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Metrics() { Pointer= p0 };

            value.Handler                                   = GetObject<MetricsHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.MetricsHandler.FromPointer); // 0245A667BCB8 0x10 Handler                     ( 000186616B60 ModelClassType MetricsHandler MetricsHandler MetricsHandler Pointer )

            return value;
        }
    }
}
