using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 Block                                    ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0A0 ContentModel                             ModelClassType XmlSchemaContentModel XmlSchemaContentModel XmlSchemaContentModel Pointer
    // 0A8 Particle                                 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 0B0 Attributes                               ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 0B8 AnyAttribute                             ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 0C0 ContentTypeParticle                      ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 0C8 BlockResolved                            ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0D0 LocalElements                            ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0D8 AttributeUses                            ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0E0 AttributeWildcard                        ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 000 anyTypeLax                               XmlSchemaComplexType IL2CPP_TYPE_CLASS
    // 008 anyTypeSkip                              XmlSchemaComplexType IL2CPP_TYPE_CLASS
    // 010 UntypedAnyType                           ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer
    // 0E8 PvFlags                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class XmlSchemaComplexType : DataModel
    {
        public XmlSchemaDerivationMethod                Block                                   { get; set; }
        public XmlSchemaContentModel?                   ContentModel                            { get; set; }
        public XmlSchemaParticle?                       Particle                                { get; set; }
        public XmlSchemaObjectCollection?               Attributes                              { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }
        public XmlSchemaParticle?                       ContentTypeParticle                     { get; set; }
        public XmlSchemaDerivationMethod                BlockResolved                           { get; set; }
        public XmlSchemaObjectTable?                    LocalElements                           { get; set; }
        public XmlSchemaObjectTable?                    AttributeUses                           { get; set; }
        public XmlSchemaAnyAttribute?                   AttributeWildcard                       { get; set; }
        public XmlSchemaComplexType?                    UntypedAnyType                          { get; set; }
        public sbyte                                    PvFlags                                 { get; set; }

        public static XmlSchemaComplexType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaComplexType() { Pointer= p0 };

            value.Block                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x098)); // 0x98 Block                       ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.ContentModel                              = GetObject<XmlSchemaContentModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaContentModel.FromPointer); // 0xA0 ContentModel                ( ModelClassType XmlSchemaContentModel XmlSchemaContentModel XmlSchemaContentModel Pointer )
            value.Particle                                  = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 0xA8 Particle                    ( ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0xB0 Attributes                  ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0xB8 AnyAttribute                ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.ContentTypeParticle                       = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 0xC0 ContentTypeParticle         ( ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.BlockResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 BlockResolved               ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.LocalElements                             = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0xD0 LocalElements               ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeUses                             = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0xD8 AttributeUses               ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeWildcard                         = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0xE0 AttributeWildcard           ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.UntypedAnyType                            = GetObject<XmlSchemaComplexType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaComplexType.FromPointer); // 0x10 UntypedAnyType              ( ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer )
            value.PvFlags                                   = GetSByte(new IntPtr(p + 0x0E8)); // 0xE8 PvFlags                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
