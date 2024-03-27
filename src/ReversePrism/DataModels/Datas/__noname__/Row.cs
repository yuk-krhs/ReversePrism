using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      000186671910 ModelPrimitiveType string string string String
    // 018 Value                                    000186671910 ModelPrimitiveType string string string String
    public partial class Row
    {
        public string                                   Key                                     { get; set; }
        public string                                   Value                                   { get; set; }

        public static Row? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Row();

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 027003D72C10 0x10 Key                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 027003D72C30 0x18 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
