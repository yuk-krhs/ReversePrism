using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 000 MaxValue                                 int IL2CPP_TYPE_I4
    // 000 MinValue                                 int IL2CPP_TYPE_I4
    public partial class Int32
    {
        public int                                      M_value                                 { get; set; }

        public static Int32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int32();

            value.M_value                                   = GetInt32(new IntPtr(p + 0x010)); // 0270015389E8 0x10 M_value                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
