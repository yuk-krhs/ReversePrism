using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Base64Encoder                            ModelClassType XmlRawWriterBase64Encoder XmlRawWriterBase64Encoder XmlRawWriterBase64Encoder Pointer
    // 020 Resolver                                 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    public partial class XmlRawWriter : DataModel
    {
        public XmlRawWriterBase64Encoder?               Base64Encoder                           { get; set; }
        public IXmlNamespaceResolver?                   Resolver                                { get; set; }

        public static XmlRawWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlRawWriter() { Pointer= p0 };

            value.Base64Encoder                             = GetObject<XmlRawWriterBase64Encoder>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlRawWriterBase64Encoder.FromPointer); // 0x18 Base64Encoder               ( ModelClassType XmlRawWriterBase64Encoder XmlRawWriterBase64Encoder XmlRawWriterBase64Encoder Pointer )
            value.Resolver                                  = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0x20 Resolver                    ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )

            return value;
        }
    }
}
