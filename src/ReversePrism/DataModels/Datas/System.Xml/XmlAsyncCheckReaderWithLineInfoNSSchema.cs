using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ReaderAsIXmlSchemaInfo                   0001866A1660 ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer
    public partial class XmlAsyncCheckReaderWithLineInfoNSSchema
    {
        public IXmlSchemaInfo?                          ReaderAsIXmlSchemaInfo                  { get; set; }

        public static XmlAsyncCheckReaderWithLineInfoNSSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReaderWithLineInfoNSSchema();

            value.ReaderAsIXmlSchemaInfo                    = GetObject<IXmlSchemaInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.IXmlSchemaInfo.FromPointer); // 0270D7384498 0x30 ReaderAsIXmlSchemaInfo      ( 0001866A1660 ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer )

            return value;
        }
    }
}
