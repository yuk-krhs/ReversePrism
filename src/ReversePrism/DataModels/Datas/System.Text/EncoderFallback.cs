using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_replacementFallback                    EncoderFallback IL2CPP_TYPE_CLASS
    // 008 s_exceptionFallback                      EncoderFallback IL2CPP_TYPE_CLASS
    public partial class EncoderFallback
    {

        public static EncoderFallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncoderFallback();


            return value;
        }
    }
}
