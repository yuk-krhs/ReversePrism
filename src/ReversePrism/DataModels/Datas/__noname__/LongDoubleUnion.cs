using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LongValue                                ModelPrimitiveType long long long Int64
    // 010 DoubleValue                              ModelPrimitiveType double double double Double
    public partial class LongDoubleUnion : DataModel
    {
        public long                                     LongValue                               { get; set; }
        public double                                   DoubleValue                             { get; set; }

        public static LongDoubleUnion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LongDoubleUnion() { Pointer= p0 };

            value.LongValue                                 = GetInt64(new IntPtr(p + 0x010)); // 0x10 LongValue                   ( ModelPrimitiveType long long long Int64 )
            value.DoubleValue                               = GetDouble(new IntPtr(p + 0x010)); // 0x10 DoubleValue                 ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
