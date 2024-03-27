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
    // 01C StandardFormat                           00018666E770 ModelEnumType StandardFormat StandardFormat StandardFormat Int32
    // 020 Alignment                                0001865F4940 ModelPrimitiveType int int int Int32
    public partial class Utf8FormatSegment
    {
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      FormatIndex                             { get; set; }
        public StandardFormat                           StandardFormat                          { get; set; }
        public int                                      Alignment                               { get; set; }

        public static Utf8FormatSegment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf8FormatSegment();

            value.Offset                                    = GetInt32(new IntPtr(p + 0x010)); // 027003CA0F58 0x10 Offset                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x014)); // 027003CA0F78 0x14 Count                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.FormatIndex                               = GetInt32(new IntPtr(p + 0x018)); // 027003CA0F98 0x18 FormatIndex                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.StandardFormat                            = (StandardFormat)GetInt32(new IntPtr(p + 0x01C)); // 027003CA0FB8 0x1C StandardFormat              ( 00018666E770 ModelEnumType StandardFormat StandardFormat StandardFormat Int32 )
            value.Alignment                                 = GetInt32(new IntPtr(p + 0x020)); // 027003CA0FD8 0x20 Alignment                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
