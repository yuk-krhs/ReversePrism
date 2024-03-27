using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 018 Schema                                   00018675AFB0 ModelClassType JsonSchema JsonSchema JsonSchema Pointer
    public partial class TypeSchema
    {
        public Type?                                    Type                                    { get; set; }
        public JsonSchema?                              Schema                                  { get; set; }

        public static TypeSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeSchema();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D8787ED8 0x10 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.Schema                                    = GetObject<JsonSchema>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonSchema.FromPointer); // 0270D8787EF8 0x18 Schema                      ( 00018675AFB0 ModelClassType JsonSchema JsonSchema JsonSchema Pointer )

            return value;
        }
    }
}
