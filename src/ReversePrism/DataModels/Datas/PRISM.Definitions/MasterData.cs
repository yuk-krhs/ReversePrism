using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <CharacterInfos>k__BackingField          Dictionary`2<int, MstCharacterInfo> IL2CPP_TYPE_GENERICINST
    // 018 <Idols>k__BackingField                   Dictionary`2<int, MstIdol> IL2CPP_TYPE_GENERICINST
    // 020 <IdolStandingPositions>k__BackingField   Dictionary`2<int, MstIdolStandingPosition> IL2CPP_TYPE_GENERICINST
    // 028 <CostumeSets>k__BackingField             Dictionary`2<int, MstCostumeSet> IL2CPP_TYPE_GENERICINST
    // 030 <Costumes>k__BackingField                Dictionary`2<int, MstCostume> IL2CPP_TYPE_GENERICINST
    // 038 <CostumeResources>k__BackingField        Dictionary`2<int, MstCostumeResource> IL2CPP_TYPE_GENERICINST
    // 040 <Hairstyles>k__BackingField              Dictionary`2<int, MstHairstyle> IL2CPP_TYPE_GENERICINST
    // 048 <HairstyleResources>k__BackingField      Dictionary`2<ValueTuple`2<int, int>, MstHairstyleResource> IL2CPP_TYPE_GENERICINST
    // 050 <Accessories>k__BackingField             Dictionary`2<int, MstAccessory> IL2CPP_TYPE_GENERICINST
    // 058 <AccessoryResources>k__BackingField      Dictionary`2<int, MstAccessoryResource> IL2CPP_TYPE_GENERICINST
    // 060 FavoriteMarks                            000185B95630 ModelClassListType MstFavoriteMark[] MstFavoriteMark[] List<MstFavoriteMark> Pointer
    // 068 <ProductTypes>k__BackingField            Dictionary`2<int, MstProductType> IL2CPP_TYPE_GENERICINST
    // 070 <ProduceIdolLimitBreakRecipes>k__BackingField Dictionary`2<int, MstProduceIdolLimitBreakRecipe> IL2CPP_TYPE_GENERICINST
    // 078 <ProduceIdolEvolutionRecipes>k__BackingField Dictionary`2<int, MstProduceIdolEvolutionRecipe> IL2CPP_TYPE_GENERICINST
    // 080 <SupportCharacterLevelExps>k__BackingField Dictionary`2<int, MstSupportCharacterLevelExp> IL2CPP_TYPE_GENERICINST
    // 088 <SupportCharacterLimitBreakRecipes>k__BackingField Dictionary`2<int, MstSupportCharacterLimitBreakRecipe> IL2CPP_TYPE_GENERICINST
    // 090 <OutgameVoiceMotions>k__BackingField     Dictionary`2<int, MstOutgameVoiceMotion> IL2CPP_TYPE_GENERICINST
    // 098 <Units>k__BackingField                   Dictionary`2<int, MstUnit> IL2CPP_TYPE_GENERICINST
    // 0A0 ItemProviders                            000185B95F60 ModelClassListType MstItemProvider[] MstItemProvider[] List<MstItemProvider> Pointer
    // 0A8 <TrainingTickets>k__BackingField         Dictionary`2<int, MstTrainingTicket> IL2CPP_TYPE_GENERICINST
    // 0B0 ProduceActionEffectDisplays              000185B96540 ModelClassListType MstProduceActionEffectDisplay[] MstProduceActionEffectDisplay[] List<MstProduceActionEffectDisplay> Pointer
    // 0B8 <VoiceResources>k__BackingField          Dictionary`2<int, MstVoiceResource> IL2CPP_TYPE_GENERICINST
    // 0C0 <SupportEffects>k__BackingField          Dictionary`2<int, MstSupportEffect> IL2CPP_TYPE_GENERICINST
    // 0C8 <ProducePassiveEffects>k__BackingField   Dictionary`2<int, MstProducePassiveEffect> IL2CPP_TYPE_GENERICINST
    // 0D0 SupportCharacterLimitBreakBonuses        000185B97160 ModelClassListType MstSupportCharacterLimitBreakBonus[] MstSupportCharacterLimitBreakBonus[] List<MstSupportCharacterLimitBreakBonus> Pointer
    // 0D8 Tips                                     000185B97340 ModelClassListType MstTips[] MstTips[] List<MstTips> Pointer
    // 0E0 <TipsCategory>k__BackingField            Dictionary`2<int, MstTipsCategory> IL2CPP_TYPE_GENERICINST
    // 0E8 ExchangeProductFilters                   000185B95440 ModelClassListType MstExchangeProductFilter[] MstExchangeProductFilter[] List<MstExchangeProductFilter> Pointer
    // 0F0 PotentialLiveSkills                      000185B96350 ModelClassListType MstPotentialLiveSkill[] MstPotentialLiveSkill[] List<MstPotentialLiveSkill> Pointer
    // 0F8 <PotentialLiveSkillLevels>k__BackingField Dictionary`2<int, MstPotentialLiveSkillLevel> IL2CPP_TYPE_GENERICINST
    // 100 <LiveSkillEffects>k__BackingField        Dictionary`2<int, MstLiveSkillEffect> IL2CPP_TYPE_GENERICINST
    // 108 <ChainGroups>k__BackingField             Dictionary`2<int, MstChainGroup> IL2CPP_TYPE_GENERICINST
    // 110 <PhoneUsers>k__BackingField              Dictionary`2<int, MstPhoneUser> IL2CPP_TYPE_GENERICINST
    // 118 <PotentialSupportSkills>k__BackingField  Dictionary`2<int, MstPotentialSupportSkill> IL2CPP_TYPE_GENERICINST
    // 120 Helps                                    000185B95BE0 ModelClassListType MstHelp[] MstHelp[] List<MstHelp> Pointer
    // 128 BirthdayVoice                            000185B94CA0 ModelClassListType MstBirthdayVoice[] MstBirthdayVoice[] List<MstBirthdayVoice> Pointer
    // 130 HelpGroups                               000185B95DA0 ModelClassListType MstHelpGroup[] MstHelpGroup[] List<MstHelpGroup> Pointer
    // 138 <IdolStories>k__BackingField             Dictionary`2<int, MstIdolStory> IL2CPP_TYPE_GENERICINST
    // 140 TitleImages                              000185B97500 ModelClassListType MstTitleImage[] MstTitleImage[] List<MstTitleImage> Pointer
    // 148 <Songs>k__BackingField                   Dictionary`2<int, MstSong> IL2CPP_TYPE_GENERICINST
    // 150 <AdvInfos>k__BackingField                Dictionary`2<string, MstAdvInfo> IL2CPP_TYPE_GENERICINST
    // 158 <TwestaUsers>k__BackingField             Dictionary`2<int, MstTwestaUser> IL2CPP_TYPE_GENERICINST
    // 160 <ChainUsers>k__BackingField              Dictionary`2<int, MstChainUser> IL2CPP_TYPE_GENERICINST
    // 168 <BannerGenre>k__BackingField             Dictionary`2<int, MstBannerGenre> IL2CPP_TYPE_GENERICINST
    // 170 <Achievement>k__BackingField             Dictionary`2<int, MstAchievement> IL2CPP_TYPE_GENERICINST
    // 178 <EventIcon>k__BackingField               Dictionary`2<int, MstEventIcon> IL2CPP_TYPE_GENERICINST
    // 180 <LoginBonus>k__BackingField              Dictionary`2<int, MstLoginBonus> IL2CPP_TYPE_GENERICINST
    // 188 <LoginBonusGraffiti>k__BackingField      Dictionary`2<int, MstLoginBonusGraffiti> IL2CPP_TYPE_GENERICINST
    // 190 Episodes                                 000185B95260 ModelClassListType MstEpisode[] MstEpisode[] List<MstEpisode> Pointer
    // 198 ProduceCardContentGroups                 000185B966D0 ModelClassListType MstProduceCardContentGroup[] MstProduceCardContentGroup[] List<MstProduceCardContentGroup> Pointer
    // 1A0 <ProduceActionEffects>k__BackingField    Dictionary`2<int, MstProduceActionEffect> IL2CPP_TYPE_GENERICINST
    // 1A8 <Events>k__BackingField                  Dictionary`2<int, MstEvent> IL2CPP_TYPE_GENERICINST
    // 1B0 <ProduceIdols>k__BackingField            Dictionary`2<int, MstProduceIdol> IL2CPP_TYPE_GENERICINST
    // 1B8 <TwestaArticles>k__BackingField          Dictionary`2<int, MstTwestaArticle> IL2CPP_TYPE_GENERICINST
    // 1C0 <SupportCharacters>k__BackingField       Dictionary`2<int, MstSupportCharacter> IL2CPP_TYPE_GENERICINST
    // 1C8 GeneralItems                             000185B95A20 ModelClassListType MstGeneralItem[] MstGeneralItem[] List<MstGeneralItem> Pointer
    // 1D0 <RecoveryDrinks>k__BackingField          Dictionary`2<int, MstRecoveryDrink> IL2CPP_TYPE_GENERICINST
    // 1D8 <EpisodeEventMissionBanners>k__BackingField Dictionary`2<int, MstEpisodeEventMissionBanner> IL2CPP_TYPE_GENERICINST
    // 1E0 <MainStoryChapters>k__BackingField       Dictionary`2<int, MstMainStoryChapter> IL2CPP_TYPE_GENERICINST
    // 1E8 <MainStories>k__BackingField             Dictionary`2<int, MstMainStory> IL2CPP_TYPE_GENERICINST
    // 1F0 <ExtraStoryCategories>k__BackingField    Dictionary`2<int, MstExtraStoryCategory> IL2CPP_TYPE_GENERICINST
    // 1F8 <ExtraStorySubCategories>k__BackingField Dictionary`2<int, MstExtraStorySubCategory> IL2CPP_TYPE_GENERICINST
    // 200 <ExtraStories>k__BackingField            Dictionary`2<int, MstExtraStory> IL2CPP_TYPE_GENERICINST
    // 208 <EventStories>k__BackingField            Dictionary`2<int, MstEventStory> IL2CPP_TYPE_GENERICINST
    // 210 <ChallengeTourStages>k__BackingField     Dictionary`2<int, MstChallengeTourStage> IL2CPP_TYPE_GENERICINST
    // 218 <ChallengeTourMissions>k__BackingField   Dictionary`2<int, MstChallengeTourMission> IL2CPP_TYPE_GENERICINST
    // 220 <ChallengeTours>k__BackingField          Dictionary`2<int, MstChallengeTour> IL2CPP_TYPE_GENERICINST
    // 228 ChallengeTourRivals                      000185B94E80 ModelClassListType MstChallengeTourRival[] MstChallengeTourRival[] List<MstChallengeTourRival> Pointer
    // 230 <SeasonMissions>k__BackingField          Dictionary`2<int, MstSeasonMission> IL2CPP_TYPE_GENERICINST
    // 238 <GashaResources>k__BackingField          Dictionary`2<string, MstGashaResource> IL2CPP_TYPE_GENERICINST
    // 240 <PhoneCalls>k__BackingField              Dictionary`2<int, MstPhoneCall> IL2CPP_TYPE_GENERICINST
    // 248 <GashaTickets>k__BackingField            Dictionary`2<int, MstGashaTicket> IL2CPP_TYPE_GENERICINST
    // 250 <GashaCompensationTickets>k__BackingField Dictionary`2<int, MstGashaCompensationTicket> IL2CPP_TYPE_GENERICINST
    // 258 <GashaTokens>k__BackingField             Dictionary`2<int, MstGashaToken> IL2CPP_TYPE_GENERICINST
    // 260 <SelectionTickets>k__BackingField        Dictionary`2<int, MstSelectionTicket> IL2CPP_TYPE_GENERICINST
    // 268 <CostumeTickets>k__BackingField          Dictionary`2<int, MstCostumeTicket> IL2CPP_TYPE_GENERICINST
    // 270 ProduceStrategyTypes                     000185B968C0 ModelClassListType MstProduceStrategyType[] MstProduceStrategyType[] List<MstProduceStrategyType> Pointer
    // 278 <StreamPrograms>k__BackingField          Dictionary`2<int, MstStreamProgram> IL2CPP_TYPE_GENERICINST
    // 280 <StreamProgramCasts>k__BackingField      Dictionary`2<int, MstStreamProgramCast> IL2CPP_TYPE_GENERICINST
    // 288 <ChainTalkTexts>k__BackingField          Dictionary`2<int, MstChainTalkText> IL2CPP_TYPE_GENERICINST
    // 290 ProduceAuditionSettings                  000185B94AB0 ModelClassListType MstAuditionSettings[] MstAuditionSettings[] List<MstAuditionSettings> Pointer
    // 298 <SongTypes>k__BackingField               Dictionary`2<int, MstSongType> IL2CPP_TYPE_GENERICINST
    // 2A0 <DressUpRoomVoices>k__BackingField       Dictionary`2<int, MstDressUpRoomVoice> IL2CPP_TYPE_GENERICINST
    // 2A8 <LetterGroups>k__BackingField            Dictionary`2<int, MstLetterGroup> IL2CPP_TYPE_GENERICINST
    // 2B0 Letters                                  000185B96140 ModelClassListType MstLetter[] MstLetter[] List<MstLetter> Pointer
    // 2B8 GalleryEtcCategories                     000185B95820 ModelClassListType MstGalleryEtcCategory[] MstGalleryEtcCategory[] List<MstGalleryEtcCategory> Pointer
    // 2C0 <LiveEventBonuses>k__BackingField        Dictionary`2<int, MstLiveEventBonus> IL2CPP_TYPE_GENERICINST
    // 2C8 <SkillBufferDisplays>k__BackingField     Dictionary`2<int, MstSkillBufferDisplay> IL2CPP_TYPE_GENERICINST
    // 2D0 ShinyPartyTokens                         000185B96D90 ModelClassListType MstShinyPartyToken[] MstShinyPartyToken[] List<MstShinyPartyToken> Pointer
    // 2D8 <TwestaComments>k__BackingField          Dictionary`2<int, MstTwestaComment> IL2CPP_TYPE_GENERICINST
    // 2E0 PvpIngameSettings                        000185B96BB0 ModelClassListType MstPvpIngameSettings[] MstPvpIngameSettings[] List<MstPvpIngameSettings> Pointer
    // 2E8 <ChainTalks>k__BackingField              Dictionary`2<int, MstChainTalk> IL2CPP_TYPE_GENERICINST
    // 2F0 SubSeasonOpeningAdvOption                000185B96F70 ModelClassListType MstSubSeasonOpeningAdvOption[] MstSubSeasonOpeningAdvOption[] List<MstSubSeasonOpeningAdvOption> Pointer
    // 2F8 CostumeShopItems                         000185B95070 ModelClassListType MstCostumeShopItemGroup[] MstCostumeShopItemGroup[] List<MstCostumeShopItemGroup> Pointer
    // 300 Tutorials                                000185B977E0 ModelClassListType MstTutorial[] MstTutorial[] List<MstTutorial> Pointer
    // 308 FavoriteMarkIds                          000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MasterData : DataModel
    {
        public List<MstFavoriteMark>?                   FavoriteMarks                           { get; set; }
        public List<MstItemProvider>?                   ItemProviders                           { get; set; }
        public List<MstProduceActionEffectDisplay>?     ProduceActionEffectDisplays             { get; set; }
        public List<MstSupportCharacterLimitBreakBonus>? SupportCharacterLimitBreakBonuses       { get; set; }
        public List<MstTips>?                           Tips                                    { get; set; }
        public List<MstExchangeProductFilter>?          ExchangeProductFilters                  { get; set; }
        public List<MstPotentialLiveSkill>?             PotentialLiveSkills                     { get; set; }
        public List<MstHelp>?                           Helps                                   { get; set; }
        public List<MstBirthdayVoice>?                  BirthdayVoice                           { get; set; }
        public List<MstHelpGroup>?                      HelpGroups                              { get; set; }
        public List<MstTitleImage>?                     TitleImages                             { get; set; }
        public List<MstEpisode>?                        Episodes                                { get; set; }
        public List<MstProduceCardContentGroup>?        ProduceCardContentGroups                { get; set; }
        public List<MstGeneralItem>?                    GeneralItems                            { get; set; }
        public List<MstChallengeTourRival>?             ChallengeTourRivals                     { get; set; }
        public List<MstProduceStrategyType>?            ProduceStrategyTypes                    { get; set; }
        public List<MstAuditionSettings>?               ProduceAuditionSettings                 { get; set; }
        public List<MstLetter>?                         Letters                                 { get; set; }
        public List<MstGalleryEtcCategory>?             GalleryEtcCategories                    { get; set; }
        public List<MstShinyPartyToken>?                ShinyPartyTokens                        { get; set; }
        public List<MstPvpIngameSettings>?              PvpIngameSettings                       { get; set; }
        public List<MstSubSeasonOpeningAdvOption>?      SubSeasonOpeningAdvOption               { get; set; }
        public List<MstCostumeShopItemGroup>?           CostumeShopItems                        { get; set; }
        public List<MstTutorial>?                       Tutorials                               { get; set; }
        public List<int>?                               FavoriteMarkIds                         { get; set; }

        public static MasterData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterData() { Pointer= p0 };

            value.FavoriteMarks                             = GetObjectList<MstFavoriteMark>(new IntPtr(p + 0x060), ReversePrism.DataModels.MstFavoriteMark.FromPointer); // 0245A44C2E70 0x60 FavoriteMarks               ( 000185B95630 ModelClassListType MstFavoriteMark[] MstFavoriteMark[] List<MstFavoriteMark> Pointer )
            value.ItemProviders                             = GetObjectList<MstItemProvider>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MstItemProvider.FromPointer); // 0245A44C2F70 0xA0 ItemProviders               ( 000185B95F60 ModelClassListType MstItemProvider[] MstItemProvider[] List<MstItemProvider> Pointer )
            value.ProduceActionEffectDisplays               = GetObjectList<MstProduceActionEffectDisplay>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MstProduceActionEffectDisplay.FromPointer); // 0245A44C2FB0 0xB0 ProduceActionEffectDisplays ( 000185B96540 ModelClassListType MstProduceActionEffectDisplay[] MstProduceActionEffectDisplay[] List<MstProduceActionEffectDisplay> Pointer )
            value.SupportCharacterLimitBreakBonuses         = GetObjectList<MstSupportCharacterLimitBreakBonus>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MstSupportCharacterLimitBreakBonus.FromPointer); // 0245A44C3030 0xD0 SupportCharacterLimitBreakBonuses ( 000185B97160 ModelClassListType MstSupportCharacterLimitBreakBonus[] MstSupportCharacterLimitBreakBonus[] List<MstSupportCharacterLimitBreakBonus> Pointer )
            value.Tips                                      = GetObjectList<MstTips>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.MstTips.FromPointer); // 0245A44C3050 0xD8 Tips                        ( 000185B97340 ModelClassListType MstTips[] MstTips[] List<MstTips> Pointer )
            value.ExchangeProductFilters                    = GetObjectList<MstExchangeProductFilter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.MstExchangeProductFilter.FromPointer); // 0245A44C3090 0xE8 ExchangeProductFilters      ( 000185B95440 ModelClassListType MstExchangeProductFilter[] MstExchangeProductFilter[] List<MstExchangeProductFilter> Pointer )
            value.PotentialLiveSkills                       = GetObjectList<MstPotentialLiveSkill>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MstPotentialLiveSkill.FromPointer); // 0245A44C30B0 0xF0 PotentialLiveSkills         ( 000185B96350 ModelClassListType MstPotentialLiveSkill[] MstPotentialLiveSkill[] List<MstPotentialLiveSkill> Pointer )
            value.Helps                                     = GetObjectList<MstHelp>(new IntPtr(p + 0x120), ReversePrism.DataModels.MstHelp.FromPointer); // 0245A44C3170 0x120 Helps                       ( 000185B95BE0 ModelClassListType MstHelp[] MstHelp[] List<MstHelp> Pointer )
            value.BirthdayVoice                             = GetObjectList<MstBirthdayVoice>(new IntPtr(p + 0x128), ReversePrism.DataModels.MstBirthdayVoice.FromPointer); // 0245A44C3190 0x128 BirthdayVoice               ( 000185B94CA0 ModelClassListType MstBirthdayVoice[] MstBirthdayVoice[] List<MstBirthdayVoice> Pointer )
            value.HelpGroups                                = GetObjectList<MstHelpGroup>(new IntPtr(p + 0x130), ReversePrism.DataModels.MstHelpGroup.FromPointer); // 0245A44C31B0 0x130 HelpGroups                  ( 000185B95DA0 ModelClassListType MstHelpGroup[] MstHelpGroup[] List<MstHelpGroup> Pointer )
            value.TitleImages                               = GetObjectList<MstTitleImage>(new IntPtr(p + 0x140), ReversePrism.DataModels.MstTitleImage.FromPointer); // 0245A44C31F0 0x140 TitleImages                 ( 000185B97500 ModelClassListType MstTitleImage[] MstTitleImage[] List<MstTitleImage> Pointer )
            value.Episodes                                  = GetObjectList<MstEpisode>(new IntPtr(p + 0x190), ReversePrism.DataModels.MstEpisode.FromPointer); // 0245A44C3330 0x190 Episodes                    ( 000185B95260 ModelClassListType MstEpisode[] MstEpisode[] List<MstEpisode> Pointer )
            value.ProduceCardContentGroups                  = GetObjectList<MstProduceCardContentGroup>(new IntPtr(p + 0x198), ReversePrism.DataModels.MstProduceCardContentGroup.FromPointer); // 0245A44C3350 0x198 ProduceCardContentGroups    ( 000185B966D0 ModelClassListType MstProduceCardContentGroup[] MstProduceCardContentGroup[] List<MstProduceCardContentGroup> Pointer )
            value.GeneralItems                              = GetObjectList<MstGeneralItem>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.MstGeneralItem.FromPointer); // 0245A44C3410 0x1C8 GeneralItems                ( 000185B95A20 ModelClassListType MstGeneralItem[] MstGeneralItem[] List<MstGeneralItem> Pointer )
            value.ChallengeTourRivals                       = GetObjectList<MstChallengeTourRival>(new IntPtr(p + 0x228), ReversePrism.DataModels.MstChallengeTourRival.FromPointer); // 0245A44C3590 0x228 ChallengeTourRivals         ( 000185B94E80 ModelClassListType MstChallengeTourRival[] MstChallengeTourRival[] List<MstChallengeTourRival> Pointer )
            value.ProduceStrategyTypes                      = GetObjectList<MstProduceStrategyType>(new IntPtr(p + 0x270), ReversePrism.DataModels.MstProduceStrategyType.FromPointer); // 0245A44C36B0 0x270 ProduceStrategyTypes        ( 000185B968C0 ModelClassListType MstProduceStrategyType[] MstProduceStrategyType[] List<MstProduceStrategyType> Pointer )
            value.ProduceAuditionSettings                   = GetObjectList<MstAuditionSettings>(new IntPtr(p + 0x290), ReversePrism.DataModels.MstAuditionSettings.FromPointer); // 0245A44C3730 0x290 ProduceAuditionSettings     ( 000185B94AB0 ModelClassListType MstAuditionSettings[] MstAuditionSettings[] List<MstAuditionSettings> Pointer )
            value.Letters                                   = GetObjectList<MstLetter>(new IntPtr(p + 0x2B0), ReversePrism.DataModels.MstLetter.FromPointer); // 0245A44C37B0 0x2B0 Letters                     ( 000185B96140 ModelClassListType MstLetter[] MstLetter[] List<MstLetter> Pointer )
            value.GalleryEtcCategories                      = GetObjectList<MstGalleryEtcCategory>(new IntPtr(p + 0x2B8), ReversePrism.DataModels.MstGalleryEtcCategory.FromPointer); // 0245A44C37D0 0x2B8 GalleryEtcCategories        ( 000185B95820 ModelClassListType MstGalleryEtcCategory[] MstGalleryEtcCategory[] List<MstGalleryEtcCategory> Pointer )
            value.ShinyPartyTokens                          = GetObjectList<MstShinyPartyToken>(new IntPtr(p + 0x2D0), ReversePrism.DataModels.MstShinyPartyToken.FromPointer); // 0245A44C3830 0x2D0 ShinyPartyTokens            ( 000185B96D90 ModelClassListType MstShinyPartyToken[] MstShinyPartyToken[] List<MstShinyPartyToken> Pointer )
            value.PvpIngameSettings                         = GetObjectList<MstPvpIngameSettings>(new IntPtr(p + 0x2E0), ReversePrism.DataModels.MstPvpIngameSettings.FromPointer); // 0245A44C3870 0x2E0 PvpIngameSettings           ( 000185B96BB0 ModelClassListType MstPvpIngameSettings[] MstPvpIngameSettings[] List<MstPvpIngameSettings> Pointer )
            value.SubSeasonOpeningAdvOption                 = GetObjectList<MstSubSeasonOpeningAdvOption>(new IntPtr(p + 0x2F0), ReversePrism.DataModels.MstSubSeasonOpeningAdvOption.FromPointer); // 0245A44C38B0 0x2F0 SubSeasonOpeningAdvOption   ( 000185B96F70 ModelClassListType MstSubSeasonOpeningAdvOption[] MstSubSeasonOpeningAdvOption[] List<MstSubSeasonOpeningAdvOption> Pointer )
            value.CostumeShopItems                          = GetObjectList<MstCostumeShopItemGroup>(new IntPtr(p + 0x2F8), ReversePrism.DataModels.MstCostumeShopItemGroup.FromPointer); // 0245A44C38D0 0x2F8 CostumeShopItems            ( 000185B95070 ModelClassListType MstCostumeShopItemGroup[] MstCostumeShopItemGroup[] List<MstCostumeShopItemGroup> Pointer )
            value.Tutorials                                 = GetObjectList<MstTutorial>(new IntPtr(p + 0x300), ReversePrism.DataModels.MstTutorial.FromPointer); // 0245A44C38F0 0x300 Tutorials                   ( 000185B977E0 ModelClassListType MstTutorial[] MstTutorial[] List<MstTutorial> Pointer )
            value.FavoriteMarkIds                           = GetInt32List(new IntPtr(p + 0x308)); // 0245A44C3910 0x308 FavoriteMarkIds             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
