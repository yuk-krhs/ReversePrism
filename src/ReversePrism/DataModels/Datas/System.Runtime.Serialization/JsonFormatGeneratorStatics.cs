using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 boxPointer                               MethodInfo IL2CPP_TYPE_CLASS
    // 008 collectionItemNameProperty               PropertyInfo IL2CPP_TYPE_CLASS
    // 010 ExtensionDataObjectCtor                  00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 018 ExtensionDataProperty                    0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 020 GetItemContractMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 028 GetJsonDataContractMethod                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 GetJsonMemberIndexMethod                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 GetRevisedItemContractMethod             000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 040 GetUninitializedObjectMethod             000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 IenumeratorGetCurrentMethod              000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 050 IenumeratorMoveNextMethod                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 058 IsStartElementMethod0                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 IsStartElementMethod2                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 068 LocalNameProperty                        0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 070 NamespaceProperty                        0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 078 MoveToContentMethod                      000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 NodeTypeProperty                         0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 088 OnDeserializationMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 090 ReadJsonValueMethod                      000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 098 SerializationExceptionCtor               00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 0A0 SerInfoCtorArgs                          000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer
    // 0A8 ThrowDuplicateMemberExceptionMethod      000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0B0 ThrowMissingRequiredMembersMethod        000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0B8 TypeHandleProperty                       0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0C0 UnboxPointer                             000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C8 UseSimpleDictionaryFormatReadProperty    0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0D0 UseSimpleDictionaryFormatWriteProperty   0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0D8 WriteAttributeStringMethod               000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0E0 WriteEndElementMethod                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0E8 WriteJsonISerializableMethod             000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0F0 WriteJsonNameWithMappingMethod           000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0F8 WriteJsonValueMethod                     000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 100 WriteStartElementMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 108 WriteStartElementStringMethod            000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 110 ParseEnumMethod                          000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 118 GetJsonMemberNameMethod                  000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class JsonFormatGeneratorStatics
    {
        public ConstructorInfo?                         ExtensionDataObjectCtor                 { get; set; }
        public PropertyInfo?                            ExtensionDataProperty                   { get; set; }
        public MethodInfo?                              GetItemContractMethod                   { get; set; }
        public MethodInfo?                              GetJsonDataContractMethod               { get; set; }
        public MethodInfo?                              GetJsonMemberIndexMethod                { get; set; }
        public MethodInfo?                              GetRevisedItemContractMethod            { get; set; }
        public MethodInfo?                              GetUninitializedObjectMethod            { get; set; }
        public MethodInfo?                              IenumeratorGetCurrentMethod             { get; set; }
        public MethodInfo?                              IenumeratorMoveNextMethod               { get; set; }
        public MethodInfo?                              IsStartElementMethod0                   { get; set; }
        public MethodInfo?                              IsStartElementMethod2                   { get; set; }
        public PropertyInfo?                            LocalNameProperty                       { get; set; }
        public PropertyInfo?                            NamespaceProperty                       { get; set; }
        public MethodInfo?                              MoveToContentMethod                     { get; set; }
        public PropertyInfo?                            NodeTypeProperty                        { get; set; }
        public MethodInfo?                              OnDeserializationMethod                 { get; set; }
        public MethodInfo?                              ReadJsonValueMethod                     { get; set; }
        public ConstructorInfo?                         SerializationExceptionCtor              { get; set; }
        public List<Type>?                              SerInfoCtorArgs                         { get; set; }
        public MethodInfo?                              ThrowDuplicateMemberExceptionMethod     { get; set; }
        public MethodInfo?                              ThrowMissingRequiredMembersMethod       { get; set; }
        public PropertyInfo?                            TypeHandleProperty                      { get; set; }
        public MethodInfo?                              UnboxPointer                            { get; set; }
        public PropertyInfo?                            UseSimpleDictionaryFormatReadProperty   { get; set; }
        public PropertyInfo?                            UseSimpleDictionaryFormatWriteProperty  { get; set; }
        public MethodInfo?                              WriteAttributeStringMethod              { get; set; }
        public MethodInfo?                              WriteEndElementMethod                   { get; set; }
        public MethodInfo?                              WriteJsonISerializableMethod            { get; set; }
        public MethodInfo?                              WriteJsonNameWithMappingMethod          { get; set; }
        public MethodInfo?                              WriteJsonValueMethod                    { get; set; }
        public MethodInfo?                              WriteStartElementMethod                 { get; set; }
        public MethodInfo?                              WriteStartElementStringMethod           { get; set; }
        public MethodInfo?                              ParseEnumMethod                         { get; set; }
        public MethodInfo?                              GetJsonMemberNameMethod                 { get; set; }

        public static JsonFormatGeneratorStatics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatGeneratorStatics();

            value.ExtensionDataObjectCtor                   = GetObject<ConstructorInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0270D7D3E6D0 0x10 ExtensionDataObjectCtor     ( 00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.ExtensionDataProperty                     = GetObject<PropertyInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7D3E6F0 0x18 ExtensionDataProperty       ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.GetItemContractMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E710 0x20 GetItemContractMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetJsonDataContractMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E730 0x28 GetJsonDataContractMethod   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetJsonMemberIndexMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E750 0x30 GetJsonMemberIndexMethod    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetRevisedItemContractMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E770 0x38 GetRevisedItemContractMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetUninitializedObjectMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E790 0x40 GetUninitializedObjectMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IenumeratorGetCurrentMethod               = GetObject<MethodInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E7B0 0x48 IenumeratorGetCurrentMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IenumeratorMoveNextMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E7D0 0x50 IenumeratorMoveNextMethod   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IsStartElementMethod0                     = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E7F0 0x58 IsStartElementMethod0       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IsStartElementMethod2                     = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E810 0x60 IsStartElementMethod2       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.LocalNameProperty                         = GetObject<PropertyInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7D3E830 0x68 LocalNameProperty           ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.NamespaceProperty                         = GetObject<PropertyInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7D3E850 0x70 NamespaceProperty           ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.MoveToContentMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E870 0x78 MoveToContentMethod         ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.NodeTypeProperty                          = GetObject<PropertyInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7D3E890 0x80 NodeTypeProperty            ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.OnDeserializationMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E8B0 0x88 OnDeserializationMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReadJsonValueMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E8D0 0x90 ReadJsonValueMethod         ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SerializationExceptionCtor                = GetObject<ConstructorInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0270D7D3E8F0 0x98 SerializationExceptionCtor  ( 00018660FC30 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.SerInfoCtorArgs                           = GetObjectList<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 0270D7D3E910 0xA0 SerInfoCtorArgs             ( 000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.ThrowDuplicateMemberExceptionMethod       = GetObject<MethodInfo>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E930 0xA8 ThrowDuplicateMemberExceptionMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowMissingRequiredMembersMethod         = GetObject<MethodInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E950 0xB0 ThrowMissingRequiredMembersMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.TypeHandleProperty                        = GetObject<PropertyInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7D3E970 0xB8 TypeHandleProperty          ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.UnboxPointer                              = GetObject<MethodInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E990 0xC0 UnboxPointer                ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.UseSimpleDictionaryFormatReadProperty     = GetObject<PropertyInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7D3E9B0 0xC8 UseSimpleDictionaryFormatReadProperty ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.UseSimpleDictionaryFormatWriteProperty    = GetObject<PropertyInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7D3E9D0 0xD0 UseSimpleDictionaryFormatWriteProperty ( 0001865D4650 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.WriteAttributeStringMethod                = GetObject<MethodInfo>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3E9F0 0xD8 WriteAttributeStringMethod  ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteEndElementMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EA10 0xE0 WriteEndElementMethod       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteJsonISerializableMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EA30 0xE8 WriteJsonISerializableMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteJsonNameWithMappingMethod            = GetObject<MethodInfo>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EA50 0xF0 WriteJsonNameWithMappingMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteJsonValueMethod                      = GetObject<MethodInfo>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EA70 0xF8 WriteJsonValueMethod        ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteStartElementMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x100), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EA90 0x100 WriteStartElementMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteStartElementStringMethod             = GetObject<MethodInfo>(new IntPtr(p + 0x108), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EAB0 0x108 WriteStartElementStringMethod ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ParseEnumMethod                           = GetObject<MethodInfo>(new IntPtr(p + 0x110), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EAD0 0x110 ParseEnumMethod             ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetJsonMemberNameMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x118), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7D3EAF0 0x118 GetJsonMemberNameMethod     ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
