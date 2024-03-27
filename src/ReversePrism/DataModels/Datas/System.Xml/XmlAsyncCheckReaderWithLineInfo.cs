using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReaderAsIXmlLineInfo                     00018669FE10 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    public partial class XmlAsyncCheckReaderWithLineInfo
    {
        public IXmlLineInfo?                            ReaderAsIXmlLineInfo                    { get; set; }

        public static XmlAsyncCheckReaderWithLineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReaderWithLineInfo();

            value.ReaderAsIXmlLineInfo                      = GetObject<IXmlLineInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0270D73840E0 0x20 ReaderAsIXmlLineInfo        ( 00018669FE10 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )

            return value;
        }
    }
}
