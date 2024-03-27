using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 Content                                  0001865C0270 ModelClassType XmlSchemaSimpleTypeContent XmlSchemaSimpleTypeContent XmlSchemaSimpleTypeContent Pointer
    public partial class XmlSchemaSimpleType
    {
        public XmlSchemaSimpleTypeContent?              Content                                 { get; set; }

        public static XmlSchemaSimpleType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleType();

            value.Content                                   = GetObject<XmlSchemaSimpleTypeContent>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlSchemaSimpleTypeContent.FromPointer); // 0270D7386B90 0x98 Content                     ( 0001865C0270 ModelClassType XmlSchemaSimpleTypeContent XmlSchemaSimpleTypeContent XmlSchemaSimpleTypeContent Pointer )

            return value;
        }
    }
}
