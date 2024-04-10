using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Element                                  000186597C20 ModelClassType XmlElement XmlElement XmlElement Pointer
    public partial class XmlElementWrapper : DataModel
    {
        public XmlElement?                              Element                                 { get; set; }

        public static XmlElementWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlElementWrapper() { Pointer= p0 };

            value.Element                                   = GetObject<XmlElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlElement.FromPointer); // 0246688AF908 0x28 Element                     ( 000186597C20 ModelClassType XmlElement XmlElement XmlElement Pointer )

            return value;
        }
    }
}
