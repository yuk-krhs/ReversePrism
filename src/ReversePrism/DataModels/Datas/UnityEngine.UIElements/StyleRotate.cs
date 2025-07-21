using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  ModelEnumType Rotate Rotate Rotate Int32
    // 028 M_Keyword                                ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleRotate : DataModel
    {
        public Rotate                                   M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleRotate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleRotate() { Pointer= p0 };

            value.M_Value                                   = (Rotate)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Value                     ( ModelEnumType Rotate Rotate Rotate Int32 )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Keyword                   ( ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
