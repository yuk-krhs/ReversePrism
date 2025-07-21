using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 BaseTypeName                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 058 BaseType                                 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 060 Facets                                   ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 068 Attributes                               ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 070 AnyAttribute                             ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    public partial class XmlSchemaSimpleContentRestriction : DataModel
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
            var value   = new XmlSchemaSimpleContentRestriction() { Pointer= p0 };

            value.BaseTypeName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x50 BaseTypeName                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.BaseType                                  = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x58 BaseType                    ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.Facets                                    = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x60 Facets                      ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x68 Attributes                  ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0x70 AnyAttribute                ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )

            return value;
        }
    }
}
