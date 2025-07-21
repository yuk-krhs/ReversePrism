using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementType                              ModelEnumType TextProcessingElementType TextProcessingElementType TextProcessingElementType Int32
    // 014 Unicode                                  ModelPrimitiveType uint uint uint UInt32
    // 018 StringIndex                              ModelPrimitiveType int int int Int32
    // 01C Length                                   ModelPrimitiveType int int int Int32
    public partial class TextProcessingElement : DataModel
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
            var value   = new TextProcessingElement() { Pointer= p0 };

            value.ElementType                               = (TextProcessingElementType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ElementType                 ( ModelEnumType TextProcessingElementType TextProcessingElementType TextProcessingElementType Int32 )
            value.Unicode                                   = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Unicode                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.StringIndex                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 StringIndex                 ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
