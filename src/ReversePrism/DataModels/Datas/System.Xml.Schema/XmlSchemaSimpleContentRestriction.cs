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
    // 068 Attributes                               0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 070 AnyAttribute                             0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    public partial class XmlSchemaSimpleContentRestriction
    {
        public XmlQualifiedName?                        BaseTypeName                            { get; set; }
        public XmlSchemaSimpleType?                     BaseType                                { get; set; }
        public XmlSchemaObjectCollection?               Facets                                  { get; set; }
        public XmlSchemaObjectCollection?               Attributes                              { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }

        public static XmlSchemaSimpleContentRestriction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleContentRestriction();

            value.BaseTypeName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7552130 0x50 BaseTypeName                ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.BaseType                                  = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0270D7552150 0x58 BaseType                    ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.Facets                                    = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D7552170 0x60 Facets                      ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D7552190 0x68 Attributes                  ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0270D75521B0 0x70 AnyAttribute                ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )

            return value;
        }
    }
}
