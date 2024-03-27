using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDisplay                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 DisplayText                              0001866722E0 ModelPrimitiveType string string string String
    public partial class TabButtonDisplay
    {
        public bool                                     IsDisplay                               { get; set; }
        public string                                   DisplayText                             { get; set; }

        public static TabButtonDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TabButtonDisplay();

            value.IsDisplay                                 = GetBool(new IntPtr(p + 0x010)); // 0270DA172770 0x10 IsDisplay                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DisplayText                               = GetString(new IntPtr(p + 0x018)); // 0270DA172790 0x18 DisplayText                 ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
