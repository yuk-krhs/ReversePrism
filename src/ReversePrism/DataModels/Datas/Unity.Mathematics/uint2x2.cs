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
    // 000 identity                                 uint2x2 IL2CPP_TYPE_VALUETYPE
    // 010 Zero                                     0001865F50F0 ModelEnumType uint2x2 uint2x2 uint2x2 Int32
    public partial class uint2x2 : DataModel
    {
        public uint2                                    C0                                      { get; set; }
        public uint2                                    C1                                      { get; set; }
        public uint2x2                                  Zero                                    { get; set; }

        public static uint2x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint2x2() { Pointer= p0 };

            value.C0                                        = (uint2)GetInt32(new IntPtr(p + 0x010)); // 0245A15CF5C0 0x10 C0                          ( 0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32 )
            value.C1                                        = (uint2)GetInt32(new IntPtr(p + 0x018)); // 0245A15CF5E0 0x18 C1                          ( 0001866CA5B0 ModelEnumType uint2 uint2 uint2 Int32 )
            value.Zero                                      = (uint2x2)GetInt32(new IntPtr(p + 0x010)); // 0245A15CF620 0x10 Zero                        ( 0001865F50F0 ModelEnumType uint2x2 uint2x2 uint2x2 Int32 )

            return value;
        }
    }
}
