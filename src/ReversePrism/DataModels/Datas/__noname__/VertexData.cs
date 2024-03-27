using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Posx                                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Posy                                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Posz                                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Posw                                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 U                                        000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A V                                        000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C R0                                       00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D R1                                       00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E R2                                       00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F R3                                       00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class VertexData
    {
        public ushort                                   Posx                                    { get; set; }
        public ushort                                   Posy                                    { get; set; }
        public ushort                                   Posz                                    { get; set; }
        public ushort                                   Posw                                    { get; set; }
        public ushort                                   U                                       { get; set; }
        public ushort                                   V                                       { get; set; }
        public sbyte                                    R0                                      { get; set; }
        public sbyte                                    R1                                      { get; set; }
        public sbyte                                    R2                                      { get; set; }
        public sbyte                                    R3                                      { get; set; }

        public static VertexData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VertexData();

            value.Posx                                      = GetUInt16(new IntPtr(p + 0x010)); // 0270D4E83588 0x10 Posx                        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Posy                                      = GetUInt16(new IntPtr(p + 0x012)); // 0270D4E835A8 0x12 Posy                        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Posz                                      = GetUInt16(new IntPtr(p + 0x014)); // 0270D4E835C8 0x14 Posz                        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Posw                                      = GetUInt16(new IntPtr(p + 0x016)); // 0270D4E835E8 0x16 Posw                        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.U                                         = GetUInt16(new IntPtr(p + 0x018)); // 0270D4E83608 0x18 U                           ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.V                                         = GetUInt16(new IntPtr(p + 0x01A)); // 0270D4E83628 0x1A V                           ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.R0                                        = GetSByte(new IntPtr(p + 0x01C)); // 0270D4E83648 0x1C R0                          ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.R1                                        = GetSByte(new IntPtr(p + 0x01D)); // 0270D4E83668 0x1D R1                          ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.R2                                        = GetSByte(new IntPtr(p + 0x01E)); // 0270D4E83688 0x1E R2                          ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.R3                                        = GetSByte(new IntPtr(p + 0x01F)); // 0270D4E836A8 0x1F R3                          ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
