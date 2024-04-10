using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 AtomicConverter                          0001865D4D90 ModelClassType XmlValueConverter XmlValueConverter XmlValueConverter Pointer
    public partial class XmlListConverter : DataModel
    {
        public XmlValueConverter?                       AtomicConverter                         { get; set; }

        public static XmlListConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlListConverter() { Pointer= p0 };

            value.AtomicConverter                           = GetObject<XmlValueConverter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlValueConverter.FromPointer); // 02466765A280 0x28 AtomicConverter             ( 0001865D4D90 ModelClassType XmlValueConverter XmlValueConverter XmlValueConverter Pointer )

            return value;
        }
    }
}
