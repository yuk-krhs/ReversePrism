using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Document                                 000186595E90 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    public partial class XmlDocumentWrapper : DataModel
    {
        public XmlDocument?                             Document                                { get; set; }

        public static XmlDocumentWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDocumentWrapper() { Pointer= p0 };

            value.Document                                  = GetObject<XmlDocument>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDocument.FromPointer); // 0246688AF170 0x28 Document                    ( 000186595E90 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )

            return value;
        }
    }
}
