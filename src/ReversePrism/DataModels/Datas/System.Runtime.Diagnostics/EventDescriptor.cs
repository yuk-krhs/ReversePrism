using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_id                                     000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 M_version                                00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_channel                                00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_level                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 M_opcode                                 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 M_task                                   000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 M_keywords                               0001865F7700 ModelPrimitiveType long long long Int64
    public partial class EventDescriptor : DataModel
    {
        public ushort                                   M_id                                    { get; set; }
        public sbyte                                    M_version                               { get; set; }
        public sbyte                                    M_channel                               { get; set; }
        public sbyte                                    M_level                                 { get; set; }
        public sbyte                                    M_opcode                                { get; set; }
        public ushort                                   M_task                                  { get; set; }
        public long                                     M_keywords                              { get; set; }

        public static EventDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventDescriptor() { Pointer= p0 };

            value.M_id                                      = GetUInt16(new IntPtr(p + 0x010)); // 0245A4D35FA8 0x10 M_id                        ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_version                                 = GetSByte(new IntPtr(p + 0x012)); // 0245A4D35FC8 0x12 M_version                   ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_channel                                 = GetSByte(new IntPtr(p + 0x013)); // 0245A4D35FE8 0x13 M_channel                   ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_level                                   = GetSByte(new IntPtr(p + 0x014)); // 0245A4D36008 0x14 M_level                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_opcode                                  = GetSByte(new IntPtr(p + 0x015)); // 0245A4D36028 0x15 M_opcode                    ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_task                                    = GetUInt16(new IntPtr(p + 0x016)); // 0245A4D36048 0x16 M_task                      ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_keywords                                = GetInt64(new IntPtr(p + 0x018)); // 0245A4D36068 0x18 M_keywords                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
