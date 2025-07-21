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
    // 010 TypeOfObject                             ModelClassType Type Type Type Pointer
    // 018 TypeOfValueType                          ModelClassType Type Type Type Pointer
    // 020 TypeOfArray                              ModelClassType Type Type Type Pointer
    // 028 TypeOfString                             ModelClassType Type Type Type Pointer
    // 030 TypeOfInt                                ModelClassType Type Type Type Pointer
    // 038 TypeOfULong                              ModelClassType Type Type Type Pointer
    // 040 TypeOfVoid                               ModelClassType Type Type Type Pointer
    // 048 TypeOfByteArray                          ModelClassType Type Type Type Pointer
    // 050 TypeOfTimeSpan                           ModelClassType Type Type Type Pointer
    // 058 TypeOfGuid                               ModelClassType Type Type Type Pointer
    // 060 TypeOfDateTimeOffset                     ModelClassType Type Type Type Pointer
    // 068 TypeOfDateTimeOffsetAdapter              ModelClassType Type Type Type Pointer
    // 070 TypeOfUri                                ModelClassType Type Type Type Pointer
    // 078 TypeOfTypeEnumerable                     ModelClassType Type Type Type Pointer
    // 080 TypeOfStreamingContext                   ModelClassType Type Type Type Pointer
    // 088 TypeOfISerializable                      ModelClassType Type Type Type Pointer
    // 090 TypeOfIDeserializationCallback           ModelClassType Type Type Type Pointer
    // 098 TypeOfIObjectReference                   ModelClassType Type Type Type Pointer
    // 0A0 TypeOfXmlFormatClassWriterDelegate       ModelClassType Type Type Type Pointer
    // 0A8 TypeOfXmlFormatCollectionWriterDelegate  ModelClassType Type Type Type Pointer
    // 0B0 TypeOfXmlFormatClassReaderDelegate       ModelClassType Type Type Type Pointer
    // 0B8 TypeOfXmlFormatCollectionReaderDelegate  ModelClassType Type Type Type Pointer
    // 0C0 TypeOfXmlFormatGetOnlyCollectionReaderDelegate ModelClassType Type Type Type Pointer
    // 0C8 TypeOfKnownTypeAttribute                 ModelClassType Type Type Type Pointer
    // 0D0 TypeOfDataContractAttribute              ModelClassType Type Type Type Pointer
    // 0D8 TypeOfContractNamespaceAttribute         ModelClassType Type Type Type Pointer
    // 0E0 TypeOfDataMemberAttribute                ModelClassType Type Type Type Pointer
    // 0E8 TypeOfEnumMemberAttribute                ModelClassType Type Type Type Pointer
    // 0F0 TypeOfCollectionDataContractAttribute    ModelClassType Type Type Type Pointer
    // 0F8 TypeOfOptionalFieldAttribute             ModelClassType Type Type Type Pointer
    // 100 TypeOfObjectArray                        ModelClassType Type Type Type Pointer
    // 108 TypeOfOnSerializingAttribute             ModelClassType Type Type Type Pointer
    // 110 TypeOfOnSerializedAttribute              ModelClassType Type Type Type Pointer
    // 118 TypeOfOnDeserializingAttribute           ModelClassType Type Type Type Pointer
    // 120 TypeOfOnDeserializedAttribute            ModelClassType Type Type Type Pointer
    // 128 TypeOfFlagsAttribute                     ModelClassType Type Type Type Pointer
    // 130 TypeOfSerializableAttribute              ModelClassType Type Type Type Pointer
    // 138 TypeOfNonSerializedAttribute             ModelClassType Type Type Type Pointer
    // 140 TypeOfSerializationInfo                  ModelClassType Type Type Type Pointer
    // 148 TypeOfSerializationInfoEnumerator        ModelClassType Type Type Type Pointer
    // 150 TypeOfSerializationEntry                 ModelClassType Type Type Type Pointer
    // 158 TypeOfIXmlSerializable                   ModelClassType Type Type Type Pointer
    // 160 TypeOfXmlSchemaProviderAttribute         ModelClassType Type Type Type Pointer
    // 168 TypeOfXmlRootAttribute                   ModelClassType Type Type Type Pointer
    // 170 TypeOfXmlQualifiedName                   ModelClassType Type Type Type Pointer
    // 178 TypeOfXmlSchemaType                      ModelClassType Type Type Type Pointer
    // 180 TypeOfXmlSerializableServices            ModelClassType Type Type Type Pointer
    // 188 TypeOfXmlNodeArray                       ModelClassType Type Type Type Pointer
    // 190 TypeOfXmlSchemaSet                       ModelClassType Type Type Type Pointer
    // 198 emptyObjectArray                         <object>[] IL2CPP_TYPE_SZARRAY
    // 1A0 EmptyTypeArray                           ModelClassListType Type[] Type[] List<Type> Pointer
    // 1A8 TypeOfIPropertyChange                    ModelClassType Type Type Type Pointer
    // 1B0 TypeOfIExtensibleDataObject              ModelClassType Type Type Type Pointer
    // 1B8 TypeOfExtensionDataObject                ModelClassType Type Type Type Pointer
    // 1C0 TypeOfISerializableDataNode              ModelClassType Type Type Type Pointer
    // 1C8 TypeOfClassDataNode                      ModelClassType Type Type Type Pointer
    // 1D0 TypeOfCollectionDataNode                 ModelClassType Type Type Type Pointer
    // 1D8 TypeOfXmlDataNode                        ModelClassType Type Type Type Pointer
    // 1E0 TypeOfNullable                           ModelClassType Type Type Type Pointer
    // 1E8 TypeOfReflectionPointer                  ModelClassType Type Type Type Pointer
    // 1F0 TypeOfIDictionaryGeneric                 ModelClassType Type Type Type Pointer
    // 1F8 TypeOfIDictionary                        ModelClassType Type Type Type Pointer
    // 200 TypeOfIListGeneric                       ModelClassType Type Type Type Pointer
    // 208 TypeOfIList                              ModelClassType Type Type Type Pointer
    // 210 TypeOfICollectionGeneric                 ModelClassType Type Type Type Pointer
    // 218 TypeOfICollection                        ModelClassType Type Type Type Pointer
    // 220 TypeOfIEnumerableGeneric                 ModelClassType Type Type Type Pointer
    // 228 TypeOfIEnumerable                        ModelClassType Type Type Type Pointer
    // 230 TypeOfIEnumeratorGeneric                 ModelClassType Type Type Type Pointer
    // 238 TypeOfIEnumerator                        ModelClassType Type Type Type Pointer
    // 240 TypeOfKeyValuePair                       ModelClassType Type Type Type Pointer
    // 248 TypeOfKeyValue                           ModelClassType Type Type Type Pointer
    // 250 TypeOfIDictionaryEnumerator              ModelClassType Type Type Type Pointer
    // 258 TypeOfDictionaryEnumerator               ModelClassType Type Type Type Pointer
    // 260 TypeOfGenericDictionaryEnumerator        ModelClassType Type Type Type Pointer
    // 268 TypeOfDictionaryGeneric                  ModelClassType Type Type Type Pointer
    // 270 TypeOfHashtable                          ModelClassType Type Type Type Pointer
    // 278 TypeOfListGeneric                        ModelClassType Type Type Type Pointer
    // 280 TypeOfXmlElement                         ModelClassType Type Type Type Pointer
    // 288 TypeOfDBNull                             ModelClassType Type Type Type Pointer
    // 290 DataContractXsdBaseNamespaceUri          ModelClassType Uri Uri Uri Pointer
    // 000 DefaultIsRequired                        bool IL2CPP_TYPE_BOOLEAN
    // 000 DefaultEmitDefaultValue                  bool IL2CPP_TYPE_BOOLEAN
    // 000 DefaultOrder                             int IL2CPP_TYPE_I4
    // 000 DefaultIsReference                       bool IL2CPP_TYPE_BOOLEAN
    // 298 NewObjectId                              ModelPrimitiveType string string string String
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
    public partial class Globals : DataModel
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
            var value   = new Globals() { Pointer= p0 };

            value.TypeOfObject                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 TypeOfObject                ( ModelClassType Type Type Type Pointer )
            value.TypeOfValueType                           = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 TypeOfValueType             ( ModelClassType Type Type Type Pointer )
            value.TypeOfArray                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 TypeOfArray                 ( ModelClassType Type Type Type Pointer )
            value.TypeOfString                              = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0x28 TypeOfString                ( ModelClassType Type Type Type Pointer )
            value.TypeOfInt                                 = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 TypeOfInt                   ( ModelClassType Type Type Type Pointer )
            value.TypeOfULong                               = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 TypeOfULong                 ( ModelClassType Type Type Type Pointer )
            value.TypeOfVoid                                = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 TypeOfVoid                  ( ModelClassType Type Type Type Pointer )
            value.TypeOfByteArray                           = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 0x48 TypeOfByteArray             ( ModelClassType Type Type Type Pointer )
            value.TypeOfTimeSpan                            = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0x50 TypeOfTimeSpan              ( ModelClassType Type Type Type Pointer )
            value.TypeOfGuid                                = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 0x58 TypeOfGuid                  ( ModelClassType Type Type Type Pointer )
            value.TypeOfDateTimeOffset                      = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0x60 TypeOfDateTimeOffset        ( ModelClassType Type Type Type Pointer )
            value.TypeOfDateTimeOffsetAdapter               = GetObject<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 0x68 TypeOfDateTimeOffsetAdapter ( ModelClassType Type Type Type Pointer )
            value.TypeOfUri                                 = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 0x70 TypeOfUri                   ( ModelClassType Type Type Type Pointer )
            value.TypeOfTypeEnumerable                      = GetObject<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 0x78 TypeOfTypeEnumerable        ( ModelClassType Type Type Type Pointer )
            value.TypeOfStreamingContext                    = GetObject<Type>(new IntPtr(p + 0x080), ReversePrism.DataModels.Type.FromPointer); // 0x80 TypeOfStreamingContext      ( ModelClassType Type Type Type Pointer )
            value.TypeOfISerializable                       = GetObject<Type>(new IntPtr(p + 0x088), ReversePrism.DataModels.Type.FromPointer); // 0x88 TypeOfISerializable         ( ModelClassType Type Type Type Pointer )
            value.TypeOfIDeserializationCallback            = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 0x90 TypeOfIDeserializationCallback ( ModelClassType Type Type Type Pointer )
            value.TypeOfIObjectReference                    = GetObject<Type>(new IntPtr(p + 0x098), ReversePrism.DataModels.Type.FromPointer); // 0x98 TypeOfIObjectReference      ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatClassWriterDelegate        = GetObject<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 0xA0 TypeOfXmlFormatClassWriterDelegate ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatCollectionWriterDelegate   = GetObject<Type>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Type.FromPointer); // 0xA8 TypeOfXmlFormatCollectionWriterDelegate ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatClassReaderDelegate        = GetObject<Type>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Type.FromPointer); // 0xB0 TypeOfXmlFormatClassReaderDelegate ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatCollectionReaderDelegate   = GetObject<Type>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Type.FromPointer); // 0xB8 TypeOfXmlFormatCollectionReaderDelegate ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlFormatGetOnlyCollectionReaderDelegate = GetObject<Type>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Type.FromPointer); // 0xC0 TypeOfXmlFormatGetOnlyCollectionReaderDelegate ( ModelClassType Type Type Type Pointer )
            value.TypeOfKnownTypeAttribute                  = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 0xC8 TypeOfKnownTypeAttribute    ( ModelClassType Type Type Type Pointer )
            value.TypeOfDataContractAttribute               = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 0xD0 TypeOfDataContractAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfContractNamespaceAttribute          = GetObject<Type>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Type.FromPointer); // 0xD8 TypeOfContractNamespaceAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfDataMemberAttribute                 = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0xE0 TypeOfDataMemberAttribute   ( ModelClassType Type Type Type Pointer )
            value.TypeOfEnumMemberAttribute                 = GetObject<Type>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Type.FromPointer); // 0xE8 TypeOfEnumMemberAttribute   ( ModelClassType Type Type Type Pointer )
            value.TypeOfCollectionDataContractAttribute     = GetObject<Type>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Type.FromPointer); // 0xF0 TypeOfCollectionDataContractAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfOptionalFieldAttribute              = GetObject<Type>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Type.FromPointer); // 0xF8 TypeOfOptionalFieldAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfObjectArray                         = GetObject<Type>(new IntPtr(p + 0x100), ReversePrism.DataModels.Type.FromPointer); // 0x100 TypeOfObjectArray           ( ModelClassType Type Type Type Pointer )
            value.TypeOfOnSerializingAttribute              = GetObject<Type>(new IntPtr(p + 0x108), ReversePrism.DataModels.Type.FromPointer); // 0x108 TypeOfOnSerializingAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfOnSerializedAttribute               = GetObject<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 0x110 TypeOfOnSerializedAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfOnDeserializingAttribute            = GetObject<Type>(new IntPtr(p + 0x118), ReversePrism.DataModels.Type.FromPointer); // 0x118 TypeOfOnDeserializingAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfOnDeserializedAttribute             = GetObject<Type>(new IntPtr(p + 0x120), ReversePrism.DataModels.Type.FromPointer); // 0x120 TypeOfOnDeserializedAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfFlagsAttribute                      = GetObject<Type>(new IntPtr(p + 0x128), ReversePrism.DataModels.Type.FromPointer); // 0x128 TypeOfFlagsAttribute        ( ModelClassType Type Type Type Pointer )
            value.TypeOfSerializableAttribute               = GetObject<Type>(new IntPtr(p + 0x130), ReversePrism.DataModels.Type.FromPointer); // 0x130 TypeOfSerializableAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfNonSerializedAttribute              = GetObject<Type>(new IntPtr(p + 0x138), ReversePrism.DataModels.Type.FromPointer); // 0x138 TypeOfNonSerializedAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfSerializationInfo                   = GetObject<Type>(new IntPtr(p + 0x140), ReversePrism.DataModels.Type.FromPointer); // 0x140 TypeOfSerializationInfo     ( ModelClassType Type Type Type Pointer )
            value.TypeOfSerializationInfoEnumerator         = GetObject<Type>(new IntPtr(p + 0x148), ReversePrism.DataModels.Type.FromPointer); // 0x148 TypeOfSerializationInfoEnumerator ( ModelClassType Type Type Type Pointer )
            value.TypeOfSerializationEntry                  = GetObject<Type>(new IntPtr(p + 0x150), ReversePrism.DataModels.Type.FromPointer); // 0x150 TypeOfSerializationEntry    ( ModelClassType Type Type Type Pointer )
            value.TypeOfIXmlSerializable                    = GetObject<Type>(new IntPtr(p + 0x158), ReversePrism.DataModels.Type.FromPointer); // 0x158 TypeOfIXmlSerializable      ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSchemaProviderAttribute          = GetObject<Type>(new IntPtr(p + 0x160), ReversePrism.DataModels.Type.FromPointer); // 0x160 TypeOfXmlSchemaProviderAttribute ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlRootAttribute                    = GetObject<Type>(new IntPtr(p + 0x168), ReversePrism.DataModels.Type.FromPointer); // 0x168 TypeOfXmlRootAttribute      ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlQualifiedName                    = GetObject<Type>(new IntPtr(p + 0x170), ReversePrism.DataModels.Type.FromPointer); // 0x170 TypeOfXmlQualifiedName      ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSchemaType                       = GetObject<Type>(new IntPtr(p + 0x178), ReversePrism.DataModels.Type.FromPointer); // 0x178 TypeOfXmlSchemaType         ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSerializableServices             = GetObject<Type>(new IntPtr(p + 0x180), ReversePrism.DataModels.Type.FromPointer); // 0x180 TypeOfXmlSerializableServices ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlNodeArray                        = GetObject<Type>(new IntPtr(p + 0x188), ReversePrism.DataModels.Type.FromPointer); // 0x188 TypeOfXmlNodeArray          ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlSchemaSet                        = GetObject<Type>(new IntPtr(p + 0x190), ReversePrism.DataModels.Type.FromPointer); // 0x190 TypeOfXmlSchemaSet          ( ModelClassType Type Type Type Pointer )
            value.EmptyTypeArray                            = GetObjectList<Type>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Type.FromPointer); // 0x1A0 EmptyTypeArray              ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.TypeOfIPropertyChange                     = GetObject<Type>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.Type.FromPointer); // 0x1A8 TypeOfIPropertyChange       ( ModelClassType Type Type Type Pointer )
            value.TypeOfIExtensibleDataObject               = GetObject<Type>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Type.FromPointer); // 0x1B0 TypeOfIExtensibleDataObject ( ModelClassType Type Type Type Pointer )
            value.TypeOfExtensionDataObject                 = GetObject<Type>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Type.FromPointer); // 0x1B8 TypeOfExtensionDataObject   ( ModelClassType Type Type Type Pointer )
            value.TypeOfISerializableDataNode               = GetObject<Type>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.Type.FromPointer); // 0x1C0 TypeOfISerializableDataNode ( ModelClassType Type Type Type Pointer )
            value.TypeOfClassDataNode                       = GetObject<Type>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Type.FromPointer); // 0x1C8 TypeOfClassDataNode         ( ModelClassType Type Type Type Pointer )
            value.TypeOfCollectionDataNode                  = GetObject<Type>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Type.FromPointer); // 0x1D0 TypeOfCollectionDataNode    ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlDataNode                         = GetObject<Type>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.Type.FromPointer); // 0x1D8 TypeOfXmlDataNode           ( ModelClassType Type Type Type Pointer )
            value.TypeOfNullable                            = GetObject<Type>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.Type.FromPointer); // 0x1E0 TypeOfNullable              ( ModelClassType Type Type Type Pointer )
            value.TypeOfReflectionPointer                   = GetObject<Type>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.Type.FromPointer); // 0x1E8 TypeOfReflectionPointer     ( ModelClassType Type Type Type Pointer )
            value.TypeOfIDictionaryGeneric                  = GetObject<Type>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.Type.FromPointer); // 0x1F0 TypeOfIDictionaryGeneric    ( ModelClassType Type Type Type Pointer )
            value.TypeOfIDictionary                         = GetObject<Type>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Type.FromPointer); // 0x1F8 TypeOfIDictionary           ( ModelClassType Type Type Type Pointer )
            value.TypeOfIListGeneric                        = GetObject<Type>(new IntPtr(p + 0x200), ReversePrism.DataModels.Type.FromPointer); // 0x200 TypeOfIListGeneric          ( ModelClassType Type Type Type Pointer )
            value.TypeOfIList                               = GetObject<Type>(new IntPtr(p + 0x208), ReversePrism.DataModels.Type.FromPointer); // 0x208 TypeOfIList                 ( ModelClassType Type Type Type Pointer )
            value.TypeOfICollectionGeneric                  = GetObject<Type>(new IntPtr(p + 0x210), ReversePrism.DataModels.Type.FromPointer); // 0x210 TypeOfICollectionGeneric    ( ModelClassType Type Type Type Pointer )
            value.TypeOfICollection                         = GetObject<Type>(new IntPtr(p + 0x218), ReversePrism.DataModels.Type.FromPointer); // 0x218 TypeOfICollection           ( ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumerableGeneric                  = GetObject<Type>(new IntPtr(p + 0x220), ReversePrism.DataModels.Type.FromPointer); // 0x220 TypeOfIEnumerableGeneric    ( ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumerable                         = GetObject<Type>(new IntPtr(p + 0x228), ReversePrism.DataModels.Type.FromPointer); // 0x228 TypeOfIEnumerable           ( ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumeratorGeneric                  = GetObject<Type>(new IntPtr(p + 0x230), ReversePrism.DataModels.Type.FromPointer); // 0x230 TypeOfIEnumeratorGeneric    ( ModelClassType Type Type Type Pointer )
            value.TypeOfIEnumerator                         = GetObject<Type>(new IntPtr(p + 0x238), ReversePrism.DataModels.Type.FromPointer); // 0x238 TypeOfIEnumerator           ( ModelClassType Type Type Type Pointer )
            value.TypeOfKeyValuePair                        = GetObject<Type>(new IntPtr(p + 0x240), ReversePrism.DataModels.Type.FromPointer); // 0x240 TypeOfKeyValuePair          ( ModelClassType Type Type Type Pointer )
            value.TypeOfKeyValue                            = GetObject<Type>(new IntPtr(p + 0x248), ReversePrism.DataModels.Type.FromPointer); // 0x248 TypeOfKeyValue              ( ModelClassType Type Type Type Pointer )
            value.TypeOfIDictionaryEnumerator               = GetObject<Type>(new IntPtr(p + 0x250), ReversePrism.DataModels.Type.FromPointer); // 0x250 TypeOfIDictionaryEnumerator ( ModelClassType Type Type Type Pointer )
            value.TypeOfDictionaryEnumerator                = GetObject<Type>(new IntPtr(p + 0x258), ReversePrism.DataModels.Type.FromPointer); // 0x258 TypeOfDictionaryEnumerator  ( ModelClassType Type Type Type Pointer )
            value.TypeOfGenericDictionaryEnumerator         = GetObject<Type>(new IntPtr(p + 0x260), ReversePrism.DataModels.Type.FromPointer); // 0x260 TypeOfGenericDictionaryEnumerator ( ModelClassType Type Type Type Pointer )
            value.TypeOfDictionaryGeneric                   = GetObject<Type>(new IntPtr(p + 0x268), ReversePrism.DataModels.Type.FromPointer); // 0x268 TypeOfDictionaryGeneric     ( ModelClassType Type Type Type Pointer )
            value.TypeOfHashtable                           = GetObject<Type>(new IntPtr(p + 0x270), ReversePrism.DataModels.Type.FromPointer); // 0x270 TypeOfHashtable             ( ModelClassType Type Type Type Pointer )
            value.TypeOfListGeneric                         = GetObject<Type>(new IntPtr(p + 0x278), ReversePrism.DataModels.Type.FromPointer); // 0x278 TypeOfListGeneric           ( ModelClassType Type Type Type Pointer )
            value.TypeOfXmlElement                          = GetObject<Type>(new IntPtr(p + 0x280), ReversePrism.DataModels.Type.FromPointer); // 0x280 TypeOfXmlElement            ( ModelClassType Type Type Type Pointer )
            value.TypeOfDBNull                              = GetObject<Type>(new IntPtr(p + 0x288), ReversePrism.DataModels.Type.FromPointer); // 0x288 TypeOfDBNull                ( ModelClassType Type Type Type Pointer )
            value.DataContractXsdBaseNamespaceUri           = GetObject<Uri>(new IntPtr(p + 0x290), ReversePrism.DataModels.Uri.FromPointer); // 0x290 DataContractXsdBaseNamespaceUri ( ModelClassType Uri Uri Uri Pointer )
            value.NewObjectId                               = GetString(new IntPtr(p + 0x298)); // 0x298 NewObjectId                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
