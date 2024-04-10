using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 018 NsDataType                               0001866722E0 ModelPrimitiveType string string string String
    // 020 NsDataTypeAlias                          0001866722E0 ModelPrimitiveType string string string String
    // 028 NsDataTypeOld                            0001866722E0 ModelPrimitiveType string string string String
    // 030 NsXml                                    0001866722E0 ModelPrimitiveType string string string String
    // 038 NsXmlNs                                  0001866722E0 ModelPrimitiveType string string string String
    // 040 NsXdr                                    0001866722E0 ModelPrimitiveType string string string String
    // 048 NsXdrAlias                               0001866722E0 ModelPrimitiveType string string string String
    // 050 NsXs                                     0001866722E0 ModelPrimitiveType string string string String
    // 058 NsXsi                                    0001866722E0 ModelPrimitiveType string string string String
    // 060 XsiType                                  0001866722E0 ModelPrimitiveType string string string String
    // 068 XsiNil                                   0001866722E0 ModelPrimitiveType string string string String
    // 070 XsiSchemaLocation                        0001866722E0 ModelPrimitiveType string string string String
    // 078 XsiNoNamespaceSchemaLocation             0001866722E0 ModelPrimitiveType string string string String
    // 080 XsdSchema                                0001866722E0 ModelPrimitiveType string string string String
    // 088 XdrSchema                                0001866722E0 ModelPrimitiveType string string string String
    // 090 QnPCData                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 098 QnXml                                    0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0A0 QnXmlNs                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0A8 QnDtDt                                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B0 QnXmlLang                                0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B8 QnName                                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0C0 QnType                                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0C8 QnMaxOccurs                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0D0 QnMinOccurs                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0D8 QnInfinite                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0E0 QnModel                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0E8 QnOpen                                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0F0 QnClosed                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0F8 QnContent                                0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 100 QnMixed                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 108 QnEmpty                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 110 QnEltOnly                                0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 118 QnTextOnly                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 120 QnOrder                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 128 QnSeq                                    0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 130 QnOne                                    0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 138 QnMany                                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 140 QnRequired                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 148 QnYes                                    0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 150 QnNo                                     0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 158 QnString                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 160 QnID                                     0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 168 QnIDRef                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 170 QnIDRefs                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 178 QnEntity                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 180 QnEntities                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 188 QnNmToken                                0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 190 QnNmTokens                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 198 QnEnumeration                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1A0 QnDefault                                0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1A8 QnXdrSchema                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1B0 QnXdrElementType                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1B8 QnXdrElement                             0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1C0 QnXdrGroup                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1C8 QnXdrAttributeType                       0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1D0 QnXdrAttribute                           0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1D8 QnXdrDataType                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1E0 QnXdrDescription                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1E8 QnXdrExtends                             0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1F0 QnXdrAliasSchema                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1F8 QnDtType                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 200 QnDtValues                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 208 QnDtMaxLength                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 210 QnDtMinLength                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 218 QnDtMax                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 220 QnDtMin                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 228 QnDtMinExclusive                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 230 QnDtMaxExclusive                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 238 QnTargetNamespace                        0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 240 QnVersion                                0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 248 QnFinalDefault                           0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 250 QnBlockDefault                           0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 258 QnFixed                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 260 QnAbstract                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 268 QnBlock                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 270 QnSubstitutionGroup                      0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 278 QnFinal                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 280 QnNillable                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 288 QnRef                                    0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 290 QnBase                                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 298 QnDerivedBy                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2A0 QnNamespace                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2A8 QnProcessContents                        0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2B0 QnRefer                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2B8 QnPublic                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2C0 QnSystem                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2C8 QnSchemaLocation                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2D0 QnValue                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2D8 QnUse                                    0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2E0 QnForm                                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2E8 QnElementFormDefault                     0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2F0 QnAttributeFormDefault                   0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2F8 QnItemType                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 300 QnMemberTypes                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 308 QnXPath                                  0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 310 QnXsdSchema                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 318 QnXsdAnnotation                          0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 320 QnXsdInclude                             0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 328 QnXsdImport                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 330 QnXsdElement                             0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 338 QnXsdAttribute                           0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 340 QnXsdAttributeGroup                      0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 348 QnXsdAnyAttribute                        0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 350 QnXsdGroup                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 358 QnXsdAll                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 360 QnXsdChoice                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 368 QnXsdSequence                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 370 QnXsdAny                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 378 QnXsdNotation                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 380 QnXsdSimpleType                          0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 388 QnXsdComplexType                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 390 QnXsdUnique                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 398 QnXsdKey                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3A0 QnXsdKeyRef                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3A8 QnXsdSelector                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3B0 QnXsdField                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3B8 QnXsdMinExclusive                        0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3C0 QnXsdMinInclusive                        0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3C8 QnXsdMaxInclusive                        0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3D0 QnXsdMaxExclusive                        0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3D8 QnXsdTotalDigits                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3E0 QnXsdFractionDigits                      0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3E8 QnXsdLength                              0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3F0 QnXsdMinLength                           0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3F8 QnXsdMaxLength                           0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 400 QnXsdEnumeration                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 408 QnXsdPattern                             0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 410 QnXsdDocumentation                       0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 418 QnXsdAppinfo                             0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 420 QnSource                                 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 428 QnXsdComplexContent                      0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 430 QnXsdSimpleContent                       0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 438 QnXsdRestriction                         0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 440 QnXsdExtension                           0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 448 QnXsdUnion                               0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 450 QnXsdList                                0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 458 QnXsdWhiteSpace                          0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 460 QnXsdRedefine                            0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 468 QnXsdAnyType                             0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 470 TokenToQName                             000185CB4168 ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer
    public partial class SchemaNames : DataModel
    {
        public XmlNameTable?                            NameTable                               { get; set; }
        public string                                   NsDataType                              { get; set; }
        public string                                   NsDataTypeAlias                         { get; set; }
        public string                                   NsDataTypeOld                           { get; set; }
        public string                                   NsXml                                   { get; set; }
        public string                                   NsXmlNs                                 { get; set; }
        public string                                   NsXdr                                   { get; set; }
        public string                                   NsXdrAlias                              { get; set; }
        public string                                   NsXs                                    { get; set; }
        public string                                   NsXsi                                   { get; set; }
        public string                                   XsiType                                 { get; set; }
        public string                                   XsiNil                                  { get; set; }
        public string                                   XsiSchemaLocation                       { get; set; }
        public string                                   XsiNoNamespaceSchemaLocation            { get; set; }
        public string                                   XsdSchema                               { get; set; }
        public string                                   XdrSchema                               { get; set; }
        public XmlQualifiedName?                        QnPCData                                { get; set; }
        public XmlQualifiedName?                        QnXml                                   { get; set; }
        public XmlQualifiedName?                        QnXmlNs                                 { get; set; }
        public XmlQualifiedName?                        QnDtDt                                  { get; set; }
        public XmlQualifiedName?                        QnXmlLang                               { get; set; }
        public XmlQualifiedName?                        QnName                                  { get; set; }
        public XmlQualifiedName?                        QnType                                  { get; set; }
        public XmlQualifiedName?                        QnMaxOccurs                             { get; set; }
        public XmlQualifiedName?                        QnMinOccurs                             { get; set; }
        public XmlQualifiedName?                        QnInfinite                              { get; set; }
        public XmlQualifiedName?                        QnModel                                 { get; set; }
        public XmlQualifiedName?                        QnOpen                                  { get; set; }
        public XmlQualifiedName?                        QnClosed                                { get; set; }
        public XmlQualifiedName?                        QnContent                               { get; set; }
        public XmlQualifiedName?                        QnMixed                                 { get; set; }
        public XmlQualifiedName?                        QnEmpty                                 { get; set; }
        public XmlQualifiedName?                        QnEltOnly                               { get; set; }
        public XmlQualifiedName?                        QnTextOnly                              { get; set; }
        public XmlQualifiedName?                        QnOrder                                 { get; set; }
        public XmlQualifiedName?                        QnSeq                                   { get; set; }
        public XmlQualifiedName?                        QnOne                                   { get; set; }
        public XmlQualifiedName?                        QnMany                                  { get; set; }
        public XmlQualifiedName?                        QnRequired                              { get; set; }
        public XmlQualifiedName?                        QnYes                                   { get; set; }
        public XmlQualifiedName?                        QnNo                                    { get; set; }
        public XmlQualifiedName?                        QnString                                { get; set; }
        public XmlQualifiedName?                        QnID                                    { get; set; }
        public XmlQualifiedName?                        QnIDRef                                 { get; set; }
        public XmlQualifiedName?                        QnIDRefs                                { get; set; }
        public XmlQualifiedName?                        QnEntity                                { get; set; }
        public XmlQualifiedName?                        QnEntities                              { get; set; }
        public XmlQualifiedName?                        QnNmToken                               { get; set; }
        public XmlQualifiedName?                        QnNmTokens                              { get; set; }
        public XmlQualifiedName?                        QnEnumeration                           { get; set; }
        public XmlQualifiedName?                        QnDefault                               { get; set; }
        public XmlQualifiedName?                        QnXdrSchema                             { get; set; }
        public XmlQualifiedName?                        QnXdrElementType                        { get; set; }
        public XmlQualifiedName?                        QnXdrElement                            { get; set; }
        public XmlQualifiedName?                        QnXdrGroup                              { get; set; }
        public XmlQualifiedName?                        QnXdrAttributeType                      { get; set; }
        public XmlQualifiedName?                        QnXdrAttribute                          { get; set; }
        public XmlQualifiedName?                        QnXdrDataType                           { get; set; }
        public XmlQualifiedName?                        QnXdrDescription                        { get; set; }
        public XmlQualifiedName?                        QnXdrExtends                            { get; set; }
        public XmlQualifiedName?                        QnXdrAliasSchema                        { get; set; }
        public XmlQualifiedName?                        QnDtType                                { get; set; }
        public XmlQualifiedName?                        QnDtValues                              { get; set; }
        public XmlQualifiedName?                        QnDtMaxLength                           { get; set; }
        public XmlQualifiedName?                        QnDtMinLength                           { get; set; }
        public XmlQualifiedName?                        QnDtMax                                 { get; set; }
        public XmlQualifiedName?                        QnDtMin                                 { get; set; }
        public XmlQualifiedName?                        QnDtMinExclusive                        { get; set; }
        public XmlQualifiedName?                        QnDtMaxExclusive                        { get; set; }
        public XmlQualifiedName?                        QnTargetNamespace                       { get; set; }
        public XmlQualifiedName?                        QnVersion                               { get; set; }
        public XmlQualifiedName?                        QnFinalDefault                          { get; set; }
        public XmlQualifiedName?                        QnBlockDefault                          { get; set; }
        public XmlQualifiedName?                        QnFixed                                 { get; set; }
        public XmlQualifiedName?                        QnAbstract                              { get; set; }
        public XmlQualifiedName?                        QnBlock                                 { get; set; }
        public XmlQualifiedName?                        QnSubstitutionGroup                     { get; set; }
        public XmlQualifiedName?                        QnFinal                                 { get; set; }
        public XmlQualifiedName?                        QnNillable                              { get; set; }
        public XmlQualifiedName?                        QnRef                                   { get; set; }
        public XmlQualifiedName?                        QnBase                                  { get; set; }
        public XmlQualifiedName?                        QnDerivedBy                             { get; set; }
        public XmlQualifiedName?                        QnNamespace                             { get; set; }
        public XmlQualifiedName?                        QnProcessContents                       { get; set; }
        public XmlQualifiedName?                        QnRefer                                 { get; set; }
        public XmlQualifiedName?                        QnPublic                                { get; set; }
        public XmlQualifiedName?                        QnSystem                                { get; set; }
        public XmlQualifiedName?                        QnSchemaLocation                        { get; set; }
        public XmlQualifiedName?                        QnValue                                 { get; set; }
        public XmlQualifiedName?                        QnUse                                   { get; set; }
        public XmlQualifiedName?                        QnForm                                  { get; set; }
        public XmlQualifiedName?                        QnElementFormDefault                    { get; set; }
        public XmlQualifiedName?                        QnAttributeFormDefault                  { get; set; }
        public XmlQualifiedName?                        QnItemType                              { get; set; }
        public XmlQualifiedName?                        QnMemberTypes                           { get; set; }
        public XmlQualifiedName?                        QnXPath                                 { get; set; }
        public XmlQualifiedName?                        QnXsdSchema                             { get; set; }
        public XmlQualifiedName?                        QnXsdAnnotation                         { get; set; }
        public XmlQualifiedName?                        QnXsdInclude                            { get; set; }
        public XmlQualifiedName?                        QnXsdImport                             { get; set; }
        public XmlQualifiedName?                        QnXsdElement                            { get; set; }
        public XmlQualifiedName?                        QnXsdAttribute                          { get; set; }
        public XmlQualifiedName?                        QnXsdAttributeGroup                     { get; set; }
        public XmlQualifiedName?                        QnXsdAnyAttribute                       { get; set; }
        public XmlQualifiedName?                        QnXsdGroup                              { get; set; }
        public XmlQualifiedName?                        QnXsdAll                                { get; set; }
        public XmlQualifiedName?                        QnXsdChoice                             { get; set; }
        public XmlQualifiedName?                        QnXsdSequence                           { get; set; }
        public XmlQualifiedName?                        QnXsdAny                                { get; set; }
        public XmlQualifiedName?                        QnXsdNotation                           { get; set; }
        public XmlQualifiedName?                        QnXsdSimpleType                         { get; set; }
        public XmlQualifiedName?                        QnXsdComplexType                        { get; set; }
        public XmlQualifiedName?                        QnXsdUnique                             { get; set; }
        public XmlQualifiedName?                        QnXsdKey                                { get; set; }
        public XmlQualifiedName?                        QnXsdKeyRef                             { get; set; }
        public XmlQualifiedName?                        QnXsdSelector                           { get; set; }
        public XmlQualifiedName?                        QnXsdField                              { get; set; }
        public XmlQualifiedName?                        QnXsdMinExclusive                       { get; set; }
        public XmlQualifiedName?                        QnXsdMinInclusive                       { get; set; }
        public XmlQualifiedName?                        QnXsdMaxInclusive                       { get; set; }
        public XmlQualifiedName?                        QnXsdMaxExclusive                       { get; set; }
        public XmlQualifiedName?                        QnXsdTotalDigits                        { get; set; }
        public XmlQualifiedName?                        QnXsdFractionDigits                     { get; set; }
        public XmlQualifiedName?                        QnXsdLength                             { get; set; }
        public XmlQualifiedName?                        QnXsdMinLength                          { get; set; }
        public XmlQualifiedName?                        QnXsdMaxLength                          { get; set; }
        public XmlQualifiedName?                        QnXsdEnumeration                        { get; set; }
        public XmlQualifiedName?                        QnXsdPattern                            { get; set; }
        public XmlQualifiedName?                        QnXsdDocumentation                      { get; set; }
        public XmlQualifiedName?                        QnXsdAppinfo                            { get; set; }
        public XmlQualifiedName?                        QnSource                                { get; set; }
        public XmlQualifiedName?                        QnXsdComplexContent                     { get; set; }
        public XmlQualifiedName?                        QnXsdSimpleContent                      { get; set; }
        public XmlQualifiedName?                        QnXsdRestriction                        { get; set; }
        public XmlQualifiedName?                        QnXsdExtension                          { get; set; }
        public XmlQualifiedName?                        QnXsdUnion                              { get; set; }
        public XmlQualifiedName?                        QnXsdList                               { get; set; }
        public XmlQualifiedName?                        QnXsdWhiteSpace                         { get; set; }
        public XmlQualifiedName?                        QnXsdRedefine                           { get; set; }
        public XmlQualifiedName?                        QnXsdAnyType                            { get; set; }
        public List<XmlQualifiedName>?                  TokenToQName                            { get; set; }

        public static SchemaNames? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaNames() { Pointer= p0 };

            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 02466753E230 0x10 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.NsDataType                                = GetString(new IntPtr(p + 0x018)); // 02466753E250 0x18 NsDataType                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsDataTypeAlias                           = GetString(new IntPtr(p + 0x020)); // 02466753E270 0x20 NsDataTypeAlias             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsDataTypeOld                             = GetString(new IntPtr(p + 0x028)); // 02466753E290 0x28 NsDataTypeOld               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsXml                                     = GetString(new IntPtr(p + 0x030)); // 02466753E2B0 0x30 NsXml                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x038)); // 02466753E2D0 0x38 NsXmlNs                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsXdr                                     = GetString(new IntPtr(p + 0x040)); // 02466753E2F0 0x40 NsXdr                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsXdrAlias                                = GetString(new IntPtr(p + 0x048)); // 02466753E310 0x48 NsXdrAlias                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsXs                                      = GetString(new IntPtr(p + 0x050)); // 02466753E330 0x50 NsXs                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x058)); // 02466753E350 0x58 NsXsi                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.XsiType                                   = GetString(new IntPtr(p + 0x060)); // 02466753E370 0x60 XsiType                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetString(new IntPtr(p + 0x068)); // 02466753E390 0x68 XsiNil                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.XsiSchemaLocation                         = GetString(new IntPtr(p + 0x070)); // 02466753E3B0 0x70 XsiSchemaLocation           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocation              = GetString(new IntPtr(p + 0x078)); // 02466753E3D0 0x78 XsiNoNamespaceSchemaLocation ( 0001866722E0 ModelPrimitiveType string string string String )
            value.XsdSchema                                 = GetString(new IntPtr(p + 0x080)); // 02466753E3F0 0x80 XsdSchema                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.XdrSchema                                 = GetString(new IntPtr(p + 0x088)); // 02466753E410 0x88 XdrSchema                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.QnPCData                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E430 0x90 QnPCData                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXml                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E450 0x98 QnXml                       ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXmlNs                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E470 0xA0 QnXmlNs                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtDt                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E490 0xA8 QnDtDt                      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXmlLang                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E4B0 0xB0 QnXmlLang                   ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnName                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E4D0 0xB8 QnName                      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnType                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E4F0 0xC0 QnType                      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMaxOccurs                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E510 0xC8 QnMaxOccurs                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMinOccurs                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E530 0xD0 QnMinOccurs                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnInfinite                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E550 0xD8 QnInfinite                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnModel                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E570 0xE0 QnModel                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnOpen                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E590 0xE8 QnOpen                      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnClosed                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E5B0 0xF0 QnClosed                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnContent                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E5D0 0xF8 QnContent                   ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMixed                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x100), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E5F0 0x100 QnMixed                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEmpty                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x108), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E610 0x108 QnEmpty                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEltOnly                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x110), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E630 0x110 QnEltOnly                   ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnTextOnly                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x118), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E650 0x118 QnTextOnly                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnOrder                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x120), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E670 0x120 QnOrder                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSeq                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x128), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E690 0x128 QnSeq                       ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnOne                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x130), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E6B0 0x130 QnOne                       ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMany                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E6D0 0x138 QnMany                      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnRequired                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x140), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E6F0 0x140 QnRequired                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnYes                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x148), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E710 0x148 QnYes                       ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNo                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x150), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E730 0x150 QnNo                        ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnString                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x158), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E750 0x158 QnString                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnID                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x160), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E770 0x160 QnID                        ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnIDRef                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x168), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E790 0x168 QnIDRef                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnIDRefs                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x170), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E7B0 0x170 QnIDRefs                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEntity                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x178), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E7D0 0x178 QnEntity                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEntities                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x180), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E7F0 0x180 QnEntities                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNmToken                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x188), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E810 0x188 QnNmToken                   ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNmTokens                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x190), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E830 0x190 QnNmTokens                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEnumeration                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x198), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E850 0x198 QnEnumeration               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDefault                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E870 0x1A0 QnDefault                   ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrSchema                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E890 0x1A8 QnXdrSchema                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrElementType                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E8B0 0x1B0 QnXdrElementType            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrElement                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E8D0 0x1B8 QnXdrElement                ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrGroup                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E8F0 0x1C0 QnXdrGroup                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrAttributeType                        = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E910 0x1C8 QnXdrAttributeType          ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrAttribute                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E930 0x1D0 QnXdrAttribute              ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrDataType                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E950 0x1D8 QnXdrDataType               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrDescription                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E970 0x1E0 QnXdrDescription            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrExtends                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E990 0x1E8 QnXdrExtends                ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrAliasSchema                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E9B0 0x1F0 QnXdrAliasSchema            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtType                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E9D0 0x1F8 QnDtType                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtValues                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x200), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753E9F0 0x200 QnDtValues                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMaxLength                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x208), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EA10 0x208 QnDtMaxLength               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMinLength                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x210), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EA30 0x210 QnDtMinLength               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMax                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x218), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EA50 0x218 QnDtMax                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMin                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x220), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EA70 0x220 QnDtMin                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMinExclusive                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x228), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EA90 0x228 QnDtMinExclusive            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMaxExclusive                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x230), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EAB0 0x230 QnDtMaxExclusive            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnTargetNamespace                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x238), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EAD0 0x238 QnTargetNamespace           ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnVersion                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x240), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EAF0 0x240 QnVersion                   ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnFinalDefault                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x248), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EB10 0x248 QnFinalDefault              ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnBlockDefault                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x250), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EB30 0x250 QnBlockDefault              ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnFixed                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x258), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EB50 0x258 QnFixed                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnAbstract                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x260), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EB70 0x260 QnAbstract                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnBlock                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x268), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EB90 0x268 QnBlock                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSubstitutionGroup                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x270), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EBB0 0x270 QnSubstitutionGroup         ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnFinal                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x278), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EBD0 0x278 QnFinal                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNillable                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x280), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EBF0 0x280 QnNillable                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnRef                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x288), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EC10 0x288 QnRef                       ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnBase                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x290), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EC30 0x290 QnBase                      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDerivedBy                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x298), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EC50 0x298 QnDerivedBy                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNamespace                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EC70 0x2A0 QnNamespace                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnProcessContents                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EC90 0x2A8 QnProcessContents           ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnRefer                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ECB0 0x2B0 QnRefer                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnPublic                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ECD0 0x2B8 QnPublic                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSystem                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ECF0 0x2C0 QnSystem                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSchemaLocation                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ED10 0x2C8 QnSchemaLocation            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnValue                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ED30 0x2D0 QnValue                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnUse                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ED50 0x2D8 QnUse                       ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnForm                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ED70 0x2E0 QnForm                      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnElementFormDefault                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753ED90 0x2E8 QnElementFormDefault        ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnAttributeFormDefault                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EDB0 0x2F0 QnAttributeFormDefault      ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnItemType                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EDD0 0x2F8 QnItemType                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMemberTypes                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x300), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EDF0 0x300 QnMemberTypes               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXPath                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x308), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EE10 0x308 QnXPath                     ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSchema                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x310), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EE30 0x310 QnXsdSchema                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAnnotation                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x318), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EE50 0x318 QnXsdAnnotation             ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdInclude                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x320), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EE70 0x320 QnXsdInclude                ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdImport                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x328), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EE90 0x328 QnXsdImport                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdElement                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x330), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EEB0 0x330 QnXsdElement                ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAttribute                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x338), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EED0 0x338 QnXsdAttribute              ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAttributeGroup                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x340), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EEF0 0x340 QnXsdAttributeGroup         ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAnyAttribute                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x348), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EF10 0x348 QnXsdAnyAttribute           ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdGroup                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x350), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EF30 0x350 QnXsdGroup                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAll                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x358), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EF50 0x358 QnXsdAll                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdChoice                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x360), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EF70 0x360 QnXsdChoice                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSequence                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x368), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EF90 0x368 QnXsdSequence               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAny                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x370), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EFB0 0x370 QnXsdAny                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdNotation                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x378), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EFD0 0x378 QnXsdNotation               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSimpleType                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x380), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753EFF0 0x380 QnXsdSimpleType             ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdComplexType                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x388), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F010 0x388 QnXsdComplexType            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdUnique                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x390), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F030 0x390 QnXsdUnique                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdKey                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x398), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F050 0x398 QnXsdKey                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdKeyRef                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F070 0x3A0 QnXsdKeyRef                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSelector                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F090 0x3A8 QnXsdSelector               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdField                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F0B0 0x3B0 QnXsdField                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMinExclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F0D0 0x3B8 QnXsdMinExclusive           ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMinInclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F0F0 0x3C0 QnXsdMinInclusive           ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMaxInclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F110 0x3C8 QnXsdMaxInclusive           ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMaxExclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F130 0x3D0 QnXsdMaxExclusive           ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdTotalDigits                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F150 0x3D8 QnXsdTotalDigits            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdFractionDigits                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F170 0x3E0 QnXsdFractionDigits         ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdLength                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F190 0x3E8 QnXsdLength                 ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMinLength                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F1B0 0x3F0 QnXsdMinLength              ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMaxLength                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F1D0 0x3F8 QnXsdMaxLength              ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdEnumeration                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x400), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F1F0 0x400 QnXsdEnumeration            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdPattern                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x408), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F210 0x408 QnXsdPattern                ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdDocumentation                        = GetObject<XmlQualifiedName>(new IntPtr(p + 0x410), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F230 0x410 QnXsdDocumentation          ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAppinfo                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x418), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F250 0x418 QnXsdAppinfo                ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSource                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x420), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F270 0x420 QnSource                    ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdComplexContent                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x428), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F290 0x428 QnXsdComplexContent         ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSimpleContent                        = GetObject<XmlQualifiedName>(new IntPtr(p + 0x430), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F2B0 0x430 QnXsdSimpleContent          ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdRestriction                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x438), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F2D0 0x438 QnXsdRestriction            ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdExtension                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x440), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F2F0 0x440 QnXsdExtension              ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdUnion                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x448), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F310 0x448 QnXsdUnion                  ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdList                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x450), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F330 0x450 QnXsdList                   ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdWhiteSpace                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x458), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F350 0x458 QnXsdWhiteSpace             ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdRedefine                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x460), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F370 0x460 QnXsdRedefine               ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAnyType                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x468), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F390 0x468 QnXsdAnyType                ( 0001866BCF50 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TokenToQName                              = GetObjectList<XmlQualifiedName>(new IntPtr(p + 0x470), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 02466753F3B0 0x470 TokenToQName                ( 000185CB4168 ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer )

            return value;
        }
    }
}
