using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventSourceName                          ModelPrimitiveType string string string String
    // 018 DiagnosticTrace                          ModelClassType EtwDiagnosticTrace EtwDiagnosticTrace EtwDiagnosticTrace Pointer
    public partial class ExceptionTrace : DataModel
    {
        public string                                   EventSourceName                         { get; set; }
        public EtwDiagnosticTrace?                      DiagnosticTrace                         { get; set; }

        public static ExceptionTrace? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionTrace() { Pointer= p0 };

            value.EventSourceName                           = GetString(new IntPtr(p + 0x010)); // 0x10 EventSourceName             ( ModelPrimitiveType string string string String )
            value.DiagnosticTrace                           = GetObject<EtwDiagnosticTrace>(new IntPtr(p + 0x018), ReversePrism.DataModels.EtwDiagnosticTrace.FromPointer); // 0x18 DiagnosticTrace             ( ModelClassType EtwDiagnosticTrace EtwDiagnosticTrace EtwDiagnosticTrace Pointer )

            return value;
        }
    }
}
