using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186672F10 ModelPrimitiveType string string string String
    // 018 <Schemas>k__BackingField                 ReadOnlyCollection`1<JsonSchema> IL2CPP_TYPE_GENERICINST
    // 020 <Properties>k__BackingField              Dictionary`2<string, JsonSchemaNode> IL2CPP_TYPE_GENERICINST
    // 028 <PatternProperties>k__BackingField       Dictionary`2<string, JsonSchemaNode> IL2CPP_TYPE_GENERICINST
    // 030 Items                                    000185CEEF78 ModelClassListType List`1<JsonSchemaNode> List`1<JsonSchemaNode> List<JsonSchemaNode> Pointer
    // 038 AdditionalProperties                     00018675C670 ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer
    // 040 AdditionalItems                          00018675C670 ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer
    public partial class JsonSchemaNode : DataModel
    {
        public string                                   Id                                      { get; set; }
        public List<JsonSchemaNode>?                    Items                                   { get; set; }
        public JsonSchemaNode?                          AdditionalProperties                    { get; set; }
        public JsonSchemaNode?                          AdditionalItems                         { get; set; }

        public static JsonSchemaNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaNode() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 024668817220 0x10 Id                          ( 000186672F10 ModelPrimitiveType string string string String )
            value.Items                                     = GetObjectList<JsonSchemaNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonSchemaNode.FromPointer); // 0246688172A0 0x30 Items                       ( 000185CEEF78 ModelClassListType List`1<JsonSchemaNode> List`1<JsonSchemaNode> List<JsonSchemaNode> Pointer )
            value.AdditionalProperties                      = GetObject<JsonSchemaNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonSchemaNode.FromPointer); // 0246688172C0 0x38 AdditionalProperties        ( 00018675C670 ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer )
            value.AdditionalItems                           = GetObject<JsonSchemaNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.JsonSchemaNode.FromPointer); // 0246688172E0 0x40 AdditionalItems             ( 00018675C670 ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer )

            return value;
        }
    }
}
