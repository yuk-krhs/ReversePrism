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
    // 012 Bytes                                    00018659DA80 ModelEnumType FixedBytes510 FixedBytes510 FixedBytes510 Int32
    public partial class FixedString512Bytes
    {
        public ushort                                   Utf8LengthInBytes                       { get; set; }
        public FixedBytes510                            Bytes                                   { get; set; }

        public static FixedString512Bytes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedString512Bytes();

            value.Utf8LengthInBytes                         = GetUInt16(new IntPtr(p + 0x010)); // 0270D98AC228 0x10 Utf8LengthInBytes           ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Bytes                                     = (FixedBytes510)GetInt32(new IntPtr(p + 0x012)); // 0270D98AC248 0x12 Bytes                       ( 00018659DA80 ModelEnumType FixedBytes510 FixedBytes510 FixedBytes510 Int32 )

            return value;
        }
    }
}
