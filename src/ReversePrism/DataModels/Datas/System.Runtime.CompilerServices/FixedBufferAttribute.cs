using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementType                              ModelClassType Type Type Type Pointer
    // 018 Length                                   ModelPrimitiveType int int int Int32
    public partial class FixedBufferAttribute : DataModel
    {
        public Type?                                    ElementType                             { get; set; }
        public int                                      Length                                  { get; set; }

        public static FixedBufferAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBufferAttribute() { Pointer= p0 };

            value.ElementType                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 ElementType                 ( ModelClassType Type Type Type Pointer )
            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
