using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReaderAsIXmlLineInfo                     ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    public partial class XmlAsyncCheckReaderWithLineInfo : DataModel
    {
        public IXmlLineInfo?                            ReaderAsIXmlLineInfo                    { get; set; }

        public static XmlAsyncCheckReaderWithLineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReaderWithLineInfo() { Pointer= p0 };

            value.ReaderAsIXmlLineInfo                      = GetObject<IXmlLineInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0x20 ReaderAsIXmlLineInfo        ( ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )

            return value;
        }
    }
}
