using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _stack                                   IList`1<JsonSchema> IL2CPP_TYPE_GENERICINST
    // 018 Resolver                                 ModelClassType JsonSchemaResolver JsonSchemaResolver JsonSchemaResolver Pointer
    // 020 _documentSchemas                         IDictionary`2<string, JsonSchema> IL2CPP_TYPE_GENERICINST
    // 028 CurrentSchema                            ModelClassType JsonSchema JsonSchema JsonSchema Pointer
    // 030 RootSchema                               ModelClassType JObject JObject JObject Pointer
    public partial class JsonSchemaBuilder : DataModel
    {
        public JsonSchemaResolver?                      Resolver                                { get; set; }
        public JsonSchema?                              CurrentSchema                           { get; set; }
        public JObject?                                 RootSchema                              { get; set; }

        public static JsonSchemaBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaBuilder() { Pointer= p0 };

            value.Resolver                                  = GetObject<JsonSchemaResolver>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonSchemaResolver.FromPointer); // 0x18 Resolver                    ( ModelClassType JsonSchemaResolver JsonSchemaResolver JsonSchemaResolver Pointer )
            value.CurrentSchema                             = GetObject<JsonSchema>(new IntPtr(p + 0x028), ReversePrism.DataModels.JsonSchema.FromPointer); // 0x28 CurrentSchema               ( ModelClassType JsonSchema JsonSchema JsonSchema Pointer )
            value.RootSchema                                = GetObject<JObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.JObject.FromPointer); // 0x30 RootSchema                  ( ModelClassType JObject JObject JObject Pointer )

            return value;
        }
    }
}
