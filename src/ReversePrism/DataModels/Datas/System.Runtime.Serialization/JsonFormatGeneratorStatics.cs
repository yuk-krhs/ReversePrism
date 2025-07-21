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
    // 010 ExtensionDataObjectCtor                  ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 018 ExtensionDataProperty                    ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 020 GetItemContractMethod                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 028 GetJsonDataContractMethod                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 GetJsonMemberIndexMethod                 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 GetRevisedItemContractMethod             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 040 GetUninitializedObjectMethod             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 IenumeratorGetCurrentMethod              ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 050 IenumeratorMoveNextMethod                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 058 IsStartElementMethod0                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 IsStartElementMethod2                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 068 LocalNameProperty                        ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 070 NamespaceProperty                        ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 078 MoveToContentMethod                      ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 NodeTypeProperty                         ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 088 OnDeserializationMethod                  ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 090 ReadJsonValueMethod                      ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 098 SerializationExceptionCtor               ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 0A0 SerInfoCtorArgs                          ModelClassListType Type[] Type[] List<Type> Pointer
    // 0A8 ThrowDuplicateMemberExceptionMethod      ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0B0 ThrowMissingRequiredMembersMethod        ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0B8 TypeHandleProperty                       ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0C0 UnboxPointer                             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C8 UseSimpleDictionaryFormatReadProperty    ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0D0 UseSimpleDictionaryFormatWriteProperty   ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0D8 WriteAttributeStringMethod               ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0E0 WriteEndElementMethod                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0E8 WriteJsonISerializableMethod             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0F0 WriteJsonNameWithMappingMethod           ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0F8 WriteJsonValueMethod                     ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 100 WriteStartElementMethod                  ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 108 WriteStartElementStringMethod            ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 110 ParseEnumMethod                          ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 118 GetJsonMemberNameMethod                  ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class JsonFormatGeneratorStatics : DataModel
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
            var value   = new JsonFormatGeneratorStatics() { Pointer= p0 };

            value.ExtensionDataObjectCtor                   = GetObject<ConstructorInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0x10 ExtensionDataObjectCtor     ( ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.ExtensionDataProperty                     = GetObject<PropertyInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0x18 ExtensionDataProperty       ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.GetItemContractMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x20 GetItemContractMethod       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetJsonDataContractMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x28 GetJsonDataContractMethod   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetJsonMemberIndexMethod                  = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x30 GetJsonMemberIndexMethod    ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetRevisedItemContractMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x38 GetRevisedItemContractMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetUninitializedObjectMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x40 GetUninitializedObjectMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IenumeratorGetCurrentMethod               = GetObject<MethodInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x48 IenumeratorGetCurrentMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IenumeratorMoveNextMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x50 IenumeratorMoveNextMethod   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IsStartElementMethod0                     = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x58 IsStartElementMethod0       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.IsStartElementMethod2                     = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x60 IsStartElementMethod2       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.LocalNameProperty                         = GetObject<PropertyInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0x68 LocalNameProperty           ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.NamespaceProperty                         = GetObject<PropertyInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0x70 NamespaceProperty           ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.MoveToContentMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x78 MoveToContentMethod         ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.NodeTypeProperty                          = GetObject<PropertyInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0x80 NodeTypeProperty            ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.OnDeserializationMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x88 OnDeserializationMethod     ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ReadJsonValueMethod                       = GetObject<MethodInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x90 ReadJsonValueMethod         ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SerializationExceptionCtor                = GetObject<ConstructorInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0x98 SerializationExceptionCtor  ( ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.SerInfoCtorArgs                           = GetObjectList<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 0xA0 SerInfoCtorArgs             ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.ThrowDuplicateMemberExceptionMethod       = GetObject<MethodInfo>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xA8 ThrowDuplicateMemberExceptionMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ThrowMissingRequiredMembersMethod         = GetObject<MethodInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xB0 ThrowMissingRequiredMembersMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.TypeHandleProperty                        = GetObject<PropertyInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xB8 TypeHandleProperty          ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.UnboxPointer                              = GetObject<MethodInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xC0 UnboxPointer                ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.UseSimpleDictionaryFormatReadProperty     = GetObject<PropertyInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xC8 UseSimpleDictionaryFormatReadProperty ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.UseSimpleDictionaryFormatWriteProperty    = GetObject<PropertyInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xD0 UseSimpleDictionaryFormatWriteProperty ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.WriteAttributeStringMethod                = GetObject<MethodInfo>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xD8 WriteAttributeStringMethod  ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteEndElementMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xE0 WriteEndElementMethod       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteJsonISerializableMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xE8 WriteJsonISerializableMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteJsonNameWithMappingMethod            = GetObject<MethodInfo>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xF0 WriteJsonNameWithMappingMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteJsonValueMethod                      = GetObject<MethodInfo>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xF8 WriteJsonValueMethod        ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteStartElementMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x100), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x100 WriteStartElementMethod     ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.WriteStartElementStringMethod             = GetObject<MethodInfo>(new IntPtr(p + 0x108), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x108 WriteStartElementStringMethod ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ParseEnumMethod                           = GetObject<MethodInfo>(new IntPtr(p + 0x110), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x110 ParseEnumMethod             ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.GetJsonMemberNameMethod                   = GetObject<MethodInfo>(new IntPtr(p + 0x118), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x118 GetJsonMemberNameMethod     ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
