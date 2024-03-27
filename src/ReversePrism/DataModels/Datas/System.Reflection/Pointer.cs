using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _ptr                                     IntPtr IL2CPP_TYPE_PTR
    // 018 PtrType                                  0001866936B0 ModelClassType Type Type Type Pointer
    public partial class Pointer
    {
        public Type?                                    PtrType                                 { get; set; }

        public static Pointer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Pointer();

            value.PtrType                                   = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 027004D94AD0 0x18 PtrType                     ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
