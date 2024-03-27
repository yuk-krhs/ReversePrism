using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Particle                                 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 058 Attributes                               0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 060 AnyAttribute                             0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 068 BaseTypeName                             0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSchemaComplexContentRestriction
    {
        public XmlSchemaParticle?                       Particle                                { get; set; }
        public XmlSchemaObjectCollection?               Attributes                              { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }
        public XmlQualifiedName?                        BaseTypeName                            { get; set; }

        public static XmlSchemaComplexContentRestriction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaComplexContentRestriction();

            value.Particle                                  = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 0270D7552F30 0x50 Particle                    ( 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D7552F50 0x58 Attributes                  ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0270D7552F70 0x60 AnyAttribute                ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.BaseTypeName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7552F90 0x68 BaseTypeName                ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}
