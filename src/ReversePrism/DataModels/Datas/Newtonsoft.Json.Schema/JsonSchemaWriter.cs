using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Writer                                   000186764290 ModelClassType JsonWriter JsonWriter JsonWriter Pointer
    // 018 Resolver                                 00018675D250 ModelClassType JsonSchemaResolver JsonSchemaResolver JsonSchemaResolver Pointer
    public partial class JsonSchemaWriter : DataModel
    {
        public JsonWriter?                              Writer                                  { get; set; }
        public JsonSchemaResolver?                      Resolver                                { get; set; }

        public static JsonSchemaWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaWriter() { Pointer= p0 };

            value.Writer                                    = GetObject<JsonWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonWriter.FromPointer); // 024668831390 0x10 Writer                      ( 000186764290 ModelClassType JsonWriter JsonWriter JsonWriter Pointer )
            value.Resolver                                  = GetObject<JsonSchemaResolver>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonSchemaResolver.FromPointer); // 0246688313B0 0x18 Resolver                    ( 00018675D250 ModelClassType JsonSchemaResolver JsonSchemaResolver JsonSchemaResolver Pointer )

            return value;
        }
    }
}
