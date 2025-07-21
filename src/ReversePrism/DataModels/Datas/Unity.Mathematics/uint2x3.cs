using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType uint2 uint2 uint2 Int32
    // 018 C1                                       ModelEnumType uint2 uint2 uint2 Int32
    // 020 C2                                       ModelEnumType uint2 uint2 uint2 Int32
    // 000 zero                                     uint2x3 IL2CPP_TYPE_VALUETYPE
    public partial class uint2x3 : DataModel
    {
        public uint2                                    C0                                      { get; set; }
        public uint2                                    C1                                      { get; set; }
        public uint2                                    C2                                      { get; set; }

        public static uint2x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint2x3() { Pointer= p0 };

            value.C0                                        = (uint2)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType uint2 uint2 uint2 Int32 )
            value.C1                                        = (uint2)GetInt32(new IntPtr(p + 0x018)); // 0x18 C1                          ( ModelEnumType uint2 uint2 uint2 Int32 )
            value.C2                                        = (uint2)GetInt32(new IntPtr(p + 0x020)); // 0x20 C2                          ( ModelEnumType uint2 uint2 uint2 Int32 )

            return value;
        }
    }
}
