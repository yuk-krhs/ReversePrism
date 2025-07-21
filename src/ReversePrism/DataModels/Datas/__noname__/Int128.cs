using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hi                                       ModelPrimitiveType long long long Int64
    // 018 Lo                                       ModelPrimitiveType ulong ulong ulong UInt64
    public partial class Int128 : DataModel
    {
        public long                                     Hi                                      { get; set; }
        public ulong                                    Lo                                      { get; set; }

        public static Int128? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int128() { Pointer= p0 };

            value.Hi                                        = GetInt64(new IntPtr(p + 0x010)); // 0x10 Hi                          ( ModelPrimitiveType long long long Int64 )
            value.Lo                                        = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Lo                          ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
