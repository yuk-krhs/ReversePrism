using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnnounceService                          0001866C3510 ModelClassType AnnounceService AnnounceService AnnounceService Pointer
    // 018 AnnounceServiceForTitle                  0001866C3CC0 ModelClassType AnnounceServiceForTitle AnnounceServiceForTitle AnnounceServiceForTitle Pointer
    // 020 AssetService                             0001866E8880 ModelClassType AssetService AssetService AssetService Pointer
    // 028 AuthService                              0001867210E0 ModelClassType AuthService AuthService AuthService Pointer
    // 030 BadgeService                             0001867371E0 ModelClassType BadgeService BadgeService BadgeService Pointer
    // 038 BannerService                            00018673A3D0 ModelClassType BannerService BannerService BannerService Pointer
    // 040 BillingService                           0001867525B0 ModelClassType BillingService BillingService BillingService Pointer
    // 048 ChallengeTourService                     00018657F7B0 ModelClassType ChallengeTourService ChallengeTourService ChallengeTourService Pointer
    // 050 CostumeService                           000186632A50 ModelClassType CostumeService CostumeService CostumeService Pointer
    // 058 DirectMessageService                     0001866D61C0 ModelClassType DirectMessageService DirectMessageService DirectMessageService Pointer
    // 060 DressUpRoomService                       0001867027B0 ModelClassType DressUpRoomService DressUpRoomService DressUpRoomService Pointer
    // 068 EventRankingService                      000186761E80 ModelClassType EventRankingService EventRankingService EventRankingService Pointer
    // 070 EventScheduleService                     0001867655F0 ModelClassType EventScheduleService EventScheduleService EventScheduleService Pointer
    // 078 ExchangeService                          00018651B470 ModelClassType ExchangeService ExchangeService ExchangeService Pointer
    // 080 FesIdolService                           0001865648D0 ModelClassType FesIdolService FesIdolService FesIdolService Pointer
    // 088 FesUnitService                           00018656CA30 ModelClassType FesUnitService FesUnitService FesUnitService Pointer
    // 090 FriendService                            0001865CA230 ModelClassType FriendService FriendService FriendService Pointer
    // 098 FriendInvitationService                  0001865C6100 ModelClassType FriendInvitationService FriendInvitationService FriendInvitationService Pointer
    // 0A0 GalleryService                           0001865E4890 ModelClassType GalleryService GalleryService GalleryService Pointer
    // 0A8 GameService                              0001865EBE00 ModelClassType GameService GameService GameService Pointer
    // 0B0 GameSettingService                       0001865ED290 ModelClassType GameSettingService GameSettingService GameSettingService Pointer
    // 0B8 GashaService                             00018661AAC0 ModelClassType GashaService GashaService GashaService Pointer
    // 0C0 HomeService                              0001866CAA60 ModelClassType HomeService HomeService HomeService Pointer
    // 0C8 IdolService                              0001866B71A0 ModelClassType IdolService IdolService IdolService Pointer
    // 0D0 InspectService                           0001867094E0 ModelClassType InspectService InspectService InspectService Pointer
    // 0D8 IntroductionService                      00018672B510 ModelClassType IntroductionService IntroductionService IntroductionService Pointer
    // 0E0 LiveService                              000186577E60 ModelClassType LiveService LiveService LiveService Pointer
    // 0E8 LiveEventAlphaService                    00018654BEF0 ModelClassType LiveEventAlphaService LiveEventAlphaService LiveEventAlphaService Pointer
    // 0F0 LoginBonusService                        0001865B8B50 ModelClassType LoginBonusService LoginBonusService LoginBonusService Pointer
    // 0F8 MedalGashaService                        0001865EE480 ModelClassType MedalGashaService MedalGashaService MedalGashaService Pointer
    // 100 MissionService                           000186628340 ModelClassType MissionService MissionService MissionService Pointer
    // 108 MobileService                            000186635870 ModelClassType MobileService MobileService MobileService Pointer
    // 110 PieceService                             000186744260 ModelClassType PieceService PieceService PieceService Pointer
    // 118 PresentService                           00018650D100 ModelClassType PresentService PresentService PresentService Pointer
    // 120 ProduceService                           00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer
    // 128 ProduceIdolService                       00018654D550 ModelClassType ProduceIdolService ProduceIdolService ProduceIdolService Pointer
    // 130 ProductService                           0001865A4890 ModelClassType ProductService ProductService ProductService Pointer
    // 138 ProfileService                           0001865C2AD0 ModelClassType ProfileService ProfileService ProfileService Pointer
    // 140 SeasonMissionService                     000186707AC0 ModelClassType SeasonMissionService SeasonMissionService SeasonMissionService Pointer
    // 148 ShopService                              0001867727D0 ModelClassType ShopService ShopService ShopService Pointer
    // 150 SpecialMissionService                    0001865482E0 ModelClassType SpecialMissionService SpecialMissionService SpecialMissionService Pointer
    // 158 StaminaService                           00018656A7F0 ModelClassType StaminaService StaminaService StaminaService Pointer
    // 160 StoryService                             00018659C2E0 ModelClassType StoryService StoryService StoryService Pointer
    // 168 StreamProgramService                     0001865B4AF0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer
    // 170 SupportCharacterService                  0001865EC700 ModelClassType SupportCharacterService SupportCharacterService SupportCharacterService Pointer
    // 178 TransferService                          0001866A7FF0 ModelClassType TransferService TransferService TransferService Pointer
    // 180 TutorialService                          0001866BD230 ModelClassType TutorialService TutorialService TutorialService Pointer
    // 188 UserService                              000186752280 ModelClassType UserService UserService UserService Pointer
    // 190 PvpService                               0001865F3590 ModelClassType PvpService PvpService PvpService Pointer
    // 198 AchievementService                       0001866774F0 ModelClassType AchievementService AchievementService AchievementService Pointer
    public partial class ServerServiceContainer
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
            var value   = new ServerServiceContainer();

            value.AnnounceService                           = GetObject<AnnounceService>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnnounceService.FromPointer); // 027003A58D40 0x10 AnnounceService             ( 0001866C3510 ModelClassType AnnounceService AnnounceService AnnounceService Pointer )
            value.AnnounceServiceForTitle                   = GetObject<AnnounceServiceForTitle>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnnounceServiceForTitle.FromPointer); // 027003A58D60 0x18 AnnounceServiceForTitle     ( 0001866C3CC0 ModelClassType AnnounceServiceForTitle AnnounceServiceForTitle AnnounceServiceForTitle Pointer )
            value.AssetService                              = GetObject<AssetService>(new IntPtr(p + 0x020), ReversePrism.DataModels.AssetService.FromPointer); // 027003A58D80 0x20 AssetService                ( 0001866E8880 ModelClassType AssetService AssetService AssetService Pointer )
            value.AuthService                               = GetObject<AuthService>(new IntPtr(p + 0x028), ReversePrism.DataModels.AuthService.FromPointer); // 027003A58DA0 0x28 AuthService                 ( 0001867210E0 ModelClassType AuthService AuthService AuthService Pointer )
            value.BadgeService                              = GetObject<BadgeService>(new IntPtr(p + 0x030), ReversePrism.DataModels.BadgeService.FromPointer); // 027003A58DC0 0x30 BadgeService                ( 0001867371E0 ModelClassType BadgeService BadgeService BadgeService Pointer )
            value.BannerService                             = GetObject<BannerService>(new IntPtr(p + 0x038), ReversePrism.DataModels.BannerService.FromPointer); // 027003A58DE0 0x38 BannerService               ( 00018673A3D0 ModelClassType BannerService BannerService BannerService Pointer )
            value.BillingService                            = GetObject<BillingService>(new IntPtr(p + 0x040), ReversePrism.DataModels.BillingService.FromPointer); // 027003A58E00 0x40 BillingService              ( 0001867525B0 ModelClassType BillingService BillingService BillingService Pointer )
            value.ChallengeTourService                      = GetObject<ChallengeTourService>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeTourService.FromPointer); // 027003A58E20 0x48 ChallengeTourService        ( 00018657F7B0 ModelClassType ChallengeTourService ChallengeTourService ChallengeTourService Pointer )
            value.CostumeService                            = GetObject<CostumeService>(new IntPtr(p + 0x050), ReversePrism.DataModels.CostumeService.FromPointer); // 027003A58E40 0x50 CostumeService              ( 000186632A50 ModelClassType CostumeService CostumeService CostumeService Pointer )
            value.DirectMessageService                      = GetObject<DirectMessageService>(new IntPtr(p + 0x058), ReversePrism.DataModels.DirectMessageService.FromPointer); // 027003A58E60 0x58 DirectMessageService        ( 0001866D61C0 ModelClassType DirectMessageService DirectMessageService DirectMessageService Pointer )
            value.DressUpRoomService                        = GetObject<DressUpRoomService>(new IntPtr(p + 0x060), ReversePrism.DataModels.DressUpRoomService.FromPointer); // 027003A58E80 0x60 DressUpRoomService          ( 0001867027B0 ModelClassType DressUpRoomService DressUpRoomService DressUpRoomService Pointer )
            value.EventRankingService                       = GetObject<EventRankingService>(new IntPtr(p + 0x068), ReversePrism.DataModels.EventRankingService.FromPointer); // 027003A58EA0 0x68 EventRankingService         ( 000186761E80 ModelClassType EventRankingService EventRankingService EventRankingService Pointer )
            value.EventScheduleService                      = GetObject<EventScheduleService>(new IntPtr(p + 0x070), ReversePrism.DataModels.EventScheduleService.FromPointer); // 027003A58EC0 0x70 EventScheduleService        ( 0001867655F0 ModelClassType EventScheduleService EventScheduleService EventScheduleService Pointer )
            value.ExchangeService                           = GetObject<ExchangeService>(new IntPtr(p + 0x078), ReversePrism.DataModels.ExchangeService.FromPointer); // 027003A58EE0 0x78 ExchangeService             ( 00018651B470 ModelClassType ExchangeService ExchangeService ExchangeService Pointer )
            value.FesIdolService                            = GetObject<FesIdolService>(new IntPtr(p + 0x080), ReversePrism.DataModels.FesIdolService.FromPointer); // 027003A58F00 0x80 FesIdolService              ( 0001865648D0 ModelClassType FesIdolService FesIdolService FesIdolService Pointer )
            value.FesUnitService                            = GetObject<FesUnitService>(new IntPtr(p + 0x088), ReversePrism.DataModels.FesUnitService.FromPointer); // 027003A58F20 0x88 FesUnitService              ( 00018656CA30 ModelClassType FesUnitService FesUnitService FesUnitService Pointer )
            value.FriendService                             = GetObject<FriendService>(new IntPtr(p + 0x090), ReversePrism.DataModels.FriendService.FromPointer); // 027003A58F40 0x90 FriendService               ( 0001865CA230 ModelClassType FriendService FriendService FriendService Pointer )
            value.FriendInvitationService                   = GetObject<FriendInvitationService>(new IntPtr(p + 0x098), ReversePrism.DataModels.FriendInvitationService.FromPointer); // 027003A58F60 0x98 FriendInvitationService     ( 0001865C6100 ModelClassType FriendInvitationService FriendInvitationService FriendInvitationService Pointer )
            value.GalleryService                            = GetObject<GalleryService>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GalleryService.FromPointer); // 027003A58F80 0xA0 GalleryService              ( 0001865E4890 ModelClassType GalleryService GalleryService GalleryService Pointer )
            value.GameService                               = GetObject<GameService>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameService.FromPointer); // 027003A58FA0 0xA8 GameService                 ( 0001865EBE00 ModelClassType GameService GameService GameService Pointer )
            value.GameSettingService                        = GetObject<GameSettingService>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameSettingService.FromPointer); // 027003A58FC0 0xB0 GameSettingService          ( 0001865ED290 ModelClassType GameSettingService GameSettingService GameSettingService Pointer )
            value.GashaService                              = GetObject<GashaService>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GashaService.FromPointer); // 027003A58FE0 0xB8 GashaService                ( 00018661AAC0 ModelClassType GashaService GashaService GashaService Pointer )
            value.HomeService                               = GetObject<HomeService>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.HomeService.FromPointer); // 027003A59000 0xC0 HomeService                 ( 0001866CAA60 ModelClassType HomeService HomeService HomeService Pointer )
            value.IdolService                               = GetObject<IdolService>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IdolService.FromPointer); // 027003A59020 0xC8 IdolService                 ( 0001866B71A0 ModelClassType IdolService IdolService IdolService Pointer )
            value.InspectService                            = GetObject<InspectService>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.InspectService.FromPointer); // 027003A59040 0xD0 InspectService              ( 0001867094E0 ModelClassType InspectService InspectService InspectService Pointer )
            value.IntroductionService                       = GetObject<IntroductionService>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IntroductionService.FromPointer); // 027003A59060 0xD8 IntroductionService         ( 00018672B510 ModelClassType IntroductionService IntroductionService IntroductionService Pointer )
            value.LiveService                               = GetObject<LiveService>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.LiveService.FromPointer); // 027003A59080 0xE0 LiveService                 ( 000186577E60 ModelClassType LiveService LiveService LiveService Pointer )
            value.LiveEventAlphaService                     = GetObject<LiveEventAlphaService>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LiveEventAlphaService.FromPointer); // 027003A590A0 0xE8 LiveEventAlphaService       ( 00018654BEF0 ModelClassType LiveEventAlphaService LiveEventAlphaService LiveEventAlphaService Pointer )
            value.LoginBonusService                         = GetObject<LoginBonusService>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.LoginBonusService.FromPointer); // 027003A590C0 0xF0 LoginBonusService           ( 0001865B8B50 ModelClassType LoginBonusService LoginBonusService LoginBonusService Pointer )
            value.MedalGashaService                         = GetObject<MedalGashaService>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.MedalGashaService.FromPointer); // 027003A590E0 0xF8 MedalGashaService           ( 0001865EE480 ModelClassType MedalGashaService MedalGashaService MedalGashaService Pointer )
            value.MissionService                            = GetObject<MissionService>(new IntPtr(p + 0x100), ReversePrism.DataModels.MissionService.FromPointer); // 027003A59100 0x100 MissionService              ( 000186628340 ModelClassType MissionService MissionService MissionService Pointer )
            value.MobileService                             = GetObject<MobileService>(new IntPtr(p + 0x108), ReversePrism.DataModels.MobileService.FromPointer); // 027003A59120 0x108 MobileService               ( 000186635870 ModelClassType MobileService MobileService MobileService Pointer )
            value.PieceService                              = GetObject<PieceService>(new IntPtr(p + 0x110), ReversePrism.DataModels.PieceService.FromPointer); // 027003A59140 0x110 PieceService                ( 000186744260 ModelClassType PieceService PieceService PieceService Pointer )
            value.PresentService                            = GetObject<PresentService>(new IntPtr(p + 0x118), ReversePrism.DataModels.PresentService.FromPointer); // 027003A59160 0x118 PresentService              ( 00018650D100 ModelClassType PresentService PresentService PresentService Pointer )
            value.ProduceService                            = GetObject<ProduceService>(new IntPtr(p + 0x120), ReversePrism.DataModels.ProduceService.FromPointer); // 027003A59180 0x120 ProduceService              ( 00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer )
            value.ProduceIdolService                        = GetObject<ProduceIdolService>(new IntPtr(p + 0x128), ReversePrism.DataModels.ProduceIdolService.FromPointer); // 027003A591A0 0x128 ProduceIdolService          ( 00018654D550 ModelClassType ProduceIdolService ProduceIdolService ProduceIdolService Pointer )
            value.ProductService                            = GetObject<ProductService>(new IntPtr(p + 0x130), ReversePrism.DataModels.ProductService.FromPointer); // 027003A591C0 0x130 ProductService              ( 0001865A4890 ModelClassType ProductService ProductService ProductService Pointer )
            value.ProfileService                            = GetObject<ProfileService>(new IntPtr(p + 0x138), ReversePrism.DataModels.ProfileService.FromPointer); // 027003A591E0 0x138 ProfileService              ( 0001865C2AD0 ModelClassType ProfileService ProfileService ProfileService Pointer )
            value.SeasonMissionService                      = GetObject<SeasonMissionService>(new IntPtr(p + 0x140), ReversePrism.DataModels.SeasonMissionService.FromPointer); // 027003A59200 0x140 SeasonMissionService        ( 000186707AC0 ModelClassType SeasonMissionService SeasonMissionService SeasonMissionService Pointer )
            value.ShopService                               = GetObject<ShopService>(new IntPtr(p + 0x148), ReversePrism.DataModels.ShopService.FromPointer); // 027003A59220 0x148 ShopService                 ( 0001867727D0 ModelClassType ShopService ShopService ShopService Pointer )
            value.SpecialMissionService                     = GetObject<SpecialMissionService>(new IntPtr(p + 0x150), ReversePrism.DataModels.SpecialMissionService.FromPointer); // 027003A59240 0x150 SpecialMissionService       ( 0001865482E0 ModelClassType SpecialMissionService SpecialMissionService SpecialMissionService Pointer )
            value.StaminaService                            = GetObject<StaminaService>(new IntPtr(p + 0x158), ReversePrism.DataModels.StaminaService.FromPointer); // 027003A59260 0x158 StaminaService              ( 00018656A7F0 ModelClassType StaminaService StaminaService StaminaService Pointer )
            value.StoryService                              = GetObject<StoryService>(new IntPtr(p + 0x160), ReversePrism.DataModels.StoryService.FromPointer); // 027003A59280 0x160 StoryService                ( 00018659C2E0 ModelClassType StoryService StoryService StoryService Pointer )
            value.StreamProgramService                      = GetObject<StreamProgramService>(new IntPtr(p + 0x168), ReversePrism.DataModels.StreamProgramService.FromPointer); // 027003A592A0 0x168 StreamProgramService        ( 0001865B4AF0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer )
            value.SupportCharacterService                   = GetObject<SupportCharacterService>(new IntPtr(p + 0x170), ReversePrism.DataModels.SupportCharacterService.FromPointer); // 027003A592C0 0x170 SupportCharacterService     ( 0001865EC700 ModelClassType SupportCharacterService SupportCharacterService SupportCharacterService Pointer )
            value.TransferService                           = GetObject<TransferService>(new IntPtr(p + 0x178), ReversePrism.DataModels.TransferService.FromPointer); // 027003A592E0 0x178 TransferService             ( 0001866A7FF0 ModelClassType TransferService TransferService TransferService Pointer )
            value.TutorialService                           = GetObject<TutorialService>(new IntPtr(p + 0x180), ReversePrism.DataModels.TutorialService.FromPointer); // 027003A59300 0x180 TutorialService             ( 0001866BD230 ModelClassType TutorialService TutorialService TutorialService Pointer )
            value.UserService                               = GetObject<UserService>(new IntPtr(p + 0x188), ReversePrism.DataModels.UserService.FromPointer); // 027003A59320 0x188 UserService                 ( 000186752280 ModelClassType UserService UserService UserService Pointer )
            value.PvpService                                = GetObject<PvpService>(new IntPtr(p + 0x190), ReversePrism.DataModels.PvpService.FromPointer); // 027003A59340 0x190 PvpService                  ( 0001865F3590 ModelClassType PvpService PvpService PvpService Pointer )
            value.AchievementService                        = GetObject<AchievementService>(new IntPtr(p + 0x198), ReversePrism.DataModels.AchievementService.FromPointer); // 027003A59360 0x198 AchievementService          ( 0001866774F0 ModelClassType AchievementService AchievementService AchievementService Pointer )

            return value;
        }
    }
}
