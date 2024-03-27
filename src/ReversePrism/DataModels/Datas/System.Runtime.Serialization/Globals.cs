using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ScanAllMembers                           BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 idQualifiedName                          XmlQualifiedName IL2CPP_TYPE_CLASS
    // 008 refQualifiedName                         XmlQualifiedName IL2CPP_TYPE_CLASS
    // 010 TypeOfObject                             0001866931D0 ModelClassType Type Type Type Pointer
    // 018 TypeOfValueType                          0001866931D0 ModelClassType Type Type Type Pointer
    // 020 TypeOfArray                              0001866931D0 ModelClassType Type Type Type Pointer
    // 028 TypeOfString                             0001866931D0 ModelClassType Type Type Type Pointer
    // 030 TypeOfInt                                0001866931D0 ModelClassType Type Type Type Pointer
    // 038 TypeOfULong                              0001866931D0 ModelClassType Type Type Type Pointer
    // 040 TypeOfVoid                               0001866931D0 ModelClassType Type Type Type Pointer
    // 048 TypeOfByteArray                          0001866931D0 ModelClassType Type Type Type Pointer
    // 050 TypeOfTimeSpan                           0001866931D0 ModelClassType Type Type Type Pointer
    // 058 TypeOfGuid                               0001866931D0 ModelClassType Type Type Type Pointer
    // 060 TypeOfDateTimeOffset                     0001866931D0 ModelClassType Type Type Type Pointer
    // 068 TypeOfDateTimeOffsetAdapter              0001866931D0 ModelClassType Type Type Type Pointer
    // 070 TypeOfUri                                0001866931D0 ModelClassType Type Type Type Pointer
    // 078 TypeOfTypeEnumerable                     0001866931D0 ModelClassType Type Type Type Pointer
    // 080 TypeOfStreamingContext                   0001866931D0 ModelClassType Type Type Type Pointer
    // 088 TypeOfISerializable                      0001866931D0 ModelClassType Type Type Type Pointer
    // 090 TypeOfIDeserializationCallback           0001866931D0 ModelClassType Type Type Type Pointer
    // 098 TypeOfIObjectReference                   0001866931D0 ModelClassType Type Type Type Pointer
    // 0A0 TypeOfXmlFormatClassWriterDelegate       0001866931D0 ModelClassType Type Type Type Pointer
    // 0A8 TypeOfXmlFormatCollectionWriterDelegate  0001866931D0 ModelClassType Type Type Type Pointer
    // 0B0 TypeOfXmlFormatClassReaderDelegate       0001866931D0 ModelClassType Type Type Type Pointer
    // 0B8 TypeOfXmlFormatCollectionReaderDelegate  0001866931D0 ModelClassType Type Type Type Pointer
    // 0C0 TypeOfXmlFormatGetOnlyCollectionReaderDelegate 0001866931D0 ModelClassType Type Type Type Pointer
    // 0C8 TypeOfKnownTypeAttribute                 0001866931D0 ModelClassType Type Type Type Pointer
    // 0D0 TypeOfDataContractAttribute              0001866931D0 ModelClassType Type Type Type Pointer
    // 0D8 TypeOfContractNamespaceAttribute         0001866931D0 ModelClassType Type Type Type Pointer
    // 0E0 TypeOfDataMemberAttribute                0001866931D0 ModelClassType Type Type Type Pointer
    // 0E8 TypeOfEnumMemberAttribute                0001866931D0 ModelClassType Type Type Type Pointer
    // 0F0 TypeOfCollectionDataContractAttribute    0001866931D0 ModelClassType Type Type Type Pointer
    // 0F8 TypeOfOptionalFieldAttribute             0001866931D0 ModelClassType Type Type Type Pointer
    // 100 TypeOfObjectArray                        0001866931D0 ModelClassType Type Type Type Pointer
    // 108 TypeOfOnSerializingAttribute             0001866931D0 ModelClassType Type Type Type Pointer
    // 110 TypeOfOnSerializedAttribute              0001866931D0 ModelClassType Type Type Type Pointer
    // 118 TypeOfOnDeserializingAttribute           0001866931D0 ModelClassType Type Type Type Pointer
    // 120 TypeOfOnDeserializedAttribute            0001866931D0 ModelClassType Type Type Type Pointer
    // 128 TypeOfFlagsAttribute                     0001866931D0 ModelClassType Type Type Type Pointer
    // 130 TypeOfSerializableAttribute              0001866931D0 ModelClassType Type Type Type Pointer
    // 138 TypeOfNonSerializedAttribute             0001866931D0 ModelClassType Type Type Type Pointer
    // 140 TypeOfSerializationInfo                  0001866931D0 ModelClassType Type Type Type Pointer
    // 148 TypeOfSerializationInfoEnumerator        0001866931D0 ModelClassType Type Type Type Pointer
    // 150 TypeOfSerializationEntry                 0001866931D0 ModelClassType Type Type Type Pointer
    // 158 TypeOfIXmlSerializable                   0001866931D0 ModelClassType Type Type Type Pointer
    // 160 TypeOfXmlSchemaProviderAttribute         0001866931D0 ModelClassType Type Type Type Pointer
    // 168 TypeOfXmlRootAttribute                   0001866931D0 ModelClassType Type Type Type Pointer
    // 170 TypeOfXmlQualifiedName                   0001866931D0 ModelClassType Type Type Type Pointer
    // 178 TypeOfXmlSchemaType                      0001866931D0 ModelClassType Type Type Type Pointer
    // 180 TypeOfXmlSerializableServices            0001866931D0 ModelClassType Type Type Type Pointer
    // 188 TypeOfXmlNodeArray                       0001866931D0 ModelClassType Type Type Type Pointer
    // 190 TypeOfXmlSchemaSet                       0001866931D0 ModelClassType Type Type Type Pointer
    // 198 emptyObjectArray                         <object>[] IL2CPP_TYPE_SZARRAY
    // 1A0 EmptyTypeArray                           000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer
    // 1A8 TypeOfIPropertyChange                    0001866931D0 ModelClassType Type Type Type Pointer
    // 1B0 TypeOfIExtensibleDataObject              0001866931D0 ModelClassType Type Type Type Pointer
    // 1B8 TypeOfExtensionDataObject                0001866931D0 ModelClassType Type Type Type Pointer
    // 1C0 TypeOfISerializableDataNode              0001866931D0 ModelClassType Type Type Type Pointer
    // 1C8 TypeOfClassDataNode                      0001866931D0 ModelClassType Type Type Type Pointer
    // 1D0 TypeOfCollectionDataNode                 0001866931D0 ModelClassType Type Type Type Pointer
    // 1D8 TypeOfXmlDataNode                        0001866931D0 ModelClassType Type Type Type Pointer
    // 1E0 TypeOfNullable                           0001866931D0 ModelClassType Type Type Type Pointer
    // 1E8 TypeOfReflectionPointer                  0001866931D0 ModelClassType Type Type Type Pointer
    // 1F0 TypeOfIDictionaryGeneric                 0001866931D0 ModelClassType Type Type Type Pointer
    // 1F8 TypeOfIDictionary                        0001866931D0 ModelClassType Type Type Type Pointer
    // 200 TypeOfIListGeneric                       0001866931D0 ModelClassType Type Type Type Pointer
    // 208 TypeOfIList                              0001866931D0 ModelClassType Type Type Type Pointer
    // 210 TypeOfICollectionGeneric                 0001866931D0 ModelClassType Type Type Type Pointer
    // 218 TypeOfICollection                        0001866931D0 ModelClassType Type Type Type Pointer
    // 220 TypeOfIEnumerableGeneric                 0001866931D0 ModelClassType Type Type Type Pointer
    // 228 TypeOfIEnumerable                        0001866931D0 ModelClassType Type Type Type Pointer
    // 230 TypeOfIEnumeratorGeneric                 0001866931D0 ModelClassType Type Type Type Pointer
    // 238 TypeOfIEnumerator                        0001866931D0 ModelClassType Type Type Type Pointer
    // 240 TypeOfKeyValuePair                       0001866931D0 ModelClassType Type Type Type Pointer
    // 248 TypeOfKeyValue                           0001866931D0 ModelClassType Type Type Type Pointer
    // 250 TypeOfIDictionaryEnumerator              0001866931D0 ModelClassType Type Type Type Pointer
    // 258 TypeOfDictionaryEnumerator               0001866931D0 ModelClassType Type Type Type Pointer
    // 260 TypeOfGenericDictionaryEnumerator        0001866931D0 ModelClassType Type Type Type Pointer
    // 268 TypeOfDictionaryGeneric                  0001866931D0 ModelClassType Type Type Type Pointer
    // 270 TypeOfHashtable                          0001866931D0 ModelClassType Type Type Type Pointer
    // 278 TypeOfListGeneric                        0001866931D0 ModelClassType Type Type Type Pointer
    // 280 TypeOfXmlElement                         0001866931D0 ModelClassType Type Type Type Pointer
    // 288 TypeOfDBNull                             0001866931D0 ModelClassType Type Type Type Pointer
    // 290 DataContractXsdBaseNamespaceUri          0001866A49A0 ModelClassType Uri Uri Uri Pointer
    // 000 DefaultIsRequired                        bool IL2CPP_TYPE_BOOLEAN
    // 000 DefaultEmitDefaultValue                  bool IL2CPP_TYPE_BOOLEAN
    // 000 DefaultOrder                             int IL2CPP_TYPE_I4
    // 000 DefaultIsReference                       bool IL2CPP_TYPE_BOOLEAN
    // 298 NewObjectId                              000186674040 ModelPrimitiveType string string string String
    // 000 SimpleSRSInternalsVisiblePattern         string IL2CPP_TYPE_STRING
    // 000 FullSRSInternalsVisiblePattern           string IL2CPP_TYPE_STRING
    // 000 NullObjectId                             string IL2CPP_TYPE_STRING
    // 000 Space                                    string IL2CPP_TYPE_STRING
    // 000 OpenBracket                              string IL2CPP_TYPE_STRING
    // 000 CloseBracket                             string IL2CPP_TYPE_STRING
    // 000 Comma                                    string IL2CPP_TYPE_STRING
    // 000 XsiPrefix                                string IL2CPP_TYPE_STRING
    // 000 XsdPrefix                                string IL2CPP_TYPE_STRING
    // 000 SerPrefix                                string IL2CPP_TYPE_STRING
    // 000 SerPrefixForSchema                       string IL2CPP_TYPE_STRING
    // 000 ElementPrefix                            string IL2CPP_TYPE_STRING
    // 000 DataContractXsdBaseNamespace             string IL2CPP_TYPE_STRING
    // 000 DataContractXmlNamespace                 string IL2CPP_TYPE_STRING
    // 000 SchemaInstanceNamespace                  string IL2CPP_TYPE_STRING
    // 000 SchemaNamespace                          string IL2CPP_TYPE_STRING
    // 000 XsiNilLocalName                          string IL2CPP_TYPE_STRING
    // 000 XsiTypeLocalName                         string IL2CPP_TYPE_STRING
    // 000 TnsPrefix                                string IL2CPP_TYPE_STRING
    // 000 OccursUnbounded                          string IL2CPP_TYPE_STRING
    // 000 AnyTypeLocalName                         string IL2CPP_TYPE_STRING
    // 000 StringLocalName                          string IL2CPP_TYPE_STRING
    // 000 IntLocalName                             string IL2CPP_TYPE_STRING
    // 000 True                                     string IL2CPP_TYPE_STRING
    // 000 False                                    string IL2CPP_TYPE_STRING
    // 000 ArrayPrefix                              string IL2CPP_TYPE_STRING
    // 000 XmlnsNamespace                           string IL2CPP_TYPE_STRING
    // 000 XmlnsPrefix                              string IL2CPP_TYPE_STRING
    // 000 SchemaLocalName                          string IL2CPP_TYPE_STRING
    // 000 CollectionsNamespace                     string IL2CPP_TYPE_STRING
    // 000 DefaultClrNamespace                      string IL2CPP_TYPE_STRING
    // 000 DefaultTypeName                          string IL2CPP_TYPE_STRING
    // 000 DefaultGeneratedMember                   string IL2CPP_TYPE_STRING
    // 000 DefaultFieldSuffix                       string IL2CPP_TYPE_STRING
    // 000 DefaultPropertySuffix                    string IL2CPP_TYPE_STRING
    // 000 DefaultMemberSuffix                      string IL2CPP_TYPE_STRING
    // 000 NameProperty                             string IL2CPP_TYPE_STRING
    // 000 NamespaceProperty                        string IL2CPP_TYPE_STRING
    // 000 OrderProperty                            string IL2CPP_TYPE_STRING
    // 000 IsReferenceProperty                      string IL2CPP_TYPE_STRING
    // 000 IsRequiredProperty                       string IL2CPP_TYPE_STRING
    // 000 EmitDefaultValueProperty                 string IL2CPP_TYPE_STRING
    // 000 ClrNamespaceProperty                     string IL2CPP_TYPE_STRING
    // 000 ItemNameProperty                         string IL2CPP_TYPE_STRING
    // 000 KeyNameProperty                          string IL2CPP_TYPE_STRING
    // 000 ValueNameProperty                        string IL2CPP_TYPE_STRING
    // 000 SerializationInfoPropertyName            string IL2CPP_TYPE_STRING
    // 000 SerializationInfoFieldName               string IL2CPP_TYPE_STRING
    // 000 NodeArrayPropertyName                    string IL2CPP_TYPE_STRING
    // 000 NodeArrayFieldName                       string IL2CPP_TYPE_STRING
    // 000 ExportSchemaMethod                       string IL2CPP_TYPE_STRING
    // 000 IsAnyProperty                            string IL2CPP_TYPE_STRING
    // 000 ContextFieldName                         string IL2CPP_TYPE_STRING
    // 000 GetObjectDataMethodName                  string IL2CPP_TYPE_STRING
    // 000 GetEnumeratorMethodName                  string IL2CPP_TYPE_STRING
    // 000 MoveNextMethodName                       string IL2CPP_TYPE_STRING
    // 000 AddValueMethodName                       string IL2CPP_TYPE_STRING
    // 000 CurrentPropertyName                      string IL2CPP_TYPE_STRING
    // 000 ValueProperty                            string IL2CPP_TYPE_STRING
    // 000 EnumeratorFieldName                      string IL2CPP_TYPE_STRING
    // 000 SerializationEntryFieldName              string IL2CPP_TYPE_STRING
    // 000 ExtensionDataSetMethod                   string IL2CPP_TYPE_STRING
    // 000 ExtensionDataSetExplicitMethod           string IL2CPP_TYPE_STRING
    // 000 ExtensionDataObjectPropertyName          string IL2CPP_TYPE_STRING
    // 000 ExtensionDataObjectFieldName             string IL2CPP_TYPE_STRING
    // 000 AddMethodName                            string IL2CPP_TYPE_STRING
    // 000 ParseMethodName                          string IL2CPP_TYPE_STRING
    // 000 GetCurrentMethodName                     string IL2CPP_TYPE_STRING
    // 000 SerializationNamespace                   string IL2CPP_TYPE_STRING
    // 000 ClrTypeLocalName                         string IL2CPP_TYPE_STRING
    // 000 ClrAssemblyLocalName                     string IL2CPP_TYPE_STRING
    // 000 IsValueTypeLocalName                     string IL2CPP_TYPE_STRING
    // 000 EnumerationValueLocalName                string IL2CPP_TYPE_STRING
    // 000 SurrogateDataLocalName                   string IL2CPP_TYPE_STRING
    // 000 GenericTypeLocalName                     string IL2CPP_TYPE_STRING
    // 000 GenericParameterLocalName                string IL2CPP_TYPE_STRING
    // 000 GenericNameAttribute                     string IL2CPP_TYPE_STRING
    // 000 GenericNamespaceAttribute                string IL2CPP_TYPE_STRING
    // 000 GenericParameterNestedLevelAttribute     string IL2CPP_TYPE_STRING
    // 000 IsDictionaryLocalName                    string IL2CPP_TYPE_STRING
    // 000 ActualTypeLocalName                      string IL2CPP_TYPE_STRING
    // 000 ActualTypeNameAttribute                  string IL2CPP_TYPE_STRING
    // 000 ActualTypeNamespaceAttribute             string IL2CPP_TYPE_STRING
    // 000 DefaultValueLocalName                    string IL2CPP_TYPE_STRING
    // 000 EmitDefaultValueAttribute                string IL2CPP_TYPE_STRING
    // 000 ISerializableFactoryTypeLocalName        string IL2CPP_TYPE_STRING
    // 000 IdLocalName                              string IL2CPP_TYPE_STRING
    // 000 RefLocalName                             string IL2CPP_TYPE_STRING
    // 000 ArraySizeLocalName                       string IL2CPP_TYPE_STRING
    // 000 KeyLocalName                             string IL2CPP_TYPE_STRING
    // 000 ValueLocalName                           string IL2CPP_TYPE_STRING
    // 000 MscorlibAssemblyName                     string IL2CPP_TYPE_STRING
    // 000 MscorlibAssemblySimpleName               string IL2CPP_TYPE_STRING
    // 000 MscorlibFileName                         string IL2CPP_TYPE_STRING
    // 000 SerializationSchema                      string IL2CPP_TYPE_STRING
    public partial class Globals
    {
        public Type?                                    TypeOfObject                            { get; set; }
        public Type?                                    TypeOfValueType                         { get; set; }
        public Type?                                    TypeOfArray                             { get; set; }
        public Type?                                    TypeOfString                            { get; set; }
        public Type?                                    TypeOfInt                               { get; set; }
        public Type?                                    TypeOfULong                             { get; set; }
        public Type?                                    TypeOfVoid                              { get; set; }
        public Type?                                    TypeOfByteArray                         { get; set; }
        public Type?                                    TypeOfTimeSpan                          { get; set; }
        public Type?                                    TypeOfGuid                              { get; set; }
        public Type?                                    TypeOfDateTimeOffset                    { get; set; }
        public Type?                                    TypeOfDateTimeOffsetAdapter             { get; set; }
        public Type?                                    TypeOfUri                               { get; set; }
        public Type?                                    TypeOfTypeEnumerable                    { get; set; }
        public Type?                                    TypeOfStreamingContext                  { get; set; }
        public Type?                                    TypeOfISerializable                     { get; set; }
        public Type?                                    TypeOfIDeserializationCallback          { get; set; }
        public Type?                                    TypeOfIObjectReference                  { get; set; }
        public Type?                                    TypeOfXmlFormatClassWriterDelegate      { get; set; }
        public Type?                                    TypeOfXmlFormatCollectionWriterDelegate { get; set; }
        public Type?                                    TypeOfXmlFormatClassReaderDelegate      { get; set; }
        public Type?                                    TypeOfXmlFormatCollectionReaderDelegate { get; set; }
        public Type?                                    TypeOfXmlFormatGetOnlyCollectionReaderDelegate { get; set; }
        public Type?                                    TypeOfKnownTypeAttribute                { get; set; }
        public Type?                                    TypeOfDataContractAttribute             { get; set; }
        public Type?                                    TypeOfContractNamespaceAttribute        { get; set; }
        public Type?                                    TypeOfDataMemberAttribute               { get; set; }
        public Type?                                    TypeOfEnumMemberAttribute               { get; set; }
        public Type?                                    TypeOfCollectionDataContractAttribute   { get; set; }
        public Type?                                    TypeOfOptionalFieldAttribute            { get; set; }
        public Type?                                    TypeOfObjectArray                       { get; set; }
        public Type?                                    TypeOfOnSerializingAttribute            { get; set; }
        public Type?                                    TypeOfOnSerializedAttribute             { get; set; }
        public Type?                                    TypeOfOnDeserializingAttribute          { get; set; }
        public Type?                                    TypeOfOnDeserializedAttribute           { get; set; }
        public Type?                                    TypeOfFlagsAttribute                    { get; set; }
        public Type?                                    TypeOfSerializableAttribute             { get; set; }
        public Type?                                    TypeOfNonSerializedAttribute            { get; set; }
        public Type?                                    TypeOfSerializationInfo                 { get; set; }
        public Type?                                    TypeOfSerializationInfoEnumerator       { get; set; }
        public Type?                                    TypeOfSerializationEntry                { get; set; }
        public Type?                                    TypeOfIXmlSerializable                  { get; set; }
        public Type?                                    TypeOfXmlSchemaProviderAttribute        { get; set; }
        public Type?                                    TypeOfXmlRootAttribute                  { get; set; }
        public Type?                                    TypeOfXmlQualifiedName                  { get; set; }
        public Type?                                    TypeOfXmlSchemaType                     { get; set; }
        public Type?                                    TypeOfXmlSerializableServices           { get; set; }
        public Type?                                    TypeOfXmlNodeArray                      { get; set; }
        public Type?                                    TypeOfXmlSchemaSet                      { get; set; }
        public List<Type>?                              EmptyTypeArray                          { get; set; }
        public Type?                                    TypeOfIPropertyChange                   { get; set; }
        public Type?                                    TypeOfIExtensibleDataObject             { get; set; }
        public Type?                                    TypeOfExtensionDataObject               { get; set; }
        public Type?                                    TypeOfISerializableDataNode             { get; set; }
        public Type?                                    TypeOfClassDataNode                     { get; set; }
        public Type?                                    TypeOfCollectionDataNode                { get; set; }
        public Type?                                    TypeOfXmlDataNode                       { get; set; }
        public Type?                                    TypeOfNullable                          { get; set; }
        public Type?                                    TypeOfReflectionPointer                 { get; set; }
        public Type?                                    TypeOfIDictionaryGeneric                { get; set; }
        public Type?                                    TypeOfIDictionary                       { get; set; }
        public Type?                                    TypeOfIListGeneric                      { get; set; }
        public Type?                                    TypeOfIList                             { get; set; }
        public Type?                                    TypeOfICollectionGeneric                { get; set; }
        public Type?                                    TypeOfICollection                       { get; set; }
        public Type?                                    TypeOfIEnumerableGeneric                { get; set; }
        public Type?                                    TypeOfIEnumerable                       { get; set; }
        public Type?                                    TypeOfIEnumeratorGeneric                { get; set; }
        public Type?                                    TypeOfIEnumerator                       { get; set; }
        public Type?                                    TypeOfKeyValuePair                      { get; set; }
        public Type?                                    TypeOfKeyValue                          { get; set; }
        public Type?                                    TypeOfIDictionaryEnumerator             { get; set; }
        public Type?                                    TypeOfDictionaryEnumerator              { get; set; }
        public Type?                                    TypeOfGenericDictionaryEnumerator       { get; set; }
        public Type?                                    TypeOfDictionaryGeneric                 { get; set; }
        public Type?                                    TypeOfHashtable                         { get; set; }
        public Type?                                    TypeOfListGeneric                       { get; set; }
        public Type?                                    TypeOfXmlElement                        { get; set; }
        public Type?                                    TypeOfDBNull                            { get; set; }
        public Uri?                                     DataContractXsdBaseNamespaceUri         { get; set; }
        public string                                   NewObjectId                             { get; set; }

        public static Globals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Globals();

            value.TypeOfObject                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027004C7E258 0x10 TypeOfObject                ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfValueType                           = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 027004C7E278 0x18 TypeOfValueType             ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfArray                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 027004C7E298 0x20 TypeOfArray                 ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfString                              = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 027004C7E2B8 0x28 TypeOfString                ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfInt                                 = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 027004C7E2D8 0x30 TypeOfInt                   ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfULong                               = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 027004C7E2F8 0x38 TypeOfULong                 ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfVoid                                = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 027004C7E318 0x40 TypeOfVoid                  ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfByteArray                           = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 027004C7E338 0x48 TypeOfByteArray             ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfTimeSpan                            = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 027004C7E358 0x50 TypeOfTimeSpan              ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfGuid                                = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 027004C7E378 0x58 TypeOfGuid                  ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfDateTimeOffset                      = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 027004C7E398 0x60 TypeOfDateTimeOffset        ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfDateTimeOffsetAdapter               = GetObject<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 027004C7E3B8 0x68 TypeOfDateTimeOffsetAdapter ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfUri                                 = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 027004C7E3D8 0x70 TypeOfUri                   ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfTypeEnumerable                      = GetObject<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 027004C7E3F8 0x78 TypeOfTypeEnumerable        ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfStreamingContext                    = GetObject<Type>(new IntPtr(p + 0x080), ReversePrism.DataModels.Type.FromPointer); // 027004C7E418 0x80 TypeOfStreamingContext      ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfISerializable                       = GetObject<Type>(new IntPtr(p + 0x088), ReversePrism.DataModels.Type.FromPointer); // 027004C7E438 0x88 TypeOfISerializable         ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIDeserializationCallback            = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 027004C7E458 0x90 TypeOfIDeserializationCallback ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIObjectReference                    = GetObject<Type>(new IntPtr(p + 0x098), ReversePrism.DataModels.Type.FromPointer); // 027004C7E478 0x98 TypeOfIObjectReference      ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatClassWriterDelegate        = GetObject<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E498 0xA0 TypeOfXmlFormatClassWriterDelegate ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatCollectionWriterDelegate   = GetObject<Type>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E4B8 0xA8 TypeOfXmlFormatCollectionWriterDelegate ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatClassReaderDelegate        = GetObject<Type>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E4D8 0xB0 TypeOfXmlFormatClassReaderDelegate ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatCollectionReaderDelegate   = GetObject<Type>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E4F8 0xB8 TypeOfXmlFormatCollectionReaderDelegate ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatGetOnlyCollectionReaderDelegate = GetObject<Type>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E518 0xC0 TypeOfXmlFormatGetOnlyCollectionReaderDelegate ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfKnownTypeAttribute                  = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E538 0xC8 TypeOfKnownTypeAttribute    ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfDataContractAttribute               = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E558 0xD0 TypeOfDataContractAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfContractNamespaceAttribute          = GetObject<Type>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E578 0xD8 TypeOfContractNamespaceAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfDataMemberAttribute                 = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E598 0xE0 TypeOfDataMemberAttribute   ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfEnumMemberAttribute                 = GetObject<Type>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E5B8 0xE8 TypeOfEnumMemberAttribute   ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfCollectionDataContractAttribute     = GetObject<Type>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E5D8 0xF0 TypeOfCollectionDataContractAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfOptionalFieldAttribute              = GetObject<Type>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E5F8 0xF8 TypeOfOptionalFieldAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfObjectArray                         = GetObject<Type>(new IntPtr(p + 0x100), ReversePrism.DataModels.Type.FromPointer); // 027004C7E618 0x100 TypeOfObjectArray           ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfOnSerializingAttribute              = GetObject<Type>(new IntPtr(p + 0x108), ReversePrism.DataModels.Type.FromPointer); // 027004C7E638 0x108 TypeOfOnSerializingAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfOnSerializedAttribute               = GetObject<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 027004C7E658 0x110 TypeOfOnSerializedAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfOnDeserializingAttribute            = GetObject<Type>(new IntPtr(p + 0x118), ReversePrism.DataModels.Type.FromPointer); // 027004C7E678 0x118 TypeOfOnDeserializingAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfOnDeserializedAttribute             = GetObject<Type>(new IntPtr(p + 0x120), ReversePrism.DataModels.Type.FromPointer); // 027004C7E698 0x120 TypeOfOnDeserializedAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfFlagsAttribute                      = GetObject<Type>(new IntPtr(p + 0x128), ReversePrism.DataModels.Type.FromPointer); // 027004C7E6B8 0x128 TypeOfFlagsAttribute        ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfSerializableAttribute               = GetObject<Type>(new IntPtr(p + 0x130), ReversePrism.DataModels.Type.FromPointer); // 027004C7E6D8 0x130 TypeOfSerializableAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfNonSerializedAttribute              = GetObject<Type>(new IntPtr(p + 0x138), ReversePrism.DataModels.Type.FromPointer); // 027004C7E6F8 0x138 TypeOfNonSerializedAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfSerializationInfo                   = GetObject<Type>(new IntPtr(p + 0x140), ReversePrism.DataModels.Type.FromPointer); // 027004C7E718 0x140 TypeOfSerializationInfo     ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfSerializationInfoEnumerator         = GetObject<Type>(new IntPtr(p + 0x148), ReversePrism.DataModels.Type.FromPointer); // 027004C7E738 0x148 TypeOfSerializationInfoEnumerator ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfSerializationEntry                  = GetObject<Type>(new IntPtr(p + 0x150), ReversePrism.DataModels.Type.FromPointer); // 027004C7E758 0x150 TypeOfSerializationEntry    ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIXmlSerializable                    = GetObject<Type>(new IntPtr(p + 0x158), ReversePrism.DataModels.Type.FromPointer); // 027004C7E778 0x158 TypeOfIXmlSerializable      ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSchemaProviderAttribute          = GetObject<Type>(new IntPtr(p + 0x160), ReversePrism.DataModels.Type.FromPointer); // 027004C7E798 0x160 TypeOfXmlSchemaProviderAttribute ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlRootAttribute                    = GetObject<Type>(new IntPtr(p + 0x168), ReversePrism.DataModels.Type.FromPointer); // 027004C7E7B8 0x168 TypeOfXmlRootAttribute      ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlQualifiedName                    = GetObject<Type>(new IntPtr(p + 0x170), ReversePrism.DataModels.Type.FromPointer); // 027004C7E7D8 0x170 TypeOfXmlQualifiedName      ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSchemaType                       = GetObject<Type>(new IntPtr(p + 0x178), ReversePrism.DataModels.Type.FromPointer); // 027004C7E7F8 0x178 TypeOfXmlSchemaType         ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSerializableServices             = GetObject<Type>(new IntPtr(p + 0x180), ReversePrism.DataModels.Type.FromPointer); // 027004C7E818 0x180 TypeOfXmlSerializableServices ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlNodeArray                        = GetObject<Type>(new IntPtr(p + 0x188), ReversePrism.DataModels.Type.FromPointer); // 027004C7E838 0x188 TypeOfXmlNodeArray          ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSchemaSet                        = GetObject<Type>(new IntPtr(p + 0x190), ReversePrism.DataModels.Type.FromPointer); // 027004C7E858 0x190 TypeOfXmlSchemaSet          ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.EmptyTypeArray                            = GetObjectList<Type>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E898 0x1A0 EmptyTypeArray              ( 000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.TypeOfIPropertyChange                     = GetObject<Type>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E8B8 0x1A8 TypeOfIPropertyChange       ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIExtensibleDataObject               = GetObject<Type>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E8D8 0x1B0 TypeOfIExtensibleDataObject ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfExtensionDataObject                 = GetObject<Type>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E8F8 0x1B8 TypeOfExtensionDataObject   ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfISerializableDataNode               = GetObject<Type>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E918 0x1C0 TypeOfISerializableDataNode ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfClassDataNode                       = GetObject<Type>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E938 0x1C8 TypeOfClassDataNode         ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfCollectionDataNode                  = GetObject<Type>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E958 0x1D0 TypeOfCollectionDataNode    ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlDataNode                         = GetObject<Type>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E978 0x1D8 TypeOfXmlDataNode           ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfNullable                            = GetObject<Type>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E998 0x1E0 TypeOfNullable              ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfReflectionPointer                   = GetObject<Type>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E9B8 0x1E8 TypeOfReflectionPointer     ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIDictionaryGeneric                  = GetObject<Type>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.Type.FromPointer); // 027004C7E9D8 0x1F0 TypeOfIDictionaryGeneric    ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIDictionary                         = GetObject<Type>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Type.FromPointer); // 027004C7E9F8 0x1F8 TypeOfIDictionary           ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIListGeneric                        = GetObject<Type>(new IntPtr(p + 0x200), ReversePrism.DataModels.Type.FromPointer); // 027004C7EA18 0x200 TypeOfIListGeneric          ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIList                               = GetObject<Type>(new IntPtr(p + 0x208), ReversePrism.DataModels.Type.FromPointer); // 027004C7EA38 0x208 TypeOfIList                 ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfICollectionGeneric                  = GetObject<Type>(new IntPtr(p + 0x210), ReversePrism.DataModels.Type.FromPointer); // 027004C7EA58 0x210 TypeOfICollectionGeneric    ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfICollection                         = GetObject<Type>(new IntPtr(p + 0x218), ReversePrism.DataModels.Type.FromPointer); // 027004C7EA78 0x218 TypeOfICollection           ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumerableGeneric                  = GetObject<Type>(new IntPtr(p + 0x220), ReversePrism.DataModels.Type.FromPointer); // 027004C7EA98 0x220 TypeOfIEnumerableGeneric    ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumerable                         = GetObject<Type>(new IntPtr(p + 0x228), ReversePrism.DataModels.Type.FromPointer); // 027004C7EAB8 0x228 TypeOfIEnumerable           ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumeratorGeneric                  = GetObject<Type>(new IntPtr(p + 0x230), ReversePrism.DataModels.Type.FromPointer); // 027004C7EAD8 0x230 TypeOfIEnumeratorGeneric    ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumerator                         = GetObject<Type>(new IntPtr(p + 0x238), ReversePrism.DataModels.Type.FromPointer); // 027004C7EAF8 0x238 TypeOfIEnumerator           ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfKeyValuePair                        = GetObject<Type>(new IntPtr(p + 0x240), ReversePrism.DataModels.Type.FromPointer); // 027004C7EB18 0x240 TypeOfKeyValuePair          ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfKeyValue                            = GetObject<Type>(new IntPtr(p + 0x248), ReversePrism.DataModels.Type.FromPointer); // 027004C7EB38 0x248 TypeOfKeyValue              ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfIDictionaryEnumerator               = GetObject<Type>(new IntPtr(p + 0x250), ReversePrism.DataModels.Type.FromPointer); // 027004C7EB58 0x250 TypeOfIDictionaryEnumerator ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfDictionaryEnumerator                = GetObject<Type>(new IntPtr(p + 0x258), ReversePrism.DataModels.Type.FromPointer); // 027004C7EB78 0x258 TypeOfDictionaryEnumerator  ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfGenericDictionaryEnumerator         = GetObject<Type>(new IntPtr(p + 0x260), ReversePrism.DataModels.Type.FromPointer); // 027004C7EB98 0x260 TypeOfGenericDictionaryEnumerator ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfDictionaryGeneric                   = GetObject<Type>(new IntPtr(p + 0x268), ReversePrism.DataModels.Type.FromPointer); // 027004C7EBB8 0x268 TypeOfDictionaryGeneric     ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfHashtable                           = GetObject<Type>(new IntPtr(p + 0x270), ReversePrism.DataModels.Type.FromPointer); // 027004C7EBD8 0x270 TypeOfHashtable             ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfListGeneric                         = GetObject<Type>(new IntPtr(p + 0x278), ReversePrism.DataModels.Type.FromPointer); // 027004C7EBF8 0x278 TypeOfListGeneric           ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfXmlElement                          = GetObject<Type>(new IntPtr(p + 0x280), ReversePrism.DataModels.Type.FromPointer); // 027004C7EC18 0x280 TypeOfXmlElement            ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.TypeOfDBNull                              = GetObject<Type>(new IntPtr(p + 0x288), ReversePrism.DataModels.Type.FromPointer); // 027004C7EC38 0x288 TypeOfDBNull                ( 0001866931D0 ModelClassType Type Type Type Pointer )
            value.DataContractXsdBaseNamespaceUri           = GetObject<Uri>(new IntPtr(p + 0x290), ReversePrism.DataModels.Uri.FromPointer); // 027004C7EC58 0x290 DataContractXsdBaseNamespaceUri ( 0001866A49A0 ModelClassType Uri Uri Uri Pointer )
            value.NewObjectId                               = GetString(new IntPtr(p + 0x298)); // 027004C7ECF8 0x298 NewObjectId                 ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
