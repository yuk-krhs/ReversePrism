using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ApplicationUrl                           000186671910 ModelPrimitiveType string string string String
    // 028 Obj_type                                 000186692850 ModelClassType Type Type Type Pointer
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

            value.ApplicationUrl                            = GetString(new IntPtr(p + 0x020)); // 024666C2A5E8 0x20 ApplicationUrl              ( 000186671910 ModelPrimitiveType string string string String )
            value.Obj_type                                  = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 024666C2A608 0x28 Obj_type                    ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
