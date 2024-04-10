using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 utf8MaxLengthInBytes                     ushort IL2CPP_TYPE_U2
    // 010 Utf8LengthInBytes                        000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Bytes                                    00018659B340 ModelEnumType FixedBytes126 FixedBytes126 FixedBytes126 Int32
    public partial class FixedString128Bytes : DataModel
    {
        public ushort                                   Utf8LengthInBytes                       { get; set; }
        public FixedBytes126                            Bytes                                   { get; set; }

        public static FixedString128Bytes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedString128Bytes() { Pointer= p0 };

            value.Utf8LengthInBytes                         = GetUInt16(new IntPtr(p + 0x010)); // 02466990FDA0 0x10 Utf8LengthInBytes           ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Bytes                                     = (FixedBytes126)GetInt32(new IntPtr(p + 0x012)); // 02466990FDC0 0x12 Bytes                       ( 00018659B340 ModelEnumType FixedBytes126 FixedBytes126 FixedBytes126 Int32 )

            return value;
        }
    }
}
