using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _knownInterfaces                         Type[] IL2CPP_TYPE_SZARRAY
    // 060 ItemType                                 ModelClassType Type Type Type Pointer
    // 068 IsItemTypeNullable                       ModelPrimitiveType bool bool bool Bool
    // 069 Kind                                     ModelEnumType CollectionKind CollectionKind CollectionKind Int32
    // 070 GetEnumeratorMethod                      ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 078 AddMethod                                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 Constructor                              ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 088 SerializationExceptionMessage            ModelPrimitiveType string string string String
    // 090 DeserializationExceptionMessage          ModelPrimitiveType string string string String
    // 098 ItemContract                             ModelClassType DataContract DataContract DataContract Pointer
    // 0A0 SharedTypeContract                       ModelClassType DataContract DataContract DataContract Pointer
    // 0A8 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 0B0 IsKnownTypeAttributeChecked              ModelPrimitiveType bool bool bool Bool
    // 0B8 ItemName                                 ModelPrimitiveType string string string String
    // 0C0 ItemNameSetExplicit                      ModelPrimitiveType bool bool bool Bool
    // 0C8 CollectionItemName                       ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0D0 KeyName                                  ModelPrimitiveType string string string String
    // 0D8 ValueName                                ModelPrimitiveType string string string String
    // 0E0 ChildElementNamespace                    ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0E8 InvalidCollectionInSharedContractMessage ModelPrimitiveType string string string String
    // 0F0 XmlFormatReaderDelegate                  ModelClassType XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate Pointer
    // 0F8 XmlFormatGetOnlyCollectionReaderDelegate ModelClassType XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate Pointer
    // 100 XmlFormatWriterDelegate                  ModelClassType XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate Pointer
    // 108 IsConstructorCheckRequired               ModelPrimitiveType bool bool bool Bool
    public partial class CollectionDataContractCriticalHelper : DataModel
    {
        public Type?                                    ItemType                                { get; set; }
        public bool                                     IsItemTypeNullable                      { get; set; }
        public CollectionKind                           Kind                                    { get; set; }
        public MethodInfo?                              GetEnumeratorMethod                     { get; set; }
        public MethodInfo?                              AddMethod                               { get; set; }
        public ConstructorInfo?                         Constructor                             { get; set; }
        public string                                   SerializationExceptionMessage           { get; set; }
        public string                                   DeserializationExceptionMessage         { get; set; }
        public DataContract?                            ItemContract                            { get; set; }
        public DataContract?                            SharedTypeContract                      { get; set; }
        public bool                                     IsKnownTypeAttributeChecked             { get; set; }
        public string                                   ItemName                                { get; set; }
        public bool                                     ItemNameSetExplicit                     { get; set; }
        public XmlDictionaryString?                     CollectionItemName                      { get; set; }
        public string                                   KeyName                                 { get; set; }
        public string                                   ValueName                               { get; set; }
        public XmlDictionaryString?                     ChildElementNamespace                   { get; set; }
        public string                                   InvalidCollectionInSharedContractMessage { get; set; }
        public XmlFormatCollectionReaderDelegate?       XmlFormatReaderDelegate                 { get; set; }
        public XmlFormatGetOnlyCollectionReaderDelegate? XmlFormatGetOnlyCollectionReaderDelegate { get; set; }
        public XmlFormatCollectionWriterDelegate?       XmlFormatWriterDelegate                 { get; set; }
        public bool                                     IsConstructorCheckRequired              { get; set; }

        public static CollectionDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionDataContractCriticalHelper() { Pointer= p0 };

            value.ItemType                                  = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0x60 ItemType                    ( ModelClassType Type Type Type Pointer )
            value.IsItemTypeNullable                        = GetBool(new IntPtr(p + 0x068)); // 0x68 IsItemTypeNullable          ( ModelPrimitiveType bool bool bool Bool )
            value.Kind                                      = (CollectionKind)GetInt32(new IntPtr(p + 0x069)); // 0x69 Kind                        ( ModelEnumType CollectionKind CollectionKind CollectionKind Int32 )
            value.GetEnumeratorMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x70 GetEnumeratorMethod         ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.AddMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x78 AddMethod                   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Constructor                               = GetObject<ConstructorInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0x80 Constructor                 ( ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.SerializationExceptionMessage             = GetString(new IntPtr(p + 0x088)); // 0x88 SerializationExceptionMessage ( ModelPrimitiveType string string string String )
            value.DeserializationExceptionMessage           = GetString(new IntPtr(p + 0x090)); // 0x90 DeserializationExceptionMessage ( ModelPrimitiveType string string string String )
            value.ItemContract                              = GetObject<DataContract>(new IntPtr(p + 0x098), ReversePrism.DataModels.DataContract.FromPointer); // 0x98 ItemContract                ( ModelClassType DataContract DataContract DataContract Pointer )
            value.SharedTypeContract                        = GetObject<DataContract>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DataContract.FromPointer); // 0xA0 SharedTypeContract          ( ModelClassType DataContract DataContract DataContract Pointer )
            value.IsKnownTypeAttributeChecked               = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsKnownTypeAttributeChecked ( ModelPrimitiveType bool bool bool Bool )
            value.ItemName                                  = GetString(new IntPtr(p + 0x0B8)); // 0xB8 ItemName                    ( ModelPrimitiveType string string string String )
            value.ItemNameSetExplicit                       = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 ItemNameSetExplicit         ( ModelPrimitiveType bool bool bool Bool )
            value.CollectionItemName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0xC8 CollectionItemName          ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.KeyName                                   = GetString(new IntPtr(p + 0x0D0)); // 0xD0 KeyName                     ( ModelPrimitiveType string string string String )
            value.ValueName                                 = GetString(new IntPtr(p + 0x0D8)); // 0xD8 ValueName                   ( ModelPrimitiveType string string string String )
            value.ChildElementNamespace                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0xE0 ChildElementNamespace       ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.InvalidCollectionInSharedContractMessage  = GetString(new IntPtr(p + 0x0E8)); // 0xE8 InvalidCollectionInSharedContractMessage ( ModelPrimitiveType string string string String )
            value.XmlFormatReaderDelegate                   = GetObject<XmlFormatCollectionReaderDelegate>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlFormatCollectionReaderDelegate.FromPointer); // 0xF0 XmlFormatReaderDelegate     ( ModelClassType XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate Pointer )
            value.XmlFormatGetOnlyCollectionReaderDelegate  = GetObject<XmlFormatGetOnlyCollectionReaderDelegate>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XmlFormatGetOnlyCollectionReaderDelegate.FromPointer); // 0xF8 XmlFormatGetOnlyCollectionReaderDelegate ( ModelClassType XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate Pointer )
            value.XmlFormatWriterDelegate                   = GetObject<XmlFormatCollectionWriterDelegate>(new IntPtr(p + 0x100), ReversePrism.DataModels.XmlFormatCollectionWriterDelegate.FromPointer); // 0x100 XmlFormatWriterDelegate     ( ModelClassType XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate Pointer )
            value.IsConstructorCheckRequired                = GetBool(new IntPtr(p + 0x108)); // 0x108 IsConstructorCheckRequired  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
