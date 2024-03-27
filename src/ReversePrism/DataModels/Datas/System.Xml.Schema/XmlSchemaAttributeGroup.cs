using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     000186671910 ModelPrimitiveType string string string String
    // 058 Attributes                               0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 060 AnyAttribute                             0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 068 Qname                                    0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 070 Redefined                                0001865AE960 ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer
    // 078 AttributeUses                            0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 080 AttributeWildcard                        0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 088 SelfReferenceCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlSchemaAttributeGroup
    {
        public string                                   Name                                    { get; set; }
        public XmlSchemaObjectCollection?               Attributes                              { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }
        public XmlQualifiedName?                        Qname                                   { get; set; }
        public XmlSchemaAttributeGroup?                 Redefined                               { get; set; }
        public XmlSchemaObjectTable?                    AttributeUses                           { get; set; }
        public XmlSchemaAnyAttribute?                   AttributeWildcard                       { get; set; }
        public int                                      SelfReferenceCount                      { get; set; }

        public static XmlSchemaAttributeGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAttributeGroup();

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0270D752E930 0x50 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D752E950 0x58 Attributes                  ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0270D752E970 0x60 AnyAttribute                ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D752E990 0x68 Qname                       ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Redefined                                 = GetObject<XmlSchemaAttributeGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaAttributeGroup.FromPointer); // 0270D752E9B0 0x70 Redefined                   ( 0001865AE960 ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer )
            value.AttributeUses                             = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0270D752E9D0 0x78 AttributeUses               ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeWildcard                         = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0270D752E9F0 0x80 AttributeWildcard           ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.SelfReferenceCount                        = GetInt32(new IntPtr(p + 0x088)); // 0270D752EA10 0x88 SelfReferenceCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
