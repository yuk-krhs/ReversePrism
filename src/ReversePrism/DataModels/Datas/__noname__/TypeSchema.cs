using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 Schema                                   ModelClassType JsonSchema JsonSchema JsonSchema Pointer
    public partial class TypeSchema : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public JsonSchema?                              Schema                                  { get; set; }

        public static TypeSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeSchema() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.Schema                                    = GetObject<JsonSchema>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonSchema.FromPointer); // 0x18 Schema                      ( ModelClassType JsonSchema JsonSchema JsonSchema Pointer )

            return value;
        }
    }
}
