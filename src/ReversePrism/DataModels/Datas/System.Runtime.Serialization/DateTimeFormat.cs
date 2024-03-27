using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FormatString                             000186671910 ModelPrimitiveType string string string String
    // 018 FormatProvider                           000186517B50 ModelClassType IFormatProvider IFormatProvider IFormatProvider Pointer
    // 020 DateTimeStyles                           0001865BE5C0 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32
    public partial class DateTimeFormat
    {
        public string                                   FormatString                            { get; set; }
        public IFormatProvider?                         FormatProvider                          { get; set; }
        public DateTimeStyles                           DateTimeStyles                          { get; set; }

        public static DateTimeFormat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeFormat();

            value.FormatString                              = GetString(new IntPtr(p + 0x010)); // 0270D7D14CD8 0x10 FormatString                ( 000186671910 ModelPrimitiveType string string string String )
            value.FormatProvider                            = GetObject<IFormatProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IFormatProvider.FromPointer); // 0270D7D14CF8 0x18 FormatProvider              ( 000186517B50 ModelClassType IFormatProvider IFormatProvider IFormatProvider Pointer )
            value.DateTimeStyles                            = (DateTimeStyles)GetInt32(new IntPtr(p + 0x020)); // 0270D7D14D18 0x20 DateTimeStyles              ( 0001865BE5C0 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32 )

            return value;
        }
    }
}
