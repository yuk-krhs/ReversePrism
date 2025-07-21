using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _ptr                                     IntPtr IL2CPP_TYPE_PTR
    // 018 PtrType                                  ModelClassType Type Type Type Pointer
    public partial class Pointer : DataModel
    {
        public Type?                                    PtrType                                 { get; set; }

        public static Pointer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Pointer() { Pointer= p0 };

            value.PtrType                                   = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 PtrType                     ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
