using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 IndentLevel                              0001865F3220 ModelPrimitiveType int int int Int32
    // 094 NewLineOnAttributes                      000186595480 ModelPrimitiveType bool bool bool Bool
    // 098 IndentChars                              000186671E00 ModelPrimitiveType string string string String
    // 0A0 MixedContent                             000186595480 ModelPrimitiveType bool bool bool Bool
    // 0A8 MixedContentStack                        000186763960 ModelClassType BitStack BitStack BitStack Pointer
    // 0B0 ConformanceLevel                         000186600360 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    public partial class XmlUtf8RawTextWriterIndent
    {
        public int                                      IndentLevel                             { get; set; }
        public bool                                     NewLineOnAttributes                     { get; set; }
        public string                                   IndentChars                             { get; set; }
        public bool                                     MixedContent                            { get; set; }
        public BitStack?                                MixedContentStack                       { get; set; }
        public ConformanceLevel                         ConformanceLevel                        { get; set; }

        public static XmlUtf8RawTextWriterIndent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUtf8RawTextWriterIndent();

            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x090)); // 0270D7401B00 0x90 IndentLevel                 ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.NewLineOnAttributes                       = GetBool(new IntPtr(p + 0x094)); // 0270D7401B20 0x94 NewLineOnAttributes         ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.IndentChars                               = GetString(new IntPtr(p + 0x098)); // 0270D7401B40 0x98 IndentChars                 ( 000186671E00 ModelPrimitiveType string string string String )
            value.MixedContent                              = GetBool(new IntPtr(p + 0x0A0)); // 0270D7401B60 0xA0 MixedContent                ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.MixedContentStack                         = GetObject<BitStack>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.BitStack.FromPointer); // 0270D7401B80 0xA8 MixedContentStack           ( 000186763960 ModelClassType BitStack BitStack BitStack Pointer )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x0B0)); // 0270D7401BA0 0xB0 ConformanceLevel            ( 000186600360 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )

            return value;
        }
    }
}
