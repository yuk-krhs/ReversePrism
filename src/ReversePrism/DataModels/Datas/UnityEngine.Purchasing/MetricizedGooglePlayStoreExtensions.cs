using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_TelemetryMetricsService                00018666FD70 ModelClassType ITelemetryMetricsService ITelemetryMetricsService ITelemetryMetricsService Pointer
    public partial class MetricizedGooglePlayStoreExtensions : DataModel
    {
        public ITelemetryMetricsService?                M_TelemetryMetricsService               { get; set; }

        public static MetricizedGooglePlayStoreExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricizedGooglePlayStoreExtensions() { Pointer= p0 };

            value.M_TelemetryMetricsService                 = GetObject<ITelemetryMetricsService>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITelemetryMetricsService.FromPointer); // 0245A68CEA98 0x48 M_TelemetryMetricsService   ( 00018666FD70 ModelClassType ITelemetryMetricsService ITelemetryMetricsService ITelemetryMetricsService Pointer )

            return value;
        }
    }
}
