using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Free                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Paid                                     0001865F7700 ModelPrimitiveType long long long Int64
    public partial class Jewel : DataModel
    {
        public long                                     Free                                    { get; set; }
        public long                                     Paid                                    { get; set; }

        public static Jewel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Jewel() { Pointer= p0 };

            value.Free                                      = GetInt64(new IntPtr(p + 0x010)); // 0245A5F5DAA8 0x10 Free                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Paid                                      = GetInt64(new IntPtr(p + 0x018)); // 0245A5F5DAC8 0x18 Paid                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
