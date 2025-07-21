using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 N                                        ModelPrimitiveType long long long Int64
    // 018 X                                        ModelPrimitiveType long long long Int64
    // 020 Y                                        ModelPrimitiveType long long long Int64
    // 028 D                                        ModelPrimitiveType long long long Int64
    // 030 NX                                       ModelPrimitiveType double double double Double
    // 038 NY                                       ModelPrimitiveType double double double Double
    public partial class IntPoint : DataModel
    {
        public long                                     N                                       { get; set; }
        public long                                     X                                       { get; set; }
        public long                                     Y                                       { get; set; }
        public long                                     D                                       { get; set; }
        public double                                   NX                                      { get; set; }
        public double                                   NY                                      { get; set; }

        public static IntPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntPoint() { Pointer= p0 };

            value.N                                         = GetInt64(new IntPtr(p + 0x010)); // 0x10 N                           ( ModelPrimitiveType long long long Int64 )
            value.X                                         = GetInt64(new IntPtr(p + 0x018)); // 0x18 X                           ( ModelPrimitiveType long long long Int64 )
            value.Y                                         = GetInt64(new IntPtr(p + 0x020)); // 0x20 Y                           ( ModelPrimitiveType long long long Int64 )
            value.D                                         = GetInt64(new IntPtr(p + 0x028)); // 0x28 D                           ( ModelPrimitiveType long long long Int64 )
            value.NX                                        = GetDouble(new IntPtr(p + 0x030)); // 0x30 NX                          ( ModelPrimitiveType double double double Double )
            value.NY                                        = GetDouble(new IntPtr(p + 0x038)); // 0x38 NY                          ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
