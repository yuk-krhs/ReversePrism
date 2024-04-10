using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstPhoneUserId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 PostDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 PhoneCallList                            000185D13EC8 ModelClassListType IReadOnlyList`1<PhoneCall> IReadOnlyList`1<PhoneCall> List<PhoneCall> Pointer
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

            value.MstPhoneUserId                            = GetInt32(new IntPtr(p + 0x010)); // 0245A4B51FB0 0x10 MstPhoneUserId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x014)); // 0245A4B51FD0 0x14 IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x018)); // 0245A4B51FF0 0x18 PostDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PhoneCallList                             = GetObjectList<PhoneCall>(new IntPtr(p + 0x028), ReversePrism.DataModels.PhoneCall.FromPointer); // 0245A4B52010 0x28 PhoneCallList               ( 000185D13EC8 ModelClassListType IReadOnlyList`1<PhoneCall> IReadOnlyList`1<PhoneCall> List<PhoneCall> Pointer )

            return value;
        }
    }
}
