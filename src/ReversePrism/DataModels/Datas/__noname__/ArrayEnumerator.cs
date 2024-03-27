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
    public partial class ArrayEnumerator
    {
        public Array?                                   Array                                   { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      EndIndex                                { get; set; }

        public static ArrayEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayEnumerator();

            value.Array                                     = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 02700601ECD0 0x10 Array                       ( 000186589390 ModelClassType Array Array Array Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 02700601ECF0 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x01C)); // 02700601ED10 0x1C EndIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
