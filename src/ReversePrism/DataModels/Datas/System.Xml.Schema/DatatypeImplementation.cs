using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Variety                                  ModelEnumType XmlSchemaDatatypeVariety XmlSchemaDatatypeVariety XmlSchemaDatatypeVariety Int32
    // 018 Restriction                              ModelClassType RestrictionFacets RestrictionFacets RestrictionFacets Pointer
    // 020 BaseType                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 028 ValueConverter                           ModelClassType XmlValueConverter XmlValueConverter XmlValueConverter Pointer
    // 030 ParentSchemaType                         ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 000 builtinTypes                             Hashtable IL2CPP_TYPE_CLASS
    // 008 enumToTypeCode                           XmlSchemaSimpleType[] IL2CPP_TYPE_SZARRAY
    // 010 AnySimpleType                            ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 018 AnyAtomicType                            ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 020 UntypedAtomicType                        ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 028 YearMonthDurationType                    ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 030 DayTimeDurationType                      ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 038 NormalizedStringTypeV1Compat             ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 040 TokenTypeV1Compat                        ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 048 QnAnySimpleType                          ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 050 QnAnyType                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 058 StringFacetsChecker                      ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 060 MiscFacetsChecker                        ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 068 Numeric2FacetsChecker                    ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 070 BinaryFacetsChecker                      ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 078 DateTimeFacetsChecker                    ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 080 DurationFacetsChecker                    ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 088 ListFacetsChecker                        ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 090 QnameFacetsChecker                       ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 098 UnionFacetsChecker                       ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer
    // 0A0 C_anySimpleType                          ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0A8 C_anyURI                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0B0 C_base64Binary                           ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0B8 C_boolean                                ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0C0 C_byte                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0C8 C_char                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0D0 C_date                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0D8 C_dateTime                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0E0 C_dateTimeNoTz                           ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0E8 C_dateTimeTz                             ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0F0 C_day                                    ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 0F8 C_decimal                                ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 100 C_double                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 108 C_doubleXdr                              ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 110 C_duration                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 118 C_ENTITY                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 120 C_ENTITIES                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 128 C_ENUMERATION                            ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 130 C_fixed                                  ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 138 C_float                                  ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 140 C_floatXdr                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 148 C_hexBinary                              ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 150 C_ID                                     ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 158 C_IDREF                                  ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 160 C_IDREFS                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 168 C_int                                    ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 170 C_integer                                ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 178 C_language                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 180 C_long                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 188 C_month                                  ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 190 C_monthDay                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 198 C_Name                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1A0 C_NCName                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1A8 C_negativeInteger                        ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1B0 C_NMTOKEN                                ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1B8 C_NMTOKENS                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1C0 C_nonNegativeInteger                     ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1C8 C_nonPositiveInteger                     ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1D0 C_normalizedString                       ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1D8 C_NOTATION                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1E0 C_positiveInteger                        ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1E8 C_QName                                  ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1F0 C_QNameXdr                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 1F8 C_short                                  ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 200 C_string                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 208 C_time                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 210 C_timeNoTz                               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 218 C_timeTz                                 ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 220 C_token                                  ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 228 C_unsignedByte                           ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 230 C_unsignedInt                            ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 238 C_unsignedLong                           ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 240 C_unsignedShort                          ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 248 C_uuid                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 250 C_year                                   ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 258 C_yearMonth                              ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 260 C_normalizedStringV1Compat               ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 268 C_tokenV1Compat                          ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 270 C_anyAtomicType                          ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 278 C_dayTimeDuration                        ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 280 C_untypedAtomicType                      ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 288 C_yearMonthDuration                      ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer
    // 290 C_tokenizedTypes                         ModelClassListType DatatypeImplementation[] DatatypeImplementation[] List<DatatypeImplementation> Pointer
    // 298 C_tokenizedTypesXsd                      ModelClassListType DatatypeImplementation[] DatatypeImplementation[] List<DatatypeImplementation> Pointer
    // 2A0 C_XdrTypes                               ModelClassListType SchemaDatatypeMap[] SchemaDatatypeMap[] List<SchemaDatatypeMap> Pointer
    // 2A8 C_XsdTypes                               ModelClassListType SchemaDatatypeMap[] SchemaDatatypeMap[] List<SchemaDatatypeMap> Pointer
    public partial class DatatypeImplementation : DataModel
    {
        public XmlSchemaDatatypeVariety                 Variety                                 { get; set; }
        public RestrictionFacets?                       Restriction                             { get; set; }
        public DatatypeImplementation?                  BaseType                                { get; set; }
        public XmlValueConverter?                       ValueConverter                          { get; set; }
        public XmlSchemaType?                           ParentSchemaType                        { get; set; }
        public XmlSchemaSimpleType?                     AnySimpleType                           { get; set; }
        public XmlSchemaSimpleType?                     AnyAtomicType                           { get; set; }
        public XmlSchemaSimpleType?                     UntypedAtomicType                       { get; set; }
        public XmlSchemaSimpleType?                     YearMonthDurationType                   { get; set; }
        public XmlSchemaSimpleType?                     DayTimeDurationType                     { get; set; }
        public XmlSchemaSimpleType?                     NormalizedStringTypeV1Compat            { get; set; }
        public XmlSchemaSimpleType?                     TokenTypeV1Compat                       { get; set; }
        public XmlQualifiedName?                        QnAnySimpleType                         { get; set; }
        public XmlQualifiedName?                        QnAnyType                               { get; set; }
        public FacetsChecker?                           StringFacetsChecker                     { get; set; }
        public FacetsChecker?                           MiscFacetsChecker                       { get; set; }
        public FacetsChecker?                           Numeric2FacetsChecker                   { get; set; }
        public FacetsChecker?                           BinaryFacetsChecker                     { get; set; }
        public FacetsChecker?                           DateTimeFacetsChecker                   { get; set; }
        public FacetsChecker?                           DurationFacetsChecker                   { get; set; }
        public FacetsChecker?                           ListFacetsChecker                       { get; set; }
        public FacetsChecker?                           QnameFacetsChecker                      { get; set; }
        public FacetsChecker?                           UnionFacetsChecker                      { get; set; }
        public DatatypeImplementation?                  C_anySimpleType                         { get; set; }
        public DatatypeImplementation?                  C_anyURI                                { get; set; }
        public DatatypeImplementation?                  C_base64Binary                          { get; set; }
        public DatatypeImplementation?                  C_boolean                               { get; set; }
        public DatatypeImplementation?                  C_byte                                  { get; set; }
        public DatatypeImplementation?                  C_char                                  { get; set; }
        public DatatypeImplementation?                  C_date                                  { get; set; }
        public DatatypeImplementation?                  C_dateTime                              { get; set; }
        public DatatypeImplementation?                  C_dateTimeNoTz                          { get; set; }
        public DatatypeImplementation?                  C_dateTimeTz                            { get; set; }
        public DatatypeImplementation?                  C_day                                   { get; set; }
        public DatatypeImplementation?                  C_decimal                               { get; set; }
        public DatatypeImplementation?                  C_double                                { get; set; }
        public DatatypeImplementation?                  C_doubleXdr                             { get; set; }
        public DatatypeImplementation?                  C_duration                              { get; set; }
        public DatatypeImplementation?                  C_ENTITY                                { get; set; }
        public DatatypeImplementation?                  C_ENTITIES                              { get; set; }
        public DatatypeImplementation?                  C_ENUMERATION                           { get; set; }
        public DatatypeImplementation?                  C_fixed                                 { get; set; }
        public DatatypeImplementation?                  C_float                                 { get; set; }
        public DatatypeImplementation?                  C_floatXdr                              { get; set; }
        public DatatypeImplementation?                  C_hexBinary                             { get; set; }
        public DatatypeImplementation?                  C_ID                                    { get; set; }
        public DatatypeImplementation?                  C_IDREF                                 { get; set; }
        public DatatypeImplementation?                  C_IDREFS                                { get; set; }
        public DatatypeImplementation?                  C_int                                   { get; set; }
        public DatatypeImplementation?                  C_integer                               { get; set; }
        public DatatypeImplementation?                  C_language                              { get; set; }
        public DatatypeImplementation?                  C_long                                  { get; set; }
        public DatatypeImplementation?                  C_month                                 { get; set; }
        public DatatypeImplementation?                  C_monthDay                              { get; set; }
        public DatatypeImplementation?                  C_Name                                  { get; set; }
        public DatatypeImplementation?                  C_NCName                                { get; set; }
        public DatatypeImplementation?                  C_negativeInteger                       { get; set; }
        public DatatypeImplementation?                  C_NMTOKEN                               { get; set; }
        public DatatypeImplementation?                  C_NMTOKENS                              { get; set; }
        public DatatypeImplementation?                  C_nonNegativeInteger                    { get; set; }
        public DatatypeImplementation?                  C_nonPositiveInteger                    { get; set; }
        public DatatypeImplementation?                  C_normalizedString                      { get; set; }
        public DatatypeImplementation?                  C_NOTATION                              { get; set; }
        public DatatypeImplementation?                  C_positiveInteger                       { get; set; }
        public DatatypeImplementation?                  C_QName                                 { get; set; }
        public DatatypeImplementation?                  C_QNameXdr                              { get; set; }
        public DatatypeImplementation?                  C_short                                 { get; set; }
        public DatatypeImplementation?                  C_string                                { get; set; }
        public DatatypeImplementation?                  C_time                                  { get; set; }
        public DatatypeImplementation?                  C_timeNoTz                              { get; set; }
        public DatatypeImplementation?                  C_timeTz                                { get; set; }
        public DatatypeImplementation?                  C_token                                 { get; set; }
        public DatatypeImplementation?                  C_unsignedByte                          { get; set; }
        public DatatypeImplementation?                  C_unsignedInt                           { get; set; }
        public DatatypeImplementation?                  C_unsignedLong                          { get; set; }
        public DatatypeImplementation?                  C_unsignedShort                         { get; set; }
        public DatatypeImplementation?                  C_uuid                                  { get; set; }
        public DatatypeImplementation?                  C_year                                  { get; set; }
        public DatatypeImplementation?                  C_yearMonth                             { get; set; }
        public DatatypeImplementation?                  C_normalizedStringV1Compat              { get; set; }
        public DatatypeImplementation?                  C_tokenV1Compat                         { get; set; }
        public DatatypeImplementation?                  C_anyAtomicType                         { get; set; }
        public DatatypeImplementation?                  C_dayTimeDuration                       { get; set; }
        public DatatypeImplementation?                  C_untypedAtomicType                     { get; set; }
        public DatatypeImplementation?                  C_yearMonthDuration                     { get; set; }
        public List<DatatypeImplementation>?            C_tokenizedTypes                        { get; set; }
        public List<DatatypeImplementation>?            C_tokenizedTypesXsd                     { get; set; }
        public List<SchemaDatatypeMap>?                 C_XdrTypes                              { get; set; }
        public List<SchemaDatatypeMap>?                 C_XsdTypes                              { get; set; }

        public static DatatypeImplementation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DatatypeImplementation() { Pointer= p0 };

            value.Variety                                   = (XmlSchemaDatatypeVariety)GetInt32(new IntPtr(p + 0x010)); // 0x10 Variety                     ( ModelEnumType XmlSchemaDatatypeVariety XmlSchemaDatatypeVariety XmlSchemaDatatypeVariety Int32 )
            value.Restriction                               = GetObject<RestrictionFacets>(new IntPtr(p + 0x018), ReversePrism.DataModels.RestrictionFacets.FromPointer); // 0x18 Restriction                 ( ModelClassType RestrictionFacets RestrictionFacets RestrictionFacets Pointer )
            value.BaseType                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x020), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x20 BaseType                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.ValueConverter                            = GetObject<XmlValueConverter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlValueConverter.FromPointer); // 0x28 ValueConverter              ( ModelClassType XmlValueConverter XmlValueConverter XmlValueConverter Pointer )
            value.ParentSchemaType                          = GetObject<XmlSchemaType>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x30 ParentSchemaType            ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.AnySimpleType                             = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x10 AnySimpleType               ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.AnyAtomicType                             = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x18 AnyAtomicType               ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.UntypedAtomicType                         = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x20 UntypedAtomicType           ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.YearMonthDurationType                     = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x28 YearMonthDurationType       ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.DayTimeDurationType                       = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x30 DayTimeDurationType         ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.NormalizedStringTypeV1Compat              = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x38 NormalizedStringTypeV1Compat ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.TokenTypeV1Compat                         = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x40 TokenTypeV1Compat           ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.QnAnySimpleType                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x48 QnAnySimpleType             ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnAnyType                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x50 QnAnyType                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.StringFacetsChecker                       = GetObject<FacetsChecker>(new IntPtr(p + 0x058), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x58 StringFacetsChecker         ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.MiscFacetsChecker                         = GetObject<FacetsChecker>(new IntPtr(p + 0x060), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x60 MiscFacetsChecker           ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.Numeric2FacetsChecker                     = GetObject<FacetsChecker>(new IntPtr(p + 0x068), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x68 Numeric2FacetsChecker       ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.BinaryFacetsChecker                       = GetObject<FacetsChecker>(new IntPtr(p + 0x070), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x70 BinaryFacetsChecker         ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.DateTimeFacetsChecker                     = GetObject<FacetsChecker>(new IntPtr(p + 0x078), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x78 DateTimeFacetsChecker       ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.DurationFacetsChecker                     = GetObject<FacetsChecker>(new IntPtr(p + 0x080), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x80 DurationFacetsChecker       ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.ListFacetsChecker                         = GetObject<FacetsChecker>(new IntPtr(p + 0x088), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x88 ListFacetsChecker           ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.QnameFacetsChecker                        = GetObject<FacetsChecker>(new IntPtr(p + 0x090), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x90 QnameFacetsChecker          ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.UnionFacetsChecker                        = GetObject<FacetsChecker>(new IntPtr(p + 0x098), ReversePrism.DataModels.FacetsChecker.FromPointer); // 0x98 UnionFacetsChecker          ( ModelClassType FacetsChecker FacetsChecker FacetsChecker Pointer )
            value.C_anySimpleType                           = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xA0 C_anySimpleType             ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_anyURI                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xA8 C_anyURI                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_base64Binary                            = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xB0 C_base64Binary              ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_boolean                                 = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xB8 C_boolean                   ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_byte                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xC0 C_byte                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_char                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xC8 C_char                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_date                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xD0 C_date                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_dateTime                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xD8 C_dateTime                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_dateTimeNoTz                            = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xE0 C_dateTimeNoTz              ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_dateTimeTz                              = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xE8 C_dateTimeTz                ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_day                                     = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xF0 C_day                       ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_decimal                                 = GetObject<DatatypeImplementation>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0xF8 C_decimal                   ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_double                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x100), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x100 C_double                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_doubleXdr                               = GetObject<DatatypeImplementation>(new IntPtr(p + 0x108), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x108 C_doubleXdr                 ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_duration                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x110), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x110 C_duration                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_ENTITY                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x118), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x118 C_ENTITY                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_ENTITIES                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x120), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x120 C_ENTITIES                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_ENUMERATION                             = GetObject<DatatypeImplementation>(new IntPtr(p + 0x128), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x128 C_ENUMERATION               ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_fixed                                   = GetObject<DatatypeImplementation>(new IntPtr(p + 0x130), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x130 C_fixed                     ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_float                                   = GetObject<DatatypeImplementation>(new IntPtr(p + 0x138), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x138 C_float                     ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_floatXdr                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x140), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x140 C_floatXdr                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_hexBinary                               = GetObject<DatatypeImplementation>(new IntPtr(p + 0x148), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x148 C_hexBinary                 ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_ID                                      = GetObject<DatatypeImplementation>(new IntPtr(p + 0x150), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x150 C_ID                        ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_IDREF                                   = GetObject<DatatypeImplementation>(new IntPtr(p + 0x158), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x158 C_IDREF                     ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_IDREFS                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x160), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x160 C_IDREFS                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_int                                     = GetObject<DatatypeImplementation>(new IntPtr(p + 0x168), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x168 C_int                       ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_integer                                 = GetObject<DatatypeImplementation>(new IntPtr(p + 0x170), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x170 C_integer                   ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_language                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x178), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x178 C_language                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_long                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x180), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x180 C_long                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_month                                   = GetObject<DatatypeImplementation>(new IntPtr(p + 0x188), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x188 C_month                     ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_monthDay                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x190), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x190 C_monthDay                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_Name                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x198), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x198 C_Name                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_NCName                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1A0 C_NCName                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_negativeInteger                         = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1A8 C_negativeInteger           ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_NMTOKEN                                 = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1B0 C_NMTOKEN                   ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_NMTOKENS                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1B8 C_NMTOKENS                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_nonNegativeInteger                      = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1C0 C_nonNegativeInteger        ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_nonPositiveInteger                      = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1C8 C_nonPositiveInteger        ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_normalizedString                        = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1D0 C_normalizedString          ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_NOTATION                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1D8 C_NOTATION                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_positiveInteger                         = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1E0 C_positiveInteger           ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_QName                                   = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1E8 C_QName                     ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_QNameXdr                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1F0 C_QNameXdr                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_short                                   = GetObject<DatatypeImplementation>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x1F8 C_short                     ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_string                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x200), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x200 C_string                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_time                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x208), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x208 C_time                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_timeNoTz                                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x210), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x210 C_timeNoTz                  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_timeTz                                  = GetObject<DatatypeImplementation>(new IntPtr(p + 0x218), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x218 C_timeTz                    ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_token                                   = GetObject<DatatypeImplementation>(new IntPtr(p + 0x220), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x220 C_token                     ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_unsignedByte                            = GetObject<DatatypeImplementation>(new IntPtr(p + 0x228), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x228 C_unsignedByte              ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_unsignedInt                             = GetObject<DatatypeImplementation>(new IntPtr(p + 0x230), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x230 C_unsignedInt               ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_unsignedLong                            = GetObject<DatatypeImplementation>(new IntPtr(p + 0x238), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x238 C_unsignedLong              ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_unsignedShort                           = GetObject<DatatypeImplementation>(new IntPtr(p + 0x240), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x240 C_unsignedShort             ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_uuid                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x248), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x248 C_uuid                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_year                                    = GetObject<DatatypeImplementation>(new IntPtr(p + 0x250), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x250 C_year                      ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_yearMonth                               = GetObject<DatatypeImplementation>(new IntPtr(p + 0x258), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x258 C_yearMonth                 ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_normalizedStringV1Compat                = GetObject<DatatypeImplementation>(new IntPtr(p + 0x260), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x260 C_normalizedStringV1Compat  ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_tokenV1Compat                           = GetObject<DatatypeImplementation>(new IntPtr(p + 0x268), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x268 C_tokenV1Compat             ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_anyAtomicType                           = GetObject<DatatypeImplementation>(new IntPtr(p + 0x270), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x270 C_anyAtomicType             ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_dayTimeDuration                         = GetObject<DatatypeImplementation>(new IntPtr(p + 0x278), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x278 C_dayTimeDuration           ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_untypedAtomicType                       = GetObject<DatatypeImplementation>(new IntPtr(p + 0x280), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x280 C_untypedAtomicType         ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_yearMonthDuration                       = GetObject<DatatypeImplementation>(new IntPtr(p + 0x288), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x288 C_yearMonthDuration         ( ModelClassType DatatypeImplementation DatatypeImplementation DatatypeImplementation Pointer )
            value.C_tokenizedTypes                          = GetObjectList<DatatypeImplementation>(new IntPtr(p + 0x290), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x290 C_tokenizedTypes            ( ModelClassListType DatatypeImplementation[] DatatypeImplementation[] List<DatatypeImplementation> Pointer )
            value.C_tokenizedTypesXsd                       = GetObjectList<DatatypeImplementation>(new IntPtr(p + 0x298), ReversePrism.DataModels.DatatypeImplementation.FromPointer); // 0x298 C_tokenizedTypesXsd         ( ModelClassListType DatatypeImplementation[] DatatypeImplementation[] List<DatatypeImplementation> Pointer )
            value.C_XdrTypes                                = GetObjectList<SchemaDatatypeMap>(new IntPtr(p + 0x2A0), ReversePrism.DataModels.SchemaDatatypeMap.FromPointer); // 0x2A0 C_XdrTypes                  ( ModelClassListType SchemaDatatypeMap[] SchemaDatatypeMap[] List<SchemaDatatypeMap> Pointer )
            value.C_XsdTypes                                = GetObjectList<SchemaDatatypeMap>(new IntPtr(p + 0x2A8), ReversePrism.DataModels.SchemaDatatypeMap.FromPointer); // 0x2A8 C_XsdTypes                  ( ModelClassListType SchemaDatatypeMap[] SchemaDatatypeMap[] List<SchemaDatatypeMap> Pointer )

            return value;
        }
    }
}
