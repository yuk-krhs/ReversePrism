using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MinValue                                 DateTimeOffset IL2CPP_TYPE_VALUETYPE
    // 010 MaxValue                                 0001865BD420 ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32
    // 020 UnixEpoch                                0001865BD420 ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32
    // 010 DateTime                                 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 OffsetMinutes                            0001865F1780 ModelPrimitiveType short short short Int16
    public partial class DateTimeOffset
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
            var value   = new DateTimeOffset();

            value.MaxValue                                  = (DateTimeOffset)GetInt32(new IntPtr(p + 0x010)); // 027003C0E778 0x10 MaxValue                    ( 0001865BD420 ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32 )
            value.UnixEpoch                                 = (DateTimeOffset)GetInt32(new IntPtr(p + 0x020)); // 027003C0E798 0x20 UnixEpoch                   ( 0001865BD420 ModelEnumType DateTimeOffset DateTimeOffset DateTimeOffset Int32 )
            value.DateTime                                  = GetDateTime(new IntPtr(p + 0x010)); // 027003C0E7B8 0x10 DateTime                    ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.OffsetMinutes                             = GetInt16(new IntPtr(p + 0x018)); // 027003C0E7D8 0x18 OffsetMinutes               ( 0001865F1780 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
