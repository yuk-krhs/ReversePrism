using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TelemetryMetricsInstanceWrapper        ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer
    // 018 M_MetricType                             ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32
    // 020 M_MetricName                             ModelPrimitiveType string string string String
    // 028 M_Stopwatch                              ModelClassType Stopwatch Stopwatch Stopwatch Pointer
    public partial class TelemetryMetricEvent : DataModel
    {
        public ITelemetryMetricsInstanceWrapper?        M_TelemetryMetricsInstanceWrapper       { get; set; }
        public TelemetryMetricTypes                     M_MetricType                            { get; set; }
        public string                                   M_MetricName                            { get; set; }
        public Stopwatch?                               M_Stopwatch                             { get; set; }

        public static TelemetryMetricEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryMetricEvent() { Pointer= p0 };

            value.M_TelemetryMetricsInstanceWrapper         = GetObject<ITelemetryMetricsInstanceWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITelemetryMetricsInstanceWrapper.FromPointer); // 0x10 M_TelemetryMetricsInstanceWrapper ( ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer )
            value.M_MetricType                              = (TelemetryMetricTypes)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_MetricType                ( ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32 )
            value.M_MetricName                              = GetString(new IntPtr(p + 0x020)); // 0x20 M_MetricName                ( ModelPrimitiveType string string string String )
            value.M_Stopwatch                               = GetObject<Stopwatch>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stopwatch.FromPointer); // 0x28 M_Stopwatch                 ( ModelClassType Stopwatch Stopwatch Stopwatch Pointer )

            return value;
        }
    }
}
