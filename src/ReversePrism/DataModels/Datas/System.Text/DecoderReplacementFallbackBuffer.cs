using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StrDefault                               000186671910 ModelPrimitiveType string string string String
    // 028 FallbackCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C FallbackIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class DecoderReplacementFallbackBuffer : DataModel
    {
        public string                                   StrDefault                              { get; set; }
        public int                                      FallbackCount                           { get; set; }
        public int                                      FallbackIndex                           { get; set; }

        public static DecoderReplacementFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderReplacementFallbackBuffer() { Pointer= p0 };

            value.StrDefault                                = GetString(new IntPtr(p + 0x020)); // 0245A4D96890 0x20 StrDefault                  ( 000186671910 ModelPrimitiveType string string string String )
            value.FallbackCount                             = GetInt32(new IntPtr(p + 0x028)); // 0245A4D968B0 0x28 FallbackCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FallbackIndex                             = GetInt32(new IntPtr(p + 0x02C)); // 0245A4D968D0 0x2C FallbackIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
