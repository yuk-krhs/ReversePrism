using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Array                                    ModelClassType Array Array Array Pointer
    // 018 Total                                    ModelPrimitiveType int int int Int32
    // 01C Current                                  ModelPrimitiveType int int int Int32
    public partial class ArraySubsetEnumerator : DataModel
    {
        public Array?                                   Array                                   { get; set; }
        public int                                      Total                                   { get; set; }
        public int                                      Current                                 { get; set; }

        public static ArraySubsetEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArraySubsetEnumerator() { Pointer= p0 };

            value.Array                                     = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 0x10 Array                       ( ModelClassType Array Array Array Pointer )
            value.Total                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Total                       ( ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Current                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
