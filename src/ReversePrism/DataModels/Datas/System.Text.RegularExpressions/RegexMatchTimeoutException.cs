using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Input                                    ModelPrimitiveType string string string String
    // 098 Pattern                                  ModelPrimitiveType string string string String
    // 0A0 MatchTimeout                             ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class RegexMatchTimeoutException : DataModel
    {
        public string                                   Input                                   { get; set; }
        public string                                   Pattern                                 { get; set; }
        public TimeSpan                                 MatchTimeout                            { get; set; }

        public static RegexMatchTimeoutException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexMatchTimeoutException() { Pointer= p0 };

            value.Input                                     = GetString(new IntPtr(p + 0x090)); // 0x90 Input                       ( ModelPrimitiveType string string string String )
            value.Pattern                                   = GetString(new IntPtr(p + 0x098)); // 0x98 Pattern                     ( ModelPrimitiveType string string string String )
            value.MatchTimeout                              = (TimeSpan)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MatchTimeout                ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}
