using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<PhoneInfoStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPhoneUserIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstPhoneUserId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsUnreadFieldNumber                      int IL2CPP_TYPE_I4
    // 02C IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 030 _PostDate                                000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PhoneCallListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_phoneCallList_codec            FieldCodec`1<PhoneCallStatus> IL2CPP_TYPE_GENERICINST
    // 038 PhoneCallList                            000185CE8828 ModelClassListType RepeatedField`1<PhoneCallStatus> RepeatedField`1<PhoneCallStatus> List<PhoneCallStatus> Pointer
    public partial class PhoneInfoStatus
    {
        public DateTime                                 PostDate                                { get; set; }
        public int                                      MstPhoneUserId                          { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public Timestamp?                               _PostDate                               { get; set; }
        public List<PhoneCallStatus>?                   PhoneCallList                           { get; set; }

        public static PhoneInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhoneInfoStatus();

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0270D2311D10 0x10 PostDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstPhoneUserId                            = GetInt32(new IntPtr(p + 0x028)); // 0270D2311D90 0x28 MstPhoneUserId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x02C)); // 0270D2311DD0 0x2C IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2311E10 0x30 _PostDate                   ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PhoneCallList                             = GetObjectList<PhoneCallStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PhoneCallStatus.FromPointer); // 0270D2311E70 0x38 PhoneCallList               ( 000185CE8828 ModelClassListType RepeatedField`1<PhoneCallStatus> RepeatedField`1<PhoneCallStatus> List<PhoneCallStatus> Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);

            return value;
        }
    }
}
