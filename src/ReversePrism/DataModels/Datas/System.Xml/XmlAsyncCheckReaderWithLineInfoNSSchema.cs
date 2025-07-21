using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ReaderAsIXmlSchemaInfo                   ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer
    public partial class XmlAsyncCheckReaderWithLineInfoNSSchema : DataModel
    {
        public IXmlSchemaInfo?                          ReaderAsIXmlSchemaInfo                  { get; set; }

        public static XmlAsyncCheckReaderWithLineInfoNSSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReaderWithLineInfoNSSchema() { Pointer= p0 };

            value.ReaderAsIXmlSchemaInfo                    = GetObject<IXmlSchemaInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.IXmlSchemaInfo.FromPointer); // 0x30 ReaderAsIXmlSchemaInfo      ( ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer )

            return value;
        }
    }
}
