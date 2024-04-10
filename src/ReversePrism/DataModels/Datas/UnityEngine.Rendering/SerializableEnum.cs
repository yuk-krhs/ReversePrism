using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_EnumValueAsString                      000186671910 ModelPrimitiveType string string string String
    // 018 M_EnumTypeAsString                       000186671910 ModelPrimitiveType string string string String
    public partial class SerializableEnum : DataModel
    {
        public string                                   M_EnumValueAsString                     { get; set; }
        public string                                   M_EnumTypeAsString                      { get; set; }

        public static SerializableEnum? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializableEnum() { Pointer= p0 };

            value.M_EnumValueAsString                       = GetString(new IntPtr(p + 0x010)); // 024669199D08 0x10 M_EnumValueAsString         ( 000186671910 ModelPrimitiveType string string string String )
            value.M_EnumTypeAsString                        = GetString(new IntPtr(p + 0x018)); // 024669199D28 0x18 M_EnumTypeAsString          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
