using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementType                              0001866936B0 ModelClassType Type Type Type Pointer
    // 018 ElementCount                             0001865F4260 ModelPrimitiveType int int int Int32
    public partial class NewArrayInitInstruction : DataModel
    {
        public Type?                                    ElementType                             { get; set; }
        public int                                      ElementCount                            { get; set; }

        public static NewArrayInitInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NewArrayInitInstruction() { Pointer= p0 };

            value.ElementType                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024669FF6168 0x10 ElementType                 ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.ElementCount                              = GetInt32(new IntPtr(p + 0x018)); // 024669FF6188 0x18 ElementCount                ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
