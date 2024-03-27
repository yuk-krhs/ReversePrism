using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 018 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 020 Order                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlAnyElementAttribute
    {
        public string                                   ElementName                             { get; set; }
        public string                                   Ns                                      { get; set; }
        public int                                      Order                                   { get; set; }

        public static XmlAnyElementAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAnyElementAttribute();

            value.ElementName                               = GetString(new IntPtr(p + 0x010)); // 0270D74B5928 0x10 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0270D74B5948 0x18 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D74B5968 0x20 Order                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
