using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  ModelClassType Font Font Font Pointer
    // 018 M_Keyword                                ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleFont : DataModel
    {
        public Font?                                    M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleFont? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleFont() { Pointer= p0 };

            value.M_Value                                   = GetObject<Font>(new IntPtr(p + 0x010), ReversePrism.DataModels.Font.FromPointer); // 0x10 M_Value                     ( ModelClassType Font Font Font Pointer )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Keyword                   ( ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
