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
    // 012 Bytes                                    00018659E410 ModelEnumType FixedBytes62 FixedBytes62 FixedBytes62 Int32
    public partial class FixedString64Bytes
    {
        public ushort                                   Utf8LengthInBytes                       { get; set; }
        public FixedBytes62                             Bytes                                   { get; set; }

        public static FixedString64Bytes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedString64Bytes();

            value.Utf8LengthInBytes                         = GetUInt16(new IntPtr(p + 0x010)); // 0270D98A8350 0x10 Utf8LengthInBytes           ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Bytes                                     = (FixedBytes62)GetInt32(new IntPtr(p + 0x012)); // 0270D98A8370 0x12 Bytes                       ( 00018659E410 ModelEnumType FixedBytes62 FixedBytes62 FixedBytes62 Int32 )

            return value;
        }
    }
}
