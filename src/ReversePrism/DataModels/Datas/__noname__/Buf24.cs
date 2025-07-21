using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 U0                                       ModelPrimitiveType uint uint uint UInt32
    // 014 U1                                       ModelPrimitiveType uint uint uint UInt32
    // 018 U2                                       ModelPrimitiveType uint uint uint UInt32
    // 01C U3                                       ModelPrimitiveType uint uint uint UInt32
    // 020 U4                                       ModelPrimitiveType uint uint uint UInt32
    // 024 U5                                       ModelPrimitiveType uint uint uint UInt32
    // 010 Ulo64LE                                  ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Umid64LE                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 Uhigh64LE                                ModelPrimitiveType ulong ulong ulong UInt64
    public partial class Buf24 : DataModel
    {
        public uint                                     U0                                      { get; set; }
        public uint                                     U1                                      { get; set; }
        public uint                                     U2                                      { get; set; }
        public uint                                     U3                                      { get; set; }
        public uint                                     U4                                      { get; set; }
        public uint                                     U5                                      { get; set; }
        public ulong                                    Ulo64LE                                 { get; set; }
        public ulong                                    Umid64LE                                { get; set; }
        public ulong                                    Uhigh64LE                               { get; set; }

        public static Buf24? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Buf24() { Pointer= p0 };

            value.U0                                        = GetUInt32(new IntPtr(p + 0x010)); // 0x10 U0                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.U1                                        = GetUInt32(new IntPtr(p + 0x014)); // 0x14 U1                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.U2                                        = GetUInt32(new IntPtr(p + 0x018)); // 0x18 U2                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.U3                                        = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C U3                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.U4                                        = GetUInt32(new IntPtr(p + 0x020)); // 0x20 U4                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.U5                                        = GetUInt32(new IntPtr(p + 0x024)); // 0x24 U5                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.Ulo64LE                                   = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Ulo64LE                     ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Umid64LE                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Umid64LE                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Uhigh64LE                                 = GetUInt64(new IntPtr(p + 0x020)); // 0x20 Uhigh64LE                   ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
