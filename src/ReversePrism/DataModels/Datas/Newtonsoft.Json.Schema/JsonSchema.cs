using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186671910 ModelPrimitiveType string string string String
    // 018 Title                                    000186671910 ModelPrimitiveType string string string String
    // 020 <Required>k__BackingField                Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 022 <ReadOnly>k__BackingField                Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 024 <Hidden>k__BackingField                  Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 026 <Transient>k__BackingField               Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    // 030 <Type>k__BackingField                    Nullable`1<JsonSchemaType> IL2CPP_TYPE_GENERICINST
    // 038 Pattern                                  000186671910 ModelPrimitiveType string string string String
    // 040 <MinimumLength>k__BackingField           Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 048 <MaximumLength>k__BackingField           Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 050 <DivisibleBy>k__BackingField             Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 060 <Minimum>k__BackingField                 Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 070 <Maximum>k__BackingField                 Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 080 <ExclusiveMinimum>k__BackingField        Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 082 <ExclusiveMaximum>k__BackingField        Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 084 <MinimumItems>k__BackingField            Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 08C <MaximumItems>k__BackingField            Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 098 <Items>k__BackingField                   IList`1<JsonSchema> IL2CPP_TYPE_GENERICINST
    // 0A0 PositionalItemsValidation                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 AdditionalItems                          00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer
    // 0B0 AllowAdditionalItems                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B1 UniqueItems                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B8 <Properties>k__BackingField              IDictionary`2<string, JsonSchema> IL2CPP_TYPE_GENERICINST
    // 0C0 AdditionalProperties                     00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer
    // 0C8 <PatternProperties>k__BackingField       IDictionary`2<string, JsonSchema> IL2CPP_TYPE_GENERICINST
    // 0D0 AllowAdditionalProperties                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 Requires                                 000186671910 ModelPrimitiveType string string string String
    // 0E0 <Enum>k__BackingField                    IList`1<JToken> IL2CPP_TYPE_GENERICINST
    // 0E8 <Disallow>k__BackingField                Nullable`1<JsonSchemaType> IL2CPP_TYPE_GENERICINST
    // 0F0 Default                                  0001865FFEA0 ModelClassType JToken JToken JToken Pointer
    // 0F8 <Extends>k__BackingField                 IList`1<JsonSchema> IL2CPP_TYPE_GENERICINST
    // 100 Format                                   000186671910 ModelPrimitiveType string string string String
    // 108 Location                                 000186671910 ModelPrimitiveType string string string String
    // 110 InternalId                               000186672F10 ModelPrimitiveType string string string String
    // 118 DeferredReference                        000186671910 ModelPrimitiveType string string string String
    // 120 ReferencesResolved                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonSchema : DataModel
    {
        public string                                   Id                                      { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   Pattern                                 { get; set; }
        public bool                                     PositionalItemsValidation               { get; set; }
        public JsonSchema?                              AdditionalItems                         { get; set; }
        public bool                                     AllowAdditionalItems                    { get; set; }
        public bool                                     UniqueItems                             { get; set; }
        public JsonSchema?                              AdditionalProperties                    { get; set; }
        public bool                                     AllowAdditionalProperties               { get; set; }
        public string                                   Requires                                { get; set; }
        public JToken?                                  Default                                 { get; set; }
        public string                                   Format                                  { get; set; }
        public string                                   Location                                { get; set; }
        public string                                   InternalId                              { get; set; }
        public string                                   DeferredReference                       { get; set; }
        public bool                                     ReferencesResolved                      { get; set; }

        public static JsonSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchema() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 02466873DF38 0x10 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 02466873DF58 0x18 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 02466873DFF8 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Pattern                                   = GetString(new IntPtr(p + 0x038)); // 02466873E038 0x38 Pattern                     ( 000186671910 ModelPrimitiveType string string string String )
            value.PositionalItemsValidation                 = GetBool(new IntPtr(p + 0x0A0)); // 02466873E198 0xA0 PositionalItemsValidation   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdditionalItems                           = GetObject<JsonSchema>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.JsonSchema.FromPointer); // 02466873E1B8 0xA8 AdditionalItems             ( 00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer )
            value.AllowAdditionalItems                      = GetBool(new IntPtr(p + 0x0B0)); // 02466873E1D8 0xB0 AllowAdditionalItems        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UniqueItems                               = GetBool(new IntPtr(p + 0x0B1)); // 02466873E1F8 0xB1 UniqueItems                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdditionalProperties                      = GetObject<JsonSchema>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.JsonSchema.FromPointer); // 02466873E238 0xC0 AdditionalProperties        ( 00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer )
            value.AllowAdditionalProperties                 = GetBool(new IntPtr(p + 0x0D0)); // 02466873E278 0xD0 AllowAdditionalProperties   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Requires                                  = GetString(new IntPtr(p + 0x0D8)); // 02466873E298 0xD8 Requires                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Default                                   = GetObject<JToken>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.JToken.FromPointer); // 02466873E2F8 0xF0 Default                     ( 0001865FFEA0 ModelClassType JToken JToken JToken Pointer )
            value.Format                                    = GetString(new IntPtr(p + 0x100)); // 02466873E338 0x100 Format                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Location                                  = GetString(new IntPtr(p + 0x108)); // 02466873E358 0x108 Location                    ( 000186671910 ModelPrimitiveType string string string String )
            value.InternalId                                = GetString(new IntPtr(p + 0x110)); // 02466873E378 0x110 InternalId                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.DeferredReference                         = GetString(new IntPtr(p + 0x118)); // 02466873E398 0x118 DeferredReference           ( 000186671910 ModelPrimitiveType string string string String )
            value.ReferencesResolved                        = GetBool(new IntPtr(p + 0x120)); // 02466873E3B8 0x120 ReferencesResolved          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
