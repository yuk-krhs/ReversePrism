using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Obj_type                                 000186692850 ModelClassType Type Type Type Pointer
    // 028 Obj_uri                                  000186671910 ModelPrimitiveType string string string String
    // 030 Obj_mode                                 000186555B00 ModelEnumType WellKnownObjectMode WellKnownObjectMode WellKnownObjectMode Int32
    public partial class WellKnownServiceTypeEntry
    {
        public Type?                                    Obj_type                                { get; set; }
        public string                                   Obj_uri                                 { get; set; }
        public WellKnownObjectMode                      Obj_mode                                { get; set; }

        public static WellKnownServiceTypeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WellKnownServiceTypeEntry();

            value.Obj_type                                  = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D6BB4A20 0x20 Obj_type                    ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Obj_uri                                   = GetString(new IntPtr(p + 0x028)); // 0270D6BB4A40 0x28 Obj_uri                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Obj_mode                                  = (WellKnownObjectMode)GetInt32(new IntPtr(p + 0x030)); // 0270D6BB4A60 0x30 Obj_mode                    ( 000186555B00 ModelEnumType WellKnownObjectMode WellKnownObjectMode WellKnownObjectMode Int32 )

            return value;
        }
    }
}
