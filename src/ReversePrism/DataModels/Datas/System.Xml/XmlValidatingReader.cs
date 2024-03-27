using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Impl                                     0001865D4510 ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer
    public partial class XmlValidatingReader
    {
        public XmlValidatingReaderImpl?                 Impl                                    { get; set; }

        public static XmlValidatingReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlValidatingReader();

            value.Impl                                      = GetObject<XmlValidatingReaderImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlValidatingReaderImpl.FromPointer); // 0270D7401E28 0x10 Impl                        ( 0001865D4510 ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer )

            return value;
        }
    }
}
