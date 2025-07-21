using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 018 NsDataType                               ModelPrimitiveType string string string String
    // 020 NsDataTypeAlias                          ModelPrimitiveType string string string String
    // 028 NsDataTypeOld                            ModelPrimitiveType string string string String
    // 030 NsXml                                    ModelPrimitiveType string string string String
    // 038 NsXmlNs                                  ModelPrimitiveType string string string String
    // 040 NsXdr                                    ModelPrimitiveType string string string String
    // 048 NsXdrAlias                               ModelPrimitiveType string string string String
    // 050 NsXs                                     ModelPrimitiveType string string string String
    // 058 NsXsi                                    ModelPrimitiveType string string string String
    // 060 XsiType                                  ModelPrimitiveType string string string String
    // 068 XsiNil                                   ModelPrimitiveType string string string String
    // 070 XsiSchemaLocation                        ModelPrimitiveType string string string String
    // 078 XsiNoNamespaceSchemaLocation             ModelPrimitiveType string string string String
    // 080 XsdSchema                                ModelPrimitiveType string string string String
    // 088 XdrSchema                                ModelPrimitiveType string string string String
    // 090 QnPCData                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 098 QnXml                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0A0 QnXmlNs                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0A8 QnDtDt                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B0 QnXmlLang                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B8 QnName                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0C0 QnType                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0C8 QnMaxOccurs                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0D0 QnMinOccurs                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0D8 QnInfinite                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0E0 QnModel                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0E8 QnOpen                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0F0 QnClosed                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0F8 QnContent                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 100 QnMixed                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 108 QnEmpty                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 110 QnEltOnly                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 118 QnTextOnly                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 120 QnOrder                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 128 QnSeq                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 130 QnOne                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 138 QnMany                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 140 QnRequired                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 148 QnYes                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 150 QnNo                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 158 QnString                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 160 QnID                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 168 QnIDRef                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 170 QnIDRefs                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 178 QnEntity                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 180 QnEntities                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 188 QnNmToken                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 190 QnNmTokens                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 198 QnEnumeration                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1A0 QnDefault                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1A8 QnXdrSchema                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1B0 QnXdrElementType                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1B8 QnXdrElement                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1C0 QnXdrGroup                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1C8 QnXdrAttributeType                       ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1D0 QnXdrAttribute                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1D8 QnXdrDataType                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1E0 QnXdrDescription                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1E8 QnXdrExtends                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1F0 QnXdrAliasSchema                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 1F8 QnDtType                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 200 QnDtValues                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 208 QnDtMaxLength                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 210 QnDtMinLength                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 218 QnDtMax                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 220 QnDtMin                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 228 QnDtMinExclusive                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 230 QnDtMaxExclusive                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 238 QnTargetNamespace                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 240 QnVersion                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 248 QnFinalDefault                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 250 QnBlockDefault                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 258 QnFixed                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 260 QnAbstract                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 268 QnBlock                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 270 QnSubstitutionGroup                      ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 278 QnFinal                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 280 QnNillable                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 288 QnRef                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 290 QnBase                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 298 QnDerivedBy                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2A0 QnNamespace                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2A8 QnProcessContents                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2B0 QnRefer                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2B8 QnPublic                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2C0 QnSystem                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2C8 QnSchemaLocation                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2D0 QnValue                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2D8 QnUse                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2E0 QnForm                                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2E8 QnElementFormDefault                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2F0 QnAttributeFormDefault                   ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 2F8 QnItemType                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 300 QnMemberTypes                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 308 QnXPath                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 310 QnXsdSchema                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 318 QnXsdAnnotation                          ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 320 QnXsdInclude                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 328 QnXsdImport                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 330 QnXsdElement                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 338 QnXsdAttribute                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 340 QnXsdAttributeGroup                      ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 348 QnXsdAnyAttribute                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 350 QnXsdGroup                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 358 QnXsdAll                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 360 QnXsdChoice                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 368 QnXsdSequence                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 370 QnXsdAny                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 378 QnXsdNotation                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 380 QnXsdSimpleType                          ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 388 QnXsdComplexType                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 390 QnXsdUnique                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 398 QnXsdKey                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3A0 QnXsdKeyRef                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3A8 QnXsdSelector                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3B0 QnXsdField                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3B8 QnXsdMinExclusive                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3C0 QnXsdMinInclusive                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3C8 QnXsdMaxInclusive                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3D0 QnXsdMaxExclusive                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3D8 QnXsdTotalDigits                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3E0 QnXsdFractionDigits                      ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3E8 QnXsdLength                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3F0 QnXsdMinLength                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 3F8 QnXsdMaxLength                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 400 QnXsdEnumeration                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 408 QnXsdPattern                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 410 QnXsdDocumentation                       ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 418 QnXsdAppinfo                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 420 QnSource                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 428 QnXsdComplexContent                      ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 430 QnXsdSimpleContent                       ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 438 QnXsdRestriction                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 440 QnXsdExtension                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 448 QnXsdUnion                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 450 QnXsdList                                ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 458 QnXsdWhiteSpace                          ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 460 QnXsdRedefine                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 468 QnXsdAnyType                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 470 TokenToQName                             ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer
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

            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x10 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.NsDataType                                = GetString(new IntPtr(p + 0x018)); // 0x18 NsDataType                  ( ModelPrimitiveType string string string String )
            value.NsDataTypeAlias                           = GetString(new IntPtr(p + 0x020)); // 0x20 NsDataTypeAlias             ( ModelPrimitiveType string string string String )
            value.NsDataTypeOld                             = GetString(new IntPtr(p + 0x028)); // 0x28 NsDataTypeOld               ( ModelPrimitiveType string string string String )
            value.NsXml                                     = GetString(new IntPtr(p + 0x030)); // 0x30 NsXml                       ( ModelPrimitiveType string string string String )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x038)); // 0x38 NsXmlNs                     ( ModelPrimitiveType string string string String )
            value.NsXdr                                     = GetString(new IntPtr(p + 0x040)); // 0x40 NsXdr                       ( ModelPrimitiveType string string string String )
            value.NsXdrAlias                                = GetString(new IntPtr(p + 0x048)); // 0x48 NsXdrAlias                  ( ModelPrimitiveType string string string String )
            value.NsXs                                      = GetString(new IntPtr(p + 0x050)); // 0x50 NsXs                        ( ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x058)); // 0x58 NsXsi                       ( ModelPrimitiveType string string string String )
            value.XsiType                                   = GetString(new IntPtr(p + 0x060)); // 0x60 XsiType                     ( ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetString(new IntPtr(p + 0x068)); // 0x68 XsiNil                      ( ModelPrimitiveType string string string String )
            value.XsiSchemaLocation                         = GetString(new IntPtr(p + 0x070)); // 0x70 XsiSchemaLocation           ( ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocation              = GetString(new IntPtr(p + 0x078)); // 0x78 XsiNoNamespaceSchemaLocation ( ModelPrimitiveType string string string String )
            value.XsdSchema                                 = GetString(new IntPtr(p + 0x080)); // 0x80 XsdSchema                   ( ModelPrimitiveType string string string String )
            value.XdrSchema                                 = GetString(new IntPtr(p + 0x088)); // 0x88 XdrSchema                   ( ModelPrimitiveType string string string String )
            value.QnPCData                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x90 QnPCData                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXml                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x98 QnXml                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXmlNs                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xA0 QnXmlNs                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtDt                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xA8 QnDtDt                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXmlLang                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xB0 QnXmlLang                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnName                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xB8 QnName                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnType                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xC0 QnType                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMaxOccurs                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xC8 QnMaxOccurs                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMinOccurs                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xD0 QnMinOccurs                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnInfinite                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xD8 QnInfinite                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnModel                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xE0 QnModel                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnOpen                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xE8 QnOpen                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnClosed                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xF0 QnClosed                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnContent                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xF8 QnContent                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMixed                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x100), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x100 QnMixed                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEmpty                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x108), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x108 QnEmpty                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEltOnly                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x110), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x110 QnEltOnly                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnTextOnly                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x118), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x118 QnTextOnly                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnOrder                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x120), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x120 QnOrder                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSeq                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x128), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x128 QnSeq                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnOne                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x130), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x130 QnOne                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMany                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x138 QnMany                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnRequired                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x140), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x140 QnRequired                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnYes                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x148), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x148 QnYes                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNo                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x150), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x150 QnNo                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnString                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x158), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x158 QnString                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnID                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x160), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x160 QnID                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnIDRef                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x168), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x168 QnIDRef                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnIDRefs                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x170), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x170 QnIDRefs                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEntity                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x178), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x178 QnEntity                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEntities                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x180), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x180 QnEntities                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNmToken                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x188), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x188 QnNmToken                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNmTokens                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x190), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x190 QnNmTokens                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnEnumeration                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x198), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x198 QnEnumeration               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDefault                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1A0 QnDefault                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrSchema                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1A8 QnXdrSchema                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrElementType                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1B0 QnXdrElementType            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrElement                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1B8 QnXdrElement                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrGroup                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1C0 QnXdrGroup                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrAttributeType                        = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1C8 QnXdrAttributeType          ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrAttribute                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1D0 QnXdrAttribute              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrDataType                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1D8 QnXdrDataType               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrDescription                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1E0 QnXdrDescription            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrExtends                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1E8 QnXdrExtends                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXdrAliasSchema                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1F0 QnXdrAliasSchema            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtType                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x1F8 QnDtType                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtValues                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x200), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x200 QnDtValues                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMaxLength                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x208), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x208 QnDtMaxLength               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMinLength                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x210), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x210 QnDtMinLength               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMax                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x218), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x218 QnDtMax                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMin                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x220), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x220 QnDtMin                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMinExclusive                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x228), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x228 QnDtMinExclusive            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDtMaxExclusive                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x230), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x230 QnDtMaxExclusive            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnTargetNamespace                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x238), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x238 QnTargetNamespace           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnVersion                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x240), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x240 QnVersion                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnFinalDefault                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x248), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x248 QnFinalDefault              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnBlockDefault                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x250), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x250 QnBlockDefault              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnFixed                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x258), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x258 QnFixed                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnAbstract                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x260), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x260 QnAbstract                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnBlock                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x268), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x268 QnBlock                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSubstitutionGroup                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x270), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x270 QnSubstitutionGroup         ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnFinal                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x278), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x278 QnFinal                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNillable                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x280), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x280 QnNillable                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnRef                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x288), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x288 QnRef                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnBase                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x290), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x290 QnBase                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnDerivedBy                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x298), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x298 QnDerivedBy                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnNamespace                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2A0 QnNamespace                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnProcessContents                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2A8 QnProcessContents           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnRefer                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2B0 QnRefer                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnPublic                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2B8 QnPublic                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSystem                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2C0 QnSystem                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSchemaLocation                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2C8 QnSchemaLocation            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnValue                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2D0 QnValue                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnUse                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2D8 QnUse                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnForm                                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2E0 QnForm                      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnElementFormDefault                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2E8 QnElementFormDefault        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnAttributeFormDefault                    = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2F0 QnAttributeFormDefault      ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnItemType                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x2F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x2F8 QnItemType                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnMemberTypes                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x300), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x300 QnMemberTypes               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXPath                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x308), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x308 QnXPath                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSchema                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x310), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x310 QnXsdSchema                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAnnotation                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x318), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x318 QnXsdAnnotation             ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdInclude                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x320), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x320 QnXsdInclude                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdImport                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x328), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x328 QnXsdImport                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdElement                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x330), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x330 QnXsdElement                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAttribute                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x338), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x338 QnXsdAttribute              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAttributeGroup                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x340), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x340 QnXsdAttributeGroup         ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAnyAttribute                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x348), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x348 QnXsdAnyAttribute           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdGroup                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x350), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x350 QnXsdGroup                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAll                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x358), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x358 QnXsdAll                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdChoice                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x360), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x360 QnXsdChoice                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSequence                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x368), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x368 QnXsdSequence               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAny                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x370), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x370 QnXsdAny                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdNotation                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x378), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x378 QnXsdNotation               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSimpleType                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x380), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x380 QnXsdSimpleType             ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdComplexType                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x388), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x388 QnXsdComplexType            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdUnique                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x390), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x390 QnXsdUnique                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdKey                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x398), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x398 QnXsdKey                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdKeyRef                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3A0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3A0 QnXsdKeyRef                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSelector                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3A8 QnXsdSelector               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdField                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3B0 QnXsdField                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMinExclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3B8 QnXsdMinExclusive           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMinInclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3C0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3C0 QnXsdMinInclusive           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMaxInclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3C8 QnXsdMaxInclusive           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMaxExclusive                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3D0 QnXsdMaxExclusive           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdTotalDigits                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3D8 QnXsdTotalDigits            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdFractionDigits                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3E0 QnXsdFractionDigits         ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdLength                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3E8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3E8 QnXsdLength                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMinLength                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3F0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3F0 QnXsdMinLength              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdMaxLength                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x3F8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x3F8 QnXsdMaxLength              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdEnumeration                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x400), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x400 QnXsdEnumeration            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdPattern                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x408), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x408 QnXsdPattern                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdDocumentation                        = GetObject<XmlQualifiedName>(new IntPtr(p + 0x410), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x410 QnXsdDocumentation          ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAppinfo                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x418), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x418 QnXsdAppinfo                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnSource                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x420), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x420 QnSource                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdComplexContent                       = GetObject<XmlQualifiedName>(new IntPtr(p + 0x428), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x428 QnXsdComplexContent         ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdSimpleContent                        = GetObject<XmlQualifiedName>(new IntPtr(p + 0x430), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x430 QnXsdSimpleContent          ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdRestriction                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x438), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x438 QnXsdRestriction            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdExtension                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x440), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x440 QnXsdExtension              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdUnion                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x448), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x448 QnXsdUnion                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdList                                 = GetObject<XmlQualifiedName>(new IntPtr(p + 0x450), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x450 QnXsdList                   ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdWhiteSpace                           = GetObject<XmlQualifiedName>(new IntPtr(p + 0x458), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x458 QnXsdWhiteSpace             ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdRedefine                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x460), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x460 QnXsdRedefine               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QnXsdAnyType                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x468), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x468 QnXsdAnyType                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TokenToQName                              = GetObjectList<XmlQualifiedName>(new IntPtr(p + 0x470), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x470 TokenToQName                ( ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer )

            return value;
        }
    }
}
