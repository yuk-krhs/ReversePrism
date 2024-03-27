using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ttt                                      000186606A10 ModelEnumType TTT TTT TTT Int32
    // 014 Num                                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Zeroes                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 _sep                                     ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    public partial class TimeSpanToken
    {
        public TTT                                      Ttt                                     { get; set; }
        public int                                      Num                                     { get; set; }
        public int                                      Zeroes                                  { get; set; }

        public static TimeSpanToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanToken();

            value.Ttt                                       = (TTT)GetInt32(new IntPtr(p + 0x010)); // 0270D6D33B00 0x10 Ttt                         ( 000186606A10 ModelEnumType TTT TTT TTT Int32 )
            value.Num                                       = GetInt32(new IntPtr(p + 0x014)); // 0270D6D33B20 0x14 Num                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Zeroes                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D6D33B40 0x18 Zeroes                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
