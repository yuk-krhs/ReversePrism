using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 000 MaxValue                                 sbyte IL2CPP_TYPE_U1
    // 000 MinValue                                 sbyte IL2CPP_TYPE_U1
    public partial class Byte : DataModel
    {
        public sbyte                                    M_value                                 { get; set; }

        public static Byte? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Byte() { Pointer= p0 };

            value.M_value                                   = GetSByte(new IntPtr(p + 0x010)); // 0245A1545D00 0x10 M_value                     ( 00018659D3E0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
