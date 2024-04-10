using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Tokens                                 000185D0EE78 ModelEnumListType List`1<StyleSyntaxToken> List`1<StyleSyntaxToken> List<StyleSyntaxToken> Pointer
    // 018 M_CurrentTokenIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StyleSyntaxTokenizer : DataModel
    {
        public List<StyleSyntaxToken>?                  M_Tokens                                { get; set; }
        public int                                      M_CurrentTokenIndex                     { get; set; }

        public static StyleSyntaxTokenizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSyntaxTokenizer() { Pointer= p0 };

            value.M_Tokens                                  = GetEnumList<StyleSyntaxToken>(new IntPtr(p + 0x010)); // 0245A684C870 0x10 M_Tokens                    ( 000185D0EE78 ModelEnumListType List`1<StyleSyntaxToken> List`1<StyleSyntaxToken> List<StyleSyntaxToken> Pointer )
            value.M_CurrentTokenIndex                       = GetInt32(new IntPtr(p + 0x018)); // 0245A684C890 0x18 M_CurrentTokenIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
