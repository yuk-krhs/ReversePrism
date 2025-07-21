using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MetricType                               ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32
    // 018 MetricName                               ModelPrimitiveType string string string String
    public partial class TelemetryMetricDefinition : DataModel
    {
        public TelemetryMetricTypes                     MetricType                              { get; set; }
        public string                                   MetricName                              { get; set; }

        public static TelemetryMetricDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryMetricDefinition() { Pointer= p0 };

            value.MetricType                                = (TelemetryMetricTypes)GetInt32(new IntPtr(p + 0x010)); // 0x10 MetricType                  ( ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32 )
            value.MetricName                                = GetString(new IntPtr(p + 0x018)); // 0x18 MetricName                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
