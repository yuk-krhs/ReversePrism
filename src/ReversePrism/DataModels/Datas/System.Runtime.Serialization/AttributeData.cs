using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 Ns                                       ModelPrimitiveType string string string String
    // 020 LocalName                                ModelPrimitiveType string string string String
    // 028 Value                                    ModelPrimitiveType string string string String
    public partial class AttributeData : DataModel
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
            var value   = new AttributeData() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x020)); // 0x20 LocalName                   ( ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
