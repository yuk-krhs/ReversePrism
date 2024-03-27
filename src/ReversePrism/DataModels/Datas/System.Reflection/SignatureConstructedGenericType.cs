using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 GenericTypeDefinition                    0001866936B0 ModelClassType Type Type Type Pointer
    // 020 GenericTypeArguments                     000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class SignatureConstructedGenericType
    {
        public Type?                                    GenericTypeDefinition                   { get; set; }
        public List<Type>?                              GenericTypeArguments                    { get; set; }

        public static SignatureConstructedGenericType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignatureConstructedGenericType();

            value.GenericTypeDefinition                     = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D6CEAC50 0x18 GenericTypeDefinition       ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.GenericTypeArguments                      = GetObjectList<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D6CEAC70 0x20 GenericTypeArguments        ( 000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
