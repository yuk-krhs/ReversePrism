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
    // 060 FavoriteMarks                            ModelClassListType MstFavoriteMark[] MstFavoriteMark[] List<MstFavoriteMark> Pointer
    // 068 <ProductTypes>k__BackingField            Dictionary`2<int, MstProductType> IL2CPP_TYPE_GENERICINST
    // 070 <ProduceIdolLimitBreakRecipes>k__BackingField Dictionary`2<int, MstProduceIdolLimitBreakRecipe> IL2CPP_TYPE_GENERICINST
    // 078 <ProduceIdolEvolutionRecipes>k__BackingField Dictionary`2<int, MstProduceIdolEvolutionRecipe> IL2CPP_TYPE_GENERICINST
    // 080 <SupportCharacterLevelExps>k__BackingField Dictionary`2<int, MstSupportCharacterLevelExp> IL2CPP_TYPE_GENERICINST
    // 088 <SupportCharacterLimitBreakRecipes>k__BackingField Dictionary`2<int, MstSupportCharacterLimitBreakRecipe> IL2CPP_TYPE_GENERICINST
    // 090 <OutgameVoiceMotions>k__BackingField     Dictionary`2<int, MstOutgameVoiceMotion> IL2CPP_TYPE_GENERICINST
    // 098 <Units>k__BackingField                   Dictionary`2<int, MstUnit> IL2CPP_TYPE_GENERICINST
    // 0A0 ItemProviders                            ModelClassListType MstItemProvider[] MstItemProvider[] List<MstItemProvider> Pointer
    // 0A8 <TrainingTickets>k__BackingField         Dictionary`2<int, MstTrainingTicket> IL2CPP_TYPE_GENERICINST
    // 0B0 ProduceActionEffectDisplays              ModelClassListType MstProduceActionEffectDisplay[] MstProduceActionEffectDisplay[] List<MstProduceActionEffectDisplay> Pointer
    // 0B8 <VoiceResources>k__BackingField          Dictionary`2<int, MstVoiceResource> IL2CPP_TYPE_GENERICINST
    // 0C0 <SupportEffects>k__BackingField          Dictionary`2<int, MstSupportEffect> IL2CPP_TYPE_GENERICINST
    // 0C8 <ProducePassiveEffects>k__BackingField   Dictionary`2<int, MstProducePassiveEffect> IL2CPP_TYPE_GENERICINST
    // 0D0 SupportCharacterLimitBreakBonuses        ModelClassListType MstSupportCharacterLimitBreakBonus[] MstSupportCharacterLimitBreakBonus[] List<MstSupportCharacterLimitBreakBonus> Pointer
    // 0D8 Tips                                     ModelClassListType MstTips[] MstTips[] List<MstTips> Pointer
    // 0E0 <TipsCategory>k__BackingField            Dictionary`2<int, MstTipsCategory> IL2CPP_TYPE_GENERICINST
    // 0E8 ExchangeProductFilters                   ModelClassListType MstExchangeProductFilter[] MstExchangeProductFilter[] List<MstExchangeProductFilter> Pointer
    // 0F0 PotentialLiveSkills                      ModelClassListType MstPotentialLiveSkill[] MstPotentialLiveSkill[] List<MstPotentialLiveSkill> Pointer
    // 0F8 <PotentialLiveSkillLevels>k__BackingField Dictionary`2<int, MstPotentialLiveSkillLevel> IL2CPP_TYPE_GENERICINST
    // 100 <LiveSkillEffects>k__BackingField        Dictionary`2<int, MstLiveSkillEffect> IL2CPP_TYPE_GENERICINST
    // 108 <ChainGroups>k__BackingField             Dictionary`2<int, MstChainGroup> IL2CPP_TYPE_GENERICINST
    // 110 <PhoneUsers>k__BackingField              Dictionary`2<int, MstPhoneUser> IL2CPP_TYPE_GENERICINST
    // 118 <PotentialSupportSkills>k__BackingField  Dictionary`2<int, MstPotentialSupportSkill> IL2CPP_TYPE_GENERICINST
    // 120 Helps                                    ModelClassListType MstHelp[] MstHelp[] List<MstHelp> Pointer
    // 128 BirthdayVoice                            ModelClassListType MstBirthdayVoice[] MstBirthdayVoice[] List<MstBirthdayVoice> Pointer
    // 130 HelpGroups                               ModelClassListType MstHelpGroup[] MstHelpGroup[] List<MstHelpGroup> Pointer
    // 138 <IdolStories>k__BackingField             Dictionary`2<int, MstIdolStory> IL2CPP_TYPE_GENERICINST
    // 140 <Songs>k__BackingField                   Dictionary`2<int, MstSong> IL2CPP_TYPE_GENERICINST
    // 148 <AdvInfos>k__BackingField                Dictionary`2<string, MstAdvInfo> IL2CPP_TYPE_GENERICINST
    // 150 <TwestaUsers>k__BackingField             Dictionary`2<int, MstTwestaUser> IL2CPP_TYPE_GENERICINST
    // 158 <ChainUsers>k__BackingField              Dictionary`2<int, MstChainUser> IL2CPP_TYPE_GENERICINST
    // 160 <BannerGenre>k__BackingField             Dictionary`2<int, MstBannerGenre> IL2CPP_TYPE_GENERICINST
    // 168 <Achievement>k__BackingField             Dictionary`2<int, MstAchievement> IL2CPP_TYPE_GENERICINST
    // 170 <EventIcon>k__BackingField               Dictionary`2<int, MstEventIcon> IL2CPP_TYPE_GENERICINST
    // 178 <LoginBonus>k__BackingField              Dictionary`2<int, MstLoginBonus> IL2CPP_TYPE_GENERICINST
    // 180 <LoginBonusGraffiti>k__BackingField      Dictionary`2<int, MstLoginBonusGraffiti> IL2CPP_TYPE_GENERICINST
    // 188 Episodes                                 ModelClassListType MstEpisode[] MstEpisode[] List<MstEpisode> Pointer
    // 190 ProduceCardContentGroups                 ModelClassListType MstProduceCardContentGroup[] MstProduceCardContentGroup[] List<MstProduceCardContentGroup> Pointer
    // 198 <ProduceActionEffects>k__BackingField    Dictionary`2<int, MstProduceActionEffect> IL2CPP_TYPE_GENERICINST
    // 1A0 <Events>k__BackingField                  Dictionary`2<int, MstEvent> IL2CPP_TYPE_GENERICINST
    // 1A8 <ProduceIdols>k__BackingField            Dictionary`2<int, MstProduceIdol> IL2CPP_TYPE_GENERICINST
    // 1B0 <TwestaArticles>k__BackingField          Dictionary`2<int, MstTwestaArticle> IL2CPP_TYPE_GENERICINST
    // 1B8 <SupportCharacters>k__BackingField       Dictionary`2<int, MstSupportCharacter> IL2CPP_TYPE_GENERICINST
    // 1C0 GeneralItems                             ModelClassListType MstGeneralItem[] MstGeneralItem[] List<MstGeneralItem> Pointer
    // 1C8 <RecoveryDrinks>k__BackingField          Dictionary`2<int, MstRecoveryDrink> IL2CPP_TYPE_GENERICINST
    // 1D0 <EpisodeEventMissionBanners>k__BackingField Dictionary`2<int, MstEpisodeEventMissionBanner> IL2CPP_TYPE_GENERICINST
    // 1D8 <MainStoryChapters>k__BackingField       Dictionary`2<int, MstMainStoryChapter> IL2CPP_TYPE_GENERICINST
    // 1E0 <MainStories>k__BackingField             Dictionary`2<int, MstMainStory> IL2CPP_TYPE_GENERICINST
    // 1E8 <ExtraStoryCategories>k__BackingField    Dictionary`2<int, MstExtraStoryCategory> IL2CPP_TYPE_GENERICINST
    // 1F0 <ExtraStorySubCategories>k__BackingField Dictionary`2<int, MstExtraStorySubCategory> IL2CPP_TYPE_GENERICINST
    // 1F8 <ExtraStories>k__BackingField            Dictionary`2<int, MstExtraStory> IL2CPP_TYPE_GENERICINST
    // 200 <EventStories>k__BackingField            Dictionary`2<int, MstEventStory> IL2CPP_TYPE_GENERICINST
    // 208 <ChallengeTourStages>k__BackingField     Dictionary`2<int, MstChallengeTourStage> IL2CPP_TYPE_GENERICINST
    // 210 <ChallengeTourMissions>k__BackingField   Dictionary`2<int, MstChallengeTourMission> IL2CPP_TYPE_GENERICINST
    // 218 <ChallengeTours>k__BackingField          Dictionary`2<int, MstChallengeTour> IL2CPP_TYPE_GENERICINST
    // 220 ChallengeTourRivals                      ModelClassListType MstChallengeTourRival[] MstChallengeTourRival[] List<MstChallengeTourRival> Pointer
    // 228 <SeasonMissions>k__BackingField          Dictionary`2<int, MstSeasonMission> IL2CPP_TYPE_GENERICINST
    // 230 <GashaResources>k__BackingField          Dictionary`2<string, MstGashaResource> IL2CPP_TYPE_GENERICINST
    // 238 <PhoneCalls>k__BackingField              Dictionary`2<int, MstPhoneCall> IL2CPP_TYPE_GENERICINST
    // 240 <GashaTickets>k__BackingField            Dictionary`2<int, MstGashaTicket> IL2CPP_TYPE_GENERICINST
    // 248 <GashaCompensationTickets>k__BackingField Dictionary`2<int, MstGashaCompensationTicket> IL2CPP_TYPE_GENERICINST
    // 250 <GashaTokens>k__BackingField             Dictionary`2<int, MstGashaToken> IL2CPP_TYPE_GENERICINST
    // 258 <SelectionTickets>k__BackingField        Dictionary`2<int, MstSelectionTicket> IL2CPP_TYPE_GENERICINST
    // 260 <CostumeTickets>k__BackingField          Dictionary`2<int, MstCostumeTicket> IL2CPP_TYPE_GENERICINST
    // 268 ProduceStrategyTypes                     ModelClassListType MstProduceStrategyType[] MstProduceStrategyType[] List<MstProduceStrategyType> Pointer
    // 270 <StreamPrograms>k__BackingField          Dictionary`2<int, MstStreamProgram> IL2CPP_TYPE_GENERICINST
    // 278 <StreamProgramCasts>k__BackingField      Dictionary`2<int, MstStreamProgramCast> IL2CPP_TYPE_GENERICINST
    // 280 <ChainTalkTexts>k__BackingField          Dictionary`2<int, MstChainTalkText> IL2CPP_TYPE_GENERICINST
    // 288 ProduceAuditionSettings                  ModelClassListType MstAuditionSettings[] MstAuditionSettings[] List<MstAuditionSettings> Pointer
    // 290 <SongTypes>k__BackingField               Dictionary`2<int, MstSongType> IL2CPP_TYPE_GENERICINST
    // 298 <DressUpRoomVoices>k__BackingField       Dictionary`2<int, MstDressUpRoomVoice> IL2CPP_TYPE_GENERICINST
    // 2A0 <LetterGroups>k__BackingField            Dictionary`2<int, MstLetterGroup> IL2CPP_TYPE_GENERICINST
    // 2A8 Letters                                  ModelClassListType MstLetter[] MstLetter[] List<MstLetter> Pointer
    // 2B0 GalleryEtcCategories                     ModelClassListType MstGalleryEtcCategory[] MstGalleryEtcCategory[] List<MstGalleryEtcCategory> Pointer
    // 2B8 <LiveEventBonuses>k__BackingField        Dictionary`2<int, MstLiveEventBonus> IL2CPP_TYPE_GENERICINST
    // 2C0 <SkillBufferDisplays>k__BackingField     Dictionary`2<int, MstSkillBufferDisplay> IL2CPP_TYPE_GENERICINST
    // 2C8 ShinyPartyTokens                         ModelClassListType MstShinyPartyToken[] MstShinyPartyToken[] List<MstShinyPartyToken> Pointer
    // 2D0 <TwestaComments>k__BackingField          Dictionary`2<int, MstTwestaComment> IL2CPP_TYPE_GENERICINST
    // 2D8 PvpIngameSettings                        ModelClassListType MstPvpIngameSettings[] MstPvpIngameSettings[] List<MstPvpIngameSettings> Pointer
    // 2E0 <ChainTalks>k__BackingField              Dictionary`2<int, MstChainTalk> IL2CPP_TYPE_GENERICINST
    // 2E8 SubSeasonOpeningAdvOption                ModelClassListType MstSubSeasonOpeningAdvOption[] MstSubSeasonOpeningAdvOption[] List<MstSubSeasonOpeningAdvOption> Pointer
    // 2F0 CostumeShopItems                         ModelClassListType MstCostumeShopItemGroup[] MstCostumeShopItemGroup[] List<MstCostumeShopItemGroup> Pointer
    // 2F8 Tutorials                                ModelClassListType MstTutorial[] MstTutorial[] List<MstTutorial> Pointer
    // 300 <MstEventAlbums>k__BackingField          Dictionary`2<int, MstEventAlbum> IL2CPP_TYPE_GENERICINST
    // 308 <MstEventRankings>k__BackingField        Dictionary`2<int, MstEventRanking> IL2CPP_TYPE_GENERICINST
    // 310 TitleBackgrounds                         ModelClassListType MstTitleBackground[] MstTitleBackground[] List<MstTitleBackground> Pointer
    // 318 ProducePromotionBanners                  ModelClassListType MstProducePromotionBanner[] MstProducePromotionBanner[] List<MstProducePromotionBanner> Pointer
    // 320 <MstMissionGroups>k__BackingField        Dictionary`2<int, MstMissionGroup> IL2CPP_TYPE_GENERICINST
    // 328 <SongDifficultyLevels>k__BackingField    Dictionary`2<ValueTuple`2<int, int>, MstSongDifficultyLevel> IL2CPP_TYPE_GENERICINST
    // 330 <LiveScoreRankTargets>k__BackingField    Dictionary`2<ValueTuple`2<int, int>, MstLiveScoreRankTarget> IL2CPP_TYPE_GENERICINST
    // 338 <LiveComboRankTargets>k__BackingField    Dictionary`2<ValueTuple`2<int, int>, MstLiveComboRankTarget> IL2CPP_TYPE_GENERICINST
    // 340 <LiveScoreRankRewards>k__BackingField    Dictionary`2<ValueTuple`2<int, int>, MstLiveScoreRankReward> IL2CPP_TYPE_GENERICINST
    // 348 <LiveComboRankRewards>k__BackingField    Dictionary`2<ValueTuple`2<int, int>, MstLiveComboRankReward> IL2CPP_TYPE_GENERICINST
    // 350 LiveTotalHighScoreRateRewards            ModelClassListType MstLiveTotalHighScoreRateReward[] MstLiveTotalHighScoreRateReward[] List<MstLiveTotalHighScoreRateReward> Pointer
    // 358 LiveTotalTechnicalRateRewards            ModelClassListType MstLiveTotalTechnicalRateReward[] MstLiveTotalTechnicalRateReward[] List<MstLiveTotalTechnicalRateReward> Pointer
    // 360 ScheduleTypeOrders                       ModelClassListType MstScheduleType[] MstScheduleType[] List<MstScheduleType> Pointer
    // 368 LiveCutScenes                            ModelClassListType MstLiveCutScene[] MstLiveCutScene[] List<MstLiveCutScene> Pointer
    // 370 LiveCutSceneCostumes                     ModelClassListType MstLiveCutSceneCostume[] MstLiveCutSceneCostume[] List<MstLiveCutSceneCostume> Pointer
    // 378 <DressOrderRecipes>k__BackingField       Dictionary`2<int, MstDressOrderRecipe> IL2CPP_TYPE_GENERICINST
    // 380 FavoriteMarkIds                          ModelPrimitiveListType int[] int[] List<int> Pointer
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
        public List<MstTitleBackground>?                TitleBackgrounds                        { get; set; }
        public List<MstProducePromotionBanner>?         ProducePromotionBanners                 { get; set; }
        public List<MstLiveTotalHighScoreRateReward>?   LiveTotalHighScoreRateRewards           { get; set; }
        public List<MstLiveTotalTechnicalRateReward>?   LiveTotalTechnicalRateRewards           { get; set; }
        public List<MstScheduleType>?                   ScheduleTypeOrders                      { get; set; }
        public List<MstLiveCutScene>?                   LiveCutScenes                           { get; set; }
        public List<MstLiveCutSceneCostume>?            LiveCutSceneCostumes                    { get; set; }
        public List<int>?                               FavoriteMarkIds                         { get; set; }

        public static MasterData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterData() { Pointer= p0 };

            value.FavoriteMarks                             = GetObjectList<MstFavoriteMark>(new IntPtr(p + 0x060), ReversePrism.DataModels.MstFavoriteMark.FromPointer); // 0x60 FavoriteMarks               ( ModelClassListType MstFavoriteMark[] MstFavoriteMark[] List<MstFavoriteMark> Pointer )
            value.ItemProviders                             = GetObjectList<MstItemProvider>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MstItemProvider.FromPointer); // 0xA0 ItemProviders               ( ModelClassListType MstItemProvider[] MstItemProvider[] List<MstItemProvider> Pointer )
            value.ProduceActionEffectDisplays               = GetObjectList<MstProduceActionEffectDisplay>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MstProduceActionEffectDisplay.FromPointer); // 0xB0 ProduceActionEffectDisplays ( ModelClassListType MstProduceActionEffectDisplay[] MstProduceActionEffectDisplay[] List<MstProduceActionEffectDisplay> Pointer )
            value.SupportCharacterLimitBreakBonuses         = GetObjectList<MstSupportCharacterLimitBreakBonus>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MstSupportCharacterLimitBreakBonus.FromPointer); // 0xD0 SupportCharacterLimitBreakBonuses ( ModelClassListType MstSupportCharacterLimitBreakBonus[] MstSupportCharacterLimitBreakBonus[] List<MstSupportCharacterLimitBreakBonus> Pointer )
            value.Tips                                      = GetObjectList<MstTips>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.MstTips.FromPointer); // 0xD8 Tips                        ( ModelClassListType MstTips[] MstTips[] List<MstTips> Pointer )
            value.ExchangeProductFilters                    = GetObjectList<MstExchangeProductFilter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.MstExchangeProductFilter.FromPointer); // 0xE8 ExchangeProductFilters      ( ModelClassListType MstExchangeProductFilter[] MstExchangeProductFilter[] List<MstExchangeProductFilter> Pointer )
            value.PotentialLiveSkills                       = GetObjectList<MstPotentialLiveSkill>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MstPotentialLiveSkill.FromPointer); // 0xF0 PotentialLiveSkills         ( ModelClassListType MstPotentialLiveSkill[] MstPotentialLiveSkill[] List<MstPotentialLiveSkill> Pointer )
            value.Helps                                     = GetObjectList<MstHelp>(new IntPtr(p + 0x120), ReversePrism.DataModels.MstHelp.FromPointer); // 0x120 Helps                       ( ModelClassListType MstHelp[] MstHelp[] List<MstHelp> Pointer )
            value.BirthdayVoice                             = GetObjectList<MstBirthdayVoice>(new IntPtr(p + 0x128), ReversePrism.DataModels.MstBirthdayVoice.FromPointer); // 0x128 BirthdayVoice               ( ModelClassListType MstBirthdayVoice[] MstBirthdayVoice[] List<MstBirthdayVoice> Pointer )
            value.HelpGroups                                = GetObjectList<MstHelpGroup>(new IntPtr(p + 0x130), ReversePrism.DataModels.MstHelpGroup.FromPointer); // 0x130 HelpGroups                  ( ModelClassListType MstHelpGroup[] MstHelpGroup[] List<MstHelpGroup> Pointer )
            value.Episodes                                  = GetObjectList<MstEpisode>(new IntPtr(p + 0x188), ReversePrism.DataModels.MstEpisode.FromPointer); // 0x188 Episodes                    ( ModelClassListType MstEpisode[] MstEpisode[] List<MstEpisode> Pointer )
            value.ProduceCardContentGroups                  = GetObjectList<MstProduceCardContentGroup>(new IntPtr(p + 0x190), ReversePrism.DataModels.MstProduceCardContentGroup.FromPointer); // 0x190 ProduceCardContentGroups    ( ModelClassListType MstProduceCardContentGroup[] MstProduceCardContentGroup[] List<MstProduceCardContentGroup> Pointer )
            value.GeneralItems                              = GetObjectList<MstGeneralItem>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.MstGeneralItem.FromPointer); // 0x1C0 GeneralItems                ( ModelClassListType MstGeneralItem[] MstGeneralItem[] List<MstGeneralItem> Pointer )
            value.ChallengeTourRivals                       = GetObjectList<MstChallengeTourRival>(new IntPtr(p + 0x220), ReversePrism.DataModels.MstChallengeTourRival.FromPointer); // 0x220 ChallengeTourRivals         ( ModelClassListType MstChallengeTourRival[] MstChallengeTourRival[] List<MstChallengeTourRival> Pointer )
            value.ProduceStrategyTypes                      = GetObjectList<MstProduceStrategyType>(new IntPtr(p + 0x268), ReversePrism.DataModels.MstProduceStrategyType.FromPointer); // 0x268 ProduceStrategyTypes        ( ModelClassListType MstProduceStrategyType[] MstProduceStrategyType[] List<MstProduceStrategyType> Pointer )
            value.ProduceAuditionSettings                   = GetObjectList<MstAuditionSettings>(new IntPtr(p + 0x288), ReversePrism.DataModels.MstAuditionSettings.FromPointer); // 0x288 ProduceAuditionSettings     ( ModelClassListType MstAuditionSettings[] MstAuditionSettings[] List<MstAuditionSettings> Pointer )
            value.Letters                                   = GetObjectList<MstLetter>(new IntPtr(p + 0x2A8), ReversePrism.DataModels.MstLetter.FromPointer); // 0x2A8 Letters                     ( ModelClassListType MstLetter[] MstLetter[] List<MstLetter> Pointer )
            value.GalleryEtcCategories                      = GetObjectList<MstGalleryEtcCategory>(new IntPtr(p + 0x2B0), ReversePrism.DataModels.MstGalleryEtcCategory.FromPointer); // 0x2B0 GalleryEtcCategories        ( ModelClassListType MstGalleryEtcCategory[] MstGalleryEtcCategory[] List<MstGalleryEtcCategory> Pointer )
            value.ShinyPartyTokens                          = GetObjectList<MstShinyPartyToken>(new IntPtr(p + 0x2C8), ReversePrism.DataModels.MstShinyPartyToken.FromPointer); // 0x2C8 ShinyPartyTokens            ( ModelClassListType MstShinyPartyToken[] MstShinyPartyToken[] List<MstShinyPartyToken> Pointer )
            value.PvpIngameSettings                         = GetObjectList<MstPvpIngameSettings>(new IntPtr(p + 0x2D8), ReversePrism.DataModels.MstPvpIngameSettings.FromPointer); // 0x2D8 PvpIngameSettings           ( ModelClassListType MstPvpIngameSettings[] MstPvpIngameSettings[] List<MstPvpIngameSettings> Pointer )
            value.SubSeasonOpeningAdvOption                 = GetObjectList<MstSubSeasonOpeningAdvOption>(new IntPtr(p + 0x2E8), ReversePrism.DataModels.MstSubSeasonOpeningAdvOption.FromPointer); // 0x2E8 SubSeasonOpeningAdvOption   ( ModelClassListType MstSubSeasonOpeningAdvOption[] MstSubSeasonOpeningAdvOption[] List<MstSubSeasonOpeningAdvOption> Pointer )
            value.CostumeShopItems                          = GetObjectList<MstCostumeShopItemGroup>(new IntPtr(p + 0x2F0), ReversePrism.DataModels.MstCostumeShopItemGroup.FromPointer); // 0x2F0 CostumeShopItems            ( ModelClassListType MstCostumeShopItemGroup[] MstCostumeShopItemGroup[] List<MstCostumeShopItemGroup> Pointer )
            value.Tutorials                                 = GetObjectList<MstTutorial>(new IntPtr(p + 0x2F8), ReversePrism.DataModels.MstTutorial.FromPointer); // 0x2F8 Tutorials                   ( ModelClassListType MstTutorial[] MstTutorial[] List<MstTutorial> Pointer )
            value.TitleBackgrounds                          = GetObjectList<MstTitleBackground>(new IntPtr(p + 0x310), ReversePrism.DataModels.MstTitleBackground.FromPointer); // 0x310 TitleBackgrounds            ( ModelClassListType MstTitleBackground[] MstTitleBackground[] List<MstTitleBackground> Pointer )
            value.ProducePromotionBanners                   = GetObjectList<MstProducePromotionBanner>(new IntPtr(p + 0x318), ReversePrism.DataModels.MstProducePromotionBanner.FromPointer); // 0x318 ProducePromotionBanners     ( ModelClassListType MstProducePromotionBanner[] MstProducePromotionBanner[] List<MstProducePromotionBanner> Pointer )
            value.LiveTotalHighScoreRateRewards             = GetObjectList<MstLiveTotalHighScoreRateReward>(new IntPtr(p + 0x350), ReversePrism.DataModels.MstLiveTotalHighScoreRateReward.FromPointer); // 0x350 LiveTotalHighScoreRateRewards ( ModelClassListType MstLiveTotalHighScoreRateReward[] MstLiveTotalHighScoreRateReward[] List<MstLiveTotalHighScoreRateReward> Pointer )
            value.LiveTotalTechnicalRateRewards             = GetObjectList<MstLiveTotalTechnicalRateReward>(new IntPtr(p + 0x358), ReversePrism.DataModels.MstLiveTotalTechnicalRateReward.FromPointer); // 0x358 LiveTotalTechnicalRateRewards ( ModelClassListType MstLiveTotalTechnicalRateReward[] MstLiveTotalTechnicalRateReward[] List<MstLiveTotalTechnicalRateReward> Pointer )
            value.ScheduleTypeOrders                        = GetObjectList<MstScheduleType>(new IntPtr(p + 0x360), ReversePrism.DataModels.MstScheduleType.FromPointer); // 0x360 ScheduleTypeOrders          ( ModelClassListType MstScheduleType[] MstScheduleType[] List<MstScheduleType> Pointer )
            value.LiveCutScenes                             = GetObjectList<MstLiveCutScene>(new IntPtr(p + 0x368), ReversePrism.DataModels.MstLiveCutScene.FromPointer); // 0x368 LiveCutScenes               ( ModelClassListType MstLiveCutScene[] MstLiveCutScene[] List<MstLiveCutScene> Pointer )
            value.LiveCutSceneCostumes                      = GetObjectList<MstLiveCutSceneCostume>(new IntPtr(p + 0x370), ReversePrism.DataModels.MstLiveCutSceneCostume.FromPointer); // 0x370 LiveCutSceneCostumes        ( ModelClassListType MstLiveCutSceneCostume[] MstLiveCutSceneCostume[] List<MstLiveCutSceneCostume> Pointer )
            value.FavoriteMarkIds                           = GetInt32List(new IntPtr(p + 0x380)); // 0x380 FavoriteMarkIds             ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
