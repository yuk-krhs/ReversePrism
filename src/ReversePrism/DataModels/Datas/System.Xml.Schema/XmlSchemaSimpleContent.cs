using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Content                                  ModelClassType XmlSchemaContent XmlSchemaContent XmlSchemaContent Pointer
    public partial class XmlSchemaSimpleContent : DataModel
    {
        public XmlSchemaContent?                        Content                                 { get; set; }

        public static XmlSchemaSimpleContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleContent() { Pointer= p0 };

            value.Content                                   = GetObject<XmlSchemaContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaContent.FromPointer); // 0x50 Content                     ( ModelClassType XmlSchemaContent XmlSchemaContent XmlSchemaContent Pointer )

            return value;
        }
    }
}
