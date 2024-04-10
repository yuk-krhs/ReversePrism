using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Oid                                      000186671910 ModelPrimitiveType string string string String
    // 018 AttrValue                                000186671910 ModelPrimitiveType string string string String
    // 020 UpperBound                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Encoding                                 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class AttributeTypeAndValue : DataModel
    {
        public string                                   Oid                                     { get; set; }
        public string                                   AttrValue                               { get; set; }
        public int                                      UpperBound                              { get; set; }
        public sbyte                                    Encoding                                { get; set; }

        public static AttributeTypeAndValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeTypeAndValue() { Pointer= p0 };

            value.Oid                                       = GetString(new IntPtr(p + 0x010)); // 02466B40A400 0x10 Oid                         ( 000186671910 ModelPrimitiveType string string string String )
            value.AttrValue                                 = GetString(new IntPtr(p + 0x018)); // 02466B40A420 0x18 AttrValue                   ( 000186671910 ModelPrimitiveType string string string String )
            value.UpperBound                                = GetInt32(new IntPtr(p + 0x020)); // 02466B40A440 0x20 UpperBound                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Encoding                                  = GetSByte(new IntPtr(p + 0x024)); // 02466B40A460 0x24 Encoding                    ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
