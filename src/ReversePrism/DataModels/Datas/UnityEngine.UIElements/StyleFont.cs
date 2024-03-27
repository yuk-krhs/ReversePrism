using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001865AD0A0 ModelClassType Font Font Font Pointer
    // 018 M_Keyword                                0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleFont
    {
        public Font?                                    M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleFont? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleFont();

            value.M_Value                                   = GetObject<Font>(new IntPtr(p + 0x010), ReversePrism.DataModels.Font.FromPointer); // 0270067F75F8 0x10 M_Value                     ( 0001865AD0A0 ModelClassType Font Font Font Pointer )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x018)); // 0270067F7618 0x18 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
