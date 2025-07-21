using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalName                                ModelPrimitiveType string string string String
    // 018 NamespaceUri                             ModelPrimitiveType string string string String
    // 020 typedAttributeValue                      <object> IL2CPP_TYPE_OBJECT
    // 028 AttributeSchemaInfo                      ModelClassType XmlSchemaInfo XmlSchemaInfo XmlSchemaInfo Pointer
    public partial class AttributePSVIInfo : DataModel
    {
        public string                                   LocalName                               { get; set; }
        public string                                   NamespaceUri                            { get; set; }
        public XmlSchemaInfo?                           AttributeSchemaInfo                     { get; set; }

        public static AttributePSVIInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributePSVIInfo() { Pointer= p0 };

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 LocalName                   ( ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0x18 NamespaceUri                ( ModelPrimitiveType string string string String )
            value.AttributeSchemaInfo                       = GetObject<XmlSchemaInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaInfo.FromPointer); // 0x28 AttributeSchemaInfo         ( ModelClassType XmlSchemaInfo XmlSchemaInfo XmlSchemaInfo Pointer )

            return value;
        }
    }
}
