using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Timeout                                  00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class WaitDecorator
    {
        public TimeSpan                                 Timeout                                 { get; set; }

        public static WaitDecorator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitDecorator();

            value.Timeout                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0270DBEB50F0 0x10 Timeout                     ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}
