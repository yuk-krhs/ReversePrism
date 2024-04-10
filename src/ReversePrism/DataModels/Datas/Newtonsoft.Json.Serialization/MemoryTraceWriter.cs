using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _traceMessages                           Queue`1<string> IL2CPP_TYPE_GENERICINST
    // 018 _lock                                    <object> IL2CPP_TYPE_OBJECT
    // 020 LevelFilter                              000186698940 ModelEnumType TraceLevel TraceLevel TraceLevel Int32
    public partial class MemoryTraceWriter : DataModel
    {
        public TraceLevel                               LevelFilter                             { get; set; }

        public static MemoryTraceWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryTraceWriter() { Pointer= p0 };

            value.LevelFilter                               = (TraceLevel)GetInt32(new IntPtr(p + 0x020)); // 0246687EBC18 0x20 LevelFilter                 ( 000186698940 ModelEnumType TraceLevel TraceLevel TraceLevel Int32 )

            return value;
        }
    }
}
