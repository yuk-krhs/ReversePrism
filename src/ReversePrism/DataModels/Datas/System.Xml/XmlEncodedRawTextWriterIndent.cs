using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 IndentLevel                              ModelPrimitiveType int int int Int32
    // 0C4 NewLineOnAttributes                      ModelPrimitiveType bool bool bool Bool
    // 0C8 IndentChars                              ModelPrimitiveType string string string String
    // 0D0 MixedContent                             ModelPrimitiveType bool bool bool Bool
    // 0D8 MixedContentStack                        ModelClassType BitStack BitStack BitStack Pointer
    // 0E0 ConformanceLevel                         ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    public partial class XmlEncodedRawTextWriterIndent : DataModel
    {
        public int                                      IndentLevel                             { get; set; }
        public bool                                     NewLineOnAttributes                     { get; set; }
        public string                                   IndentChars                             { get; set; }
        public bool                                     MixedContent                            { get; set; }
        public BitStack?                                MixedContentStack                       { get; set; }
        public ConformanceLevel                         ConformanceLevel                        { get; set; }

        public static XmlEncodedRawTextWriterIndent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlEncodedRawTextWriterIndent() { Pointer= p0 };

            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 IndentLevel                 ( ModelPrimitiveType int int int Int32 )
            value.NewLineOnAttributes                       = GetBool(new IntPtr(p + 0x0C4)); // 0xC4 NewLineOnAttributes         ( ModelPrimitiveType bool bool bool Bool )
            value.IndentChars                               = GetString(new IntPtr(p + 0x0C8)); // 0xC8 IndentChars                 ( ModelPrimitiveType string string string String )
            value.MixedContent                              = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 MixedContent                ( ModelPrimitiveType bool bool bool Bool )
            value.MixedContentStack                         = GetObject<BitStack>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.BitStack.FromPointer); // 0xD8 MixedContentStack           ( ModelClassType BitStack BitStack BitStack Pointer )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 ConformanceLevel            ( ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )

            return value;
        }
    }
}
