using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Parent                                   ModelClassType CharEntityEncoderFallback CharEntityEncoderFallback CharEntityEncoderFallback Pointer
    // 038 CharEntity                               ModelPrimitiveType string string string String
    // 040 CharEntityIndex                          ModelPrimitiveType int int int Int32
    public partial class CharEntityEncoderFallbackBuffer : DataModel
    {
        public CharEntityEncoderFallback?               Parent                                  { get; set; }
        public string                                   CharEntity                              { get; set; }
        public int                                      CharEntityIndex                         { get; set; }

        public static CharEntityEncoderFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharEntityEncoderFallbackBuffer() { Pointer= p0 };

            value.Parent                                    = GetObject<CharEntityEncoderFallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharEntityEncoderFallback.FromPointer); // 0x30 Parent                      ( ModelClassType CharEntityEncoderFallback CharEntityEncoderFallback CharEntityEncoderFallback Pointer )
            value.CharEntity                                = GetString(new IntPtr(p + 0x038)); // 0x38 CharEntity                  ( ModelPrimitiveType string string string String )
            value.CharEntityIndex                           = GetInt32(new IntPtr(p + 0x040)); // 0x40 CharEntityIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
