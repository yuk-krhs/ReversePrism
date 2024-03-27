using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalName                                0001866722E0 ModelPrimitiveType string string string String
    // 018 NamespaceURI                             0001866722E0 ModelPrimitiveType string string string String
    public partial class XmlNodeIdentety
    {
        public string                                   LocalName                               { get; set; }
        public string                                   NamespaceURI                            { get; set; }

        public static XmlNodeIdentety? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeIdentety();

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0270D8979458 0x10 LocalName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NamespaceURI                              = GetString(new IntPtr(p + 0x018)); // 0270D8979478 0x18 NamespaceURI                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
