using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Array                                    0001865898B0 ModelClassType Array Array Array Pointer
    // 018 Total                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Current                                  0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Array                                     = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 024667B84368 0x10 Array                       ( 0001865898B0 ModelClassType Array Array Array Pointer )
            value.Total                                     = GetInt32(new IntPtr(p + 0x018)); // 024667B84388 0x18 Total                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetInt32(new IntPtr(p + 0x01C)); // 024667B843A8 0x1C Current                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
