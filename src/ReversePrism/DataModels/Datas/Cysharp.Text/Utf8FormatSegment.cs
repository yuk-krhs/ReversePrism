using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NotFormatIndex                           int IL2CPP_TYPE_I4
    // 010 Offset                                   ModelPrimitiveType int int int Int32
    // 014 Count                                    ModelPrimitiveType int int int Int32
    // 018 FormatIndex                              ModelPrimitiveType int int int Int32
    // 01C StandardFormat                           ModelEnumType StandardFormat StandardFormat StandardFormat Int32
    // 020 Alignment                                ModelPrimitiveType int int int Int32
    public partial class Utf8FormatSegment : DataModel
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
            var value   = new Utf8FormatSegment() { Pointer= p0 };

            value.Offset                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Count                       ( ModelPrimitiveType int int int Int32 )
            value.FormatIndex                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 FormatIndex                 ( ModelPrimitiveType int int int Int32 )
            value.StandardFormat                            = (StandardFormat)GetInt32(new IntPtr(p + 0x01C)); // 0x1C StandardFormat              ( ModelEnumType StandardFormat StandardFormat StandardFormat Int32 )
            value.Alignment                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 Alignment                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
