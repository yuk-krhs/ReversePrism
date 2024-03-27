using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Str                                      000186672F10 ModelPrimitiveType string string string String
    // 018 marshaled_string                         <int> IL2CPP_TYPE_I
    public partial class SafeStringMarshal
    {
        public string                                   Str                                     { get; set; }

        public static SafeStringMarshal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeStringMarshal();

            value.Str                                       = GetString(new IntPtr(p + 0x010)); // 0270D6930318 0x10 Str                         ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
