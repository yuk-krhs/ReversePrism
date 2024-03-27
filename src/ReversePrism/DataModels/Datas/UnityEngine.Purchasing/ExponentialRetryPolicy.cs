using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BaseRetryDelay                         0001865F4260 ModelPrimitiveType int int int Int32
    // 014 M_MaxRetryDelay                          0001865F4260 ModelPrimitiveType int int int Int32
    // 018 M_ExponentialFactor                      0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ExponentialRetryPolicy
    {
        public int                                      M_BaseRetryDelay                        { get; set; }
        public int                                      M_MaxRetryDelay                         { get; set; }
        public int                                      M_ExponentialFactor                     { get; set; }

        public static ExponentialRetryPolicy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExponentialRetryPolicy();

            value.M_BaseRetryDelay                          = GetInt32(new IntPtr(p + 0x010)); // 02700691F098 0x10 M_BaseRetryDelay            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_MaxRetryDelay                           = GetInt32(new IntPtr(p + 0x014)); // 02700691F0B8 0x14 M_MaxRetryDelay             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_ExponentialFactor                       = GetInt32(new IntPtr(p + 0x018)); // 02700691F0D8 0x18 M_ExponentialFactor         ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
