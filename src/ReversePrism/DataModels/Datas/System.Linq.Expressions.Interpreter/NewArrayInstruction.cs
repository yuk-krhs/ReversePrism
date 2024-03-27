using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementType                              0001866936B0 ModelClassType Type Type Type Pointer
    public partial class NewArrayInstruction
    {
        public Type?                                    ElementType                             { get; set; }

        public static NewArrayInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NewArrayInstruction();

            value.ElementType                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D9F865F8 0x10 ElementType                 ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
