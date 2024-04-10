using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  0001865F8300 ModelPrimitiveType long long long Int64
    // 000 MaxValue                                 long IL2CPP_TYPE_I8
    // 000 MinValue                                 long IL2CPP_TYPE_I8
    public partial class Int64 : DataModel
    {
        public long                                     M_value                                 { get; set; }

        public static Int64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int64() { Pointer= p0 };

            value.M_value                                   = GetInt64(new IntPtr(p + 0x010)); // 0245A3564BF8 0x10 M_value                     ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
