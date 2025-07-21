using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 BytesUnknown                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0A0 Index                                    ModelPrimitiveType int int int Int32
    public partial class DecoderFallbackException : DataModel
    {
        public List<sbyte>?                             BytesUnknown                            { get; set; }
        public int                                      Index                                   { get; set; }

        public static DecoderFallbackException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderFallbackException() { Pointer= p0 };

            value.BytesUnknown                              = GetSByteList(new IntPtr(p + 0x098)); // 0x98 BytesUnknown                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
