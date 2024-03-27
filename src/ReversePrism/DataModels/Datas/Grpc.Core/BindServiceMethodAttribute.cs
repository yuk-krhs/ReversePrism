using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ServiceBinderAccessibility               DynamicallyAccessedMemberTypes IL2CPP_TYPE_VALUETYPE
    // 010 BindType                                 0001866936B0 ModelClassType Type Type Type Pointer
    // 018 BindMethodName                           000186672F10 ModelPrimitiveType string string string String
    public partial class BindServiceMethodAttribute
    {
        public Type?                                    BindType                                { get; set; }
        public string                                   BindMethodName                          { get; set; }

        public static BindServiceMethodAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindServiceMethodAttribute();

            value.BindType                                  = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270DBB2D3C8 0x10 BindType                    ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.BindMethodName                            = GetString(new IntPtr(p + 0x018)); // 0270DBB2D3E8 0x18 BindMethodName              ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
