using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     ModelPrimitiveType string string string String
    // 058 Attributes                               ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 060 AnyAttribute                             ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 068 Qname                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 070 Redefined                                ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer
    // 078 AttributeUses                            ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 080 AttributeWildcard                        ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 088 SelfReferenceCount                       ModelPrimitiveType int int int Int32
    public partial class XmlSchemaAttributeGroup : DataModel
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
            var value   = new XmlSchemaAttributeGroup() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0x50 Name                        ( ModelPrimitiveType string string string String )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x58 Attributes                  ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0x60 AnyAttribute                ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x68 Qname                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Redefined                                 = GetObject<XmlSchemaAttributeGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaAttributeGroup.FromPointer); // 0x70 Redefined                   ( ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer )
            value.AttributeUses                             = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x78 AttributeUses               ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeWildcard                         = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0x80 AttributeWildcard           ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.SelfReferenceCount                        = GetInt32(new IntPtr(p + 0x088)); // 0x88 SelfReferenceCount          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
