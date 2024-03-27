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
    // 038 SkillIconButtonArray                     000185B8ABD0 ModelClassListType IdolSkillIconView[] IdolSkillIconView[] List<IdolSkillIconView> Pointer
    // 040 IdolStatusArray                          000185CC5BE8 ModelClassListType StatusInfo[] StatusInfo[] List<StatusInfo> Pointer
    // 048 IdolTapAreaViews                         000185B8B0A0 ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer
    // 050 IdolParentObjctArray                     000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 TotalVo                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TotalDa                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TotalVi                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TotalHP                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 TotalCost                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 TotalVoRank                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 088 TotalDaRank                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 090 TotalViRank                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 098 TotalMeRank                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0A0 SupportUnitButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0A8 EmptySupportButtonArray                  000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    // 0B0 SupportButtonArray                       000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 0B8 EmptyFriendButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0C0 FriendButton                             0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 0C8 FooterBackGround                         0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 0D0 Particle                                 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 0D8 PageAnimationTarget                      000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 0E0 PageAnimationHideTarget                  000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 0E8 PageAnimationDistance                    0001866656B0 ModelPrimitiveType float float float Single
    // 0EC PageAnimationTime                        0001866656B0 ModelPrimitiveType float float float Single
    // 0F0 StartButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F8 StartButtonStText                        0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 100 SubSeasonDetailButton                    000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 108 SubSeasonCheckOn                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 110 SubSeasonCheckOff                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 118 InheritanceFUButton                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 120 StaminaUsageButton                       000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 128 RightPageButton                          000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 130 LeftPageButton                           000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 138 InheritanceFUStatusText                  0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 140 InheritanceButtonGrayOut                 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 148 InheritanceButtonOn                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 150 InheritanceButtonOff                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 158 AutoSettingButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 160 AutoPlayToggle                           000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 168 ProducePreparationIdolSkillSelectPopupCaller 00018656E630 ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer
    // 170 AutoSettingPopupCaller                   000186531460 ModelClassType ProduceAutoSettingPopupCaller ProduceAutoSettingPopupCaller ProduceAutoSettingPopupCaller Pointer
    // 178 StaminaUsagePopupCaller                  000186581880 ModelClassType ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller Pointer
    // 180 StaminaUsageStatusText                   0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 188 UnitNameText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 190 ConfirmHowToPlayButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 198 UnitNameEditButton                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 1A0 HowToPlayManualKey                       000186671910 ModelPrimitiveType string string string String
    // 1A8 FesDataPossessionLimitPopupCaller        000186777820 ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer
    // 1B0 SubSeasonDetailContentViewModel          0001865D4BF0 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer
    // 1B8 HowToPlayProduceManualData               0001866DA470 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    // 1C0 onClickIdol                              Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 1C8 onLongClickIdol                          Subject`1<ValueTuple`2<int, ProduceIdolModel>> IL2CPP_TYPE_GENERICINST
    // 1D0 onClickIdolSkillIcon                     Subject`1<ValueTuple`2<int, ProduceIdolModel>> IL2CPP_TYPE_GENERICINST
    // 1D8 autoPlayToggleSubject                    Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 1E0 onClickConfirmHowToPlayButton            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1E8 onClickUnitNameEditButton                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1F0 ButtonDisposables                        0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 1F8 OnClickStart                             000186679A00 ModelClassType Action Action Action Pointer
    // 200 OnClickEpisodeDetail                     000186679A00 ModelClassType Action Action Action Pointer
    // 208 OnCkickSupportEdit                       000186679A00 ModelClassType Action Action Action Pointer
    // 210 OnClickSupport                           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 218 OnLongClickSupport                       Action`2<SupportCharacterModel, int> IL2CPP_TYPE_GENERICINST
    // 220 OnClickFriendSupport                     000186679A00 ModelClassType Action Action Action Pointer
    // 228 OnLongClickFriendSupport                 Action`1<FriendSupportModel> IL2CPP_TYPE_GENERICINST
    // 230 OnClickSubSeasonButton                   000186679A00 ModelClassType Action Action Action Pointer
    // 238 OnClickInheritanceFU                     000186679A00 ModelClassType Action Action Action Pointer
    // 240 OnClickStaminaUsage                      000186679A00 ModelClassType Action Action Action Pointer
    // 248 OnPageMove                               Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ViewProducePreparationIdolSelectView
    {
        public UITextMeshProUGUI?                       EpisodeName                             { get; set; }
        public List<GameObject>?                        DifficultyIcons                         { get; set; }
        public ButtonBase?                              EpisodeDetailButton                     { get; set; }
        public List<IdolSkillIconView>?                 SkillIconButtonArray                    { get; set; }
        public List<StatusInfo>?                        IdolStatusArray                         { get; set; }
        public List<IdolTapAreaView>?                   IdolTapAreaViews                        { get; set; }
        public List<GameObject>?                        IdolParentObjctArray                    { get; set; }
        public UITextMeshProUGUI?                       TotalVo                                 { get; set; }
        public UITextMeshProUGUI?                       TotalDa                                 { get; set; }
        public UITextMeshProUGUI?                       TotalVi                                 { get; set; }
        public UITextMeshProUGUI?                       TotalHP                                 { get; set; }
        public UITextMeshProUGUI?                       TotalCost                               { get; set; }
        public UIRawImage?                              TotalVoRank                             { get; set; }
        public UIRawImage?                              TotalDaRank                             { get; set; }
        public UIRawImage?                              TotalViRank                             { get; set; }
        public UIRawImage?                              TotalMeRank                             { get; set; }
        public UIButton?                                SupportUnitButton                       { get; set; }
        public List<UIButton>?                          EmptySupportButtonArray                 { get; set; }
        public List<SCharaIconView>?                    SupportButtonArray                      { get; set; }
        public UIButton?                                EmptyFriendButton                       { get; set; }
        public SCharaIconView?                          FriendButton                            { get; set; }
        public UIImage?                                 FooterBackGround                        { get; set; }
        public ParticleSystem?                          Particle                                { get; set; }
        public List<CanvasGroup>?                       PageAnimationTarget                     { get; set; }
        public List<CanvasGroup>?                       PageAnimationHideTarget                 { get; set; }
        public float                                    PageAnimationDistance                   { get; set; }
        public float                                    PageAnimationTime                       { get; set; }
        public ButtonBase?                              StartButton                             { get; set; }
        public TextMeshProUGUI?                         StartButtonStText                       { get; set; }
        public ButtonBase?                              SubSeasonDetailButton                   { get; set; }
        public GameObject?                              SubSeasonCheckOn                        { get; set; }
        public GameObject?                              SubSeasonCheckOff                       { get; set; }
        public ButtonBase?                              InheritanceFUButton                     { get; set; }
        public ButtonBase?                              StaminaUsageButton                      { get; set; }
        public ButtonBase?                              RightPageButton                         { get; set; }
        public ButtonBase?                              LeftPageButton                          { get; set; }
        public TextMeshProUGUI?                         InheritanceFUStatusText                 { get; set; }
        public UIGrayOutController?                     InheritanceButtonGrayOut                { get; set; }
        public GameObject?                              InheritanceButtonOn                     { get; set; }
        public GameObject?                              InheritanceButtonOff                    { get; set; }
        public UIButton?                                AutoSettingButton                       { get; set; }
        public ToggleButton?                            AutoPlayToggle                          { get; set; }
        public ProducePreparationIdolSkillSelectPopupCaller? ProducePreparationIdolSkillSelectPopupCaller { get; set; }
        public ProduceAutoSettingPopupCaller?           AutoSettingPopupCaller                  { get; set; }
        public ProduceStaminaUsagePopupCaller?          StaminaUsagePopupCaller                 { get; set; }
        public TextMeshProUGUI?                         StaminaUsageStatusText                  { get; set; }
        public TextMeshProUGUI?                         UnitNameText                            { get; set; }
        public UIButton?                                ConfirmHowToPlayButton                  { get; set; }
        public UIButton?                                UnitNameEditButton                      { get; set; }
        public string                                   HowToPlayManualKey                      { get; set; }
        public IFesDataPossessionLimitPopupCaller?      FesDataPossessionLimitPopupCaller       { get; set; }
        public SubSeasonDetailContentViewModel?         SubSeasonDetailContentViewModel         { get; set; }
        public HowToPlayProduceManualData?              HowToPlayProduceManualData              { get; set; }
        public CompositeDisposable?                     ButtonDisposables                       { get; set; }
        public Action?                                  OnClickStart                            { get; set; }
        public Action?                                  OnClickEpisodeDetail                    { get; set; }
        public Action?                                  OnCkickSupportEdit                      { get; set; }
        public Action?                                  OnClickFriendSupport                    { get; set; }
        public Action?                                  OnClickSubSeasonButton                  { get; set; }
        public Action?                                  OnClickInheritanceFU                    { get; set; }
        public Action?                                  OnClickStaminaUsage                     { get; set; }

        public static ViewProducePreparationIdolSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationIdolSelectView();

            value.EpisodeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A66F58 0x20 EpisodeName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyIcons                           = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A66F78 0x28 DifficultyIcons             ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EpisodeDetailButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5A66F98 0x30 EpisodeDetailButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SkillIconButtonArray                      = GetObjectList<IdolSkillIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270D5A66FB8 0x38 SkillIconButtonArray        ( 000185B8ABD0 ModelClassListType IdolSkillIconView[] IdolSkillIconView[] List<IdolSkillIconView> Pointer )
            value.IdolStatusArray                           = GetObjectList<StatusInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.StatusInfo.FromPointer); // 0270D5A66FD8 0x40 IdolStatusArray             ( 000185CC5BE8 ModelClassListType StatusInfo[] StatusInfo[] List<StatusInfo> Pointer )
            value.IdolTapAreaViews                          = GetObjectList<IdolTapAreaView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolTapAreaView.FromPointer); // 0270D5A66FF8 0x48 IdolTapAreaViews            ( 000185B8B0A0 ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer )
            value.IdolParentObjctArray                      = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A67018 0x50 IdolParentObjctArray        ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TotalVo                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A67038 0x58 TotalVo                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalDa                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A67058 0x60 TotalDa                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalVi                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A67078 0x68 TotalVi                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalHP                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A67098 0x70 TotalHP                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalCost                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A670B8 0x78 TotalCost                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalVoRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5A670D8 0x80 TotalVoRank                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TotalDaRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5A670F8 0x88 TotalDaRank                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TotalViRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5A67118 0x90 TotalViRank                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TotalMeRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5A67138 0x98 TotalMeRank                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SupportUnitButton                         = GetObject<UIButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A67158 0xA0 SupportUnitButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EmptySupportButtonArray                   = GetObjectList<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A67178 0xA8 EmptySupportButtonArray     ( 000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D5A67198 0xB0 SupportButtonArray          ( 000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.EmptyFriendButton                         = GetObject<UIButton>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A671B8 0xB8 EmptyFriendButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FriendButton                              = GetObject<SCharaIconView>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D5A671D8 0xC0 FriendButton                ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FooterBackGround                          = GetObject<UIImage>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5A671F8 0xC8 FooterBackGround            ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Particle                                  = GetObject<ParticleSystem>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D5A67218 0xD0 Particle                    ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.PageAnimationTarget                       = GetObjectList<CanvasGroup>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5A67238 0xD8 PageAnimationTarget         ( 000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationHideTarget                   = GetObjectList<CanvasGroup>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5A67258 0xE0 PageAnimationHideTarget     ( 000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationDistance                     = GetSingle(new IntPtr(p + 0x0E8)); // 0270D5A67278 0xE8 PageAnimationDistance       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PageAnimationTime                         = GetSingle(new IntPtr(p + 0x0EC)); // 0270D5A67298 0xEC PageAnimationTime           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StartButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5A672B8 0xF0 StartButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StartButtonStText                         = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D5A672D8 0xF8 StartButtonStText           ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.SubSeasonDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x100), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5A672F8 0x100 SubSeasonDetailButton       ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SubSeasonCheckOn                          = GetObject<GameObject>(new IntPtr(p + 0x108), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A67318 0x108 SubSeasonCheckOn            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SubSeasonCheckOff                         = GetObject<GameObject>(new IntPtr(p + 0x110), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A67338 0x110 SubSeasonCheckOff           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceFUButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x118), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5A67358 0x118 InheritanceFUButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StaminaUsageButton                        = GetObject<ButtonBase>(new IntPtr(p + 0x120), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5A67378 0x120 StaminaUsageButton          ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RightPageButton                           = GetObject<ButtonBase>(new IntPtr(p + 0x128), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5A67398 0x128 RightPageButton             ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LeftPageButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x130), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5A673B8 0x130 LeftPageButton              ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.InheritanceFUStatusText                   = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x138), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D5A673D8 0x138 InheritanceFUStatusText     ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.InheritanceButtonGrayOut                  = GetObject<UIGrayOutController>(new IntPtr(p + 0x140), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D5A673F8 0x140 InheritanceButtonGrayOut    ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.InheritanceButtonOn                       = GetObject<GameObject>(new IntPtr(p + 0x148), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A67418 0x148 InheritanceButtonOn         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InheritanceButtonOff                      = GetObject<GameObject>(new IntPtr(p + 0x150), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A67438 0x150 InheritanceButtonOff        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AutoSettingButton                         = GetObject<UIButton>(new IntPtr(p + 0x158), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A67458 0x158 AutoSettingButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AutoPlayToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x160), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5A67478 0x160 AutoPlayToggle              ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ProducePreparationIdolSkillSelectPopupCaller = GetObject<ProducePreparationIdolSkillSelectPopupCaller>(new IntPtr(p + 0x168), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupCaller.FromPointer); // 0270D5A67498 0x168 ProducePreparationIdolSkillSelectPopupCaller ( 00018656E630 ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer )
            value.AutoSettingPopupCaller                    = GetObject<ProduceAutoSettingPopupCaller>(new IntPtr(p + 0x170), ReversePrism.DataModels.ProduceAutoSettingPopupCaller.FromPointer); // 0270D5A674B8 0x170 AutoSettingPopupCaller      ( 000186531460 ModelClassType ProduceAutoSettingPopupCaller ProduceAutoSettingPopupCaller ProduceAutoSettingPopupCaller Pointer )
            value.StaminaUsagePopupCaller                   = GetObject<ProduceStaminaUsagePopupCaller>(new IntPtr(p + 0x178), ReversePrism.DataModels.ProduceStaminaUsagePopupCaller.FromPointer); // 0270D5A674D8 0x178 StaminaUsagePopupCaller     ( 000186581880 ModelClassType ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller Pointer )
            value.StaminaUsageStatusText                    = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x180), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D5A674F8 0x180 StaminaUsageStatusText      ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.UnitNameText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x188), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D5A67518 0x188 UnitNameText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConfirmHowToPlayButton                    = GetObject<UIButton>(new IntPtr(p + 0x190), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A67538 0x190 ConfirmHowToPlayButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UnitNameEditButton                        = GetObject<UIButton>(new IntPtr(p + 0x198), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A67558 0x198 UnitNameEditButton          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x1A0)); // 0270D5A67578 0x1A0 HowToPlayManualKey          ( 000186671910 ModelPrimitiveType string string string String )
            value.FesDataPossessionLimitPopupCaller         = GetObject<IFesDataPossessionLimitPopupCaller>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.IFesDataPossessionLimitPopupCaller.FromPointer); // 0270D5A67598 0x1A8 FesDataPossessionLimitPopupCaller ( 000186777820 ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer )
            value.SubSeasonDetailContentViewModel           = GetObject<SubSeasonDetailContentViewModel>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.SubSeasonDetailContentViewModel.FromPointer); // 0270D5A675B8 0x1B0 SubSeasonDetailContentViewModel ( 0001865D4BF0 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer )
            value.HowToPlayProduceManualData                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0270D5A675D8 0x1B8 HowToPlayProduceManualData  ( 0001866DA470 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )
            value.ButtonDisposables                         = GetObject<CompositeDisposable>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5A676B8 0x1F0 ButtonDisposables           ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.OnClickStart                              = GetObject<Action>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Action.FromPointer); // 0270D5A676D8 0x1F8 OnClickStart                ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnClickEpisodeDetail                      = GetObject<Action>(new IntPtr(p + 0x200), ReversePrism.DataModels.Action.FromPointer); // 0270D5A676F8 0x200 OnClickEpisodeDetail        ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnCkickSupportEdit                        = GetObject<Action>(new IntPtr(p + 0x208), ReversePrism.DataModels.Action.FromPointer); // 0270D5A67718 0x208 OnCkickSupportEdit          ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnClickFriendSupport                      = GetObject<Action>(new IntPtr(p + 0x220), ReversePrism.DataModels.Action.FromPointer); // 0270D5A67778 0x220 OnClickFriendSupport        ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnClickSubSeasonButton                    = GetObject<Action>(new IntPtr(p + 0x230), ReversePrism.DataModels.Action.FromPointer); // 0270D5A677B8 0x230 OnClickSubSeasonButton      ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnClickInheritanceFU                      = GetObject<Action>(new IntPtr(p + 0x238), ReversePrism.DataModels.Action.FromPointer); // 0270D5A677D8 0x238 OnClickInheritanceFU        ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.OnClickStaminaUsage                       = GetObject<Action>(new IntPtr(p + 0x240), ReversePrism.DataModels.Action.FromPointer); // 0270D5A677F8 0x240 OnClickStaminaUsage         ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
