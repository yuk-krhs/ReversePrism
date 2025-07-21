using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementName                              ModelPrimitiveType string string string String
    // 018 Ns                                       ModelPrimitiveType string string string String
    // 020 Order                                    ModelPrimitiveType int int int Int32
    public partial class XmlAnyElementAttribute : DataModel
    {
        public string                                   ElementName                             { get; set; }
        public string                                   Ns                                      { get; set; }
        public int                                      Order                                   { get; set; }

        public static XmlAnyElementAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAnyElementAttribute() { Pointer= p0 };

            value.ElementName                               = GetString(new IntPtr(p + 0x010)); // 0x10 ElementName                 ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Order                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
