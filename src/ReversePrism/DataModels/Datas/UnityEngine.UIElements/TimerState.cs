using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType long long long Int64
    // 018 Now                                      ModelPrimitiveType long long long Int64
    public partial class TimerState : DataModel
    {
        public long                                     Start                                   { get; set; }
        public long                                     Now                                     { get; set; }

        public static TimerState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerState() { Pointer= p0 };

            value.Start                                     = GetInt64(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType long long long Int64 )
            value.Now                                       = GetInt64(new IntPtr(p + 0x018)); // 0x18 Now                         ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
