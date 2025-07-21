using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EpisodeName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DifficultyIcons                          ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 EpisodeDetailButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 AutoPlayInfoText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 SubSeasonDetailButton                    ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 SubSeasonCheckOn                         ModelClassType GameObject GameObject GameObject Pointer
    // 050 SubSeasonCheckOff                        ModelClassType GameObject GameObject GameObject Pointer
    // 058 UnitIdolButtonArray                      ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer
    // 060 SupportButtonArray                       ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 068 FriendButton                             ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 070 SupportConfirmButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 078 FUnitIconEmptyButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 080 FUnitObjectRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 088 InheritanceFUnitIcon                     ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 090 InheritanceEmptyObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 098 InheritanceFullObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 InheritanceCount                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 VodaviRankView                           ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 0B0 CostText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 AutoSettingButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 0C0 AutoPlayToggle                           ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 0C8 StaminaUsageButton                       ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 StaminaUsageStatusText                   ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 0D8 ConfirmHowToPlayButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 HowToPlayManualKey                       ModelPrimitiveType string string string String
    // 0E8 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 0F0 StartButtonStText                        ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 0F8 ConfirmMessage                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 100 StaminaGaugeView                         ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer
    // 108 StaminaRecoverButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 110 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 118 FooterBackGround                         ModelClassType UIImage UIImage UIImage Pointer
    // 120 autoPlayToggleSubject                    Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 128 onClickPIdolIconSubject                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 130 onClickSCharaIconSubject                 Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 138 onClickInheritanceFUnitIconSubject       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 140 onLongPressInheritanceFUnitIconSubject   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 148 onClickBackSubject                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceConfirmView : DataModel
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
        public StaminaRecoveryTypeItemPanelView?        StaminaGaugeView                        { get; set; }
        public UIButton?                                StaminaRecoverButton                    { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public UIImage?                                 FooterBackGround                        { get; set; }

        public static ProduceConfirmView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmView() { Pointer= p0 };

            value.EpisodeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 EpisodeName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyIcons                           = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 DifficultyIcons             ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EpisodeDetailButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 EpisodeDetailButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AutoPlayInfoText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 AutoPlayInfoText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SubSeasonDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 SubSeasonDetailButton       ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SubSeasonCheckOn                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 SubSeasonCheckOn            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SubSeasonCheckOff                         = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SubSeasonCheckOff           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UnitIdolButtonArray                       = GetObjectList<PFIdolIconRectView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x58 UnitIdolButtonArray         ( ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x60 SupportButtonArray          ( ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendButton                              = GetObject<SCharaIconView>(new IntPtr(p + 0x068), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x68 FriendButton                ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.SupportConfirmButton                      = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 SupportConfirmButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FUnitIconEmptyButton                      = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 FUnitIconEmptyButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FUnitObjectRoot                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 FUnitObjectRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceFUnitIcon                      = GetObject<FUnitIconView>(new IntPtr(p + 0x088), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x88 InheritanceFUnitIcon        ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.InheritanceEmptyObject                    = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 InheritanceEmptyObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceFullObject                     = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 InheritanceFullObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 InheritanceCount            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VodaviRankView                            = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0xA8 VodaviRankView              ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 CostText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AutoSettingButton                         = GetObject<UIButton>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIButton.FromPointer); // 0xB8 AutoSettingButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AutoPlayToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ToggleButton.FromPointer); // 0xC0 AutoPlayToggle              ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StaminaUsageButton                        = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0xC8 StaminaUsageButton          ( ModelClassType UIButton UIButton UIButton Pointer )
            value.StaminaUsageStatusText                    = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0xD0 StaminaUsageStatusText      ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConfirmHowToPlayButton                    = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0xD8 ConfirmHowToPlayButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x0E0)); // 0xE0 HowToPlayManualKey          ( ModelPrimitiveType string string string String )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIButton.FromPointer); // 0xE8 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.StartButtonStText                         = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0xF0 StartButtonStText           ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConfirmMessage                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0xF8 ConfirmMessage              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StaminaGaugeView                          = GetObject<StaminaRecoveryTypeItemPanelView>(new IntPtr(p + 0x100), ReversePrism.DataModels.StaminaRecoveryTypeItemPanelView.FromPointer); // 0x100 StaminaGaugeView            ( ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer )
            value.StaminaRecoverButton                      = GetObject<UIButton>(new IntPtr(p + 0x108), ReversePrism.DataModels.UIButton.FromPointer); // 0x108 StaminaRecoverButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x110), ReversePrism.DataModels.UIButton.FromPointer); // 0x110 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FooterBackGround                          = GetObject<UIImage>(new IntPtr(p + 0x118), ReversePrism.DataModels.UIImage.FromPointer); // 0x118 FooterBackGround            ( ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
