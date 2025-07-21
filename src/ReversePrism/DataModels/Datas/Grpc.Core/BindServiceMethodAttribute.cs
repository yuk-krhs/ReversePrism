using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ServiceBinderAccessibility               DynamicallyAccessedMemberTypes IL2CPP_TYPE_VALUETYPE
    // 010 BindType                                 ModelClassType Type Type Type Pointer
    // 018 BindMethodName                           ModelPrimitiveType string string string String
    public partial class BindServiceMethodAttribute : DataModel
    {
        public Type?                                    BindType                                { get; set; }
        public string                                   BindMethodName                          { get; set; }

        public static BindServiceMethodAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindServiceMethodAttribute() { Pointer= p0 };

            value.BindType                                  = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 BindType                    ( ModelClassType Type Type Type Pointer )
            value.BindMethodName                            = GetString(new IntPtr(p + 0x018)); // 0x18 BindMethodName              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
