using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Type0                                  ModelClassType Type Type Type Pointer
    // 018 M_Type1                                  ModelClassType Type Type Type Pointer
    // 020 M_Type2                                  ModelClassType Type Type Type Pointer
    public partial class RequireComponent : DataModel
    {
        public Type?                                    M_Type0                                 { get; set; }
        public Type?                                    M_Type1                                 { get; set; }
        public Type?                                    M_Type2                                 { get; set; }

        public static RequireComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequireComponent() { Pointer= p0 };

            value.M_Type0                                   = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 M_Type0                     ( ModelClassType Type Type Type Pointer )
            value.M_Type1                                   = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 M_Type1                     ( ModelClassType Type Type Type Pointer )
            value.M_Type2                                   = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 M_Type2                     ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
