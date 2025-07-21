using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CodePage                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 UiFamilyCodePage                         ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Flags                                    ModelPrimitiveType uint uint uint UInt32
    // 018 Names                                    ModelPrimitiveType string string string String
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

            value.CodePage                                  = GetUInt16(new IntPtr(p + 0x010)); // 0x10 CodePage                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UiFamilyCodePage                          = GetUInt16(new IntPtr(p + 0x012)); // 0x12 UiFamilyCodePage            ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Flags                                     = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Flags                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Names                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Names                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
