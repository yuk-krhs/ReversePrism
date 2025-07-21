using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_floatingPoint                          ModelPrimitiveType double double double Double
    // 010 M_integer                                ModelPrimitiveType ulong ulong ulong UInt64
    public partial class tFloatUnion64 : DataModel
    {
        public double                                   M_floatingPoint                         { get; set; }
        public ulong                                    M_integer                               { get; set; }

        public static tFloatUnion64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new tFloatUnion64() { Pointer= p0 };

            value.M_floatingPoint                           = GetDouble(new IntPtr(p + 0x010)); // 0x10 M_floatingPoint             ( ModelPrimitiveType double double double Double )
            value.M_integer                                 = GetUInt64(new IntPtr(p + 0x010)); // 0x10 M_integer                   ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
