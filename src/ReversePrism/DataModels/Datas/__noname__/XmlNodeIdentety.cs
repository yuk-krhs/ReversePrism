using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalName                                ModelPrimitiveType string string string String
    // 018 NamespaceURI                             ModelPrimitiveType string string string String
    public partial class XmlNodeIdentety : DataModel
    {
        public string                                   LocalName                               { get; set; }
        public string                                   NamespaceURI                            { get; set; }

        public static XmlNodeIdentety? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeIdentety() { Pointer= p0 };

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 LocalName                   ( ModelPrimitiveType string string string String )
            value.NamespaceURI                              = GetString(new IntPtr(p + 0x018)); // 0x18 NamespaceURI                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
