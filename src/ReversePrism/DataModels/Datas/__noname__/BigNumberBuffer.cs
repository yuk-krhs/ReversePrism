using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Digits                                   ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 018 Precision                                ModelPrimitiveType int int int Int32
    // 01C Scale                                    ModelPrimitiveType int int int Int32
    // 020 Sign                                     ModelPrimitiveType bool bool bool Bool
    public partial class BigNumberBuffer : DataModel
    {
        public StringBuilder?                           Digits                                  { get; set; }
        public int                                      Precision                               { get; set; }
        public int                                      Scale                                   { get; set; }
        public bool                                     Sign                                    { get; set; }

        public static BigNumberBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BigNumberBuffer() { Pointer= p0 };

            value.Digits                                    = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x10 Digits                      ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.Precision                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 Precision                   ( ModelPrimitiveType int int int Int32 )
            value.Scale                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Scale                       ( ModelPrimitiveType int int int Int32 )
            value.Sign                                      = GetBool(new IntPtr(p + 0x020)); // 0x20 Sign                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
