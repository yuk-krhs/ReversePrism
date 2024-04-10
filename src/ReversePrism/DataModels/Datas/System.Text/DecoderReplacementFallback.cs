using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StrDefault                               000186671910 ModelPrimitiveType string string string String
    public partial class DecoderReplacementFallback : DataModel
    {
        public string                                   StrDefault                              { get; set; }

        public static DecoderReplacementFallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderReplacementFallback() { Pointer= p0 };

            value.StrDefault                                = GetString(new IntPtr(p + 0x010)); // 0245A33E56B8 0x10 StrDefault                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
