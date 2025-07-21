using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 F0                                       ModelPrimitiveType long long long Int64
    // 018 F1                                       ModelPrimitiveType long long long Int64
    // 020 F2                                       ModelPrimitiveType long long long Int64
    // 028 F3                                       ModelPrimitiveType long long long Int64
    // 030 F4                                       ModelPrimitiveType long long long Int64
    // 038 F5                                       ModelPrimitiveType long long long Int64
    // 040 F6                                       ModelPrimitiveType long long long Int64
    // 048 F7                                       ModelPrimitiveType long long long Int64
    public partial class Long8 : DataModel
    {
        public long                                     F0                                      { get; set; }
        public long                                     F1                                      { get; set; }
        public long                                     F2                                      { get; set; }
        public long                                     F3                                      { get; set; }
        public long                                     F4                                      { get; set; }
        public long                                     F5                                      { get; set; }
        public long                                     F6                                      { get; set; }
        public long                                     F7                                      { get; set; }

        public static Long8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Long8() { Pointer= p0 };

            value.F0                                        = GetInt64(new IntPtr(p + 0x010)); // 0x10 F0                          ( ModelPrimitiveType long long long Int64 )
            value.F1                                        = GetInt64(new IntPtr(p + 0x018)); // 0x18 F1                          ( ModelPrimitiveType long long long Int64 )
            value.F2                                        = GetInt64(new IntPtr(p + 0x020)); // 0x20 F2                          ( ModelPrimitiveType long long long Int64 )
            value.F3                                        = GetInt64(new IntPtr(p + 0x028)); // 0x28 F3                          ( ModelPrimitiveType long long long Int64 )
            value.F4                                        = GetInt64(new IntPtr(p + 0x030)); // 0x30 F4                          ( ModelPrimitiveType long long long Int64 )
            value.F5                                        = GetInt64(new IntPtr(p + 0x038)); // 0x38 F5                          ( ModelPrimitiveType long long long Int64 )
            value.F6                                        = GetInt64(new IntPtr(p + 0x040)); // 0x40 F6                          ( ModelPrimitiveType long long long Int64 )
            value.F7                                        = GetInt64(new IntPtr(p + 0x048)); // 0x48 F7                          ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
