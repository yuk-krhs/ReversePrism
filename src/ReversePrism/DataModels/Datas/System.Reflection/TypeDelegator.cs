using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 TypeImpl                                 000186692D10 ModelClassType Type Type Type Pointer
    public partial class TypeDelegator
    {
        public Type?                                    TypeImpl                                { get; set; }

        public static TypeDelegator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeDelegator();

            value.TypeImpl                                  = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 027003D55B38 0x18 TypeImpl                    ( 000186692D10 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
