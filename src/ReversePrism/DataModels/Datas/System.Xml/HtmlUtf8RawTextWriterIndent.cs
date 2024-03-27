using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 IndentLevel                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C4 EndBlockPos                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C8 IndentChars                              000186671910 ModelPrimitiveType string string string String
    // 0D0 NewLineOnAttributes                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HtmlUtf8RawTextWriterIndent
    {
        public int                                      IndentLevel                             { get; set; }
        public int                                      EndBlockPos                             { get; set; }
        public string                                   IndentChars                             { get; set; }
        public bool                                     NewLineOnAttributes                     { get; set; }

        public static HtmlUtf8RawTextWriterIndent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HtmlUtf8RawTextWriterIndent();

            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x0C0)); // 0270D736CF60 0xC0 IndentLevel                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndBlockPos                               = GetInt32(new IntPtr(p + 0x0C4)); // 0270D736CF80 0xC4 EndBlockPos                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IndentChars                               = GetString(new IntPtr(p + 0x0C8)); // 0270D736CFA0 0xC8 IndentChars                 ( 000186671910 ModelPrimitiveType string string string String )
            value.NewLineOnAttributes                       = GetBool(new IntPtr(p + 0x0D0)); // 0270D736CFC0 0xD0 NewLineOnAttributes         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
