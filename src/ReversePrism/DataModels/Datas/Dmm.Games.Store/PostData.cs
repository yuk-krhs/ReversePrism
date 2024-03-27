using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      0001866722E0 ModelPrimitiveType string string string String
    // 018 Value                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class PostData
    {
        public string                                   Key                                     { get; set; }
        public string                                   Value                                   { get; set; }

        public static PostData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostData();

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 0270DB4A3C68 0x10 Key                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0270DB4A3C88 0x18 Value                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
