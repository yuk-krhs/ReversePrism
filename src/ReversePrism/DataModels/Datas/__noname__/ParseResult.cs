using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 018 FormatString                             ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 028 LastIndex                                0001865F4940 ModelPrimitiveType int int int Int32
    // 02C Alignment                                0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ParseResult
    {
        public int                                      Index                                   { get; set; }
        public int                                      LastIndex                               { get; set; }
        public int                                      Alignment                               { get; set; }

        public static ParseResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParseResult();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DAB5FE48 0x10 Index                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.LastIndex                                 = GetInt32(new IntPtr(p + 0x028)); // 0270DAB5FE88 0x28 LastIndex                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Alignment                                 = GetInt32(new IntPtr(p + 0x02C)); // 0270DAB5FEA8 0x2C Alignment                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
