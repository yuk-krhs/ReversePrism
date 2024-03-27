using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 BytesUnknown                             000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0A0 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class DecoderFallbackException
    {
        public List<sbyte>?                             BytesUnknown                            { get; set; }
        public int                                      Index                                   { get; set; }

        public static DecoderFallbackException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecoderFallbackException();

            value.BytesUnknown                              = GetSByteList(new IntPtr(p + 0x098)); // 0270D6B62438 0x98 BytesUnknown                ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0A0)); // 0270D6B62458 0xA0 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
