using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TelemetryDiagnosticsInstanceWrapper    00018666EA00 ModelClassType ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper Pointer
    public partial class TelemetryDiagnostics
    {
        public ITelemetryDiagnosticsInstanceWrapper?    M_TelemetryDiagnosticsInstanceWrapper   { get; set; }

        public static TelemetryDiagnostics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryDiagnostics();

            value.M_TelemetryDiagnosticsInstanceWrapper     = GetObject<ITelemetryDiagnosticsInstanceWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITelemetryDiagnosticsInstanceWrapper.FromPointer); // 02700692FB58 0x10 M_TelemetryDiagnosticsInstanceWrapper ( 00018666EA00 ModelClassType ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper Pointer )

            return value;
        }
    }
}
