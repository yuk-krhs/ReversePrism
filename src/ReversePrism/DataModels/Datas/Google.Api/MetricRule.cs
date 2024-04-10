using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MetricRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 000186671910 ModelPrimitiveType string string string String
    // 000 MetricCostsFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _map_metricCosts_codec                   Codec<string, long> IL2CPP_TYPE_GENERICINST
    // 020 metricCosts_                             MapField`2<string, long> IL2CPP_TYPE_GENERICINST
    public partial class MetricRule : DataModel
    {
        public string                                   Selector                                { get; set; }

        public static MetricRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 02466A883ED8 0x18 Selector                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
