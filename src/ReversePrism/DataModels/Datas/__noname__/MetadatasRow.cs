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
    public partial class MetadatasRow
    {
        public string                                   Key                                     { get; set; }
        public string                                   Value                                   { get; set; }

        public static MetadatasRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetadatasRow();

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 027003E01DC8 0x10 Key                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 027003E01DE8 0x18 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
