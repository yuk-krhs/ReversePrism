using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Fallback                                 ModelClassType EncoderFallback EncoderFallback EncoderFallback Pointer
    // 018 FallbackBuffer                           ModelClassType EncoderFallbackBuffer EncoderFallbackBuffer EncoderFallbackBuffer Pointer
    public partial class Encoder : DataModel
    {
        public EncoderFallback?                         Fallback                                { get; set; }
        public EncoderFallbackBuffer?                   FallbackBuffer                          { get; set; }

        public static Encoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Encoder() { Pointer= p0 };

            value.Fallback                                  = GetObject<EncoderFallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.EncoderFallback.FromPointer); // 0x10 Fallback                    ( ModelClassType EncoderFallback EncoderFallback EncoderFallback Pointer )
            value.FallbackBuffer                            = GetObject<EncoderFallbackBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.EncoderFallbackBuffer.FromPointer); // 0x18 FallbackBuffer              ( ModelClassType EncoderFallbackBuffer EncoderFallbackBuffer EncoderFallbackBuffer Pointer )

            return value;
        }
    }
}
