using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32
    // 01C C1                                       0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32
    // 028 C2                                       0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32
    // 034 C3                                       0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32
    // 000 zero                                     uint3x4 IL2CPP_TYPE_VALUETYPE
    public partial class uint3x4
    {
        public uint3                                    C0                                      { get; set; }
        public uint3                                    C1                                      { get; set; }
        public uint3                                    C2                                      { get; set; }
        public uint3                                    C3                                      { get; set; }

        public static uint3x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint3x4();

            value.C0                                        = (uint3)GetInt32(new IntPtr(p + 0x010)); // 0270D7E7C2A8 0x10 C0                          ( 0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32 )
            value.C1                                        = (uint3)GetInt32(new IntPtr(p + 0x01C)); // 0270D7E7C2C8 0x1C C1                          ( 0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32 )
            value.C2                                        = (uint3)GetInt32(new IntPtr(p + 0x028)); // 0270D7E7C2E8 0x28 C2                          ( 0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32 )
            value.C3                                        = (uint3)GetInt32(new IntPtr(p + 0x034)); // 0270D7E7C308 0x34 C3                          ( 0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32 )

            return value;
        }
    }
}
