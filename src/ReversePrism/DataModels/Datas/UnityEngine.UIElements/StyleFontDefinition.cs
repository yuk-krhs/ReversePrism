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
    public partial class StyleFontDefinition
    {
        public StyleKeyword                             M_Keyword                               { get; set; }
        public FontDefinition                           M_Value                                 { get; set; }

        public static StyleFontDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleFontDefinition();

            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x010)); // 0270067F8220 0x10 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )
            value.M_Value                                   = (FontDefinition)GetInt32(new IntPtr(p + 0x018)); // 0270067F8240 0x18 M_Value                     ( 0001865AEB70 ModelEnumType FontDefinition FontDefinition FontDefinition Int32 )

            return value;
        }
    }
}
