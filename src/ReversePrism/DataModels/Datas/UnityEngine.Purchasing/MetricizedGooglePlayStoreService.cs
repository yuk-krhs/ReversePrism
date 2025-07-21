using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 M_TelemetryMetricsService                ModelClassType ITelemetryMetricsService ITelemetryMetricsService ITelemetryMetricsService Pointer
    // 080 M_TelemetryDiagnostics                   ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    public partial class MetricizedGooglePlayStoreService : DataModel
    {
        public ITelemetryMetricsService?                M_TelemetryMetricsService               { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }

        public static MetricizedGooglePlayStoreService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricizedGooglePlayStoreService() { Pointer= p0 };

            value.M_TelemetryMetricsService                 = GetObject<ITelemetryMetricsService>(new IntPtr(p + 0x078), ReversePrism.DataModels.ITelemetryMetricsService.FromPointer); // 0x78 M_TelemetryMetricsService   ( ModelClassType ITelemetryMetricsService ITelemetryMetricsService ITelemetryMetricsService Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x080), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 0x80 M_TelemetryDiagnostics      ( ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )

            return value;
        }
    }
}
