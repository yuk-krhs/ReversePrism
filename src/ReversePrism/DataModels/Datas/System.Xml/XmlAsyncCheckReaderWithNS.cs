using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReaderAsIXmlNamespaceResolver            ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    public partial class XmlAsyncCheckReaderWithNS : DataModel
    {
        public IXmlNamespaceResolver?                   ReaderAsIXmlNamespaceResolver           { get; set; }

        public static XmlAsyncCheckReaderWithNS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReaderWithNS() { Pointer= p0 };

            value.ReaderAsIXmlNamespaceResolver             = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0x20 ReaderAsIXmlNamespaceResolver ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )

            return value;
        }
    }
}
