using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType StyleSyntaxTokenType StyleSyntaxTokenType StyleSyntaxTokenType Int32
    // 018 Text                                     ModelPrimitiveType string string string String
    // 020 Number                                   ModelPrimitiveType int int int Int32
    public partial class StyleSyntaxToken : DataModel
    {
        public StyleSyntaxTokenType                     Type                                    { get; set; }
        public string                                   Text                                    { get; set; }
        public int                                      Number                                  { get; set; }

        public static StyleSyntaxToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSyntaxToken() { Pointer= p0 };

            value.Type                                      = (StyleSyntaxTokenType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType StyleSyntaxTokenType StyleSyntaxTokenType StyleSyntaxTokenType Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Text                        ( ModelPrimitiveType string string string String )
            value.Number                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Number                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
