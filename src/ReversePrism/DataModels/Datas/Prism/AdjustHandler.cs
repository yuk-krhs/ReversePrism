using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Environment                              ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32
    // 024 LogLevel                                 ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32
    public partial class AdjustHandler : DataModel
    {
        public AdjustEnvironment                        Environment                             { get; set; }
        public AdjustLogLevel                           LogLevel                                { get; set; }

        public static AdjustHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustHandler() { Pointer= p0 };

            value.Environment                               = (AdjustEnvironment)GetInt32(new IntPtr(p + 0x020)); // 0x20 Environment                 ( ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32 )
            value.LogLevel                                  = (AdjustLogLevel)GetInt32(new IntPtr(p + 0x024)); // 0x24 LogLevel                    ( ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32 )

            return value;
        }
    }
}
