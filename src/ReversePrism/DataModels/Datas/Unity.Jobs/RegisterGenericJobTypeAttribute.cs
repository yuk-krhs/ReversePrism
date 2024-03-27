using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConcreteType                             000186692F60 ModelClassType Type Type Type Pointer
    public partial class RegisterGenericJobTypeAttribute
    {
        public Type?                                    ConcreteType                            { get; set; }

        public static RegisterGenericJobTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterGenericJobTypeAttribute();

            value.ConcreteType                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027005268B50 0x10 ConcreteType                ( 000186692F60 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
