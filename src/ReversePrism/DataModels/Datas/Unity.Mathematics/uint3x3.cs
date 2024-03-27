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
    // 000 identity                                 uint3x3 IL2CPP_TYPE_VALUETYPE
    // 024 Zero                                     0001865F6390 ModelEnumType uint3x3 uint3x3 uint3x3 Int32
    public partial class uint3x3
    {
        public uint3                                    C0                                      { get; set; }
        public uint3                                    C1                                      { get; set; }
        public uint3                                    C2                                      { get; set; }
        public uint3x3                                  Zero                                    { get; set; }

        public static uint3x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint3x3();

            value.C0                                        = (uint3)GetInt32(new IntPtr(p + 0x010)); // 0270015D4A70 0x10 C0                          ( 0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32 )
            value.C1                                        = (uint3)GetInt32(new IntPtr(p + 0x01C)); // 0270015D4A90 0x1C C1                          ( 0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32 )
            value.C2                                        = (uint3)GetInt32(new IntPtr(p + 0x028)); // 0270015D4AB0 0x28 C2                          ( 0001866CAF20 ModelEnumType uint3 uint3 uint3 Int32 )
            value.Zero                                      = (uint3x3)GetInt32(new IntPtr(p + 0x024)); // 0270015D4AF0 0x24 Zero                        ( 0001865F6390 ModelEnumType uint3x3 uint3x3 uint3x3 Int32 )

            return value;
        }
    }
}
