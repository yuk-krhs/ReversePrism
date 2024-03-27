using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flags                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 High                                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Low                                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C Mid                                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class MutableDecimal
    {
        public uint                                     Flags                                   { get; set; }
        public uint                                     High                                    { get; set; }
        public uint                                     Low                                     { get; set; }
        public uint                                     Mid                                     { get; set; }

        public static MutableDecimal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MutableDecimal();

            value.Flags                                     = GetUInt32(new IntPtr(p + 0x010)); // 0270D6A32638 0x10 Flags                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.High                                      = GetUInt32(new IntPtr(p + 0x014)); // 0270D6A32658 0x14 High                        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Low                                       = GetUInt32(new IntPtr(p + 0x018)); // 0270D6A32678 0x18 Low                         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Mid                                       = GetUInt32(new IntPtr(p + 0x01C)); // 0270D6A32698 0x1C Mid                         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
