using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  00018665D9F0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 000 MaxValue                                 sbyte IL2CPP_TYPE_I1
    // 000 MinValue                                 sbyte IL2CPP_TYPE_I1
    public partial class SByte
    {
        public sbyte                                    M_value                                 { get; set; }

        public static SByte? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SByte();

            value.M_value                                   = GetSByte(new IntPtr(p + 0x010)); // 0270033EC5C0 0x10 M_value                     ( 00018665D9F0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
