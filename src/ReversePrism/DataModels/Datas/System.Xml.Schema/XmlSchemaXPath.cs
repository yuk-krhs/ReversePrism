using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Xpath                                    000186671910 ModelPrimitiveType string string string String
    public partial class XmlSchemaXPath
    {
        public string                                   Xpath                                   { get; set; }

        public static XmlSchemaXPath? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaXPath();

            value.Xpath                                     = GetString(new IntPtr(p + 0x050)); // 0270D75B0DC8 0x50 Xpath                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
