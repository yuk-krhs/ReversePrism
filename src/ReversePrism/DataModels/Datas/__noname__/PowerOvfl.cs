using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hi                                       000186699EB0 ModelPrimitiveType uint uint uint UInt32
    // 018 MidLo                                    00018669C740 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class PowerOvfl
    {
        public uint                                     Hi                                      { get; set; }
        public ulong                                    MidLo                                   { get; set; }

        public static PowerOvfl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PowerOvfl();

            value.Hi                                        = GetUInt32(new IntPtr(p + 0x010)); // 0270D6AC1AB8 0x10 Hi                          ( 000186699EB0 ModelPrimitiveType uint uint uint UInt32 )
            value.MidLo                                     = GetUInt64(new IntPtr(p + 0x018)); // 0270D6AC1AD8 0x18 MidLo                       ( 00018669C740 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
