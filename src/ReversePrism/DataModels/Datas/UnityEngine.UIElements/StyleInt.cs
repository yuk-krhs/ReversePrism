using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Keyword                                0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleInt
    {
        public int                                      M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleInt();

            value.M_Value                                   = GetInt32(new IntPtr(p + 0x010)); // 0270067F86D0 0x10 M_Value                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x014)); // 0270067F86F0 0x14 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
