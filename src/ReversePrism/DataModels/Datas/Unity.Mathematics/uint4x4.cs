using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType uint4 uint4 uint4 Int32
    // 020 C1                                       ModelEnumType uint4 uint4 uint4 Int32
    // 030 C2                                       ModelEnumType uint4 uint4 uint4 Int32
    // 040 C3                                       ModelEnumType uint4 uint4 uint4 Int32
    // 000 identity                                 uint4x4 IL2CPP_TYPE_VALUETYPE
    // 040 Zero                                     ModelEnumType uint4x4 uint4x4 uint4x4 Int32
    public partial class uint4x4 : DataModel
    {
        public uint4                                    C0                                      { get; set; }
        public uint4                                    C1                                      { get; set; }
        public uint4                                    C2                                      { get; set; }
        public uint4                                    C3                                      { get; set; }
        public uint4x4                                  Zero                                    { get; set; }

        public static uint4x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint4x4() { Pointer= p0 };

            value.C0                                        = (uint4)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType uint4 uint4 uint4 Int32 )
            value.C1                                        = (uint4)GetInt32(new IntPtr(p + 0x020)); // 0x20 C1                          ( ModelEnumType uint4 uint4 uint4 Int32 )
            value.C2                                        = (uint4)GetInt32(new IntPtr(p + 0x030)); // 0x30 C2                          ( ModelEnumType uint4 uint4 uint4 Int32 )
            value.C3                                        = (uint4)GetInt32(new IntPtr(p + 0x040)); // 0x40 C3                          ( ModelEnumType uint4 uint4 uint4 Int32 )
            value.Zero                                      = (uint4x4)GetInt32(new IntPtr(p + 0x040)); // 0x40 Zero                        ( ModelEnumType uint4x4 uint4x4 uint4x4 Int32 )

            return value;
        }
    }
}
