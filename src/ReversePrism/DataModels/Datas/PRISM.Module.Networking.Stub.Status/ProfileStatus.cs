using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastLoginDate                            ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ProfileStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 028 UserId                                   ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Name                                     ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Comment                                  ModelPrimitiveType string string string String
    // 000 LastLoginDateFieldNumber                 int IL2CPP_TYPE_I4
    // 040 _LastLoginDate                           ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 048 MstAchievementIdList                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class ProfileStatus : DataModel
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
            var value   = new ProfileStatus() { Pointer= p0 };

            value.LastLoginDate                             = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastLoginDate               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.UserId                                    = GetString(new IntPtr(p + 0x028)); // 0x28 UserId                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Name                        ( ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x038)); // 0x38 Comment                     ( ModelPrimitiveType string string string String )
            value._LastLoginDate                            = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _LastLoginDate              ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x048)); // 0x48 MstAchievementIdList        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.LastLoginDate                 = ToDateTime(value._LastLoginDate);

            return value;
        }
    }
}
