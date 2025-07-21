using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Str                                      ModelPrimitiveType string string string String
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C _currentElement                          char IL2CPP_TYPE_CHAR
    public partial class CharEnumerator : DataModel
    {
        public string                                   Str                                     { get; set; }
        public int                                      Index                                   { get; set; }

        public static CharEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharEnumerator() { Pointer= p0 };

            value.Str                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Str                         ( ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
