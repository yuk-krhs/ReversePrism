using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PhoneUserId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 IsUnread                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 PostDate                                 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class CallTopUserButtonCellViewModel : DataModel
    {
        public int                                      PhoneUserId                             { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public DateTime                                 PostDate                                { get; set; }

        public static CallTopUserButtonCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallTopUserButtonCellViewModel() { Pointer= p0 };

            value.PhoneUserId                               = GetInt32(new IntPtr(p + 0x010)); // 024666465080 0x10 PhoneUserId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x014)); // 0246664650A0 0x14 IsUnread                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x018)); // 0246664650C0 0x18 PostDate                    ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
