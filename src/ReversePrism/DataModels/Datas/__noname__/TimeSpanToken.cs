using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ttt                                      ModelEnumType TTT TTT TTT Int32
    // 014 Num                                      ModelPrimitiveType int int int Int32
    // 018 Zeroes                                   ModelPrimitiveType int int int Int32
    // 020 _sep                                     ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    public partial class TimeSpanToken : DataModel
    {
        public TTT                                      Ttt                                     { get; set; }
        public int                                      Num                                     { get; set; }
        public int                                      Zeroes                                  { get; set; }

        public static TimeSpanToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanToken() { Pointer= p0 };

            value.Ttt                                       = (TTT)GetInt32(new IntPtr(p + 0x010)); // 0x10 Ttt                         ( ModelEnumType TTT TTT TTT Int32 )
            value.Num                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 Num                         ( ModelPrimitiveType int int int Int32 )
            value.Zeroes                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Zeroes                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
