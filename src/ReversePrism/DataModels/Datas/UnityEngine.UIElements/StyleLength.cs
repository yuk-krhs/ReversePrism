using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001866061D0 ModelEnumType Length Length Length Int32
    // 018 M_Keyword                                0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleLength : DataModel
    {
        public Length                                   M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleLength? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleLength() { Pointer= p0 };

            value.M_Value                                   = (Length)GetInt32(new IntPtr(p + 0x010)); // 0245A67BAEA0 0x10 M_Value                     ( 0001866061D0 ModelEnumType Length Length Length Int32 )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x018)); // 0245A67BAEC0 0x18 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
