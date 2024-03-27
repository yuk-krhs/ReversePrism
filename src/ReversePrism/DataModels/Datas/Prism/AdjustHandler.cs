using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Environment                              00018668EC50 ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32
    // 024 LogLevel                                 0001866904D0 ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32
    public partial class AdjustHandler
    {
        public AdjustEnvironment                        Environment                             { get; set; }
        public AdjustLogLevel                           LogLevel                                { get; set; }

        public static AdjustHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustHandler();

            value.Environment                               = (AdjustEnvironment)GetInt32(new IntPtr(p + 0x020)); // 027004375BB0 0x20 Environment                 ( 00018668EC50 ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32 )
            value.LogLevel                                  = (AdjustLogLevel)GetInt32(new IntPtr(p + 0x024)); // 027004375BD0 0x24 LogLevel                    ( 0001866904D0 ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32 )

            return value;
        }
    }
}
