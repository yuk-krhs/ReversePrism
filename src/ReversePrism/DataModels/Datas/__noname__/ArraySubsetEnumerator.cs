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
    public partial class ArraySubsetEnumerator
    {
        public Array?                                   Array                                   { get; set; }
        public int                                      Total                                   { get; set; }
        public int                                      Current                                 { get; set; }

        public static ArraySubsetEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArraySubsetEnumerator();

            value.Array                                     = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 0270D7B1C368 0x10 Array                       ( 0001865898B0 ModelClassType Array Array Array Pointer )
            value.Total                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D7B1C388 0x18 Total                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetInt32(new IntPtr(p + 0x01C)); // 0270D7B1C3A8 0x1C Current                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
