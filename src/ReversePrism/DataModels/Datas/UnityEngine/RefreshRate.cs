using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Numerator                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Denominator                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class RefreshRate
    {
        public uint                                     Numerator                               { get; set; }
        public uint                                     Denominator                             { get; set; }

        public static RefreshRate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RefreshRate();

            value.Numerator                                 = GetUInt32(new IntPtr(p + 0x010)); // 027002485FC0 0x10 Numerator                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Denominator                               = GetUInt32(new IntPtr(p + 0x014)); // 027002485FE0 0x14 Denominator                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
