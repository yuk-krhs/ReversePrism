using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Particle                                 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 058 Attributes                               ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 060 AnyAttribute                             ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 068 BaseTypeName                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSchemaComplexContentExtension : DataModel
    {
        public XmlSchemaParticle?                       Particle                                { get; set; }
        public XmlSchemaObjectCollection?               Attributes                              { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }
        public XmlQualifiedName?                        BaseTypeName                            { get; set; }

        public static XmlSchemaComplexContentExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaComplexContentExtension() { Pointer= p0 };

            value.Particle                                  = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 0x50 Particle                    ( ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x58 Attributes                  ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0x60 AnyAttribute                ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.BaseTypeName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x68 BaseTypeName                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}
