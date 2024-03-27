using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866CBBB0 ModelEnumType uint4 uint4 uint4 Int32
    // 020 C1                                       0001866CBBB0 ModelEnumType uint4 uint4 uint4 Int32
    // 000 zero                                     uint4x2 IL2CPP_TYPE_VALUETYPE
    public partial class uint4x2
    {
        public uint4                                    C0                                      { get; set; }
        public uint4                                    C1                                      { get; set; }

        public static uint4x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint4x2();

            value.C0                                        = (uint4)GetInt32(new IntPtr(p + 0x010)); // 0270D7E9A648 0x10 C0                          ( 0001866CBBB0 ModelEnumType uint4 uint4 uint4 Int32 )
            value.C1                                        = (uint4)GetInt32(new IntPtr(p + 0x020)); // 0270D7E9A668 0x20 C1                          ( 0001866CBBB0 ModelEnumType uint4 uint4 uint4 Int32 )

            return value;
        }
    }
}
