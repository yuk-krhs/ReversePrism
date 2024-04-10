using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventSourceName                          000186671910 ModelPrimitiveType string string string String
    // 018 DiagnosticTrace                          00018674B5F0 ModelClassType EtwDiagnosticTrace EtwDiagnosticTrace EtwDiagnosticTrace Pointer
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

            value.EventSourceName                           = GetString(new IntPtr(p + 0x010)); // 024667DDCA28 0x10 EventSourceName             ( 000186671910 ModelPrimitiveType string string string String )
            value.DiagnosticTrace                           = GetObject<EtwDiagnosticTrace>(new IntPtr(p + 0x018), ReversePrism.DataModels.EtwDiagnosticTrace.FromPointer); // 024667DDCA48 0x18 DiagnosticTrace             ( 00018674B5F0 ModelClassType EtwDiagnosticTrace EtwDiagnosticTrace EtwDiagnosticTrace Pointer )

            return value;
        }
    }
}
