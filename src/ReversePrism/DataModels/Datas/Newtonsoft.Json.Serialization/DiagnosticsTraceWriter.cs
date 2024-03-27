using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LevelFilter                              000186698940 ModelEnumType TraceLevel TraceLevel TraceLevel Int32
    public partial class DiagnosticsTraceWriter
    {
        public TraceLevel                               LevelFilter                             { get; set; }

        public static DiagnosticsTraceWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiagnosticsTraceWriter();

            value.LevelFilter                               = (TraceLevel)GetInt32(new IntPtr(p + 0x010)); // 0270D875D168 0x10 LevelFilter                 ( 000186698940 ModelEnumType TraceLevel TraceLevel TraceLevel Int32 )

            return value;
        }
    }
}
