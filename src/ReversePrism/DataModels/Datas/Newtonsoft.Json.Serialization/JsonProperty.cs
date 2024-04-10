using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _required                                Nullable`1<Required> IL2CPP_TYPE_GENERICINST
    // 018 HasExplicitDefaultValue                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 020 _defaultValue                            <object> IL2CPP_TYPE_OBJECT
    // 028 HasGeneratedDefaultValue                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 PropertyName                             000186671910 ModelPrimitiveType string string string String
    // 038 SkipPropertyNameEscape                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 040 PropertyType                             000186692850 ModelClassType Type Type Type Pointer
    // 048 PropertyContract                         000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer
    // 050 DeclaringType                            000186692850 ModelClassType Type Type Type Pointer
    // 058 <Order>k__BackingField                   Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 060 UnderlyingName                           000186671910 ModelPrimitiveType string string string String
    // 068 ValueProvider                            000186691B10 ModelClassType IValueProvider IValueProvider IValueProvider Pointer
    // 070 AttributeProvider                        00018670B580 ModelClassType IAttributeProvider IAttributeProvider IAttributeProvider Pointer
    // 078 Converter                                0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer
    // 080 Ignored                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 081 Readable                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 082 Writable                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 083 HasMemberAttribute                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 084 <IsReference>k__BackingField             Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 088 <NullValueHandling>k__BackingField       Nullable`1<NullValueHandling> IL2CPP_TYPE_GENERICINST
    // 090 <DefaultValueHandling>k__BackingField    Nullable`1<DefaultValueHandling> IL2CPP_TYPE_GENERICINST
    // 098 <ReferenceLoopHandling>k__BackingField   Nullable`1<ReferenceLoopHandling> IL2CPP_TYPE_GENERICINST
    // 0A0 <ObjectCreationHandling>k__BackingField  Nullable`1<ObjectCreationHandling> IL2CPP_TYPE_GENERICINST
    // 0A8 <TypeNameHandling>k__BackingField        Nullable`1<TypeNameHandling> IL2CPP_TYPE_GENERICINST
    // 0B0 <ShouldSerialize>k__BackingField         Predicate`1<<object>> IL2CPP_TYPE_GENERICINST
    // 0B8 <ShouldDeserialize>k__BackingField       Predicate`1<<object>> IL2CPP_TYPE_GENERICINST
    // 0C0 <GetIsSpecified>k__BackingField          Predicate`1<<object>> IL2CPP_TYPE_GENERICINST
    // 0C8 <SetIsSpecified>k__BackingField          Action`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 0D0 ItemConverter                            0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer
    // 0D8 <ItemIsReference>k__BackingField         Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0DC <ItemTypeNameHandling>k__BackingField    Nullable`1<TypeNameHandling> IL2CPP_TYPE_GENERICINST
    // 0E4 <ItemReferenceLoopHandling>k__BackingField Nullable`1<ReferenceLoopHandling> IL2CPP_TYPE_GENERICINST
    public partial class JsonProperty : DataModel
    {
        public bool                                     HasExplicitDefaultValue                 { get; set; }
        public bool                                     HasGeneratedDefaultValue                { get; set; }
        public string                                   PropertyName                            { get; set; }
        public bool                                     SkipPropertyNameEscape                  { get; set; }
        public Type?                                    PropertyType                            { get; set; }
        public JsonContract?                            PropertyContract                        { get; set; }
        public Type?                                    DeclaringType                           { get; set; }
        public string                                   UnderlyingName                          { get; set; }
        public IValueProvider?                          ValueProvider                           { get; set; }
        public IAttributeProvider?                      AttributeProvider                       { get; set; }
        public JsonConverter?                           Converter                               { get; set; }
        public bool                                     Ignored                                 { get; set; }
        public bool                                     Readable                                { get; set; }
        public bool                                     Writable                                { get; set; }
        public bool                                     HasMemberAttribute                      { get; set; }
        public JsonConverter?                           ItemConverter                           { get; set; }

        public static JsonProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonProperty() { Pointer= p0 };

            value.HasExplicitDefaultValue                   = GetBool(new IntPtr(p + 0x018)); // 0245A6010CB0 0x18 HasExplicitDefaultValue     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HasGeneratedDefaultValue                  = GetBool(new IntPtr(p + 0x028)); // 0245A6010CF0 0x28 HasGeneratedDefaultValue    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PropertyName                              = GetString(new IntPtr(p + 0x030)); // 0245A6010D10 0x30 PropertyName                ( 000186671910 ModelPrimitiveType string string string String )
            value.SkipPropertyNameEscape                    = GetBool(new IntPtr(p + 0x038)); // 0245A6010D30 0x38 SkipPropertyNameEscape      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PropertyType                              = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0245A6010D50 0x40 PropertyType                ( 000186692850 ModelClassType Type Type Type Pointer )
            value.PropertyContract                          = GetObject<JsonContract>(new IntPtr(p + 0x048), ReversePrism.DataModels.JsonContract.FromPointer); // 0245A6010D70 0x48 PropertyContract            ( 000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer )
            value.DeclaringType                             = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0245A6010D90 0x50 DeclaringType               ( 000186692850 ModelClassType Type Type Type Pointer )
            value.UnderlyingName                            = GetString(new IntPtr(p + 0x060)); // 0245A6010DD0 0x60 UnderlyingName              ( 000186671910 ModelPrimitiveType string string string String )
            value.ValueProvider                             = GetObject<IValueProvider>(new IntPtr(p + 0x068), ReversePrism.DataModels.IValueProvider.FromPointer); // 0245A6010DF0 0x68 ValueProvider               ( 000186691B10 ModelClassType IValueProvider IValueProvider IValueProvider Pointer )
            value.AttributeProvider                         = GetObject<IAttributeProvider>(new IntPtr(p + 0x070), ReversePrism.DataModels.IAttributeProvider.FromPointer); // 0245A6010E10 0x70 AttributeProvider           ( 00018670B580 ModelClassType IAttributeProvider IAttributeProvider IAttributeProvider Pointer )
            value.Converter                                 = GetObject<JsonConverter>(new IntPtr(p + 0x078), ReversePrism.DataModels.JsonConverter.FromPointer); // 0245A6010E30 0x78 Converter                   ( 0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer )
            value.Ignored                                   = GetBool(new IntPtr(p + 0x080)); // 0245A6010E50 0x80 Ignored                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Readable                                  = GetBool(new IntPtr(p + 0x081)); // 0245A6010E70 0x81 Readable                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Writable                                  = GetBool(new IntPtr(p + 0x082)); // 0245A6010E90 0x82 Writable                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasMemberAttribute                        = GetBool(new IntPtr(p + 0x083)); // 0245A6010EB0 0x83 HasMemberAttribute          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ItemConverter                             = GetObject<JsonConverter>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.JsonConverter.FromPointer); // 0245A6011010 0xD0 ItemConverter               ( 0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer )

            return value;
        }
    }
}
