using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Impl                                     0001865CD480 ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer
    public partial class XmlTextReader
    {
        public XmlTextReaderImpl?                       Impl                                    { get; set; }

        public static XmlTextReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTextReader();

            value.Impl                                      = GetObject<XmlTextReaderImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlTextReaderImpl.FromPointer); // 0270D73C31D0 0x10 Impl                        ( 0001865CD480 ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer )

            return value;
        }
    }
}
