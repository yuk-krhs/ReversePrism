using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 DocumentType                             ModelClassType XmlDocumentType XmlDocumentType XmlDocumentType Pointer
    public partial class XmlDocumentTypeWrapper : DataModel
    {
        public XmlDocumentType?                         DocumentType                            { get; set; }

        public static XmlDocumentTypeWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDocumentTypeWrapper() { Pointer= p0 };

            value.DocumentType                              = GetObject<XmlDocumentType>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDocumentType.FromPointer); // 0x28 DocumentType                ( ModelClassType XmlDocumentType XmlDocumentType XmlDocumentType Pointer )

            return value;
        }
    }
}
