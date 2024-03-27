using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Timeout                                  00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class SetTimeoutTokenDecorator
    {
        public TimeSpan                                 Timeout                                 { get; set; }

        public static SetTimeoutTokenDecorator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetTimeoutTokenDecorator();

            value.Timeout                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 027004E1CD38 0x10 Timeout                     ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}
