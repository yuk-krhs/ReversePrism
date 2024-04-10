using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CodePage                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 UiFamilyCodePage                         000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Flags                                    000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 Names                                    000186671BA0 ModelPrimitiveType string string string String
    public partial class InternalCodePageDataItem : DataModel
    {
        public ushort                                   CodePage                                { get; set; }
        public ushort                                   UiFamilyCodePage                        { get; set; }
        public uint                                     Flags                                   { get; set; }
        public string                                   Names                                   { get; set; }

        public static InternalCodePageDataItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalCodePageDataItem() { Pointer= p0 };

            value.CodePage                                  = GetUInt16(new IntPtr(p + 0x010)); // 0245A4C6A940 0x10 CodePage                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UiFamilyCodePage                          = GetUInt16(new IntPtr(p + 0x012)); // 0245A4C6A960 0x12 UiFamilyCodePage            ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Flags                                     = GetUInt32(new IntPtr(p + 0x014)); // 0245A4C6A980 0x14 Flags                       ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Names                                     = GetString(new IntPtr(p + 0x018)); // 0245A4C6A9A0 0x18 Names                       ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
