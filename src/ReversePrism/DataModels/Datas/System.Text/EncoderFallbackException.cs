using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 _charUnknown                             char IL2CPP_TYPE_CHAR
    // 09A _charUnknownHigh                         char IL2CPP_TYPE_CHAR
    // 09C _charUnknownLow                          char IL2CPP_TYPE_CHAR
    // 0A0 Index                                    ModelPrimitiveType int int int Int32
    public partial class EncoderFallbackException : DataModel
    {
        public int                                      Index                                   { get; set; }

        public static EncoderFallbackException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncoderFallbackException() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
