using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OnWin32                                  bool IL2CPP_TYPE_BOOLEAN
    // 008 MonoTracePrefix                          string IL2CPP_TYPE_STRING
    // 010 MonoTraceFile                            0001866738F0 ModelPrimitiveType string string string String
    // 038 LogFileName                              000186671910 ModelPrimitiveType string string string String
    public partial class DefaultTraceListener
    {
        public string                                   MonoTraceFile                           { get; set; }
        public string                                   LogFileName                             { get; set; }

        public static DefaultTraceListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultTraceListener();

            value.MonoTraceFile                             = GetString(new IntPtr(p + 0x010)); // 027004D01CF8 0x10 MonoTraceFile               ( 0001866738F0 ModelPrimitiveType string string string String )
            value.LogFileName                               = GetString(new IntPtr(p + 0x038)); // 027004D01D18 0x38 LogFileName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
