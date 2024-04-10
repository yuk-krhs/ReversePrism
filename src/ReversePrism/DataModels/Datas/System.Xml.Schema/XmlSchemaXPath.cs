using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Xpath                                    000186671910 ModelPrimitiveType string string string String
    public partial class XmlSchemaXPath : DataModel
    {
        public string                                   Xpath                                   { get; set; }

        public static XmlSchemaXPath? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaXPath() { Pointer= p0 };

            value.Xpath                                     = GetString(new IntPtr(p + 0x050)); // 024667620DC8 0x50 Xpath                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
