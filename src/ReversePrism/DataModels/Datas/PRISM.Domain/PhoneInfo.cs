using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstPhoneUserId                           ModelPrimitiveType int int int Int32
    // 014 IsUnread                                 ModelPrimitiveType bool bool bool Bool
    // 018 PostDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 PhoneCallList                            ModelClassListType IReadOnlyList`1<PhoneCall> IReadOnlyList`1<PhoneCall> List<PhoneCall> Pointer
    public partial class PhoneInfo : DataModel
    {
        public int                                      MstPhoneUserId                          { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public DateTime                                 PostDate                                { get; set; }
        public List<PhoneCall>?                         PhoneCallList                           { get; set; }

        public static PhoneInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhoneInfo() { Pointer= p0 };

            value.MstPhoneUserId                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstPhoneUserId              ( ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x014)); // 0x14 IsUnread                    ( ModelPrimitiveType bool bool bool Bool )
            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x018)); // 0x18 PostDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PhoneCallList                             = GetObjectList<PhoneCall>(new IntPtr(p + 0x028), ReversePrism.DataModels.PhoneCall.FromPointer); // 0x28 PhoneCallList               ( ModelClassListType IReadOnlyList`1<PhoneCall> IReadOnlyList`1<PhoneCall> List<PhoneCall> Pointer )

            return value;
        }
    }
}
