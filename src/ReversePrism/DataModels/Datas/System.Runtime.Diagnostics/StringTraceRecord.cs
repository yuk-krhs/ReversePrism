using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 018 Content                                  000186671910 ModelPrimitiveType string string string String
    public partial class StringTraceRecord
    {
        public string                                   ElementName                             { get; set; }
        public string                                   Content                                 { get; set; }

        public static StringTraceRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringTraceRecord();

            value.ElementName                               = GetString(new IntPtr(p + 0x010)); // 027004C663E8 0x10 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Content                                   = GetString(new IntPtr(p + 0x018)); // 027004C66408 0x18 Content                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
