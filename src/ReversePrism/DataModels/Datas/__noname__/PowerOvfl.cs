using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hi                                       ModelPrimitiveType uint uint uint UInt32
    // 018 MidLo                                    ModelPrimitiveType ulong ulong ulong UInt64
    public partial class PowerOvfl : DataModel
    {
        public uint                                     Hi                                      { get; set; }
        public ulong                                    MidLo                                   { get; set; }

        public static PowerOvfl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PowerOvfl() { Pointer= p0 };

            value.Hi                                        = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Hi                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.MidLo                                     = GetUInt64(new IntPtr(p + 0x018)); // 0x18 MidLo                       ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
