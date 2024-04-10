using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_TelemetryMetricsService                00018666FD70 ModelClassType ITelemetryMetricsService ITelemetryMetricsService ITelemetryMetricsService Pointer
    public partial class MetricizedJsonStore : DataModel
    {
        public ITelemetryMetricsService?                M_TelemetryMetricsService               { get; set; }

        public static MetricizedJsonStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricizedJsonStore() { Pointer= p0 };

            value.M_TelemetryMetricsService                 = GetObject<ITelemetryMetricsService>(new IntPtr(p + 0x060), ReversePrism.DataModels.ITelemetryMetricsService.FromPointer); // 0245A68DB238 0x60 M_TelemetryMetricsService   ( 00018666FD70 ModelClassType ITelemetryMetricsService ITelemetryMetricsService ITelemetryMetricsService Pointer )

            return value;
        }
    }
}
