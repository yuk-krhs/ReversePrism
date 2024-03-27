using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EpisodeName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DifficultyIcons                          000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 EpisodeDetailButton                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 AutoPlayInfoText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 SubSeasonDetailButton                    000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 SubSeasonCheckOn                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 SubSeasonCheckOff                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 UnitIdolButtonArray                      000185B99BC0 ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer
    // 060 SupportButtonArray                       000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 068 FriendButton                             0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 070 SupportConfirmButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 FUnitIconEmptyButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 FUnitObjectRoot                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 InheritanceFUnitIcon                     00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 090 InheritanceEmptyObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 InheritanceFullObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 InheritanceCount                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 VodaviRankView                           000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 0B0 CostText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 AutoSettingButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0C0 AutoPlayToggle                           000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 0C8 StaminaUsageButton                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 StaminaUsageStatusText                   0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 0D8 ConfirmHowToPlayButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 HowToPlayManualKey                       000186671910 ModelPrimitiveType string string string String
    // 0E8 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0F0 StartButtonStText                        0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 0F8 ConfirmMessage                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 100 StaminaGaugeView                         000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 108 StaminaRecoverButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 110 FooterBackGround                         0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 118 autoSettingFactory                       PopupViewFactory`1<IProduceAutoSettingPopupView> IL2CPP_TYPE_GENERICINST
    // 120 staminaUsageFactory                      PopupViewFactory`1<IProduceStaminaUsagePopupView> IL2CPP_TYPE_GENERICINST
    // 128 supportConfirmFactory                    PopupViewFactory`1<IProduceSCharaEditConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 130 fesUnitDetailPopupViewFactory            PopupViewFactory`1<IFUnitDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 138 pIdolDetailPopupViewFactory              PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 140 supportCharaDetailPopupViewFactory       PopupViewFactory`1<ISCharaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 148 fesDataPossessionLimitPopupfactory       PopupViewFactory`1<IFesDataPossessionLimitPopupView> IL2CPP_TYPE_GENERICINST
    // 150 autoPlayToggleSubject                    Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 158 onClickPIdolIconSubject                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 160 onClickSCharaIconSubject                 Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 168 onClickInheritanceFUnitIconSubject       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 170 onLongPressInheritanceFUnitIconSubject   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceConfirmView
    {
        public UITextMeshProUGUI?                       EpisodeName                             { get; set; }
        public List<GameObject>?                        DifficultyIcons                         { get; set; }
        public ButtonBase?                              EpisodeDetailButton                     { get; set; }
        public UITextMeshProUGUI?                       AutoPlayInfoText                        { get; set; }
        public ButtonBase?                              SubSeasonDetailButton                   { get; set; }
        public GameObject?                              SubSeasonCheckOn                        { get; set; }
        public GameObject?                              SubSeasonCheckOff                       { get; set; }
        public List<PFIdolIconRectView>?                UnitIdolButtonArray                     { get; set; }
        public List<SCharaIconView>?                    SupportButtonArray                      { get; set; }
        public SCharaIconView?                          FriendButton                            { get; set; }
        public UIButton?                                SupportConfirmButton                    { get; set; }
        public UIButton?                                FUnitIconEmptyButton                    { get; set; }
        public GameObject?                              FUnitObjectRoot                         { get; set; }
        public FUnitIconView?                           InheritanceFUnitIcon                    { get; set; }
        public GameObject?                              InheritanceEmptyObject                  { get; set; }
        public GameObject?                              InheritanceFullObject                   { get; set; }
        public UITextMeshProUGUI?                       InheritanceCount                        { get; set; }
        public VoDaViMeRankView?                        VodaviRankView                          { get; set; }
        public UITextMeshProUGUI?                       CostText                                { get; set; }
        public UIButton?                                AutoSettingButton                       { get; set; }
        public ToggleButton?                            AutoPlayToggle                          { get; set; }
        public UIButton?                                StaminaUsageButton                      { get; set; }
        public TextMeshProUGUI?                         StaminaUsageStatusText                  { get; set; }
        public UIButton?                                ConfirmHowToPlayButton                  { get; set; }
        public string                                   HowToPlayManualKey                      { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public TextMeshProUGUI?                         StartButtonStText                       { get; set; }
        public TextMeshProUGUI?                         ConfirmMessage                          { get; set; }
        public StaminaRecoveryTypeItemContentView?      StaminaGaugeView                        { get; set; }
        public UIButton?                                StaminaRecoverButton                    { get; set; }
        public UIImage?                                 FooterBackGround                        { get; set; }

        public static ProduceConfirmView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmView();

            value.EpisodeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1328A0 0x20 EpisodeName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyIcons                           = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1328C0 0x28 DifficultyIcons             ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EpisodeDetailButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DA1328E0 0x30 EpisodeDetailButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AutoPlayInfoText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA132900 0x38 AutoPlayInfoText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SubSeasonDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DA132920 0x40 SubSeasonDetailButton       ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SubSeasonCheckOn                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA132940 0x48 SubSeasonCheckOn            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SubSeasonCheckOff                         = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA132960 0x50 SubSeasonCheckOff           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnitIdolButtonArray                       = GetObjectList<PFIdolIconRectView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270DA132980 0x58 UnitIdolButtonArray         ( 000185B99BC0 ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DA1329A0 0x60 SupportButtonArray          ( 000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendButton                              = GetObject<SCharaIconView>(new IntPtr(p + 0x068), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DA1329C0 0x68 FriendButton                ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.SupportConfirmButton                      = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1329E0 0x70 SupportConfirmButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FUnitIconEmptyButton                      = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA132A00 0x78 FUnitIconEmptyButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FUnitObjectRoot                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA132A20 0x80 FUnitObjectRoot             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceFUnitIcon                      = GetObject<FUnitIconView>(new IntPtr(p + 0x088), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0270DA132A40 0x88 InheritanceFUnitIcon        ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.InheritanceEmptyObject                    = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA132A60 0x90 InheritanceEmptyObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceFullObject                     = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA132A80 0x98 InheritanceFullObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA132AA0 0xA0 InheritanceCount            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VodaviRankView                            = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0270DA132AC0 0xA8 VodaviRankView              ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA132AE0 0xB0 CostText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AutoSettingButton                         = GetObject<UIButton>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA132B00 0xB8 AutoSettingButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AutoPlayToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA132B20 0xC0 AutoPlayToggle              ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StaminaUsageButton                        = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA132B40 0xC8 StaminaUsageButton          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.StaminaUsageStatusText                    = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DA132B60 0xD0 StaminaUsageStatusText      ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConfirmHowToPlayButton                    = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA132B80 0xD8 ConfirmHowToPlayButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x0E0)); // 0270DA132BA0 0xE0 HowToPlayManualKey          ( 000186671910 ModelPrimitiveType string string string String )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA132BC0 0xE8 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.StartButtonStText                         = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DA132BE0 0xF0 StartButtonStText           ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConfirmMessage                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DA132C00 0xF8 ConfirmMessage              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StaminaGaugeView                          = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x100), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 0270DA132C20 0x100 StaminaGaugeView            ( 000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.StaminaRecoverButton                      = GetObject<UIButton>(new IntPtr(p + 0x108), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA132C40 0x108 StaminaRecoverButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FooterBackGround                          = GetObject<UIImage>(new IntPtr(p + 0x110), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA132C60 0x110 FooterBackGround            ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
