using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001865910E0 ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32
    // 024 M_Keyword                                0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    public partial class StyleBackgroundSize
    {
        public BackgroundSize                           M_Value                                 { get; set; }
        public StyleKeyword                             M_Keyword                               { get; set; }

        public static StyleBackgroundSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleBackgroundSize();

            value.M_Value                                   = (BackgroundSize)GetInt32(new IntPtr(p + 0x010)); // 0270067ED200 0x10 M_Value                     ( 0001865910E0 ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32 )
            value.M_Keyword                                 = (StyleKeyword)GetInt32(new IntPtr(p + 0x024)); // 0270067ED220 0x24 M_Keyword                   ( 0001865C8070 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
