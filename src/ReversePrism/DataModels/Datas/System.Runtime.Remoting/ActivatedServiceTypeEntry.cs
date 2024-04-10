using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Obj_type                                 000186692850 ModelClassType Type Type Type Pointer
    public partial class ActivatedServiceTypeEntry : DataModel
    {
        public Type?                                    Obj_type                                { get; set; }

        public static ActivatedServiceTypeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActivatedServiceTypeEntry() { Pointer= p0 };

            value.Obj_type                                  = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024666C2A970 0x20 Obj_type                    ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
