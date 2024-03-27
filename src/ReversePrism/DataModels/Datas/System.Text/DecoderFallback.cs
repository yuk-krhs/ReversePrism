using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_replacementFallback                    DecoderFallback IL2CPP_TYPE_CLASS
    // 008 s_exceptionFallback                      DecoderFallback IL2CPP_TYPE_CLASS
    public partial class DecoderFallback
    {

        public static DecoderFallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderFallback();


            return value;
        }
    }
}
