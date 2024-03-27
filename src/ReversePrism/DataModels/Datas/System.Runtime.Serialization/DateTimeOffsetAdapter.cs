using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UtcDateTime                              0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 OffsetMinutes                            0001865F1060 ModelPrimitiveType short short short Int16
    public partial class DateTimeOffsetAdapter
    {
        public DateTime                                 UtcDateTime                             { get; set; }
        public short                                    OffsetMinutes                           { get; set; }

        public static DateTimeOffsetAdapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeOffsetAdapter();

            value.UtcDateTime                               = GetDateTime(new IntPtr(p + 0x010)); // 027004D44898 0x10 UtcDateTime                 ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.OffsetMinutes                             = GetInt16(new IntPtr(p + 0x018)); // 027004D448B8 0x18 OffsetMinutes               ( 0001865F1060 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
