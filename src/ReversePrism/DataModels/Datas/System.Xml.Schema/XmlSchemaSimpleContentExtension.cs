using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Attributes                               0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 058 AnyAttribute                             0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 060 BaseTypeName                             0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSchemaSimpleContentExtension : DataModel
    {
        public XmlSchemaObjectCollection?               Attributes                              { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }
        public XmlQualifiedName?                        BaseTypeName                            { get; set; }

        public static XmlSchemaSimpleContentExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleContentExtension() { Pointer= p0 };

            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 024667592C18 0x50 Attributes                  ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 024667592C38 0x58 AnyAttribute                ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.BaseTypeName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667592C58 0x60 BaseTypeName                ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}
