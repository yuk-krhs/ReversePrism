using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001865AA8E0 ModelEnumType Color Color Color Int32
    // 020 M_Keyword                                0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleColor
    {
        public Color                                    M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleColor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleColor();

            value.M_Value                                   = (Color)GetInt32(new IntPtr(p + 0x010)); // 0270067F6748 0x10 M_Value                     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x020)); // 0270067F6768 0x20 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
