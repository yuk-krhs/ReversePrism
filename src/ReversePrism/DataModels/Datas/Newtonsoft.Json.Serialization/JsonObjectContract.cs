using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 MemberSerialization                      ModelEnumType MemberSerialization MemberSerialization MemberSerialization Int32
    // 0C4 <MissingMemberHandling>k__BackingField   Nullable`1<MissingMemberHandling> IL2CPP_TYPE_GENERICINST
    // 0CC <ItemRequired>k__BackingField            Nullable`1<Required> IL2CPP_TYPE_GENERICINST
    // 0D4 <ItemNullValueHandling>k__BackingField   Nullable`1<NullValueHandling> IL2CPP_TYPE_GENERICINST
    // 0E0 Properties                               ModelClassType JsonPropertyCollection JsonPropertyCollection JsonPropertyCollection Pointer
    // 0E8 ExtensionDataSetter                      ModelClassType ExtensionDataSetter ExtensionDataSetter ExtensionDataSetter Pointer
    // 0F0 ExtensionDataGetter                      ModelClassType ExtensionDataGetter ExtensionDataGetter ExtensionDataGetter Pointer
    // 0F8 <ExtensionDataNameResolver>k__BackingField Func`2<string, string> IL2CPP_TYPE_GENERICINST
    // 100 ExtensionDataIsJToken                    ModelPrimitiveType bool bool bool Bool
    // 101 _hasRequiredOrDefaultValueProperties     Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 108 _overrideCreator                         ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 110 _parameterizedCreator                    ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 118 CreatorParameters                        ModelClassType JsonPropertyCollection JsonPropertyCollection JsonPropertyCollection Pointer
    // 120 ExtensionDataValueType                   ModelClassType Type Type Type Pointer
    public partial class JsonObjectContract : DataModel
    {
        public MemberSerialization                      MemberSerialization                     { get; set; }
        public JsonPropertyCollection?                  Properties                              { get; set; }
        public ExtensionDataSetter?                     ExtensionDataSetter                     { get; set; }
        public ExtensionDataGetter?                     ExtensionDataGetter                     { get; set; }
        public bool                                     ExtensionDataIsJToken                   { get; set; }
        public JsonPropertyCollection?                  CreatorParameters                       { get; set; }
        public Type?                                    ExtensionDataValueType                  { get; set; }

        public static JsonObjectContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonObjectContract() { Pointer= p0 };

            value.MemberSerialization                       = (MemberSerialization)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 MemberSerialization         ( ModelEnumType MemberSerialization MemberSerialization MemberSerialization Int32 )
            value.Properties                                = GetObject<JsonPropertyCollection>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.JsonPropertyCollection.FromPointer); // 0xE0 Properties                  ( ModelClassType JsonPropertyCollection JsonPropertyCollection JsonPropertyCollection Pointer )
            value.ExtensionDataSetter                       = GetObject<ExtensionDataSetter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ExtensionDataSetter.FromPointer); // 0xE8 ExtensionDataSetter         ( ModelClassType ExtensionDataSetter ExtensionDataSetter ExtensionDataSetter Pointer )
            value.ExtensionDataGetter                       = GetObject<ExtensionDataGetter>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ExtensionDataGetter.FromPointer); // 0xF0 ExtensionDataGetter         ( ModelClassType ExtensionDataGetter ExtensionDataGetter ExtensionDataGetter Pointer )
            value.ExtensionDataIsJToken                     = GetBool(new IntPtr(p + 0x100)); // 0x100 ExtensionDataIsJToken       ( ModelPrimitiveType bool bool bool Bool )
            value.CreatorParameters                         = GetObject<JsonPropertyCollection>(new IntPtr(p + 0x118), ReversePrism.DataModels.JsonPropertyCollection.FromPointer); // 0x118 CreatorParameters           ( ModelClassType JsonPropertyCollection JsonPropertyCollection JsonPropertyCollection Pointer )
            value.ExtensionDataValueType                    = GetObject<Type>(new IntPtr(p + 0x120), ReversePrism.DataModels.Type.FromPointer); // 0x120 ExtensionDataValueType      ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
