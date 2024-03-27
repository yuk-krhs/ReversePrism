using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Content                                  0001865B1D00 ModelClassType XmlSchemaContent XmlSchemaContent XmlSchemaContent Pointer
    public partial class XmlSchemaSimpleContent
    {
        public XmlSchemaContent?                        Content                                 { get; set; }

        public static XmlSchemaSimpleContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleContent();

            value.Content                                   = GetObject<XmlSchemaContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaContent.FromPointer); // 0270D75BB7D0 0x50 Content                     ( 0001865B1D00 ModelClassType XmlSchemaContent XmlSchemaContent XmlSchemaContent Pointer )

            return value;
        }
    }
}
