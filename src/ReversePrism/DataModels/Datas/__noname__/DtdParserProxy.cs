using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   0001865CD480 ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer
    public partial class DtdParserProxy
    {
        public XmlTextReaderImpl?                       Reader                                  { get; set; }

        public static DtdParserProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DtdParserProxy();

            value.Reader                                    = GetObject<XmlTextReaderImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlTextReaderImpl.FromPointer); // 0270D73D8C48 0x10 Reader                      ( 0001865CD480 ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer )

            return value;
        }
    }
}
