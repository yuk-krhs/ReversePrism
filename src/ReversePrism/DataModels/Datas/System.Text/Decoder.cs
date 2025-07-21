using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Fallback                                 ModelClassType DecoderFallback DecoderFallback DecoderFallback Pointer
    // 018 FallbackBuffer                           ModelClassType DecoderFallbackBuffer DecoderFallbackBuffer DecoderFallbackBuffer Pointer
    public partial class Decoder : DataModel
    {
        public DecoderFallback?                         Fallback                                { get; set; }
        public DecoderFallbackBuffer?                   FallbackBuffer                          { get; set; }

        public static Decoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Decoder() { Pointer= p0 };

            value.Fallback                                  = GetObject<DecoderFallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecoderFallback.FromPointer); // 0x10 Fallback                    ( ModelClassType DecoderFallback DecoderFallback DecoderFallback Pointer )
            value.FallbackBuffer                            = GetObject<DecoderFallbackBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.DecoderFallbackBuffer.FromPointer); // 0x18 FallbackBuffer              ( ModelClassType DecoderFallbackBuffer DecoderFallbackBuffer DecoderFallbackBuffer Pointer )

            return value;
        }
    }
}
