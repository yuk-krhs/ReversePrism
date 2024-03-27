using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TelemetryMetricsInstanceWrapper        00018666F890 ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer
    public partial class TelemetryMetricsService
    {
        public ITelemetryMetricsInstanceWrapper?        M_TelemetryMetricsInstanceWrapper       { get; set; }

        public static TelemetryMetricsService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryMetricsService();

            value.M_TelemetryMetricsInstanceWrapper         = GetObject<ITelemetryMetricsInstanceWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITelemetryMetricsInstanceWrapper.FromPointer); // 0270066C62F8 0x10 M_TelemetryMetricsInstanceWrapper ( 00018666F890 ModelClassType ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper ITelemetryMetricsInstanceWrapper Pointer )

            return value;
        }
    }
}
