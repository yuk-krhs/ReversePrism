using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 038 List                                     000185CEEC98 ModelClassListType List`1<JsonProperty> List`1<JsonProperty> List<JsonProperty> Pointer
    public partial class JsonPropertyCollection
    {
        public Type?                                    Type                                    { get; set; }
        public List<JsonProperty>?                      List                                    { get; set; }

        public static JsonPropertyCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonPropertyCollection();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 02700603A218 0x30 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.List                                      = GetObjectList<JsonProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonProperty.FromPointer); // 02700603A238 0x38 List                        ( 000185CEEC98 ModelClassListType List`1<JsonProperty> List`1<JsonProperty> List<JsonProperty> Pointer )

            return value;
        }
    }
}
