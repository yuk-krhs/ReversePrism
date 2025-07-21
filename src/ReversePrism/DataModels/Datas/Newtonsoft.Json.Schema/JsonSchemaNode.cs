using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 <Schemas>k__BackingField                 ReadOnlyCollection`1<JsonSchema> IL2CPP_TYPE_GENERICINST
    // 020 <Properties>k__BackingField              Dictionary`2<string, JsonSchemaNode> IL2CPP_TYPE_GENERICINST
    // 028 <PatternProperties>k__BackingField       Dictionary`2<string, JsonSchemaNode> IL2CPP_TYPE_GENERICINST
    // 030 Items                                    ModelClassListType List`1<JsonSchemaNode> List`1<JsonSchemaNode> List<JsonSchemaNode> Pointer
    // 038 AdditionalProperties                     ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer
    // 040 AdditionalItems                          ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer
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

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.Items                                     = GetObjectList<JsonSchemaNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonSchemaNode.FromPointer); // 0x30 Items                       ( ModelClassListType List`1<JsonSchemaNode> List`1<JsonSchemaNode> List<JsonSchemaNode> Pointer )
            value.AdditionalProperties                      = GetObject<JsonSchemaNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonSchemaNode.FromPointer); // 0x38 AdditionalProperties        ( ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer )
            value.AdditionalItems                           = GetObject<JsonSchemaNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.JsonSchemaNode.FromPointer); // 0x40 AdditionalItems             ( ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer )

            return value;
        }
    }
}
