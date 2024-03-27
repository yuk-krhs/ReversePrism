using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StrDefault                               000186671910 ModelPrimitiveType string string string String
    public partial class EncoderReplacementFallback
    {
        public string                                   StrDefault                              { get; set; }

        public static EncoderReplacementFallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncoderReplacementFallback();

            value.StrDefault                                = GetString(new IntPtr(p + 0x010)); // 0270033E5D90 0x10 StrDefault                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
