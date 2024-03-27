using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Reader                                   00018675A030 ModelClassType JsonReader JsonReader JsonReader Pointer
    // 080 _stack                                   Stack`1<SchemaScope> IL2CPP_TYPE_GENERICINST
    // 088 Schema                                   00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer
    // 090 Model                                    00018675BEF0 ModelClassType JsonSchemaModel JsonSchemaModel JsonSchemaModel Pointer
    // 098 CurrentScope                             000186672980 ModelClassType SchemaScope SchemaScope SchemaScope Pointer
    // 0A0 ValidationEventHandler                   000186765630 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 000 EmptySchemaList                          IList`1<JsonSchemaModel> IL2CPP_TYPE_GENERICINST
    public partial class JsonValidatingReader
    {
        public JsonReader?                              Reader                                  { get; set; }
        public JsonSchema?                              Schema                                  { get; set; }
        public JsonSchemaModel?                         Model                                   { get; set; }
        public SchemaScope?                             CurrentScope                            { get; set; }
        public ValidationEventHandler?                  ValidationEventHandler                  { get; set; }

        public static JsonValidatingReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonValidatingReader();

            value.Reader                                    = GetObject<JsonReader>(new IntPtr(p + 0x078), ReversePrism.DataModels.JsonReader.FromPointer); // 0270D86CD298 0x78 Reader                      ( 00018675A030 ModelClassType JsonReader JsonReader JsonReader Pointer )
            value.Schema                                    = GetObject<JsonSchema>(new IntPtr(p + 0x088), ReversePrism.DataModels.JsonSchema.FromPointer); // 0270D86CD2D8 0x88 Schema                      ( 00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer )
            value.Model                                     = GetObject<JsonSchemaModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.JsonSchemaModel.FromPointer); // 0270D86CD2F8 0x90 Model                       ( 00018675BEF0 ModelClassType JsonSchemaModel JsonSchemaModel JsonSchemaModel Pointer )
            value.CurrentScope                              = GetObject<SchemaScope>(new IntPtr(p + 0x098), ReversePrism.DataModels.SchemaScope.FromPointer); // 0270D86CD318 0x98 CurrentScope                ( 000186672980 ModelClassType SchemaScope SchemaScope SchemaScope Pointer )
            value.ValidationEventHandler                    = GetObject<ValidationEventHandler>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0270D86CD338 0xA0 ValidationEventHandler      ( 000186765630 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )

            return value;
        }
    }
}
