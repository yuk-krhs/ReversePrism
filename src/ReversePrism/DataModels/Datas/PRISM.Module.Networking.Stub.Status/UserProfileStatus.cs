using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastLoginDate                            ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<UserProfileStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Name                                     ModelPrimitiveType string string string String
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 030 DisplayName                              ModelPrimitiveType string string string String
    // 000 PlayerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 038 PlayerId                                 ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 040 Comment                                  ModelPrimitiveType string string string String
    // 000 BirthdayFieldNumber                      int IL2CPP_TYPE_I4
    // 048 Birthday                                 ModelPrimitiveType string string string String
    // 000 IsBirthdayPublicFieldNumber              int IL2CPP_TYPE_I4
    // 050 IsBirthdayPublic                         ModelPrimitiveType bool bool bool Bool
    // 000 FavoriteProduceIdolFieldNumber           int IL2CPP_TYPE_I4
    // 058 FavoriteProduceIdol                      ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 SupportCharacterFieldNumber              int IL2CPP_TYPE_I4
    // 060 SupportCharacter                         ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 068 MstAchievementIdList                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 FriendStateFieldNumber                   int IL2CPP_TYPE_I4
    // 070 FriendState                              ModelEnumType FriendState FriendState FriendState Int32
    // 000 LastLoginDateFieldNumber                 int IL2CPP_TYPE_I4
    // 078 _LastLoginDate                           ModelClassType Timestamp Timestamp Timestamp Pointer
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

            value.LastLoginDate                             = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastLoginDate               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x030)); // 0x30 DisplayName                 ( ModelPrimitiveType string string string String )
            value.PlayerId                                  = GetString(new IntPtr(p + 0x038)); // 0x38 PlayerId                    ( ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x040)); // 0x40 Comment                     ( ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x048)); // 0x48 Birthday                    ( ModelPrimitiveType string string string String )
            value.IsBirthdayPublic                          = GetBool(new IntPtr(p + 0x050)); // 0x50 IsBirthdayPublic            ( ModelPrimitiveType bool bool bool Bool )
            value.FavoriteProduceIdol                       = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0x58 FavoriteProduceIdol         ( ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.SupportCharacter                          = GetObject<SupportCharacterStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportCharacterStatus.FromPointer); // 0x60 SupportCharacter            ( ModelClassType SupportCharacterStatus SupportCharacterStatus SupportCharacterStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x068)); // 0x68 MstAchievementIdList        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x070)); // 0x70 FriendState                 ( ModelEnumType FriendState FriendState FriendState Int32 )
            value._LastLoginDate                            = GetObject<Timestamp>(new IntPtr(p + 0x078), ReversePrism.DataModels.Timestamp.FromPointer); // 0x78 _LastLoginDate              ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastLoginDate                 = ToDateTime(value._LastLoginDate);

            return value;
        }
    }
}
