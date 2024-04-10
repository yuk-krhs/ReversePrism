using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndBitOffset                             000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 LeftChildIndex                           0001865F1520 ModelPrimitiveType short short short Int16
    // 014 ControlStartIndex                        000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 ControlCount                             00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class ControlBitRangeNode : DataModel
    {
        public ushort                                   EndBitOffset                            { get; set; }
        public short                                    LeftChildIndex                          { get; set; }
        public ushort                                   ControlStartIndex                       { get; set; }
        public sbyte                                    ControlCount                            { get; set; }

        public static ControlBitRangeNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlBitRangeNode() { Pointer= p0 };

            value.EndBitOffset                              = GetUInt16(new IntPtr(p + 0x010)); // 0245A01DF660 0x10 EndBitOffset                ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.LeftChildIndex                            = GetInt16(new IntPtr(p + 0x012)); // 0245A01DF680 0x12 LeftChildIndex              ( 0001865F1520 ModelPrimitiveType short short short Int16 )
            value.ControlStartIndex                         = GetUInt16(new IntPtr(p + 0x014)); // 0245A01DF6A0 0x14 ControlStartIndex           ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.ControlCount                              = GetSByte(new IntPtr(p + 0x016)); // 0245A01DF6C0 0x16 ControlCount                ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
