using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Keyword                                ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    // 014 M_Value                                  ModelEnumType TextShadow TextShadow TextShadow Int32
    public partial class StyleTextShadow : DataModel
    {
        public StyleKeyword                             M_Keyword                               { get; set; }
        public TextShadow                               M_Value                                 { get; set; }

        public static StyleTextShadow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleTextShadow() { Pointer= p0 };

            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Keyword                   ( ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )
            value.M_Value                                   = (TextShadow)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_Value                     ( ModelEnumType TextShadow TextShadow TextShadow Int32 )

            return value;
        }
    }
}
