using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Input                                    000186672F10 ModelPrimitiveType string string string String
    // 098 Pattern                                  000186672F10 ModelPrimitiveType string string string String
    // 0A0 MatchTimeout                             00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class RegexMatchTimeoutException
    {
        public string                                   Input                                   { get; set; }
        public string                                   Pattern                                 { get; set; }
        public TimeSpan                                 MatchTimeout                            { get; set; }

        public static RegexMatchTimeoutException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexMatchTimeoutException();

            value.Input                                     = GetString(new IntPtr(p + 0x090)); // 0270D79A18F0 0x90 Input                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.Pattern                                   = GetString(new IntPtr(p + 0x098)); // 0270D79A1910 0x98 Pattern                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.MatchTimeout                              = (TimeSpan)GetInt32(new IntPtr(p + 0x0A0)); // 0270D79A1930 0xA0 MatchTimeout                ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}
