using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TelemetryMetricsInstanceWrapper        00018666F890 ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer
    // 018 M_MetricType                             00018662BB80 ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32
    // 020 M_MetricName                             000186672F10 ModelPrimitiveType string string string String
    // 028 M_Stopwatch                              00018658E360 ModelClassType Stopwatch Stopwatch Stopwatch Pointer
    public partial class TelemetryMetricEvent
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
            var value   = new TelemetryMetricEvent();

            value.M_TelemetryMetricsInstanceWrapper         = GetObject<ITelemetryMetricsInstanceWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITelemetryMetricsInstanceWrapper.FromPointer); // 027006930540 0x10 M_TelemetryMetricsInstanceWrapper ( 00018666F890 ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer )
            value.M_MetricType                              = (TelemetryMetricTypes)GetInt32(new IntPtr(p + 0x018)); // 027006930560 0x18 M_MetricType                ( 00018662BB80 ModelEnumType TelemetryMetricTypes TelemetryMetricTypes TelemetryMetricTypes Int32 )
            value.M_MetricName                              = GetString(new IntPtr(p + 0x020)); // 027006930580 0x20 M_MetricName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_Stopwatch                               = GetObject<Stopwatch>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stopwatch.FromPointer); // 0270069305A0 0x28 M_Stopwatch                 ( 00018658E360 ModelClassType Stopwatch Stopwatch Stopwatch Pointer )

            return value;
        }
    }
}
