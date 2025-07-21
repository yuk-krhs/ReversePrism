using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNullable                               ModelPrimitiveType bool bool bool Bool
    // 011 IsConvertable                            ModelPrimitiveType bool bool bool Bool
    // 012 IsEnum                                   ModelPrimitiveType bool bool bool Bool
    // 018 NonNullableUnderlyingType                ModelClassType Type Type Type Pointer
    // 020 InternalReadType                         ModelEnumType ReadType ReadType ReadType Int32
    // 024 ContractType                             ModelEnumType JsonContractType JsonContractType JsonContractType Int32
    // 028 IsReadOnlyOrFixedSize                    ModelPrimitiveType bool bool bool Bool
    // 029 IsSealed                                 ModelPrimitiveType bool bool bool Bool
    // 02A IsInstantiable                           ModelPrimitiveType bool bool bool Bool
    // 030 OnDeserializedCallbacks                  ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 038 OnDeserializingCallbacks                 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 040 OnSerializedCallbacks                    ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 048 OnSerializingCallbacks                   ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 050 OnErrorCallbacks                         ModelClassListType List`1<SerializationErrorCallback> List`1<SerializationErrorCallback> List<SerializationErrorCallback> Pointer
    // 058 CreatedType                              ModelClassType Type Type Type Pointer
    // 060 UnderlyingType                           ModelClassType Type Type Type Pointer
    // 068 <IsReference>k__BackingField             Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 Converter                                ModelClassType JsonConverter JsonConverter JsonConverter Pointer
    // 078 InternalConverter                        ModelClassType JsonConverter JsonConverter JsonConverter Pointer
    // 080 <DefaultCreator>k__BackingField          Func`1<<object>> IL2CPP_TYPE_GENERICINST
    // 088 DefaultCreatorNonPublic                  ModelPrimitiveType bool bool bool Bool
    public partial class JsonContract : DataModel
    {
        public bool                                     IsNullable                              { get; set; }
        public bool                                     IsConvertable                           { get; set; }
        public bool                                     IsEnum                                  { get; set; }
        public Type?                                    NonNullableUnderlyingType               { get; set; }
        public ReadType                                 InternalReadType                        { get; set; }
        public JsonContractType                         ContractType                            { get; set; }
        public bool                                     IsReadOnlyOrFixedSize                   { get; set; }
        public bool                                     IsSealed                                { get; set; }
        public bool                                     IsInstantiable                          { get; set; }
        public List<SerializationCallback>?             OnDeserializedCallbacks                 { get; set; }
        public List<SerializationCallback>?             OnDeserializingCallbacks                { get; set; }
        public List<SerializationCallback>?             OnSerializedCallbacks                   { get; set; }
        public List<SerializationCallback>?             OnSerializingCallbacks                  { get; set; }
        public List<SerializationErrorCallback>?        OnErrorCallbacks                        { get; set; }
        public Type?                                    CreatedType                             { get; set; }
        public Type?                                    UnderlyingType                          { get; set; }
        public JsonConverter?                           Converter                               { get; set; }
        public JsonConverter?                           InternalConverter                       { get; set; }
        public bool                                     DefaultCreatorNonPublic                 { get; set; }

        public static JsonContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonContract() { Pointer= p0 };

            value.IsNullable                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsNullable                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsConvertable                             = GetBool(new IntPtr(p + 0x011)); // 0x11 IsConvertable               ( ModelPrimitiveType bool bool bool Bool )
            value.IsEnum                                    = GetBool(new IntPtr(p + 0x012)); // 0x12 IsEnum                      ( ModelPrimitiveType bool bool bool Bool )
            value.NonNullableUnderlyingType                 = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 NonNullableUnderlyingType   ( ModelClassType Type Type Type Pointer )
            value.InternalReadType                          = (ReadType)GetInt32(new IntPtr(p + 0x020)); // 0x20 InternalReadType            ( ModelEnumType ReadType ReadType ReadType Int32 )
            value.ContractType                              = (JsonContractType)GetInt32(new IntPtr(p + 0x024)); // 0x24 ContractType                ( ModelEnumType JsonContractType JsonContractType JsonContractType Int32 )
            value.IsReadOnlyOrFixedSize                     = GetBool(new IntPtr(p + 0x028)); // 0x28 IsReadOnlyOrFixedSize       ( ModelPrimitiveType bool bool bool Bool )
            value.IsSealed                                  = GetBool(new IntPtr(p + 0x029)); // 0x29 IsSealed                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsInstantiable                            = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsInstantiable              ( ModelPrimitiveType bool bool bool Bool )
            value.OnDeserializedCallbacks                   = GetObjectList<SerializationCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.SerializationCallback.FromPointer); // 0x30 OnDeserializedCallbacks     ( ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnDeserializingCallbacks                  = GetObjectList<SerializationCallback>(new IntPtr(p + 0x038), ReversePrism.DataModels.SerializationCallback.FromPointer); // 0x38 OnDeserializingCallbacks    ( ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnSerializedCallbacks                     = GetObjectList<SerializationCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.SerializationCallback.FromPointer); // 0x40 OnSerializedCallbacks       ( ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnSerializingCallbacks                    = GetObjectList<SerializationCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.SerializationCallback.FromPointer); // 0x48 OnSerializingCallbacks      ( ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnErrorCallbacks                          = GetObjectList<SerializationErrorCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.SerializationErrorCallback.FromPointer); // 0x50 OnErrorCallbacks            ( ModelClassListType List`1<SerializationErrorCallback> List`1<SerializationErrorCallback> List<SerializationErrorCallback> Pointer )
            value.CreatedType                               = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 0x58 CreatedType                 ( ModelClassType Type Type Type Pointer )
            value.UnderlyingType                            = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0x60 UnderlyingType              ( ModelClassType Type Type Type Pointer )
            value.Converter                                 = GetObject<JsonConverter>(new IntPtr(p + 0x070), ReversePrism.DataModels.JsonConverter.FromPointer); // 0x70 Converter                   ( ModelClassType JsonConverter JsonConverter JsonConverter Pointer )
            value.InternalConverter                         = GetObject<JsonConverter>(new IntPtr(p + 0x078), ReversePrism.DataModels.JsonConverter.FromPointer); // 0x78 InternalConverter           ( ModelClassType JsonConverter JsonConverter JsonConverter Pointer )
            value.DefaultCreatorNonPublic                   = GetBool(new IntPtr(p + 0x088)); // 0x88 DefaultCreatorNonPublic     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
