using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastLoginDate                            000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ProfileStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 028 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 000 LastLoginDateFieldNumber                 int IL2CPP_TYPE_I4
    // 040 _LastLoginDate                           000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 048 MstAchievementIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class ProfileStatus
    {
        public DateTime                                 LastLoginDate                           { get; set; }
        public string                                   UserId                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Comment                                 { get; set; }
        public Timestamp?                               _LastLoginDate                          { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }

        public static ProfileStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileStatus();

            value.LastLoginDate                             = GetDateTime(new IntPtr(p + 0x010)); // 0270D0D38310 0x10 LastLoginDate               ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.UserId                                    = GetString(new IntPtr(p + 0x028)); // 0270D0D38390 0x28 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 0270D0D383D0 0x30 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x038)); // 0270D0D38410 0x38 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value._LastLoginDate                            = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0D38450 0x40 _LastLoginDate              ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x048)); // 0270D0D384B0 0x48 MstAchievementIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.LastLoginDate                 = ToDateTime(value._LastLoginDate);

            return value;
        }
    }
}
