using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NotFormatIndex                           int IL2CPP_TYPE_I4
    // 010 Offset                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Count                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 018 FormatIndex                              0001865F4940 ModelPrimitiveType int int int Int32
    // 01C Alignment                                0001865F4940 ModelPrimitiveType int int int Int32
    public partial class Utf16FormatSegment
    {
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      FormatIndex                             { get; set; }
        public int                                      Alignment                               { get; set; }

        public static Utf16FormatSegment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf16FormatSegment();

            value.Offset                                    = GetInt32(new IntPtr(p + 0x010)); // 0270DAB60448 0x10 Offset                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x014)); // 0270DAB60468 0x14 Count                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.FormatIndex                               = GetInt32(new IntPtr(p + 0x018)); // 0270DAB60488 0x18 FormatIndex                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Alignment                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270DAB604A8 0x1C Alignment                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
