using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Precision                                ModelPrimitiveType int int int Int32
    // 014 Scale                                    ModelPrimitiveType int int int Int32
    // 018 Sign                                     ModelPrimitiveType bool bool bool Bool
    // 020 overrideDigits                           IntPtr IL2CPP_TYPE_PTR
    public partial class NumberBuffer : DataModel
    {
        public int                                      Precision                               { get; set; }
        public int                                      Scale                                   { get; set; }
        public bool                                     Sign                                    { get; set; }

        public static NumberBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumberBuffer() { Pointer= p0 };

            value.Precision                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 Precision                   ( ModelPrimitiveType int int int Int32 )
            value.Scale                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Scale                       ( ModelPrimitiveType int int int Int32 )
            value.Sign                                      = GetBool(new IntPtr(p + 0x018)); // 0x18 Sign                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
