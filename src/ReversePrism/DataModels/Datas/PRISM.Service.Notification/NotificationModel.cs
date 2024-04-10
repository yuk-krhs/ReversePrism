using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    000186672F10 ModelPrimitiveType string string string String
    // 018 Message                                  000186672F10 ModelPrimitiveType string string string String
    // 020 Kind                                     000186514890 ModelEnumType Kind Kind Kind Int32
    // 028 NotificationTime                         000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class NotificationModel : DataModel
    {
        public string                                   Title                                   { get; set; }
        public string                                   Message                                 { get; set; }
        public Kind                                     Kind                                    { get; set; }
        public DateTime                                 NotificationTime                        { get; set; }

        public static NotificationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationModel() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 024663059880 0x10 Title                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0246630598A0 0x18 Message                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Kind                                      = (Kind)GetInt32(new IntPtr(p + 0x020)); // 0246630598C0 0x20 Kind                        ( 000186514890 ModelEnumType Kind Kind Kind Int32 )
            value.NotificationTime                          = GetDateTime(new IntPtr(p + 0x028)); // 0246630598E0 0x28 NotificationTime            ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
