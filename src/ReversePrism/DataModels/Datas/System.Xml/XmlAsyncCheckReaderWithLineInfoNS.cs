using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ReaderAsIXmlNamespaceResolver            ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    public partial class XmlAsyncCheckReaderWithLineInfoNS : DataModel
    {
        public IXmlNamespaceResolver?                   ReaderAsIXmlNamespaceResolver           { get; set; }

        public static XmlAsyncCheckReaderWithLineInfoNS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReaderWithLineInfoNS() { Pointer= p0 };

            value.ReaderAsIXmlNamespaceResolver             = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x028), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0x28 ReaderAsIXmlNamespaceResolver ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )

            return value;
        }
    }
}
