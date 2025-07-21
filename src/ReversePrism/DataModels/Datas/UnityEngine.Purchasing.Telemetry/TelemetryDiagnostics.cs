using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TelemetryDiagnosticsInstanceWrapper    ModelClassType ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper Pointer
    public partial class TelemetryDiagnostics : DataModel
    {
        public ITelemetryDiagnosticsInstanceWrapper?    M_TelemetryDiagnosticsInstanceWrapper   { get; set; }

        public static TelemetryDiagnostics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryDiagnostics() { Pointer= p0 };

            value.M_TelemetryDiagnosticsInstanceWrapper     = GetObject<ITelemetryDiagnosticsInstanceWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITelemetryDiagnosticsInstanceWrapper.FromPointer); // 0x10 M_TelemetryDiagnosticsInstanceWrapper ( ModelClassType ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper ITelemetryDiagnosticsInstanceWrapper Pointer )

            return value;
        }
    }
}
