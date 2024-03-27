using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 byteStart                                IntPtr IL2CPP_TYPE_PTR
    // 018 charEnd                                  IntPtr IL2CPP_TYPE_PTR
    public partial class DecoderFallbackBuffer
    {

        public static DecoderFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderFallbackBuffer();


            return value;
        }
    }
}
