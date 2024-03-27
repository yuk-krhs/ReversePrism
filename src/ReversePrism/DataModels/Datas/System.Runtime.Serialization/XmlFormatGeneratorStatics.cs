using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 writeStartElementMethod2                 MethodInfo IL2CPP_TYPE_CLASS
    // 008 writeStartElementMethod3                 MethodInfo IL2CPP_TYPE_CLASS
    // 010 WriteEndElementMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 WriteNamespaceDeclMethod                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 ExtensionDataProperty                    0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 028 BoxPointer                               000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 DictionaryEnumeratorCtor                 00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 038 IenumeratorMoveNextMethod                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 040 IenumeratorGetCurrentMethod              000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 GetItemContractMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 050 IsStartElementMethod2                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 058 IsStartElementMethod0                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 GetUninitializedObjectMethod             000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 068 OnDeserializationMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 070 UnboxPointer                             000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 078 NodeTypeProperty                         0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 080 SerializationExceptionCtor               00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 088 ExtensionDataObjectCtor                  00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 090 HashtableCtor                            00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 098 GetStreamingContextMethod                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0A0 GetCollectionMemberMethod                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0A8 StoreCollectionMemberInfoMethod          000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0B0 StoreIsGetOnlyCollectionMethod           000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0B8 ThrowNullValueReturnedForGetOnlyCollectionExceptionMethod 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C0 ThrowArrayExceededSizeExceptionMethod    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C8 IncrementItemCountMethod                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0D0 DemandSerializationFormatterPermissionMethod 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0D8 DemandMemberAccessPermissionMethod       000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0E0 InternalDeserializeMethod                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0E8 MoveToNextElementMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0F0 GetMemberIndexMethod                     000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0F8 GetMemberIndexWithRequiredMembersMethod  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 100 ThrowRequiredMemberMissingExceptionMethod 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 108 SkipUnknownElementMethod                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 110 ReadIfNullOrRefMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 118 ReadAttributesMethod                     000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 120 ResetAttributesMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 128 GetObjectIdMethod                        000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 130 GetArraySizeMethod                       000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 138 AddNewObjectMethod                       000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 140 AddNewObjectWithIdMethod                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 148 ReplaceDeserializedObjectMethod          000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 150 GetExistingObjectMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 158 GetRealObjectMethod                      000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 160 ReadMethod                               000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 168 EnsureArraySizeMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 170 TrimArraySizeMethod                      000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 178 CheckEndOfArrayMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 180 GetArrayLengthMethod                     000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 188 ReadSerializationInfoMethod              000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 190 CreateUnexpectedStateExceptionMethod     000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 198 InternalSerializeReferenceMethod         000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1A0 InternalSerializeMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1A8 WriteNullMethod                          000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1B0 IncrementArrayCountMethod                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1B8 IncrementCollectionCountMethod           000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1C0 IncrementCollectionCountGenericMethod    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1C8 GetDefaultValueMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1D0 GetNullableValueMethod                   000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1D8 ThrowRequiredMemberMustBeEmittedMethod   000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1E0 GetHasValueMethod                        000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1E8 WriteISerializableMethod                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1F0 WriteExtensionDataMethod                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 1F8 WriteXmlValueMethod                      000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 200 ReadXmlValueMethod                       000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 208 ThrowTypeNotSerializableMethod           000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 210 NamespaceProperty                        0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 218 ContractNamespacesField                  0001865735D0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    // 220 MemberNamesField                         0001865735D0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    // 228 ExtensionDataSetExplicitMethodInfo       000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 230 ChildElementNamespacesProperty           0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 238 CollectionItemNameProperty               0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 240 ChildElementNamespaceProperty            0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 248 GetDateTimeOffsetMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 250 GetDateTimeOffsetAdapterMethod           000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 258 TraceInstructionMethod                   000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 260 ThrowInvalidDataContractExceptionMethod  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 268 SerializeReadOnlyTypesProperty           0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 270 ClassSerializationExceptionMessageProperty 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 278 CollectionSerializationExceptionMessageProperty 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    public partial class XmlFormatGeneratorStatics
    {
        public MethodInfo?                              WriteEndElementMethod                   { get; set; }
        public MethodInfo?                              WriteNamespaceDeclMethod                { get; set; }
        public PropertyInfo?                            ExtensionDataProperty                   { get; set; }
        public MethodInfo?                              BoxPointer                              { get; set; }
        public ConstructorInfo?                         DictionaryEnumeratorCtor                { get; set; }
        public MethodInfo?                              IenumeratorMoveNextMethod               { get; set; }
        public MethodInfo?                              IenumeratorGetCurrentMethod             { get; set; }
        public MethodInfo?                              GetItemContractMethod                   { get; set; }
        public MethodInfo?                              IsStartElementMethod2                   { get; set; }
        public MethodInfo?                              IsStartElementMethod0                   { get; set; }
        public MethodInfo?                              GetUninitializedObjectMethod            { get; set; }
        public MethodInfo?                              OnDeserializationMethod                 { get; set; }
        public MethodInfo?                              UnboxPointer                            { get; set; }
        public PropertyInfo?                            NodeTypeProperty                        { get; set; }
        public ConstructorInfo?                         SerializationExceptionCtor              { get; set; }
        public ConstructorInfo?                         ExtensionDataObjectCtor                 { get; set; }
        public ConstructorInfo?                         HashtableCtor                           { get; set; }
        public MethodInfo?                              GetStreamingContextMethod               { get; set; }
        public MethodInfo?                              GetCollectionMemberMethod               { get; set; }
        public MethodInfo?                              StoreCollectionMemberInfoMethod         { get; set; }
        public MethodInfo?                              StoreIsGetOnlyCollectionMethod          { get; set; }
        public MethodInfo?                              ThrowNullValueReturnedForGetOnlyCollectionExceptionMethod { get; set; }
        public MethodInfo?                              ThrowArrayExceededSizeExceptionMethod   { get; set; }
        public MethodInfo?                              IncrementItemCountMethod                { get; set; }
        public MethodInfo?                              DemandSerializationFormatterPermissionMethod { get; set; }
        public MethodInfo?                              DemandMemberAccessPermissionMethod      { get; set; }
        public MethodInfo?                              InternalDeserializeMethod               { get; set; }
        public MethodInfo?                              MoveToNextElementMethod                 { get; set; }
        public MethodInfo?                              GetMemberIndexMethod                    { get; set; }
        public MethodInfo?                              GetMemberIndexWithRequiredMembersMethod { get; set; }
        public MethodInfo?                              ThrowRequiredMemberMissingExceptionMethod { get; set; }
        public MethodInfo?                              SkipUnknownElementMethod                { get; set; }
        public MethodInfo?                              ReadIfNullOrRefMethod                   { get; set; }
        public MethodInfo?                              ReadAttributesMethod                    { get; set; }
        public MethodInfo?                              ResetAttributesMethod                   { get; set; }
        public MethodInfo?                              GetObjectIdMethod                       { get; set; }
        public MethodInfo?                              GetArraySizeMethod                      { get; set; }
        public MethodInfo?                              AddNewObjectMethod                      { get; set; }
        public MethodInfo?                              AddNewObjectWithIdMethod                { get; set; }
        public MethodInfo?                              ReplaceDeserializedObjectMethod         { get; set; }
        public MethodInfo?                              GetExistingObjectMethod                 { get; set; }
        public MethodInfo?                              GetRealObjectMethod                     { get; set; }
        public MethodInfo?                              ReadMethod                              { get; set; }
        public MethodInfo?                              EnsureArraySizeMethod                   { get; set; }
        public MethodInfo?                              TrimArraySizeMethod                     { get; set; }
        public MethodInfo?                              CheckEndOfArrayMethod                   { get; set; }
        public MethodInfo?                              GetArrayLengthMethod                    { get; set; }
        public MethodInfo?                              ReadSerializationInfoMethod             { get; set; }
        public MethodInfo?                              CreateUnexpectedStateExceptionMethod    { get; set; }
        public MethodInfo?                              InternalSerializeReferenceMethod        { get; set; }
        public MethodInfo?                              InternalSerializeMethod                 { get; set; }
        public MethodInfo?                              WriteNullMethod                         { get; set; }
        public MethodInfo?                              IncrementArrayCountMethod               { get; set; }
        public MethodInfo?                              IncrementCollectionCountMethod          { get; set; }
        public MethodInfo?                              IncrementCollectionCountGenericMethod   { get; set; }
        public MethodInfo?                              GetDefaultValueMethod                   { get; set; }
        public MethodInfo?                              GetNullableValueMethod                  { get; set; }
        public MethodInfo?                              ThrowRequiredMemberMustBeEmittedMethod  { get; set; }
        public MethodInfo?                              GetHasValueMethod                       { get; set; }
        public MethodInfo?                              WriteISerializableMethod                { get; set; }
        public MethodInfo?                              WriteExtensionDataMethod                { get; set; }
        public MethodInfo?                              WriteXmlValueMethod                     { get; set; }
        public MethodInfo?                              ReadXmlValueMethod                      { get; set; }
        public MethodInfo?                              ThrowTypeNotSerializableMethod          { get; set; }
        public PropertyInfo?                            NamespaceProperty                       { get; set; }
        public FieldInfo?                               ContractNamespacesField                 { get; set; }
        public FieldInfo?                               MemberNamesField                        { get; set; }
        public MethodInfo?                              ExtensionDataSetExplicitMethodInfo      { get; set; }
        public PropertyInfo?                            ChildElementNamespacesProperty          { get; set; }
        public PropertyInfo?                            CollectionItemNameProperty              { get; set; }
        public PropertyInfo?                            ChildElementNamespaceProperty           { get; set; }
        public MethodInfo?                              GetDateTimeOffsetMethod                 { get; set; }
        public MethodInfo?                              GetDateTimeOffsetAdapterMethod          { get; set; }
        public MethodInfo?                              TraceInstructionMethod                  { get; set; }
        public MethodInfo?                              ThrowInvalidDataContractExceptionMethod { get; set; }
        public PropertyInfo?                            SerializeReadOnlyTypesProperty          { get; set; }
        public PropertyInfo?                            ClassSerializationExceptionMessageProperty { get; set; }
        public PropertyInfo?                            CollectionSerializationExceptionMessageProperty { get; set; }

        public static XmlFormatGeneratorStatics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlFormatGeneratorStatics();

            value.WriteEndElementMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96AF0 0x10 WriteEndElementMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteNamespaceDeclMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96B10 0x18 WriteNamespaceDeclMethod    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ExtensionDataProperty                     = GetObject<PropertyInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D96B30 0x20 ExtensionDataProperty       ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.BoxPointer                                = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96B50 0x28 BoxPointer                  ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.DictionaryEnumeratorCtor                  = GetObject<ConstructorInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 027004D96B70 0x30 DictionaryEnumeratorCtor    ( 00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.IenumeratorMoveNextMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96B90 0x38 IenumeratorMoveNextMethod   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IenumeratorGetCurrentMethod               = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96BB0 0x40 IenumeratorGetCurrentMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetItemContractMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96BD0 0x48 GetItemContractMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IsStartElementMethod2                     = GetObject<MethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96BF0 0x50 IsStartElementMethod2       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IsStartElementMethod0                     = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96C10 0x58 IsStartElementMethod0       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetUninitializedObjectMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96C30 0x60 GetUninitializedObjectMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.OnDeserializationMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96C50 0x68 OnDeserializationMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.UnboxPointer                              = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96C70 0x70 UnboxPointer                ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.NodeTypeProperty                          = GetObject<PropertyInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D96C90 0x78 NodeTypeProperty            ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.SerializationExceptionCtor                = GetObject<ConstructorInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 027004D96CB0 0x80 SerializationExceptionCtor  ( 00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.ExtensionDataObjectCtor                   = GetObject<ConstructorInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 027004D96CD0 0x88 ExtensionDataObjectCtor     ( 00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.HashtableCtor                             = GetObject<ConstructorInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 027004D96CF0 0x90 HashtableCtor               ( 00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.GetStreamingContextMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96D10 0x98 GetStreamingContextMethod   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetCollectionMemberMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96D30 0xA0 GetCollectionMemberMethod   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.StoreCollectionMemberInfoMethod           = GetObject<MethodInfo>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96D50 0xA8 StoreCollectionMemberInfoMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.StoreIsGetOnlyCollectionMethod            = GetObject<MethodInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96D70 0xB0 StoreIsGetOnlyCollectionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowNullValueReturnedForGetOnlyCollectionExceptionMethod = GetObject<MethodInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96D90 0xB8 ThrowNullValueReturnedForGetOnlyCollectionExceptionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowArrayExceededSizeExceptionMethod     = GetObject<MethodInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96DB0 0xC0 ThrowArrayExceededSizeExceptionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IncrementItemCountMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96DD0 0xC8 IncrementItemCountMethod    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.DemandSerializationFormatterPermissionMethod = GetObject<MethodInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96DF0 0xD0 DemandSerializationFormatterPermissionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.DemandMemberAccessPermissionMethod        = GetObject<MethodInfo>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96E10 0xD8 DemandMemberAccessPermissionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.InternalDeserializeMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96E30 0xE0 InternalDeserializeMethod   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.MoveToNextElementMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96E50 0xE8 MoveToNextElementMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetMemberIndexMethod                      = GetObject<MethodInfo>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96E70 0xF0 GetMemberIndexMethod        ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetMemberIndexWithRequiredMembersMethod   = GetObject<MethodInfo>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96E90 0xF8 GetMemberIndexWithRequiredMembersMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowRequiredMemberMissingExceptionMethod = GetObject<MethodInfo>(new IntPtr(p + 0x100), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96EB0 0x100 ThrowRequiredMemberMissingExceptionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SkipUnknownElementMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x108), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96ED0 0x108 SkipUnknownElementMethod    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReadIfNullOrRefMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x110), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96EF0 0x110 ReadIfNullOrRefMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReadAttributesMethod                      = GetObject<MethodInfo>(new IntPtr(p + 0x118), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96F10 0x118 ReadAttributesMethod        ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ResetAttributesMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x120), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96F30 0x120 ResetAttributesMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetObjectIdMethod                         = GetObject<MethodInfo>(new IntPtr(p + 0x128), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96F50 0x128 GetObjectIdMethod           ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetArraySizeMethod                        = GetObject<MethodInfo>(new IntPtr(p + 0x130), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96F70 0x130 GetArraySizeMethod          ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.AddNewObjectMethod                        = GetObject<MethodInfo>(new IntPtr(p + 0x138), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96F90 0x138 AddNewObjectMethod          ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.AddNewObjectWithIdMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x140), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96FB0 0x140 AddNewObjectWithIdMethod    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReplaceDeserializedObjectMethod           = GetObject<MethodInfo>(new IntPtr(p + 0x148), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96FD0 0x148 ReplaceDeserializedObjectMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetExistingObjectMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x150), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D96FF0 0x150 GetExistingObjectMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetRealObjectMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x158), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97010 0x158 GetRealObjectMethod         ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReadMethod                                = GetObject<MethodInfo>(new IntPtr(p + 0x160), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97030 0x160 ReadMethod                  ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.EnsureArraySizeMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x168), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97050 0x168 EnsureArraySizeMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.TrimArraySizeMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x170), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97070 0x170 TrimArraySizeMethod         ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.CheckEndOfArrayMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x178), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97090 0x178 CheckEndOfArrayMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetArrayLengthMethod                      = GetObject<MethodInfo>(new IntPtr(p + 0x180), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D970B0 0x180 GetArrayLengthMethod        ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReadSerializationInfoMethod               = GetObject<MethodInfo>(new IntPtr(p + 0x188), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D970D0 0x188 ReadSerializationInfoMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.CreateUnexpectedStateExceptionMethod      = GetObject<MethodInfo>(new IntPtr(p + 0x190), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D970F0 0x190 CreateUnexpectedStateExceptionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.InternalSerializeReferenceMethod          = GetObject<MethodInfo>(new IntPtr(p + 0x198), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97110 0x198 InternalSerializeReferenceMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.InternalSerializeMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97130 0x1A0 InternalSerializeMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteNullMethod                           = GetObject<MethodInfo>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97150 0x1A8 WriteNullMethod             ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IncrementArrayCountMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97170 0x1B0 IncrementArrayCountMethod   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IncrementCollectionCountMethod            = GetObject<MethodInfo>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97190 0x1B8 IncrementCollectionCountMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IncrementCollectionCountGenericMethod     = GetObject<MethodInfo>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D971B0 0x1C0 IncrementCollectionCountGenericMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetDefaultValueMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D971D0 0x1C8 GetDefaultValueMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetNullableValueMethod                    = GetObject<MethodInfo>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D971F0 0x1D0 GetNullableValueMethod      ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowRequiredMemberMustBeEmittedMethod    = GetObject<MethodInfo>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97210 0x1D8 ThrowRequiredMemberMustBeEmittedMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetHasValueMethod                         = GetObject<MethodInfo>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97230 0x1E0 GetHasValueMethod           ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteISerializableMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97250 0x1E8 WriteISerializableMethod    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteExtensionDataMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97270 0x1F0 WriteExtensionDataMethod    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteXmlValueMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97290 0x1F8 WriteXmlValueMethod         ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReadXmlValueMethod                        = GetObject<MethodInfo>(new IntPtr(p + 0x200), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D972B0 0x200 ReadXmlValueMethod          ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowTypeNotSerializableMethod            = GetObject<MethodInfo>(new IntPtr(p + 0x208), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D972D0 0x208 ThrowTypeNotSerializableMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.NamespaceProperty                         = GetObject<PropertyInfo>(new IntPtr(p + 0x210), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D972F0 0x210 NamespaceProperty           ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.ContractNamespacesField                   = GetObject<FieldInfo>(new IntPtr(p + 0x218), ReversePrism.DataModels.FieldInfo.FromPointer); // 027004D97310 0x218 ContractNamespacesField     ( 0001865735D0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer )
            value.MemberNamesField                          = GetObject<FieldInfo>(new IntPtr(p + 0x220), ReversePrism.DataModels.FieldInfo.FromPointer); // 027004D97330 0x220 MemberNamesField            ( 0001865735D0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer )
            value.ExtensionDataSetExplicitMethodInfo        = GetObject<MethodInfo>(new IntPtr(p + 0x228), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97350 0x228 ExtensionDataSetExplicitMethodInfo ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ChildElementNamespacesProperty            = GetObject<PropertyInfo>(new IntPtr(p + 0x230), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D97370 0x230 ChildElementNamespacesProperty ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.CollectionItemNameProperty                = GetObject<PropertyInfo>(new IntPtr(p + 0x238), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D97390 0x238 CollectionItemNameProperty  ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.ChildElementNamespaceProperty             = GetObject<PropertyInfo>(new IntPtr(p + 0x240), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D973B0 0x240 ChildElementNamespaceProperty ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.GetDateTimeOffsetMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x248), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D973D0 0x248 GetDateTimeOffsetMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetDateTimeOffsetAdapterMethod            = GetObject<MethodInfo>(new IntPtr(p + 0x250), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D973F0 0x250 GetDateTimeOffsetAdapterMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.TraceInstructionMethod                    = GetObject<MethodInfo>(new IntPtr(p + 0x258), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97410 0x258 TraceInstructionMethod      ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowInvalidDataContractExceptionMethod   = GetObject<MethodInfo>(new IntPtr(p + 0x260), ReversePrism.DataModels.MethodInfo.FromPointer); // 027004D97430 0x260 ThrowInvalidDataContractExceptionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SerializeReadOnlyTypesProperty            = GetObject<PropertyInfo>(new IntPtr(p + 0x268), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D97450 0x268 SerializeReadOnlyTypesProperty ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.ClassSerializationExceptionMessageProperty = GetObject<PropertyInfo>(new IntPtr(p + 0x270), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D97470 0x270 ClassSerializationExceptionMessageProperty ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.CollectionSerializationExceptionMessageProperty = GetObject<PropertyInfo>(new IntPtr(p + 0x278), ReversePrism.DataModels.PropertyInfo.FromPointer); // 027004D97490 0x278 CollectionSerializationExceptionMessageProperty ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
