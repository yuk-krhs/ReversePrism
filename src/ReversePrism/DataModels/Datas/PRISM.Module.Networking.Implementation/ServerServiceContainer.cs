using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnnounceService                          ModelClassType AnnounceService AnnounceService AnnounceService Pointer
    // 018 AnnounceServiceForTitle                  ModelClassType AnnounceServiceForTitle AnnounceServiceForTitle AnnounceServiceForTitle Pointer
    // 020 AssetService                             ModelClassType AssetService AssetService AssetService Pointer
    // 028 AuthService                              ModelClassType AuthService AuthService AuthService Pointer
    // 030 BadgeService                             ModelClassType BadgeService BadgeService BadgeService Pointer
    // 038 BannerService                            ModelClassType BannerService BannerService BannerService Pointer
    // 040 BillingService                           ModelClassType BillingService BillingService BillingService Pointer
    // 048 ChallengeTourService                     ModelClassType ChallengeTourService ChallengeTourService ChallengeTourService Pointer
    // 050 CostumeService                           ModelClassType CostumeService CostumeService CostumeService Pointer
    // 058 DirectMessageService                     ModelClassType DirectMessageService DirectMessageService DirectMessageService Pointer
    // 060 DressUpRoomService                       ModelClassType DressUpRoomService DressUpRoomService DressUpRoomService Pointer
    // 068 EventRankingService                      ModelClassType EventRankingService EventRankingService EventRankingService Pointer
    // 070 EventScheduleService                     ModelClassType EventScheduleService EventScheduleService EventScheduleService Pointer
    // 078 ExchangeService                          ModelClassType ExchangeService ExchangeService ExchangeService Pointer
    // 080 FesIdolService                           ModelClassType FesIdolService FesIdolService FesIdolService Pointer
    // 088 FesUnitService                           ModelClassType FesUnitService FesUnitService FesUnitService Pointer
    // 090 FriendService                            ModelClassType FriendService FriendService FriendService Pointer
    // 098 FriendInvitationService                  ModelClassType FriendInvitationService FriendInvitationService FriendInvitationService Pointer
    // 0A0 GalleryService                           ModelClassType GalleryService GalleryService GalleryService Pointer
    // 0A8 GameService                              ModelClassType GameService GameService GameService Pointer
    // 0B0 GameSettingService                       ModelClassType GameSettingService GameSettingService GameSettingService Pointer
    // 0B8 GashaService                             ModelClassType GashaService GashaService GashaService Pointer
    // 0C0 HomeService                              ModelClassType HomeService HomeService HomeService Pointer
    // 0C8 IdolService                              ModelClassType IdolService IdolService IdolService Pointer
    // 0D0 InspectService                           ModelClassType InspectService InspectService InspectService Pointer
    // 0D8 IntroductionService                      ModelClassType IntroductionService IntroductionService IntroductionService Pointer
    // 0E0 LiveService                              ModelClassType LiveService LiveService LiveService Pointer
    // 0E8 LiveEventAlphaService                    ModelClassType LiveEventAlphaService LiveEventAlphaService LiveEventAlphaService Pointer
    // 0F0 LiveEventAllSongService                  ModelClassType LiveEventAllSongService LiveEventAllSongService LiveEventAllSongService Pointer
    // 0F8 LoginBonusService                        ModelClassType LoginBonusService LoginBonusService LoginBonusService Pointer
    // 100 MedalGashaService                        ModelClassType MedalGashaService MedalGashaService MedalGashaService Pointer
    // 108 MissionService                           ModelClassType MissionService MissionService MissionService Pointer
    // 110 MobileService                            ModelClassType MobileService MobileService MobileService Pointer
    // 118 PieceService                             ModelClassType PieceService PieceService PieceService Pointer
    // 120 PresentService                           ModelClassType PresentService PresentService PresentService Pointer
    // 128 ProduceService                           ModelClassType ProduceService ProduceService ProduceService Pointer
    // 130 ProduceIdolService                       ModelClassType ProduceIdolService ProduceIdolService ProduceIdolService Pointer
    // 138 ProductService                           ModelClassType ProductService ProductService ProductService Pointer
    // 140 ProfileService                           ModelClassType ProfileService ProfileService ProfileService Pointer
    // 148 SeasonMissionService                     ModelClassType SeasonMissionService SeasonMissionService SeasonMissionService Pointer
    // 150 ShopService                              ModelClassType ShopService ShopService ShopService Pointer
    // 158 SpecialMissionService                    ModelClassType SpecialMissionService SpecialMissionService SpecialMissionService Pointer
    // 160 StaminaService                           ModelClassType StaminaService StaminaService StaminaService Pointer
    // 168 StoryService                             ModelClassType StoryService StoryService StoryService Pointer
    // 170 StreamProgramService                     ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer
    // 178 SupportCharacterService                  ModelClassType SupportCharacterService SupportCharacterService SupportCharacterService Pointer
    // 180 TransferService                          ModelClassType TransferService TransferService TransferService Pointer
    // 188 TutorialService                          ModelClassType TutorialService TutorialService TutorialService Pointer
    // 190 UserService                              ModelClassType UserService UserService UserService Pointer
    // 198 PvpService                               ModelClassType PvpService PvpService PvpService Pointer
    // 1A0 AchievementService                       ModelClassType AchievementService AchievementService AchievementService Pointer
    public partial class ServerServiceContainer : DataModel
    {
        public AnnounceService?                         AnnounceService                         { get; set; }
        public AnnounceServiceForTitle?                 AnnounceServiceForTitle                 { get; set; }
        public AssetService?                            AssetService                            { get; set; }
        public AuthService?                             AuthService                             { get; set; }
        public BadgeService?                            BadgeService                            { get; set; }
        public BannerService?                           BannerService                           { get; set; }
        public BillingService?                          BillingService                          { get; set; }
        public ChallengeTourService?                    ChallengeTourService                    { get; set; }
        public CostumeService?                          CostumeService                          { get; set; }
        public DirectMessageService?                    DirectMessageService                    { get; set; }
        public DressUpRoomService?                      DressUpRoomService                      { get; set; }
        public EventRankingService?                     EventRankingService                     { get; set; }
        public EventScheduleService?                    EventScheduleService                    { get; set; }
        public ExchangeService?                         ExchangeService                         { get; set; }
        public FesIdolService?                          FesIdolService                          { get; set; }
        public FesUnitService?                          FesUnitService                          { get; set; }
        public FriendService?                           FriendService                           { get; set; }
        public FriendInvitationService?                 FriendInvitationService                 { get; set; }
        public GalleryService?                          GalleryService                          { get; set; }
        public GameService?                             GameService                             { get; set; }
        public GameSettingService?                      GameSettingService                      { get; set; }
        public GashaService?                            GashaService                            { get; set; }
        public HomeService?                             HomeService                             { get; set; }
        public IdolService?                             IdolService                             { get; set; }
        public InspectService?                          InspectService                          { get; set; }
        public IntroductionService?                     IntroductionService                     { get; set; }
        public LiveService?                             LiveService                             { get; set; }
        public LiveEventAlphaService?                   LiveEventAlphaService                   { get; set; }
        public LiveEventAllSongService?                 LiveEventAllSongService                 { get; set; }
        public LoginBonusService?                       LoginBonusService                       { get; set; }
        public MedalGashaService?                       MedalGashaService                       { get; set; }
        public MissionService?                          MissionService                          { get; set; }
        public MobileService?                           MobileService                           { get; set; }
        public PieceService?                            PieceService                            { get; set; }
        public PresentService?                          PresentService                          { get; set; }
        public ProduceService?                          ProduceService                          { get; set; }
        public ProduceIdolService?                      ProduceIdolService                      { get; set; }
        public ProductService?                          ProductService                          { get; set; }
        public ProfileService?                          ProfileService                          { get; set; }
        public SeasonMissionService?                    SeasonMissionService                    { get; set; }
        public ShopService?                             ShopService                             { get; set; }
        public SpecialMissionService?                   SpecialMissionService                   { get; set; }
        public StaminaService?                          StaminaService                          { get; set; }
        public StoryService?                            StoryService                            { get; set; }
        public StreamProgramService?                    StreamProgramService                    { get; set; }
        public SupportCharacterService?                 SupportCharacterService                 { get; set; }
        public TransferService?                         TransferService                         { get; set; }
        public TutorialService?                         TutorialService                         { get; set; }
        public UserService?                             UserService                             { get; set; }
        public PvpService?                              PvpService                              { get; set; }
        public AchievementService?                      AchievementService                      { get; set; }

        public static ServerServiceContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerServiceContainer() { Pointer= p0 };

            value.AnnounceService                           = GetObject<AnnounceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnnounceService.FromPointer); // 0x10 AnnounceService             ( ModelClassType AnnounceService AnnounceService AnnounceService Pointer )
            value.AnnounceServiceForTitle                   = GetObject<AnnounceServiceForTitle>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnnounceServiceForTitle.FromPointer); // 0x18 AnnounceServiceForTitle     ( ModelClassType AnnounceServiceForTitle AnnounceServiceForTitle AnnounceServiceForTitle Pointer )
            value.AssetService                              = GetObject<AssetService>(new IntPtr(p + 0x020), ReversePrism.DataModels.AssetService.FromPointer); // 0x20 AssetService                ( ModelClassType AssetService AssetService AssetService Pointer )
            value.AuthService                               = GetObject<AuthService>(new IntPtr(p + 0x028), ReversePrism.DataModels.AuthService.FromPointer); // 0x28 AuthService                 ( ModelClassType AuthService AuthService AuthService Pointer )
            value.BadgeService                              = GetObject<BadgeService>(new IntPtr(p + 0x030), ReversePrism.DataModels.BadgeService.FromPointer); // 0x30 BadgeService                ( ModelClassType BadgeService BadgeService BadgeService Pointer )
            value.BannerService                             = GetObject<BannerService>(new IntPtr(p + 0x038), ReversePrism.DataModels.BannerService.FromPointer); // 0x38 BannerService               ( ModelClassType BannerService BannerService BannerService Pointer )
            value.BillingService                            = GetObject<BillingService>(new IntPtr(p + 0x040), ReversePrism.DataModels.BillingService.FromPointer); // 0x40 BillingService              ( ModelClassType BillingService BillingService BillingService Pointer )
            value.ChallengeTourService                      = GetObject<ChallengeTourService>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeTourService.FromPointer); // 0x48 ChallengeTourService        ( ModelClassType ChallengeTourService ChallengeTourService ChallengeTourService Pointer )
            value.CostumeService                            = GetObject<CostumeService>(new IntPtr(p + 0x050), ReversePrism.DataModels.CostumeService.FromPointer); // 0x50 CostumeService              ( ModelClassType CostumeService CostumeService CostumeService Pointer )
            value.DirectMessageService                      = GetObject<DirectMessageService>(new IntPtr(p + 0x058), ReversePrism.DataModels.DirectMessageService.FromPointer); // 0x58 DirectMessageService        ( ModelClassType DirectMessageService DirectMessageService DirectMessageService Pointer )
            value.DressUpRoomService                        = GetObject<DressUpRoomService>(new IntPtr(p + 0x060), ReversePrism.DataModels.DressUpRoomService.FromPointer); // 0x60 DressUpRoomService          ( ModelClassType DressUpRoomService DressUpRoomService DressUpRoomService Pointer )
            value.EventRankingService                       = GetObject<EventRankingService>(new IntPtr(p + 0x068), ReversePrism.DataModels.EventRankingService.FromPointer); // 0x68 EventRankingService         ( ModelClassType EventRankingService EventRankingService EventRankingService Pointer )
            value.EventScheduleService                      = GetObject<EventScheduleService>(new IntPtr(p + 0x070), ReversePrism.DataModels.EventScheduleService.FromPointer); // 0x70 EventScheduleService        ( ModelClassType EventScheduleService EventScheduleService EventScheduleService Pointer )
            value.ExchangeService                           = GetObject<ExchangeService>(new IntPtr(p + 0x078), ReversePrism.DataModels.ExchangeService.FromPointer); // 0x78 ExchangeService             ( ModelClassType ExchangeService ExchangeService ExchangeService Pointer )
            value.FesIdolService                            = GetObject<FesIdolService>(new IntPtr(p + 0x080), ReversePrism.DataModels.FesIdolService.FromPointer); // 0x80 FesIdolService              ( ModelClassType FesIdolService FesIdolService FesIdolService Pointer )
            value.FesUnitService                            = GetObject<FesUnitService>(new IntPtr(p + 0x088), ReversePrism.DataModels.FesUnitService.FromPointer); // 0x88 FesUnitService              ( ModelClassType FesUnitService FesUnitService FesUnitService Pointer )
            value.FriendService                             = GetObject<FriendService>(new IntPtr(p + 0x090), ReversePrism.DataModels.FriendService.FromPointer); // 0x90 FriendService               ( ModelClassType FriendService FriendService FriendService Pointer )
            value.FriendInvitationService                   = GetObject<FriendInvitationService>(new IntPtr(p + 0x098), ReversePrism.DataModels.FriendInvitationService.FromPointer); // 0x98 FriendInvitationService     ( ModelClassType FriendInvitationService FriendInvitationService FriendInvitationService Pointer )
            value.GalleryService                            = GetObject<GalleryService>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GalleryService.FromPointer); // 0xA0 GalleryService              ( ModelClassType GalleryService GalleryService GalleryService Pointer )
            value.GameService                               = GetObject<GameService>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameService.FromPointer); // 0xA8 GameService                 ( ModelClassType GameService GameService GameService Pointer )
            value.GameSettingService                        = GetObject<GameSettingService>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameSettingService.FromPointer); // 0xB0 GameSettingService          ( ModelClassType GameSettingService GameSettingService GameSettingService Pointer )
            value.GashaService                              = GetObject<GashaService>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GashaService.FromPointer); // 0xB8 GashaService                ( ModelClassType GashaService GashaService GashaService Pointer )
            value.HomeService                               = GetObject<HomeService>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.HomeService.FromPointer); // 0xC0 HomeService                 ( ModelClassType HomeService HomeService HomeService Pointer )
            value.IdolService                               = GetObject<IdolService>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IdolService.FromPointer); // 0xC8 IdolService                 ( ModelClassType IdolService IdolService IdolService Pointer )
            value.InspectService                            = GetObject<InspectService>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.InspectService.FromPointer); // 0xD0 InspectService              ( ModelClassType InspectService InspectService InspectService Pointer )
            value.IntroductionService                       = GetObject<IntroductionService>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IntroductionService.FromPointer); // 0xD8 IntroductionService         ( ModelClassType IntroductionService IntroductionService IntroductionService Pointer )
            value.LiveService                               = GetObject<LiveService>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.LiveService.FromPointer); // 0xE0 LiveService                 ( ModelClassType LiveService LiveService LiveService Pointer )
            value.LiveEventAlphaService                     = GetObject<LiveEventAlphaService>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LiveEventAlphaService.FromPointer); // 0xE8 LiveEventAlphaService       ( ModelClassType LiveEventAlphaService LiveEventAlphaService LiveEventAlphaService Pointer )
            value.LiveEventAllSongService                   = GetObject<LiveEventAllSongService>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.LiveEventAllSongService.FromPointer); // 0xF0 LiveEventAllSongService     ( ModelClassType LiveEventAllSongService LiveEventAllSongService LiveEventAllSongService Pointer )
            value.LoginBonusService                         = GetObject<LoginBonusService>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.LoginBonusService.FromPointer); // 0xF8 LoginBonusService           ( ModelClassType LoginBonusService LoginBonusService LoginBonusService Pointer )
            value.MedalGashaService                         = GetObject<MedalGashaService>(new IntPtr(p + 0x100), ReversePrism.DataModels.MedalGashaService.FromPointer); // 0x100 MedalGashaService           ( ModelClassType MedalGashaService MedalGashaService MedalGashaService Pointer )
            value.MissionService                            = GetObject<MissionService>(new IntPtr(p + 0x108), ReversePrism.DataModels.MissionService.FromPointer); // 0x108 MissionService              ( ModelClassType MissionService MissionService MissionService Pointer )
            value.MobileService                             = GetObject<MobileService>(new IntPtr(p + 0x110), ReversePrism.DataModels.MobileService.FromPointer); // 0x110 MobileService               ( ModelClassType MobileService MobileService MobileService Pointer )
            value.PieceService                              = GetObject<PieceService>(new IntPtr(p + 0x118), ReversePrism.DataModels.PieceService.FromPointer); // 0x118 PieceService                ( ModelClassType PieceService PieceService PieceService Pointer )
            value.PresentService                            = GetObject<PresentService>(new IntPtr(p + 0x120), ReversePrism.DataModels.PresentService.FromPointer); // 0x120 PresentService              ( ModelClassType PresentService PresentService PresentService Pointer )
            value.ProduceService                            = GetObject<ProduceService>(new IntPtr(p + 0x128), ReversePrism.DataModels.ProduceService.FromPointer); // 0x128 ProduceService              ( ModelClassType ProduceService ProduceService ProduceService Pointer )
            value.ProduceIdolService                        = GetObject<ProduceIdolService>(new IntPtr(p + 0x130), ReversePrism.DataModels.ProduceIdolService.FromPointer); // 0x130 ProduceIdolService          ( ModelClassType ProduceIdolService ProduceIdolService ProduceIdolService Pointer )
            value.ProductService                            = GetObject<ProductService>(new IntPtr(p + 0x138), ReversePrism.DataModels.ProductService.FromPointer); // 0x138 ProductService              ( ModelClassType ProductService ProductService ProductService Pointer )
            value.ProfileService                            = GetObject<ProfileService>(new IntPtr(p + 0x140), ReversePrism.DataModels.ProfileService.FromPointer); // 0x140 ProfileService              ( ModelClassType ProfileService ProfileService ProfileService Pointer )
            value.SeasonMissionService                      = GetObject<SeasonMissionService>(new IntPtr(p + 0x148), ReversePrism.DataModels.SeasonMissionService.FromPointer); // 0x148 SeasonMissionService        ( ModelClassType SeasonMissionService SeasonMissionService SeasonMissionService Pointer )
            value.ShopService                               = GetObject<ShopService>(new IntPtr(p + 0x150), ReversePrism.DataModels.ShopService.FromPointer); // 0x150 ShopService                 ( ModelClassType ShopService ShopService ShopService Pointer )
            value.SpecialMissionService                     = GetObject<SpecialMissionService>(new IntPtr(p + 0x158), ReversePrism.DataModels.SpecialMissionService.FromPointer); // 0x158 SpecialMissionService       ( ModelClassType SpecialMissionService SpecialMissionService SpecialMissionService Pointer )
            value.StaminaService                            = GetObject<StaminaService>(new IntPtr(p + 0x160), ReversePrism.DataModels.StaminaService.FromPointer); // 0x160 StaminaService              ( ModelClassType StaminaService StaminaService StaminaService Pointer )
            value.StoryService                              = GetObject<StoryService>(new IntPtr(p + 0x168), ReversePrism.DataModels.StoryService.FromPointer); // 0x168 StoryService                ( ModelClassType StoryService StoryService StoryService Pointer )
            value.StreamProgramService                      = GetObject<StreamProgramService>(new IntPtr(p + 0x170), ReversePrism.DataModels.StreamProgramService.FromPointer); // 0x170 StreamProgramService        ( ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer )
            value.SupportCharacterService                   = GetObject<SupportCharacterService>(new IntPtr(p + 0x178), ReversePrism.DataModels.SupportCharacterService.FromPointer); // 0x178 SupportCharacterService     ( ModelClassType SupportCharacterService SupportCharacterService SupportCharacterService Pointer )
            value.TransferService                           = GetObject<TransferService>(new IntPtr(p + 0x180), ReversePrism.DataModels.TransferService.FromPointer); // 0x180 TransferService             ( ModelClassType TransferService TransferService TransferService Pointer )
            value.TutorialService                           = GetObject<TutorialService>(new IntPtr(p + 0x188), ReversePrism.DataModels.TutorialService.FromPointer); // 0x188 TutorialService             ( ModelClassType TutorialService TutorialService TutorialService Pointer )
            value.UserService                               = GetObject<UserService>(new IntPtr(p + 0x190), ReversePrism.DataModels.UserService.FromPointer); // 0x190 UserService                 ( ModelClassType UserService UserService UserService Pointer )
            value.PvpService                                = GetObject<PvpService>(new IntPtr(p + 0x198), ReversePrism.DataModels.PvpService.FromPointer); // 0x198 PvpService                  ( ModelClassType PvpService PvpService PvpService Pointer )
            value.AchievementService                        = GetObject<AchievementService>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.AchievementService.FromPointer); // 0x1A0 AchievementService          ( ModelClassType AchievementService AchievementService AchievementService Pointer )

            return value;
        }
    }
}
