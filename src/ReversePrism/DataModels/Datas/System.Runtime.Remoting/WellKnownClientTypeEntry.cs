using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Obj_type                                 000186692850 ModelClassType Type Type Type Pointer
    // 028 Obj_url                                  000186671910 ModelPrimitiveType string string string String
    // 030 App_url                                  000186671910 ModelPrimitiveType string string string String
    public partial class WellKnownClientTypeEntry
    {
        public Type?                                    Obj_type                                { get; set; }
        public string                                   Obj_url                                 { get; set; }
        public string                                   App_url                                 { get; set; }

        public static WellKnownClientTypeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WellKnownClientTypeEntry();

            value.Obj_type                                  = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D6BB4720 0x20 Obj_type                    ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Obj_url                                   = GetString(new IntPtr(p + 0x028)); // 0270D6BB4740 0x28 Obj_url                     ( 000186671910 ModelPrimitiveType string string string String )
            value.App_url                                   = GetString(new IntPtr(p + 0x030)); // 0270D6BB4760 0x30 App_url                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
