using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 StrDefault                               000186671910 ModelPrimitiveType string string string String
    // 038 FallbackCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C FallbackIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EncoderReplacementFallbackBuffer
    {
        public string                                   StrDefault                              { get; set; }
        public int                                      FallbackCount                           { get; set; }
        public int                                      FallbackIndex                           { get; set; }

        public static EncoderReplacementFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncoderReplacementFallbackBuffer();

            value.StrDefault                                = GetString(new IntPtr(p + 0x030)); // 0270D6B63788 0x30 StrDefault                  ( 000186671910 ModelPrimitiveType string string string String )
            value.FallbackCount                             = GetInt32(new IntPtr(p + 0x038)); // 0270D6B637A8 0x38 FallbackCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FallbackIndex                             = GetInt32(new IntPtr(p + 0x03C)); // 0270D6B637C8 0x3C FallbackIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
