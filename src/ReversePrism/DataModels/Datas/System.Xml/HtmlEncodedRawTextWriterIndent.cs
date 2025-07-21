using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0F0 IndentLevel                              ModelPrimitiveType int int int Int32
    // 0F4 EndBlockPos                              ModelPrimitiveType int int int Int32
    // 0F8 IndentChars                              ModelPrimitiveType string string string String
    // 100 NewLineOnAttributes                      ModelPrimitiveType bool bool bool Bool
    public partial class HtmlEncodedRawTextWriterIndent : DataModel
    {
        public int                                      IndentLevel                             { get; set; }
        public int                                      EndBlockPos                             { get; set; }
        public string                                   IndentChars                             { get; set; }
        public bool                                     NewLineOnAttributes                     { get; set; }

        public static HtmlEncodedRawTextWriterIndent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HtmlEncodedRawTextWriterIndent() { Pointer= p0 };

            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 IndentLevel                 ( ModelPrimitiveType int int int Int32 )
            value.EndBlockPos                               = GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 EndBlockPos                 ( ModelPrimitiveType int int int Int32 )
            value.IndentChars                               = GetString(new IntPtr(p + 0x0F8)); // 0xF8 IndentChars                 ( ModelPrimitiveType string string string String )
            value.NewLineOnAttributes                       = GetBool(new IntPtr(p + 0x100)); // 0x100 NewLineOnAttributes         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
