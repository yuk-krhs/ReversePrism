using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Required                                 ModelPrimitiveType bool bool bool Bool
    // 014 Type                                     ModelEnumType JsonSchemaType JsonSchemaType JsonSchemaType Int32
    // 018 <MinimumLength>k__BackingField           Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 020 <MaximumLength>k__BackingField           Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 028 <DivisibleBy>k__BackingField             Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 038 <Minimum>k__BackingField                 Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 048 <Maximum>k__BackingField                 Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 058 ExclusiveMinimum                         ModelPrimitiveType bool bool bool Bool
    // 059 ExclusiveMaximum                         ModelPrimitiveType bool bool bool Bool
    // 05C <MinimumItems>k__BackingField            Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 064 <MaximumItems>k__BackingField            Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 070 <Patterns>k__BackingField                IList`1<string> IL2CPP_TYPE_GENERICINST
    // 078 <Items>k__BackingField                   IList`1<JsonSchemaModel> IL2CPP_TYPE_GENERICINST
    // 080 <Properties>k__BackingField              IDictionary`2<string, JsonSchemaModel> IL2CPP_TYPE_GENERICINST
    // 088 <PatternProperties>k__BackingField       IDictionary`2<string, JsonSchemaModel> IL2CPP_TYPE_GENERICINST
    // 090 AdditionalProperties                     ModelClassType JsonSchemaModel JsonSchemaModel JsonSchemaModel Pointer
    // 098 AdditionalItems                          ModelClassType JsonSchemaModel JsonSchemaModel JsonSchemaModel Pointer
    // 0A0 PositionalItemsValidation                ModelPrimitiveType bool bool bool Bool
    // 0A1 AllowAdditionalProperties                ModelPrimitiveType bool bool bool Bool
    // 0A2 AllowAdditionalItems                     ModelPrimitiveType bool bool bool Bool
    // 0A3 UniqueItems                              ModelPrimitiveType bool bool bool Bool
    // 0A8 <Enum>k__BackingField                    IList`1<JToken> IL2CPP_TYPE_GENERICINST
    // 0B0 Disallow                                 ModelEnumType JsonSchemaType JsonSchemaType JsonSchemaType Int32
    public partial class JsonSchemaModel : DataModel
    {
        public bool                                     Required                                { get; set; }
        public JsonSchemaType                           Type                                    { get; set; }
        public bool                                     ExclusiveMinimum                        { get; set; }
        public bool                                     ExclusiveMaximum                        { get; set; }
        public JsonSchemaModel?                         AdditionalProperties                    { get; set; }
        public JsonSchemaModel?                         AdditionalItems                         { get; set; }
        public bool                                     PositionalItemsValidation               { get; set; }
        public bool                                     AllowAdditionalProperties               { get; set; }
        public bool                                     AllowAdditionalItems                    { get; set; }
        public bool                                     UniqueItems                             { get; set; }
        public JsonSchemaType                           Disallow                                { get; set; }

        public static JsonSchemaModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaModel() { Pointer= p0 };

            value.Required                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 Required                    ( ModelPrimitiveType bool bool bool Bool )
            value.Type                                      = (JsonSchemaType)GetInt32(new IntPtr(p + 0x014)); // 0x14 Type                        ( ModelEnumType JsonSchemaType JsonSchemaType JsonSchemaType Int32 )
            value.ExclusiveMinimum                          = GetBool(new IntPtr(p + 0x058)); // 0x58 ExclusiveMinimum            ( ModelPrimitiveType bool bool bool Bool )
            value.ExclusiveMaximum                          = GetBool(new IntPtr(p + 0x059)); // 0x59 ExclusiveMaximum            ( ModelPrimitiveType bool bool bool Bool )
            value.AdditionalProperties                      = GetObject<JsonSchemaModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.JsonSchemaModel.FromPointer); // 0x90 AdditionalProperties        ( ModelClassType JsonSchemaModel JsonSchemaModel JsonSchemaModel Pointer )
            value.AdditionalItems                           = GetObject<JsonSchemaModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.JsonSchemaModel.FromPointer); // 0x98 AdditionalItems             ( ModelClassType JsonSchemaModel JsonSchemaModel JsonSchemaModel Pointer )
            value.PositionalItemsValidation                 = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 PositionalItemsValidation   ( ModelPrimitiveType bool bool bool Bool )
            value.AllowAdditionalProperties                 = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 AllowAdditionalProperties   ( ModelPrimitiveType bool bool bool Bool )
            value.AllowAdditionalItems                      = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 AllowAdditionalItems        ( ModelPrimitiveType bool bool bool Bool )
            value.UniqueItems                               = GetBool(new IntPtr(p + 0x0A3)); // 0xA3 UniqueItems                 ( ModelPrimitiveType bool bool bool Bool )
            value.Disallow                                  = (JsonSchemaType)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Disallow                    ( ModelEnumType JsonSchemaType JsonSchemaType JsonSchemaType Int32 )

            return value;
        }
    }
}
