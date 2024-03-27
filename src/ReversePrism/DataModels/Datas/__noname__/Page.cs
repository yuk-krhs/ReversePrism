using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Y                                        000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 FreeSlots                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Page
    {
        public ushort                                   X                                       { get; set; }
        public ushort                                   Y                                       { get; set; }
        public int                                      FreeSlots                               { get; set; }

        public static Page? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Page();

            value.X                                         = GetUInt16(new IntPtr(p + 0x010)); // 02700687C7F8 0x10 X                           ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Y                                         = GetUInt16(new IntPtr(p + 0x012)); // 02700687C818 0x12 Y                           ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.FreeSlots                                 = GetInt32(new IntPtr(p + 0x014)); // 02700687C838 0x14 FreeSlots                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
