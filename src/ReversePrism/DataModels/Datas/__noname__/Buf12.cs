using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 U0                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 U1                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 U2                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 010 Ulo64LE                                  00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 014 Uhigh64LE                                00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class Buf12
    {
        public uint                                     U0                                      { get; set; }
        public uint                                     U1                                      { get; set; }
        public uint                                     U2                                      { get; set; }
        public ulong                                    Ulo64LE                                 { get; set; }
        public ulong                                    Uhigh64LE                               { get; set; }

        public static Buf12? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Buf12();

            value.U0                                        = GetUInt32(new IntPtr(p + 0x010)); // 0270D6AC1B70 0x10 U0                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.U1                                        = GetUInt32(new IntPtr(p + 0x014)); // 0270D6AC1B90 0x14 U1                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.U2                                        = GetUInt32(new IntPtr(p + 0x018)); // 0270D6AC1BB0 0x18 U2                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Ulo64LE                                   = GetUInt64(new IntPtr(p + 0x010)); // 0270D6AC1BD0 0x10 Ulo64LE                     ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Uhigh64LE                                 = GetUInt64(new IntPtr(p + 0x014)); // 0270D6AC1BF0 0x14 Uhigh64LE                   ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
