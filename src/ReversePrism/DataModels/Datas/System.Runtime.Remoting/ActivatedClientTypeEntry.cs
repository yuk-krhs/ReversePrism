using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ApplicationUrl                           ModelPrimitiveType string string string String
    // 028 Obj_type                                 ModelClassType Type Type Type Pointer
    public partial class ActivatedClientTypeEntry : DataModel
    {
        public string                                   ApplicationUrl                          { get; set; }
        public Type?                                    Obj_type                                { get; set; }

        public static ActivatedClientTypeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActivatedClientTypeEntry() { Pointer= p0 };

            value.ApplicationUrl                            = GetString(new IntPtr(p + 0x020)); // 0x20 ApplicationUrl              ( ModelPrimitiveType string string string String )
            value.Obj_type                                  = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0x28 Obj_type                    ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
