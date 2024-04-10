using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Parent                                   000186594E60 ModelClassType CharEntityEncoderFallback CharEntityEncoderFallback CharEntityEncoderFallback Pointer
    // 038 CharEntity                               000186671910 ModelPrimitiveType string string string String
    // 040 CharEntityIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Parent                                    = GetObject<CharEntityEncoderFallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharEntityEncoderFallback.FromPointer); // 0246673B8A30 0x30 Parent                      ( 000186594E60 ModelClassType CharEntityEncoderFallback CharEntityEncoderFallback CharEntityEncoderFallback Pointer )
            value.CharEntity                                = GetString(new IntPtr(p + 0x038)); // 0246673B8A50 0x38 CharEntity                  ( 000186671910 ModelPrimitiveType string string string String )
            value.CharEntityIndex                           = GetInt32(new IntPtr(p + 0x040)); // 0246673B8A70 0x40 CharEntityIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
