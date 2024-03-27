using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   000186671910 ModelPrimitiveType string string string String
    public partial class XmlTypeConvertorAttribute
    {
        public string                                   Method                                  { get; set; }

        public static XmlTypeConvertorAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeConvertorAttribute();

            value.Method                                    = GetString(new IntPtr(p + 0x010)); // 0270D74B40D0 0x10 Method                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
