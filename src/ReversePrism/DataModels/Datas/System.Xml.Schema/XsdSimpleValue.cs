using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlType                                  0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 018 typedValue                               <object> IL2CPP_TYPE_OBJECT
    public partial class XsdSimpleValue
    {
        public XmlSchemaSimpleType?                     XmlType                                 { get; set; }

        public static XsdSimpleValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdSimpleValue();

            value.XmlType                                   = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0270D74FFAE8 0x10 XmlType                     ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )

            return value;
        }
    }
}
