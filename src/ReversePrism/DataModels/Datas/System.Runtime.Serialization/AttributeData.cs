using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Ns                                       0001866722E0 ModelPrimitiveType string string string String
    // 020 LocalName                                0001866722E0 ModelPrimitiveType string string string String
    // 028 Value                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class AttributeData
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   Ns                                      { get; set; }
        public string                                   LocalName                               { get; set; }
        public string                                   Value                                   { get; set; }

        public static AttributeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeData();

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0270D7D3DCC0 0x10 Prefix                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0270D7D3DCE0 0x18 Ns                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x020)); // 0270D7D3DD00 0x20 LocalName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x028)); // 0270D7D3DD20 0x28 Value                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
