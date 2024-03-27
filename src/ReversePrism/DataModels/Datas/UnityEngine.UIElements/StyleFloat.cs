using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_Keyword                                0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleFloat
    {
        public float                                    M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleFloat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleFloat();

            value.M_Value                                   = GetSingle(new IntPtr(p + 0x010)); // 0270067F7148 0x10 M_Value                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x014)); // 0270067F7168 0x14 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
