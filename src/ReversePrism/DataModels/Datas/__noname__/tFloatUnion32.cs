using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_floatingPoint                          000186666050 ModelPrimitiveType float float float Single
    // 010 M_integer                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class tFloatUnion32 : DataModel
    {
        public float                                    M_floatingPoint                         { get; set; }
        public uint                                     M_integer                               { get; set; }

        public static tFloatUnion32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new tFloatUnion32() { Pointer= p0 };

            value.M_floatingPoint                           = GetSingle(new IntPtr(p + 0x010)); // 02466A90FAF8 0x10 M_floatingPoint             ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_integer                                 = GetUInt32(new IntPtr(p + 0x010)); // 02466A90FB18 0x10 M_integer                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
