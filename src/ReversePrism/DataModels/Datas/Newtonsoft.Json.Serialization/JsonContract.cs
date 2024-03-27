using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNullable                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 011 IsConvertable                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 012 IsEnum                                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 018 NonNullableUnderlyingType                000186692A80 ModelClassType Type Type Type Pointer
    // 020 InternalReadType                         00018661E800 ModelEnumType ReadType ReadType ReadType Int32
    // 024 ContractType                             0001867508E0 ModelEnumType JsonContractType JsonContractType JsonContractType Int32
    // 028 IsReadOnlyOrFixedSize                    000186595210 ModelPrimitiveType bool bool bool Bool
    // 029 IsSealed                                 000186595210 ModelPrimitiveType bool bool bool Bool
    // 02A IsInstantiable                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 030 OnDeserializedCallbacks                  000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 038 OnDeserializingCallbacks                 000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 040 OnSerializedCallbacks                    000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 048 OnSerializingCallbacks                   000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer
    // 050 OnErrorCallbacks                         000185D07E98 ModelClassListType List`1<SerializationErrorCallback> List`1<SerializationErrorCallback> List<SerializationErrorCallback> Pointer
    // 058 CreatedType                              000186692850 ModelClassType Type Type Type Pointer
    // 060 UnderlyingType                           0001866936B0 ModelClassType Type Type Type Pointer
    // 068 <IsReference>k__BackingField             Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 Converter                                0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer
    // 078 InternalConverter                        0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer
    // 080 <DefaultCreator>k__BackingField          Func`1<<object>> IL2CPP_TYPE_GENERICINST
    // 088 DefaultCreatorNonPublic                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonContract
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
            var value   = new JsonContract();

            value.IsNullable                                = GetBool(new IntPtr(p + 0x010)); // 027003B8C770 0x10 IsNullable                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsConvertable                             = GetBool(new IntPtr(p + 0x011)); // 027003B8C790 0x11 IsConvertable               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsEnum                                    = GetBool(new IntPtr(p + 0x012)); // 027003B8C7B0 0x12 IsEnum                      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NonNullableUnderlyingType                 = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 027003B8C7D0 0x18 NonNullableUnderlyingType   ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.InternalReadType                          = (ReadType)GetInt32(new IntPtr(p + 0x020)); // 027003B8C7F0 0x20 InternalReadType            ( 00018661E800 ModelEnumType ReadType ReadType ReadType Int32 )
            value.ContractType                              = (JsonContractType)GetInt32(new IntPtr(p + 0x024)); // 027003B8C810 0x24 ContractType                ( 0001867508E0 ModelEnumType JsonContractType JsonContractType JsonContractType Int32 )
            value.IsReadOnlyOrFixedSize                     = GetBool(new IntPtr(p + 0x028)); // 027003B8C830 0x28 IsReadOnlyOrFixedSize       ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsSealed                                  = GetBool(new IntPtr(p + 0x029)); // 027003B8C850 0x29 IsSealed                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsInstantiable                            = GetBool(new IntPtr(p + 0x02A)); // 027003B8C870 0x2A IsInstantiable              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.OnDeserializedCallbacks                   = GetObjectList<SerializationCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.SerializationCallback.FromPointer); // 027003B8C890 0x30 OnDeserializedCallbacks     ( 000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnDeserializingCallbacks                  = GetObjectList<SerializationCallback>(new IntPtr(p + 0x038), ReversePrism.DataModels.SerializationCallback.FromPointer); // 027003B8C8B0 0x38 OnDeserializingCallbacks    ( 000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnSerializedCallbacks                     = GetObjectList<SerializationCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.SerializationCallback.FromPointer); // 027003B8C8D0 0x40 OnSerializedCallbacks       ( 000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnSerializingCallbacks                    = GetObjectList<SerializationCallback>(new IntPtr(p + 0x048), ReversePrism.DataModels.SerializationCallback.FromPointer); // 027003B8C8F0 0x48 OnSerializingCallbacks      ( 000185D07BC8 ModelClassListType List`1<SerializationCallback> List`1<SerializationCallback> List<SerializationCallback> Pointer )
            value.OnErrorCallbacks                          = GetObjectList<SerializationErrorCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.SerializationErrorCallback.FromPointer); // 027003B8C910 0x50 OnErrorCallbacks            ( 000185D07E98 ModelClassListType List`1<SerializationErrorCallback> List`1<SerializationErrorCallback> List<SerializationErrorCallback> Pointer )
            value.CreatedType                               = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 027003B8C930 0x58 CreatedType                 ( 000186692850 ModelClassType Type Type Type Pointer )
            value.UnderlyingType                            = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 027003B8C950 0x60 UnderlyingType              ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.Converter                                 = GetObject<JsonConverter>(new IntPtr(p + 0x070), ReversePrism.DataModels.JsonConverter.FromPointer); // 027003B8C990 0x70 Converter                   ( 0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer )
            value.InternalConverter                         = GetObject<JsonConverter>(new IntPtr(p + 0x078), ReversePrism.DataModels.JsonConverter.FromPointer); // 027003B8C9B0 0x78 InternalConverter           ( 0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer )
            value.DefaultCreatorNonPublic                   = GetBool(new IntPtr(p + 0x088)); // 027003B8C9F0 0x88 DefaultCreatorNonPublic     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
