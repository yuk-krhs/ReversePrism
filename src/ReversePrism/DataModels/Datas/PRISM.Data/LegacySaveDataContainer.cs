using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 LoginUser                                0001865BC9A0 ModelClassType LoginUserData LoginUserData LoginUserData Pointer
    // 020 NonLoginUser                             0001866A6B60 ModelClassType NonLoginUserData NonLoginUserData NonLoginUserData Pointer
    // 028 Badge                                    000186736D10 ModelClassType BadgeSaveData BadgeSaveData BadgeSaveData Pointer
    // 030 HowToPlayPopup                           0001866D9F90 ModelClassType HowToPlayPopupSaveData HowToPlayPopupSaveData HowToPlayPopupSaveData Pointer
    // 038 RhythmGameOption                         000186685E40 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 040 UnitMemberChangeView                     00018670E6E0 ModelClassType UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData Pointer
    // 048 ComboInfoView                            0001865DE1D0 ModelClassType ComboInfoViewSaveData ComboInfoViewSaveData ComboInfoViewSaveData Pointer
    // 050 LiveCostumeChange                        000186549620 ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer
    // 058 CasualCostumeChange                      000186549620 ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer
    // 060 LiveMVOption                             00018655B880 ModelClassType LiveMVOption LiveMVOption LiveMVOption Pointer
    // 068 LiveToken                                0001865879E0 ModelClassType LiveTokenSaveData LiveTokenSaveData LiveTokenSaveData Pointer
    // 070 LiveMVUnitConfirmation                   00018655EE40 ModelClassType LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData Pointer
    // 078 LiveMusicSelection                       0001865661F0 ModelClassType LiveMusicSelectionSaveData LiveMusicSelectionSaveData LiveMusicSelectionSaveData Pointer
    // 080 UnitEditView                             00018670BC20 ModelClassType UnitEditViewSaveData UnitEditViewSaveData UnitEditViewSaveData Pointer
    // 088 LiveUnitConfirmation                     00018658A9F0 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer
    // 090 LiveUnitMemberChange                     000186595FD0 ModelClassType LiveUnitMemberChangeSaveData LiveUnitMemberChangeSaveData LiveUnitMemberChangeSaveData Pointer
    // 098 IdolListFUSortFilter                     0001866B2640 ModelClassType IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData Pointer
    // 0A0 MissionFilter                            000186620FC0 ModelClassType MissionFilterSaveData MissionFilterSaveData MissionFilterSaveData Pointer
    // 0A8 Option                                   0001866E7540 ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer
    // 0B0 Shop                                     000186762480 ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer
    // 0B8 Personal                                 000186738130 ModelClassType PersonalLocalSave PersonalLocalSave PersonalLocalSave Pointer
    // 0C0 Purchase                                 0001865DDC50 ModelClassType PurchaseLocalSave PurchaseLocalSave PurchaseLocalSave Pointer
    // 0C8 Exchange                                 000186517230 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer
    // 0D0 PrivacyOptionAgreement                   0001865198B0 ModelClassType PrivacyOptionAgreementSaveData PrivacyOptionAgreementSaveData PrivacyOptionAgreementSaveData Pointer
    // 0D8 Gasha                                    000186606B60 ModelClassType GashaLocalSave GashaLocalSave GashaLocalSave Pointer
    // 0E0 GashaDetailsTab                          0001865F9B80 ModelClassType GashaDetailsTabSave GashaDetailsTabSave GashaDetailsTabSave Pointer
    // 0E8 GashaExchangeExpiryDateInfo              000186600830 ModelClassType GashaExchangeExpiryDateInfoSave GashaExchangeExpiryDateInfoSave GashaExchangeExpiryDateInfoSave Pointer
    // 0F0 ProduceOption                            0001865618D0 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    // 0F8 ProduceTutorial                          000186591610 ModelClassType ProduceTutorialSaveData ProduceTutorialSaveData ProduceTutorialSaveData Pointer
    // 100 ProducePreparationEpisodeSelect          00018656B3C0 ModelClassType ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData Pointer
    // 108 StorySortFilterFavorite                  0001865A3010 ModelClassType StorySortFilterSaveDataFavorite StorySortFilterSaveDataFavorite StorySortFilterSaveDataFavorite Pointer
    // 110 StorySortFilterSearch                    0001865A3520 ModelClassType StorySortFilterSaveDataSearch StorySortFilterSaveDataSearch StorySortFilterSaveDataSearch Pointer
    // 118 Notification                             0001866B4790 ModelClassType NotificationSaveData NotificationSaveData NotificationSaveData Pointer
    // 120 NotificationSettings                     0001866B53A0 ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer
    // 128 ProduceInGame                            SavableJsonObject`1<InGameSaveData> IL2CPP_TYPE_GENERICINST
    // 130 ChallengeTourInGame                      SavableJsonObject`1<InGameSaveData> IL2CPP_TYPE_GENERICINST
    // 138 PvpInGame                                SavableJsonObject`1<InGameSaveData> IL2CPP_TYPE_GENERICINST
    public partial class LegacySaveDataContainer : DataModel
    {
        public LoginUserData?                           LoginUser                               { get; set; }
        public NonLoginUserData?                        NonLoginUser                            { get; set; }
        public BadgeSaveData?                           Badge                                   { get; set; }
        public HowToPlayPopupSaveData?                  HowToPlayPopup                          { get; set; }
        public RhythmGameOption?                        RhythmGameOption                        { get; set; }
        public UnitMemberChangeViewSaveData?            UnitMemberChangeView                    { get; set; }
        public ComboInfoViewSaveData?                   ComboInfoView                           { get; set; }
        public LiveCostumeChangeSaveData?               LiveCostumeChange                       { get; set; }
        public LiveCostumeChangeSaveData?               CasualCostumeChange                     { get; set; }
        public LiveMVOption?                            LiveMVOption                            { get; set; }
        public LiveTokenSaveData?                       LiveToken                               { get; set; }
        public LiveMVUnitConfirmationSaveData?          LiveMVUnitConfirmation                  { get; set; }
        public LiveMusicSelectionSaveData?              LiveMusicSelection                      { get; set; }
        public UnitEditViewSaveData?                    UnitEditView                            { get; set; }
        public LiveUnitConfirmationSaveData?            LiveUnitConfirmation                    { get; set; }
        public LiveUnitMemberChangeSaveData?            LiveUnitMemberChange                    { get; set; }
        public IdolListFUSortFilterSaveData?            IdolListFUSortFilter                    { get; set; }
        public MissionFilterSaveData?                   MissionFilter                           { get; set; }
        public OptionLocalSave?                         Option                                  { get; set; }
        public ShopLocalSave?                           Shop                                    { get; set; }
        public PersonalLocalSave?                       Personal                                { get; set; }
        public PurchaseLocalSave?                       Purchase                                { get; set; }
        public ExchangeSaveData?                        Exchange                                { get; set; }
        public PrivacyOptionAgreementSaveData?          PrivacyOptionAgreement                  { get; set; }
        public GashaLocalSave?                          Gasha                                   { get; set; }
        public GashaDetailsTabSave?                     GashaDetailsTab                         { get; set; }
        public GashaExchangeExpiryDateInfoSave?         GashaExchangeExpiryDateInfo             { get; set; }
        public ProduceOptionSaveData?                   ProduceOption                           { get; set; }
        public ProduceTutorialSaveData?                 ProduceTutorial                         { get; set; }
        public ProducePreparationEpisodeSelectSaveData? ProducePreparationEpisodeSelect         { get; set; }
        public StorySortFilterSaveDataFavorite?         StorySortFilterFavorite                 { get; set; }
        public StorySortFilterSaveDataSearch?           StorySortFilterSearch                   { get; set; }
        public NotificationSaveData?                    Notification                            { get; set; }
        public NotificationSettingsSaveData?            NotificationSettings                    { get; set; }

        public static LegacySaveDataContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacySaveDataContainer() { Pointer= p0 };

            value.LoginUser                                 = GetObject<LoginUserData>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginUserData.FromPointer); // 0245A3A70020 0x18 LoginUser                   ( 0001865BC9A0 ModelClassType LoginUserData LoginUserData LoginUserData Pointer )
            value.NonLoginUser                              = GetObject<NonLoginUserData>(new IntPtr(p + 0x020), ReversePrism.DataModels.NonLoginUserData.FromPointer); // 0245A3A70040 0x20 NonLoginUser                ( 0001866A6B60 ModelClassType NonLoginUserData NonLoginUserData NonLoginUserData Pointer )
            value.Badge                                     = GetObject<BadgeSaveData>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeSaveData.FromPointer); // 0245A3A70060 0x28 Badge                       ( 000186736D10 ModelClassType BadgeSaveData BadgeSaveData BadgeSaveData Pointer )
            value.HowToPlayPopup                            = GetObject<HowToPlayPopupSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.HowToPlayPopupSaveData.FromPointer); // 0245A3A70080 0x30 HowToPlayPopup              ( 0001866D9F90 ModelClassType HowToPlayPopupSaveData HowToPlayPopupSaveData HowToPlayPopupSaveData Pointer )
            value.RhythmGameOption                          = GetObject<RhythmGameOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0245A3A700A0 0x38 RhythmGameOption            ( 000186685E40 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.UnitMemberChangeView                      = GetObject<UnitMemberChangeViewSaveData>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitMemberChangeViewSaveData.FromPointer); // 0245A3A700C0 0x40 UnitMemberChangeView        ( 00018670E6E0 ModelClassType UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData UnitMemberChangeViewSaveData Pointer )
            value.ComboInfoView                             = GetObject<ComboInfoViewSaveData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ComboInfoViewSaveData.FromPointer); // 0245A3A700E0 0x48 ComboInfoView               ( 0001865DE1D0 ModelClassType ComboInfoViewSaveData ComboInfoViewSaveData ComboInfoViewSaveData Pointer )
            value.LiveCostumeChange                         = GetObject<LiveCostumeChangeSaveData>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveCostumeChangeSaveData.FromPointer); // 0245A3A70100 0x50 LiveCostumeChange           ( 000186549620 ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer )
            value.CasualCostumeChange                       = GetObject<LiveCostumeChangeSaveData>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveCostumeChangeSaveData.FromPointer); // 0245A3A70120 0x58 CasualCostumeChange         ( 000186549620 ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer )
            value.LiveMVOption                              = GetObject<LiveMVOption>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveMVOption.FromPointer); // 0245A3A70140 0x60 LiveMVOption                ( 00018655B880 ModelClassType LiveMVOption LiveMVOption LiveMVOption Pointer )
            value.LiveToken                                 = GetObject<LiveTokenSaveData>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveTokenSaveData.FromPointer); // 0245A3A70160 0x68 LiveToken                   ( 0001865879E0 ModelClassType LiveTokenSaveData LiveTokenSaveData LiveTokenSaveData Pointer )
            value.LiveMVUnitConfirmation                    = GetObject<LiveMVUnitConfirmationSaveData>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveMVUnitConfirmationSaveData.FromPointer); // 0245A3A70180 0x70 LiveMVUnitConfirmation      ( 00018655EE40 ModelClassType LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData Pointer )
            value.LiveMusicSelection                        = GetObject<LiveMusicSelectionSaveData>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveMusicSelectionSaveData.FromPointer); // 0245A3A701A0 0x78 LiveMusicSelection          ( 0001865661F0 ModelClassType LiveMusicSelectionSaveData LiveMusicSelectionSaveData LiveMusicSelectionSaveData Pointer )
            value.UnitEditView                              = GetObject<UnitEditViewSaveData>(new IntPtr(p + 0x080), ReversePrism.DataModels.UnitEditViewSaveData.FromPointer); // 0245A3A701C0 0x80 UnitEditView                ( 00018670BC20 ModelClassType UnitEditViewSaveData UnitEditViewSaveData UnitEditViewSaveData Pointer )
            value.LiveUnitConfirmation                      = GetObject<LiveUnitConfirmationSaveData>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveUnitConfirmationSaveData.FromPointer); // 0245A3A701E0 0x88 LiveUnitConfirmation        ( 00018658A9F0 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer )
            value.LiveUnitMemberChange                      = GetObject<LiveUnitMemberChangeSaveData>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveUnitMemberChangeSaveData.FromPointer); // 0245A3A70200 0x90 LiveUnitMemberChange        ( 000186595FD0 ModelClassType LiveUnitMemberChangeSaveData LiveUnitMemberChangeSaveData LiveUnitMemberChangeSaveData Pointer )
            value.IdolListFUSortFilter                      = GetObject<IdolListFUSortFilterSaveData>(new IntPtr(p + 0x098), ReversePrism.DataModels.IdolListFUSortFilterSaveData.FromPointer); // 0245A3A70220 0x98 IdolListFUSortFilter        ( 0001866B2640 ModelClassType IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData Pointer )
            value.MissionFilter                             = GetObject<MissionFilterSaveData>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MissionFilterSaveData.FromPointer); // 0245A3A70240 0xA0 MissionFilter               ( 000186620FC0 ModelClassType MissionFilterSaveData MissionFilterSaveData MissionFilterSaveData Pointer )
            value.Option                                    = GetObject<OptionLocalSave>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.OptionLocalSave.FromPointer); // 0245A3A70260 0xA8 Option                      ( 0001866E7540 ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer )
            value.Shop                                      = GetObject<ShopLocalSave>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ShopLocalSave.FromPointer); // 0245A3A70280 0xB0 Shop                        ( 000186762480 ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer )
            value.Personal                                  = GetObject<PersonalLocalSave>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PersonalLocalSave.FromPointer); // 0245A3A702A0 0xB8 Personal                    ( 000186738130 ModelClassType PersonalLocalSave PersonalLocalSave PersonalLocalSave Pointer )
            value.Purchase                                  = GetObject<PurchaseLocalSave>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.PurchaseLocalSave.FromPointer); // 0245A3A702C0 0xC0 Purchase                    ( 0001865DDC50 ModelClassType PurchaseLocalSave PurchaseLocalSave PurchaseLocalSave Pointer )
            value.Exchange                                  = GetObject<ExchangeSaveData>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ExchangeSaveData.FromPointer); // 0245A3A702E0 0xC8 Exchange                    ( 000186517230 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer )
            value.PrivacyOptionAgreement                    = GetObject<PrivacyOptionAgreementSaveData>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.PrivacyOptionAgreementSaveData.FromPointer); // 0245A3A70300 0xD0 PrivacyOptionAgreement      ( 0001865198B0 ModelClassType PrivacyOptionAgreementSaveData PrivacyOptionAgreementSaveData PrivacyOptionAgreementSaveData Pointer )
            value.Gasha                                     = GetObject<GashaLocalSave>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GashaLocalSave.FromPointer); // 0245A3A70320 0xD8 Gasha                       ( 000186606B60 ModelClassType GashaLocalSave GashaLocalSave GashaLocalSave Pointer )
            value.GashaDetailsTab                           = GetObject<GashaDetailsTabSave>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GashaDetailsTabSave.FromPointer); // 0245A3A70340 0xE0 GashaDetailsTab             ( 0001865F9B80 ModelClassType GashaDetailsTabSave GashaDetailsTabSave GashaDetailsTabSave Pointer )
            value.GashaExchangeExpiryDateInfo               = GetObject<GashaExchangeExpiryDateInfoSave>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GashaExchangeExpiryDateInfoSave.FromPointer); // 0245A3A70360 0xE8 GashaExchangeExpiryDateInfo ( 000186600830 ModelClassType GashaExchangeExpiryDateInfoSave GashaExchangeExpiryDateInfoSave GashaExchangeExpiryDateInfoSave Pointer )
            value.ProduceOption                             = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0245A3A70380 0xF0 ProduceOption               ( 0001865618D0 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )
            value.ProduceTutorial                           = GetObject<ProduceTutorialSaveData>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProduceTutorialSaveData.FromPointer); // 0245A3A703A0 0xF8 ProduceTutorial             ( 000186591610 ModelClassType ProduceTutorialSaveData ProduceTutorialSaveData ProduceTutorialSaveData Pointer )
            value.ProducePreparationEpisodeSelect           = GetObject<ProducePreparationEpisodeSelectSaveData>(new IntPtr(p + 0x100), ReversePrism.DataModels.ProducePreparationEpisodeSelectSaveData.FromPointer); // 0245A3A703C0 0x100 ProducePreparationEpisodeSelect ( 00018656B3C0 ModelClassType ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData Pointer )
            value.StorySortFilterFavorite                   = GetObject<StorySortFilterSaveDataFavorite>(new IntPtr(p + 0x108), ReversePrism.DataModels.StorySortFilterSaveDataFavorite.FromPointer); // 0245A3A703E0 0x108 StorySortFilterFavorite     ( 0001865A3010 ModelClassType StorySortFilterSaveDataFavorite StorySortFilterSaveDataFavorite StorySortFilterSaveDataFavorite Pointer )
            value.StorySortFilterSearch                     = GetObject<StorySortFilterSaveDataSearch>(new IntPtr(p + 0x110), ReversePrism.DataModels.StorySortFilterSaveDataSearch.FromPointer); // 0245A3A70400 0x110 StorySortFilterSearch       ( 0001865A3520 ModelClassType StorySortFilterSaveDataSearch StorySortFilterSaveDataSearch StorySortFilterSaveDataSearch Pointer )
            value.Notification                              = GetObject<NotificationSaveData>(new IntPtr(p + 0x118), ReversePrism.DataModels.NotificationSaveData.FromPointer); // 0245A3A70420 0x118 Notification                ( 0001866B4790 ModelClassType NotificationSaveData NotificationSaveData NotificationSaveData Pointer )
            value.NotificationSettings                      = GetObject<NotificationSettingsSaveData>(new IntPtr(p + 0x120), ReversePrism.DataModels.NotificationSettingsSaveData.FromPointer); // 0245A3A70440 0x120 NotificationSettings        ( 0001866B53A0 ModelClassType NotificationSettingsSaveData NotificationSettingsSaveData NotificationSettingsSaveData Pointer )

            return value;
        }
    }
}
