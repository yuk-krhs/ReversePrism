using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Profile                                  00018668F730 ModelClassType IUserProfileStatus IUserProfileStatus IUserProfileStatus Pointer
    // 018 friendState                              ReactiveProperty`1<FriendState> IL2CPP_TYPE_GENERICINST
    // 020 UserId                                   000186672F10 ModelPrimitiveType string string string String
    // 028 CharacterInfo                            00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 AchievementIds                           000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 Birthday                                 000186672F10 ModelPrimitiveType string string string String
    // 040 SupportCharaIcon                         0001866AA140 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 048 TotalHighScoreRatingViewModel            0001866720C0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer
    // 050 TotalTechnicalRatingViewModel            0001866720C0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer
    // 058 UserProfileLiveClearList                 000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 060 UserProfileLiveFullComboList             000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 068 UserProfileLiveAllGreatList              000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 070 UserProfileLiveAllPerfectList            000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 078 UserProfileFesUnitRankList               000185D0F228 ModelClassListType IReadOnlyList`1<IUserProfileFesUnitRankStatus> IReadOnlyList`1<IUserProfileFesUnitRankStatus> List<IUserProfileFesUnitRankStatus> Pointer
    // 080 UserProfileProduceSenarioClearList       000185D0F888 ModelClassListType IReadOnlyList`1<IUserProfileProduceStatus> IReadOnlyList`1<IUserProfileProduceStatus> List<IUserProfileProduceStatus> Pointer
    // 088 <UserFesUnitRankViewModelList>k__BackingField IList`1<ProfileFriendUserFesUnitRankViewModel> IL2CPP_TYPE_GENERICINST
    public partial class ProfileFriendUserViewModel
    {
        public IUserProfileStatus?                      Profile                                 { get; set; }
        public string                                   UserId                                  { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }
        public List<int>?                               AchievementIds                          { get; set; }
        public string                                   Birthday                                { get; set; }
        public SCharaIcon?                              SupportCharaIcon                        { get; set; }
        public MusicRateViewModel?                      TotalHighScoreRatingViewModel           { get; set; }
        public MusicRateViewModel?                      TotalTechnicalRatingViewModel           { get; set; }
        public List<IUserProfileLiveStatus>?            UserProfileLiveClearList                { get; set; }
        public List<IUserProfileLiveStatus>?            UserProfileLiveFullComboList            { get; set; }
        public List<IUserProfileLiveStatus>?            UserProfileLiveAllGreatList             { get; set; }
        public List<IUserProfileLiveStatus>?            UserProfileLiveAllPerfectList           { get; set; }
        public List<IUserProfileFesUnitRankStatus>?     UserProfileFesUnitRankList              { get; set; }
        public List<IUserProfileProduceStatus>?         UserProfileProduceSenarioClearList      { get; set; }

        public static ProfileFriendUserViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserViewModel();

            value.Profile                                   = GetObject<IUserProfileStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUserProfileStatus.FromPointer); // 0270D6323DB0 0x10 Profile                     ( 00018668F730 ModelClassType IUserProfileStatus IUserProfileStatus IUserProfileStatus Pointer )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0270D6323DF0 0x20 UserId                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0270D6323E10 0x28 CharacterInfo               ( 00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.AchievementIds                            = GetInt32List(new IntPtr(p + 0x030)); // 0270D6323E30 0x30 AchievementIds              ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Birthday                                  = GetString(new IntPtr(p + 0x038)); // 0270D6323E50 0x38 Birthday                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.SupportCharaIcon                          = GetObject<SCharaIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0270D6323E70 0x40 SupportCharaIcon            ( 0001866AA140 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.TotalHighScoreRatingViewModel             = GetObject<MusicRateViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.MusicRateViewModel.FromPointer); // 0270D6323E90 0x48 TotalHighScoreRatingViewModel ( 0001866720C0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer )
            value.TotalTechnicalRatingViewModel             = GetObject<MusicRateViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.MusicRateViewModel.FromPointer); // 0270D6323EB0 0x50 TotalTechnicalRatingViewModel ( 0001866720C0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer )
            value.UserProfileLiveClearList                  = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0270D6323ED0 0x58 UserProfileLiveClearList    ( 000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.UserProfileLiveFullComboList              = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0270D6323EF0 0x60 UserProfileLiveFullComboList ( 000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.UserProfileLiveAllGreatList               = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0270D6323F10 0x68 UserProfileLiveAllGreatList ( 000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.UserProfileLiveAllPerfectList             = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0270D6323F30 0x70 UserProfileLiveAllPerfectList ( 000185D0F478 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.UserProfileFesUnitRankList                = GetObjectList<IUserProfileFesUnitRankStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IUserProfileFesUnitRankStatus.FromPointer); // 0270D6323F50 0x78 UserProfileFesUnitRankList  ( 000185D0F228 ModelClassListType IReadOnlyList`1<IUserProfileFesUnitRankStatus> IReadOnlyList`1<IUserProfileFesUnitRankStatus> List<IUserProfileFesUnitRankStatus> Pointer )
            value.UserProfileProduceSenarioClearList        = GetObjectList<IUserProfileProduceStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IUserProfileProduceStatus.FromPointer); // 0270D6323F70 0x80 UserProfileProduceSenarioClearList ( 000185D0F888 ModelClassListType IReadOnlyList`1<IUserProfileProduceStatus> IReadOnlyList`1<IUserProfileProduceStatus> List<IUserProfileProduceStatus> Pointer )

            return value;
        }
    }
}
