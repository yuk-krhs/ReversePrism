using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 logCountForPT                            int IL2CPP_TYPE_I4
    // 004 canLogEvent                              bool IL2CPP_TYPE_BOOLEAN
    // 010 DiagnosticTrace                          0001866CD260 ModelClassType DiagnosticTraceBase DiagnosticTraceBase DiagnosticTraceBase Pointer
    // 018 EventLogSourceName                       000186671910 ModelPrimitiveType string string string String
    // 020 IsInPartialTrust                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EventLogger : DataModel
    {
        public DiagnosticTraceBase?                     DiagnosticTrace                         { get; set; }
        public string                                   EventLogSourceName                      { get; set; }
        public bool                                     IsInPartialTrust                        { get; set; }

        public static EventLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventLogger() { Pointer= p0 };

            value.DiagnosticTrace                           = GetObject<DiagnosticTraceBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.DiagnosticTraceBase.FromPointer); // 0245A4D4C6A8 0x10 DiagnosticTrace             ( 0001866CD260 ModelClassType DiagnosticTraceBase DiagnosticTraceBase DiagnosticTraceBase Pointer )
            value.EventLogSourceName                        = GetString(new IntPtr(p + 0x018)); // 0245A4D4C6C8 0x18 EventLogSourceName          ( 000186671910 ModelPrimitiveType string string string String )
            value.IsInPartialTrust                          = GetBool(new IntPtr(p + 0x020)); // 0245A4D4C6E8 0x20 IsInPartialTrust            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
