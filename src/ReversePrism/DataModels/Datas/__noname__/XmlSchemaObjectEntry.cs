using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Qname                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Xso                                      ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    public partial class XmlSchemaObjectEntry : DataModel
    {
        public XmlQualifiedName?                        Qname                                   { get; set; }
        public XmlSchemaObject?                         Xso                                     { get; set; }

        public static XmlSchemaObjectEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaObjectEntry() { Pointer= p0 };

            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x10 Qname                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Xso                                       = GetObject<XmlSchemaObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0x18 Xso                         ( ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )

            return value;
        }
    }
}
