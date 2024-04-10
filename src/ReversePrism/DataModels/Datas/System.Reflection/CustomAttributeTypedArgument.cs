using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ArgumentType                             0001866936B0 ModelClassType Type Type Type Pointer
    // 018 <Value>k__BackingField                   <object> IL2CPP_TYPE_OBJECT
    public partial class CustomAttributeTypedArgument : DataModel
    {
        public Type?                                    ArgumentType                            { get; set; }

        public static CustomAttributeTypedArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomAttributeTypedArgument() { Pointer= p0 };

            value.ArgumentType                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0245A3DA9318 0x10 ArgumentType                ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
