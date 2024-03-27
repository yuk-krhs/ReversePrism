using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Localname                                0001866722E0 ModelPrimitiveType string string string String
    // 020 NamespaceUri                             0001866722E0 ModelPrimitiveType string string string String
    public partial class QName
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   Localname                               { get; set; }
        public string                                   NamespaceUri                            { get; set; }

        public static QName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QName();

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0270D734DDF0 0x10 Prefix                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Localname                                 = GetString(new IntPtr(p + 0x018)); // 0270D734DE10 0x18 Localname                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x020)); // 0270D734DE30 0x20 NamespaceUri                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
