using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 018 Exception                                000186671BA0 ModelPrimitiveType string string string String
    public partial class TelemetryDiagnosticParams
    {
        public string                                   Name                                    { get; set; }
        public string                                   Exception                               { get; set; }

        public static TelemetryDiagnosticParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryDiagnosticParams();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02700692FA30 0x10 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Exception                                 = GetString(new IntPtr(p + 0x018)); // 02700692FA50 0x18 Exception                   ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
