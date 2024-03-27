using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Datatype                                 000186687B60 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 018 DerivedRestriction                       000186674560 ModelClassType RestrictionFacets RestrictionFacets RestrictionFacets Pointer
    // 020 BaseFlags                                000186674A40 ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    // 024 BaseFixedFlags                           000186674A40 ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    // 028 ValidRestrictionFlags                    000186674A40 ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    // 030 NonNegativeInt                           0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 038 BuiltInType                              0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 040 BuiltInEnum                              0001865CF010 ModelEnumType XmlTypeCode XmlTypeCode XmlTypeCode Int32
    // 044 FirstPattern                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 RegStr                                   000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 050 Pattern_facet                            0001865BDA60 ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer
    // 000 c_map                                    Map[] IL2CPP_TYPE_SZARRAY
    public partial class FacetsCompiler
    {
        public DatatypeImplementation?                  Datatype                                { get; set; }
        public RestrictionFacets?                       DerivedRestriction                      { get; set; }
        public RestrictionFlags                         BaseFlags                               { get; set; }
        public RestrictionFlags                         BaseFixedFlags                          { get; set; }
        public RestrictionFlags                         ValidRestrictionFlags                   { get; set; }
        public XmlSchemaDatatype?                       NonNegativeInt                          { get; set; }
        public XmlSchemaDatatype?                       BuiltInType                             { get; set; }
        public XmlTypeCode                              BuiltInEnum                             { get; set; }
        public bool                                     FirstPattern                            { get; set; }
        public StringBuilder?                           RegStr                                  { get; set; }
        public XmlSchemaPatternFacet?                   Pattern_facet                           { get; set; }

        public static FacetsCompiler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FacetsCompiler();

            value.Datatype                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x010), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0270D7527478 0x10 Datatype                    ( 000186687B60 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.DerivedRestriction                        = GetObject<RestrictionFacets>(new IntPtr(p + 0x018), ReversePrism.DataModels.RestrictionFacets.FromPointer); // 0270D7527498 0x18 DerivedRestriction          ( 000186674560 ModelClassType RestrictionFacets RestrictionFacets RestrictionFacets Pointer )
            value.BaseFlags                                 = (RestrictionFlags)GetInt32(new IntPtr(p + 0x020)); // 0270D75274B8 0x20 BaseFlags                   ( 000186674A40 ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )
            value.BaseFixedFlags                            = (RestrictionFlags)GetInt32(new IntPtr(p + 0x024)); // 0270D75274D8 0x24 BaseFixedFlags              ( 000186674A40 ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )
            value.ValidRestrictionFlags                     = (RestrictionFlags)GetInt32(new IntPtr(p + 0x028)); // 0270D75274F8 0x28 ValidRestrictionFlags       ( 000186674A40 ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )
            value.NonNegativeInt                            = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0270D7527518 0x30 NonNegativeInt              ( 0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.BuiltInType                               = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0270D7527538 0x38 BuiltInType                 ( 0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.BuiltInEnum                               = (XmlTypeCode)GetInt32(new IntPtr(p + 0x040)); // 0270D7527558 0x40 BuiltInEnum                 ( 0001865CF010 ModelEnumType XmlTypeCode XmlTypeCode XmlTypeCode Int32 )
            value.FirstPattern                              = GetBool(new IntPtr(p + 0x044)); // 0270D7527578 0x44 FirstPattern                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RegStr                                    = GetObject<StringBuilder>(new IntPtr(p + 0x048), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D7527598 0x48 RegStr                      ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.Pattern_facet                             = GetObject<XmlSchemaPatternFacet>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaPatternFacet.FromPointer); // 0270D75275B8 0x50 Pattern_facet               ( 0001865BDA60 ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer )

            return value;
        }
    }
}
