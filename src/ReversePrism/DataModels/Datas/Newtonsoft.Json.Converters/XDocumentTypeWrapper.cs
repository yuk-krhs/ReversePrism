using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DocumentType                             000186574F10 ModelClassType XDocumentType XDocumentType XDocumentType Pointer
    public partial class XDocumentTypeWrapper : DataModel
    {
        public XDocumentType?                           DocumentType                            { get; set; }

        public static XDocumentTypeWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XDocumentTypeWrapper() { Pointer= p0 };

            value.DocumentType                              = GetObject<XDocumentType>(new IntPtr(p + 0x018), ReversePrism.DataModels.XDocumentType.FromPointer); // 0246688C1A60 0x18 DocumentType                ( 000186574F10 ModelClassType XDocumentType XDocumentType XDocumentType Pointer )

            return value;
        }
    }
}
