using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      ModelClassType Type Type Type Pointer
    public partial class ComDefaultInterfaceAttribute : DataModel
    {
        public Type?                                    Val                                     { get; set; }

        public static ComDefaultInterfaceAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComDefaultInterfaceAttribute() { Pointer= p0 };

            value.Val                                       = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Val                         ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
