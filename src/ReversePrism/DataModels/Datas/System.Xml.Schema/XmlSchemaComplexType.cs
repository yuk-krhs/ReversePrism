using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 Block                                    0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0A0 ContentModel                             0001865B21E0 ModelClassType XmlSchemaContentModel XmlSchemaContentModel XmlSchemaContentModel Pointer
    // 0A8 Particle                                 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 0B0 Attributes                               0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 0B8 AnyAttribute                             0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 0C0 ContentTypeParticle                      0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 0C8 BlockResolved                            0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0D0 LocalElements                            0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0D8 AttributeUses                            0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 0E0 AttributeWildcard                        0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 000 anyTypeLax                               XmlSchemaComplexType IL2CPP_TYPE_CLASS
    // 008 anyTypeSkip                              XmlSchemaComplexType IL2CPP_TYPE_CLASS
    // 010 UntypedAnyType                           0001865B1820 ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer
    // 0E8 PvFlags                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
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

            value.Block                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x098)); // 02466753B1B0 0x98 Block                       ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.ContentModel                              = GetObject<XmlSchemaContentModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaContentModel.FromPointer); // 02466753B1D0 0xA0 ContentModel                ( 0001865B21E0 ModelClassType XmlSchemaContentModel XmlSchemaContentModel XmlSchemaContentModel Pointer )
            value.Particle                                  = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 02466753B1F0 0xA8 Particle                    ( 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.Attributes                                = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 02466753B210 0xB0 Attributes                  ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 02466753B230 0xB8 AnyAttribute                ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.ContentTypeParticle                       = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 02466753B250 0xC0 ContentTypeParticle         ( 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.BlockResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x0C8)); // 02466753B270 0xC8 BlockResolved               ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.LocalElements                             = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 02466753B290 0xD0 LocalElements               ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeUses                             = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 02466753B2B0 0xD8 AttributeUses               ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeWildcard                         = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 02466753B2D0 0xE0 AttributeWildcard           ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.UntypedAnyType                            = GetObject<XmlSchemaComplexType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaComplexType.FromPointer); // 02466753B330 0x10 UntypedAnyType              ( 0001865B1820 ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer )
            value.PvFlags                                   = GetSByte(new IntPtr(p + 0x0E8)); // 02466753B350 0xE8 PvFlags                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
