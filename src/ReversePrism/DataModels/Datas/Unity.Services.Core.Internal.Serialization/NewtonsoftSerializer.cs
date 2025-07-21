using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Serializer                             ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer
    public partial class NewtonsoftSerializer : DataModel
    {
        public JsonSerializer?                          M_Serializer                            { get; set; }

        public static NewtonsoftSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NewtonsoftSerializer() { Pointer= p0 };

            value.M_Serializer                              = GetObject<JsonSerializer>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonSerializer.FromPointer); // 0x10 M_Serializer                ( ModelClassType JsonSerializer JsonSerializer JsonSerializer Pointer )

            return value;
        }
    }
}
