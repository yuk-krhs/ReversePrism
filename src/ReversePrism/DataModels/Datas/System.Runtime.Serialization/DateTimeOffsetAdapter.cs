using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UtcDateTime                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 OffsetMinutes                            ModelPrimitiveType short short short Int16
    public partial class DateTimeOffsetAdapter : DataModel
    {
        public DateTime                                 UtcDateTime                             { get; set; }
        public short                                    OffsetMinutes                           { get; set; }

        public static DateTimeOffsetAdapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeOffsetAdapter() { Pointer= p0 };

            value.UtcDateTime                               = GetDateTime(new IntPtr(p + 0x010)); // 0x10 UtcDateTime                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.OffsetMinutes                             = GetInt16(new IntPtr(p + 0x018)); // 0x18 OffsetMinutes               ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
