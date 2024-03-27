using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FormatString                             000186671910 ModelPrimitiveType string string string String
    public partial class DisplayStringFormatAttribute
    {
        public string                                   FormatString                            { get; set; }

        public static DisplayStringFormatAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisplayStringFormatAttribute();

            value.FormatString                              = GetString(new IntPtr(p + 0x010)); // 0270D78AB740 0x10 FormatString                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
