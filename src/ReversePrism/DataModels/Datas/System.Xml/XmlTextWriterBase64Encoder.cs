using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 XmlTextEncoder                           0001865CCD50 ModelClassType XmlTextEncoder XmlTextEncoder XmlTextEncoder Pointer
    public partial class XmlTextWriterBase64Encoder : DataModel
    {
        public XmlTextEncoder?                          XmlTextEncoder                          { get; set; }

        public static XmlTextWriterBase64Encoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTextWriterBase64Encoder() { Pointer= p0 };

            value.XmlTextEncoder                            = GetObject<XmlTextEncoder>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlTextEncoder.FromPointer); // 024667399968 0x28 XmlTextEncoder              ( 0001865CCD50 ModelClassType XmlTextEncoder XmlTextEncoder XmlTextEncoder Pointer )

            return value;
        }
    }
}
