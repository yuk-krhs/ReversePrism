using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  0001865F1780 ModelPrimitiveType short short short Int16
    // 000 MaxValue                                 short IL2CPP_TYPE_I2
    // 000 MinValue                                 short IL2CPP_TYPE_I2
    public partial class Int16
    {
        public short                                    M_value                                 { get; set; }

        public static Int16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Int16();

            value.M_value                                   = GetInt16(new IntPtr(p + 0x010)); // 0270033E9FB8 0x10 M_value                     ( 0001865F1780 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
