using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 StrDefault                               ModelPrimitiveType string string string String
    // 038 FallbackCount                            ModelPrimitiveType int int int Int32
    // 03C FallbackIndex                            ModelPrimitiveType int int int Int32
    public partial class EncoderReplacementFallbackBuffer : DataModel
    {
        public string                                   StrDefault                              { get; set; }
        public int                                      FallbackCount                           { get; set; }
        public int                                      FallbackIndex                           { get; set; }

        public static EncoderReplacementFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncoderReplacementFallbackBuffer() { Pointer= p0 };

            value.StrDefault                                = GetString(new IntPtr(p + 0x030)); // 0x30 StrDefault                  ( ModelPrimitiveType string string string String )
            value.FallbackCount                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 FallbackCount               ( ModelPrimitiveType int int int Int32 )
            value.FallbackIndex                             = GetInt32(new IntPtr(p + 0x03C)); // 0x3C FallbackIndex               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
