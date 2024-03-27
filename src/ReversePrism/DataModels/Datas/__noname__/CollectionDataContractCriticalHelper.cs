using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _knownInterfaces                         Type[] IL2CPP_TYPE_SZARRAY
    // 060 ItemType                                 000186692850 ModelClassType Type Type Type Pointer
    // 068 IsItemTypeNullable                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 Kind                                     0001865C6820 ModelEnumType CollectionKind CollectionKind CollectionKind Int32
    // 070 GetEnumeratorMethod                      000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 078 AddMethod                                000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 Constructor                              00018660FE70 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 088 SerializationExceptionMessage            000186672F10 ModelPrimitiveType string string string String
    // 090 DeserializationExceptionMessage          000186672F10 ModelPrimitiveType string string string String
    // 098 ItemContract                             0001865B6200 ModelClassType DataContract DataContract DataContract Pointer
    // 0A0 SharedTypeContract                       0001865B6200 ModelClassType DataContract DataContract DataContract Pointer
    // 0A8 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 0B0 IsKnownTypeAttributeChecked              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B8 ItemName                                 000186671910 ModelPrimitiveType string string string String
    // 0C0 ItemNameSetExplicit                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C8 CollectionItemName                       0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0D0 KeyName                                  000186671910 ModelPrimitiveType string string string String
    // 0D8 ValueName                                000186671910 ModelPrimitiveType string string string String
    // 0E0 ChildElementNamespace                    0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0E8 InvalidCollectionInSharedContractMessage 000186671910 ModelPrimitiveType string string string String
    // 0F0 XmlFormatReaderDelegate                  00018659B960 ModelClassType XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate Pointer
    // 0F8 XmlFormatGetOnlyCollectionReaderDelegate 00018659C580 ModelClassType XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate Pointer
    // 100 XmlFormatWriterDelegate                  00018659BE70 ModelClassType XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate Pointer
    // 108 IsConstructorCheckRequired               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CollectionDataContractCriticalHelper
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
            var value   = new CollectionDataContractCriticalHelper();

            value.ItemType                                  = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 027004D5F660 0x60 ItemType                    ( 000186692850 ModelClassType Type Type Type Pointer )
            value.IsItemTypeNullable                        = GetBool(new IntPtr(p + 0x068)); // 027004D5F680 0x68 IsItemTypeNullable          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Kind                                      = (CollectionKind)GetInt32(new IntPtr(p + 0x069)); // 027004D5F6A0 0x69 Kind                        ( 0001865C6820 ModelEnumType CollectionKind CollectionKind CollectionKind Int32 )
            value.GetEnumeratorMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D5F6C0 0x70 GetEnumeratorMethod         ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.AddMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D5F6E0 0x78 AddMethod                   ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Constructor                               = GetObject<ConstructorInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 027004D5F700 0x80 Constructor                 ( 00018660FE70 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.SerializationExceptionMessage             = GetString(new IntPtr(p + 0x088)); // 027004D5F720 0x88 SerializationExceptionMessage ( 000186672F10 ModelPrimitiveType string string string String )
            value.DeserializationExceptionMessage           = GetString(new IntPtr(p + 0x090)); // 027004D5F740 0x90 DeserializationExceptionMessage ( 000186672F10 ModelPrimitiveType string string string String )
            value.ItemContract                              = GetObject<DataContract>(new IntPtr(p + 0x098), ReversePrism.DataModels.DataContract.FromPointer); // 027004D5F760 0x98 ItemContract                ( 0001865B6200 ModelClassType DataContract DataContract DataContract Pointer )
            value.SharedTypeContract                        = GetObject<DataContract>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DataContract.FromPointer); // 027004D5F780 0xA0 SharedTypeContract          ( 0001865B6200 ModelClassType DataContract DataContract DataContract Pointer )
            value.IsKnownTypeAttributeChecked               = GetBool(new IntPtr(p + 0x0B0)); // 027004D5F7C0 0xB0 IsKnownTypeAttributeChecked ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ItemName                                  = GetString(new IntPtr(p + 0x0B8)); // 027004D5F7E0 0xB8 ItemName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ItemNameSetExplicit                       = GetBool(new IntPtr(p + 0x0C0)); // 027004D5F800 0xC0 ItemNameSetExplicit         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CollectionItemName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 027004D5F820 0xC8 CollectionItemName          ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.KeyName                                   = GetString(new IntPtr(p + 0x0D0)); // 027004D5F840 0xD0 KeyName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ValueName                                 = GetString(new IntPtr(p + 0x0D8)); // 027004D5F860 0xD8 ValueName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.ChildElementNamespace                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 027004D5F880 0xE0 ChildElementNamespace       ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.InvalidCollectionInSharedContractMessage  = GetString(new IntPtr(p + 0x0E8)); // 027004D5F8A0 0xE8 InvalidCollectionInSharedContractMessage ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlFormatReaderDelegate                   = GetObject<XmlFormatCollectionReaderDelegate>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlFormatCollectionReaderDelegate.FromPointer); // 027004D5F8C0 0xF0 XmlFormatReaderDelegate     ( 00018659B960 ModelClassType XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate XmlFormatCollectionReaderDelegate Pointer )
            value.XmlFormatGetOnlyCollectionReaderDelegate  = GetObject<XmlFormatGetOnlyCollectionReaderDelegate>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XmlFormatGetOnlyCollectionReaderDelegate.FromPointer); // 027004D5F8E0 0xF8 XmlFormatGetOnlyCollectionReaderDelegate ( 00018659C580 ModelClassType XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate XmlFormatGetOnlyCollectionReaderDelegate Pointer )
            value.XmlFormatWriterDelegate                   = GetObject<XmlFormatCollectionWriterDelegate>(new IntPtr(p + 0x100), ReversePrism.DataModels.XmlFormatCollectionWriterDelegate.FromPointer); // 027004D5F900 0x100 XmlFormatWriterDelegate     ( 00018659BE70 ModelClassType XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate XmlFormatCollectionWriterDelegate Pointer )
            value.IsConstructorCheckRequired                = GetBool(new IntPtr(p + 0x108)); // 027004D5F920 0x108 IsConstructorCheckRequired  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
