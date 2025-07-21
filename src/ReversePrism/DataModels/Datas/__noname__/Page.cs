using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Y                                        ModelPrimitiveType ushort ushort ushort UInt16
    // 014 FreeSlots                                ModelPrimitiveType int int int Int32
    public partial class Page : DataModel
    {
        public ushort                                   X                                       { get; set; }
        public ushort                                   Y                                       { get; set; }
        public int                                      FreeSlots                               { get; set; }

        public static Page? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Page() { Pointer= p0 };

            value.X                                         = GetUInt16(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Y                                         = GetUInt16(new IntPtr(p + 0x012)); // 0x12 Y                           ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.FreeSlots                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 FreeSlots                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
