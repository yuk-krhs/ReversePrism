using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ArraySize                                ModelPrimitiveType int int int Int32
    // 018 ElementType                              ModelClassType Type Type Type Pointer
    public partial class HLSLArray : DataModel
    {
        public int                                      ArraySize                               { get; set; }
        public Type?                                    ElementType                             { get; set; }

        public static HLSLArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HLSLArray() { Pointer= p0 };

            value.ArraySize                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 ArraySize                   ( ModelPrimitiveType int int int Int32 )
            value.ElementType                               = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 ElementType                 ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
