using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Array                                    000186589390 ModelClassType Array Array Array Pointer
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C EndIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ArrayEnumerator : DataModel
    {
        public Array?                                   Array                                   { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      EndIndex                                { get; set; }

        public static ArrayEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayEnumerator() { Pointer= p0 };

            value.Array                                     = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 0245A5FE89C8 0x10 Array                       ( 000186589390 ModelClassType Array Array Array Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A5FE89E8 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x01C)); // 0245A5FE8A08 0x1C EndIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
