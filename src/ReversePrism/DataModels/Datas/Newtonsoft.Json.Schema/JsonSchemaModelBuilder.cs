using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Nodes                                    00018675CB30 ModelClassType JsonSchemaNodeCollection JsonSchemaNodeCollection JsonSchemaNodeCollection Pointer
    // 018 _nodeModels                              Dictionary`2<JsonSchemaNode, JsonSchemaModel> IL2CPP_TYPE_GENERICINST
    // 020 Node                                     00018675C670 ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer
    public partial class JsonSchemaModelBuilder
    {
        public JsonSchemaNodeCollection?                Nodes                                   { get; set; }
        public JsonSchemaNode?                          Node                                    { get; set; }

        public static JsonSchemaModelBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaModelBuilder();

            value.Nodes                                     = GetObject<JsonSchemaNodeCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonSchemaNodeCollection.FromPointer); // 0270D87B1B30 0x10 Nodes                       ( 00018675CB30 ModelClassType JsonSchemaNodeCollection JsonSchemaNodeCollection JsonSchemaNodeCollection Pointer )
            value.Node                                      = GetObject<JsonSchemaNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonSchemaNode.FromPointer); // 0270D87B1B70 0x20 Node                        ( 00018675C670 ModelClassType JsonSchemaNode JsonSchemaNode JsonSchemaNode Pointer )

            return value;
        }
    }
}
