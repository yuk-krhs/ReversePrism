using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Datatype                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 018 DerivedRestriction                       ModelClassType RestrictionFacets RestrictionFacets RestrictionFacets Pointer
    // 020 BaseFlags                                ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    // 024 BaseFixedFlags                           ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    // 028 ValidRestrictionFlags                    ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    // 030 NonNegativeInt                           ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 038 BuiltInType                              ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 040 BuiltInEnum                              ModelEnumType XmlTypeCode XmlTypeCode XmlTypeCode Int32
    // 044 FirstPattern                             ModelPrimitiveType bool bool bool Bool
    // 048 RegStr                                   ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 050 Pattern_facet                            ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer
    // 000 c_map                                    Map[] IL2CPP_TYPE_SZARRAY
    public partial class FacetsCompiler : DataModel
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
            var value   = new FacetsCompiler() { Pointer= p0 };

            value.Datatype                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x010), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x10 Datatype                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.DerivedRestriction                        = GetObject<RestrictionFacets>(new IntPtr(p + 0x018), ReversePrism.DataModels.RestrictionFacets.FromPointer); // 0x18 DerivedRestriction          ( ModelClassType RestrictionFacets RestrictionFacets RestrictionFacets Pointer )
            value.BaseFlags                                 = (RestrictionFlags)GetInt32(new IntPtr(p + 0x020)); // 0x20 BaseFlags                   ( ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )
            value.BaseFixedFlags                            = (RestrictionFlags)GetInt32(new IntPtr(p + 0x024)); // 0x24 BaseFixedFlags              ( ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )
            value.ValidRestrictionFlags                     = (RestrictionFlags)GetInt32(new IntPtr(p + 0x028)); // 0x28 ValidRestrictionFlags       ( ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )
            value.NonNegativeInt                            = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x30 NonNegativeInt              ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.BuiltInType                               = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x38 BuiltInType                 ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.BuiltInEnum                               = (XmlTypeCode)GetInt32(new IntPtr(p + 0x040)); // 0x40 BuiltInEnum                 ( ModelEnumType XmlTypeCode XmlTypeCode XmlTypeCode Int32 )
            value.FirstPattern                              = GetBool(new IntPtr(p + 0x044)); // 0x44 FirstPattern                ( ModelPrimitiveType bool bool bool Bool )
            value.RegStr                                    = GetObject<StringBuilder>(new IntPtr(p + 0x048), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x48 RegStr                      ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.Pattern_facet                             = GetObject<XmlSchemaPatternFacet>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaPatternFacet.FromPointer); // 0x50 Pattern_facet               ( ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer )

            return value;
        }
    }
}
