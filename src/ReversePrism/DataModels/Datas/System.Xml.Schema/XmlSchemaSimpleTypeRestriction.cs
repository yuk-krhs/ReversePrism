using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 BaseTypeName                             0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 058 BaseType                                 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 060 Facets                                   0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    public partial class XmlSchemaSimpleTypeRestriction
    {
        public XmlQualifiedName?                        BaseTypeName                            { get; set; }
        public XmlSchemaSimpleType?                     BaseType                                { get; set; }
        public XmlSchemaObjectCollection?               Facets                                  { get; set; }

        public static XmlSchemaSimpleTypeRestriction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleTypeRestriction();

            value.BaseTypeName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D75BBD90 0x50 BaseTypeName                ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.BaseType                                  = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0270D75BBDB0 0x58 BaseType                    ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.Facets                                    = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D75BBDD0 0x60 Facets                      ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )

            return value;
        }
    }
}
