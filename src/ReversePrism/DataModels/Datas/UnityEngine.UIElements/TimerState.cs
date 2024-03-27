using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Now                                      0001865F7700 ModelPrimitiveType long long long Int64
    public partial class TimerState
    {
        public long                                     Start                                   { get; set; }
        public long                                     Now                                     { get; set; }

        public static TimerState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerState();

            value.Start                                     = GetInt64(new IntPtr(p + 0x010)); // 0270067E9F40 0x10 Start                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Now                                       = GetInt64(new IntPtr(p + 0x018)); // 0270067E9F60 0x18 Now                         ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
