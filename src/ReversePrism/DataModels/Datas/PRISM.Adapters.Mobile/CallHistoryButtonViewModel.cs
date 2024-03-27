using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PhoneCallId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 IsUnread                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 PostDate                                 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class CallHistoryButtonViewModel
    {
        public int                                      PhoneCallId                             { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public DateTime                                 PostDate                                { get; set; }

        public static CallHistoryButtonViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallHistoryButtonViewModel();

            value.PhoneCallId                               = GetInt32(new IntPtr(p + 0x010)); // 0270D6842750 0x10 PhoneCallId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x014)); // 0270D6842770 0x14 IsUnread                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x018)); // 0270D6842790 0x18 PostDate                    ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
