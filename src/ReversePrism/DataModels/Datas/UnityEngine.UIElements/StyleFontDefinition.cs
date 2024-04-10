using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Keyword                                0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    // 018 M_Value                                  0001865AEB70 ModelEnumType FontDefinition FontDefinition FontDefinition Int32
    public partial class StyleFontDefinition : DataModel
    {
        public StyleKeyword                             M_Keyword                               { get; set; }
        public FontDefinition                           M_Value                                 { get; set; }

        public static StyleFontDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleFontDefinition() { Pointer= p0 };

            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x010)); // 0245A67BA3A0 0x10 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )
            value.M_Value                                   = (FontDefinition)GetInt32(new IntPtr(p + 0x018)); // 0245A67BA3C0 0x18 M_Value                     ( 0001865AEB70 ModelEnumType FontDefinition FontDefinition FontDefinition Int32 )

            return value;
        }
    }
}
