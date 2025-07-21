using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ElementName                            ModelPrimitiveType string string string String
    // 018 M_AttributeName                          ModelPrimitiveType string string string String
    // 020 M_Value                                  ModelPrimitiveType string string string String
    public partial class AttributeOverride : DataModel
    {
        public string                                   M_ElementName                           { get; set; }
        public string                                   M_AttributeName                         { get; set; }
        public string                                   M_Value                                 { get; set; }

        public static AttributeOverride? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeOverride() { Pointer= p0 };

            value.M_ElementName                             = GetString(new IntPtr(p + 0x010)); // 0x10 M_ElementName               ( ModelPrimitiveType string string string String )
            value.M_AttributeName                           = GetString(new IntPtr(p + 0x018)); // 0x18 M_AttributeName             ( ModelPrimitiveType string string string String )
            value.M_Value                                   = GetString(new IntPtr(p + 0x020)); // 0x20 M_Value                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
