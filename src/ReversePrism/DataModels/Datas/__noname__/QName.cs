using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 Localname                                ModelPrimitiveType string string string String
    // 020 NamespaceUri                             ModelPrimitiveType string string string String
    public partial class QName : DataModel
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   Localname                               { get; set; }
        public string                                   NamespaceUri                            { get; set; }

        public static QName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QName() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.Localname                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Localname                   ( ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x020)); // 0x20 NamespaceUri                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
