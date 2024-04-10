using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastLoginDate                            000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<UserProfileStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 030 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 000 PlayerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 038 PlayerId                                 000186671910 ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 040 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 000 BirthdayFieldNumber                      int IL2CPP_TYPE_I4
    // 048 Birthday                                 000186671910 ModelPrimitiveType string string string String
    // 000 IsBirthdayPublicFieldNumber              int IL2CPP_TYPE_I4
    // 050 IsBirthdayPublic                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 FavoriteProduceIdolFieldNumber           int IL2CPP_TYPE_I4
    // 058 FavoriteProduceIdol                      000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 SupportCharacterFieldNumber              int IL2CPP_TYPE_I4
    // 060 SupportCharacter                         0001865ED2A0 ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 068 MstAchievementIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 FriendStateFieldNumber                   int IL2CPP_TYPE_I4
    // 070 FriendState                              0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32
    // 000 LastLoginDateFieldNumber                 int IL2CPP_TYPE_I4
    // 078 _LastLoginDate                           000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class UserProfileStatus : DataModel
    {
        public DateTime                                 LastLoginDate                           { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   PlayerId                                { get; set; }
        public string                                   Comment                                 { get; set; }
        public string                                   Birthday                                { get; set; }
        public bool                                     IsBirthdayPublic                        { get; set; }
        public ProduceIdolStatus?                       FavoriteProduceIdol                     { get; set; }
        public SupportCharacterStatus?                  SupportCharacter                        { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }
        public FriendState                              FriendState                             { get; set; }
        public Timestamp?                               _LastLoginDate                          { get; set; }

        public static UserProfileStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserProfileStatus() { Pointer= p0 };

            value.LastLoginDate                             = GetDateTime(new IntPtr(p + 0x010)); // 024662696D48 0x10 LastLoginDate               ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 024662696DC8 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x030)); // 024662696E08 0x30 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PlayerId                                  = GetString(new IntPtr(p + 0x038)); // 024662696E48 0x38 PlayerId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x040)); // 024662696E88 0x40 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x048)); // 024662696EC8 0x48 Birthday                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsBirthdayPublic                          = GetBool(new IntPtr(p + 0x050)); // 024662696F08 0x50 IsBirthdayPublic            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FavoriteProduceIdol                       = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 024662696F48 0x58 FavoriteProduceIdol         ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.SupportCharacter                          = GetObject<SupportCharacterStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 024662696F88 0x60 SupportCharacter            ( 0001865ED2A0 ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x068)); // 024662696FE8 0x68 MstAchievementIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x070)); // 024662697028 0x70 FriendState                 ( 0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32 )
            value._LastLoginDate                            = GetObject<Timestamp>(new IntPtr(p + 0x078), ReversePrism.DataModels.Timestamp.FromPointer); // 024662697068 0x78 _LastLoginDate              ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastLoginDate                 = ToDateTime(value._LastLoginDate);

            return value;
        }
    }
}
