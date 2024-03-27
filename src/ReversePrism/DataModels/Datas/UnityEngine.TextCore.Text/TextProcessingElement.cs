using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementType                              000186644160 ModelEnumType TextProcessingElementType TextProcessingElementType TextProcessingElementType Int32
    // 014 Unicode                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 StringIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Length                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TextProcessingElement
    {
        public TextProcessingElementType                ElementType                             { get; set; }
        public uint                                     Unicode                                 { get; set; }
        public int                                      StringIndex                             { get; set; }
        public int                                      Length                                  { get; set; }

        public static TextProcessingElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextProcessingElement();

            value.ElementType                               = (TextProcessingElementType)GetInt32(new IntPtr(p + 0x010)); // 0270068F9578 0x10 ElementType                 ( 000186644160 ModelEnumType TextProcessingElementType TextProcessingElementType TextProcessingElementType Int32 )
            value.Unicode                                   = GetUInt32(new IntPtr(p + 0x014)); // 0270068F9598 0x14 Unicode                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.StringIndex                               = GetInt32(new IntPtr(p + 0x018)); // 0270068F95B8 0x18 StringIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270068F95D8 0x1C Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
