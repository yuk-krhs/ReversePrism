using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32
    // 018 C1                                       0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32
    // 020 C2                                       0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32
    // 028 C3                                       0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32
    // 000 zero                                     uint2x4 IL2CPP_TYPE_VALUETYPE
    public partial class uint2x4 : DataModel
    {
        public uint2                                    C0                                      { get; set; }
        public uint2                                    C1                                      { get; set; }
        public uint2                                    C2                                      { get; set; }
        public uint2                                    C3                                      { get; set; }

        public static uint2x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint2x4() { Pointer= p0 };

            value.C0                                        = (uint2)GetInt32(new IntPtr(p + 0x010)); // 024667ECF6D0 0x10 C0                          ( 0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32 )
            value.C1                                        = (uint2)GetInt32(new IntPtr(p + 0x018)); // 024667ECF6F0 0x18 C1                          ( 0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32 )
            value.C2                                        = (uint2)GetInt32(new IntPtr(p + 0x020)); // 024667ECF710 0x20 C2                          ( 0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32 )
            value.C3                                        = (uint2)GetInt32(new IntPtr(p + 0x028)); // 024667ECF730 0x28 C3                          ( 0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32 )

            return value;
        }
    }
}
