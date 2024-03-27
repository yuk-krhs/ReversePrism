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
    // 012 Bytes                                    00018659C690 ModelEnumType FixedBytes30 FixedBytes30 FixedBytes30 Int32
    public partial class FixedString32Bytes
    {
        public ushort                                   Utf8LengthInBytes                       { get; set; }
        public FixedBytes30                             Bytes                                   { get; set; }

        public static FixedString32Bytes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedString32Bytes();

            value.Utf8LengthInBytes                         = GetUInt16(new IntPtr(p + 0x010)); // 0270D98A61C8 0x10 Utf8LengthInBytes           ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Bytes                                     = (FixedBytes30)GetInt32(new IntPtr(p + 0x012)); // 0270D98A61E8 0x12 Bytes                       ( 00018659C690 ModelEnumType FixedBytes30 FixedBytes30 FixedBytes30 Int32 )

            return value;
        }
    }
}
