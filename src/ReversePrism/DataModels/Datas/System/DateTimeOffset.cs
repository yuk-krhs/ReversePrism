using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MinValue                                 DateTimeOffset IL2CPP_TYPE_VALUETYPE
    // 010 MaxValue                                 ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32
    // 020 UnixEpoch                                ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32
    // 010 DateTime                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 OffsetMinutes                            ModelPrimitiveType short short short Int16
    public partial class DateTimeOffset : DataModel
    {
        public DateTimeOffset                           MaxValue                                { get; set; }
        public DateTimeOffset                           UnixEpoch                               { get; set; }
        public DateTime                                 DateTime                                { get; set; }
        public short                                    OffsetMinutes                           { get; set; }

        public static DateTimeOffset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeOffset() { Pointer= p0 };

            value.MaxValue                                  = (DateTimeOffset)GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxValue                    ( ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32 )
            value.UnixEpoch                                 = (DateTimeOffset)GetInt32(new IntPtr(p + 0x020)); // 0x20 UnixEpoch                   ( ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32 )
            value.DateTime                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 DateTime                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.OffsetMinutes                             = GetInt16(new IntPtr(p + 0x018)); // 0x18 OffsetMinutes               ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
