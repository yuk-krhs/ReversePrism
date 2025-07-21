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
    // 038 SkillIconButtonArray                     ModelClassListType IdolSkillIconView[] IdolSkillIconView[] List<IdolSkillIconView> Pointer
    // 040 IdolStatusArray                          ModelClassListType StatusInfo[] StatusInfo[] List<StatusInfo> Pointer
    // 048 IdolTapAreaViews                         ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer
    // 050 IdolParentObjctArray                     ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 TotalVo                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TotalDa                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TotalVi                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TotalHP                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 TotalCost                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 TotalVoRank                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 088 TotalDaRank                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 090 TotalViRank                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 098 TotalMeRank                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0A0 SupportUnitButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 0A8 EmptySupportButtonArray                  ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    // 0B0 SupportButtonArray                       ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 0B8 FooterBackGround                         ModelClassType UIImage UIImage UIImage Pointer
    // 0C0 Particle                                 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 0C8 PageAnimationTarget                      ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 0D0 PageAnimationHideTarget                  ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 0D8 PageAnimationDistance                    ModelPrimitiveType float float float Single
    // 0DC PageAnimationTime                        ModelPrimitiveType float float float Single
    // 0E0 StartButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0E8 StartButtonStText                        ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 0F0 SubSeasonDetailButton                    ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F8 SubSeasonCheckOn                         ModelClassType GameObject GameObject GameObject Pointer
    // 100 SubSeasonCheckOff                        ModelClassType GameObject GameObject GameObject Pointer
    // 108 RightPageButton                          ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 110 LeftPageButton                           ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 118 ProducePreparationIdolSkillSelectPopupCaller ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer
    // 120 StaminaUsagePopupCaller                  ModelClassType ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller Pointer
    // 128 StaminaUsageStatusText                   ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 130 UnitNameText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 138 ConfirmHowToPlayButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 140 UnitNameEditButton                       ModelClassType UIButton UIButton UIButton Pointer
    // 148 HowToPlayManualKey                       ModelPrimitiveType string string string String
    // 150 FesDataPossessionLimitPopupCaller        ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer
    // 158 SubSeasonDetailContentViewModel          ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer
    // 160 HowToPlayProduceManualData               ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    // 168 onClickIdol                              Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 170 onLongClickIdol                          Subject`1<ValueTuple`2<int, ProduceIdolModel>> IL2CPP_TYPE_GENERICINST
    // 178 onClickIdolSkillIcon                     Subject`1<ValueTuple`2<int, ProduceIdolModel>> IL2CPP_TYPE_GENERICINST
    // 180 autoPlayToggleSubject                    Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 188 onClickConfirmHowToPlayButton            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 190 onClickUnitNameEditButton                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 198 ButtonDisposables                        ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 1A0 OnClickStart                             ModelClassType Action Action Action Pointer
    // 1A8 OnClickEpisodeDetail                     ModelClassType Action Action Action Pointer
    // 1B0 OnCkickSupportEdit                       ModelClassType Action Action Action Pointer
    // 1B8 OnClickSupport                           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 1C0 OnLongClickSupport                       Action`2<SupportCharacterModel, int> IL2CPP_TYPE_GENERICINST
    // 1C8 OnClickSubSeasonButton                   ModelClassType Action Action Action Pointer
    // 1D0 OnPageMove                               Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ViewProducePreparationIdolSelectView : DataModel
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
        public ButtonBase?                              RightPageButton                         { get; set; }
        public ButtonBase?                              LeftPageButton                          { get; set; }
        public ProducePreparationIdolSkillSelectPopupCaller? ProducePreparationIdolSkillSelectPopupCaller { get; set; }
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
        public Action?                                  OnClickSubSeasonButton                  { get; set; }

        public static ViewProducePreparationIdolSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationIdolSelectView() { Pointer= p0 };

            value.EpisodeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 EpisodeName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyIcons                           = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 DifficultyIcons             ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EpisodeDetailButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 EpisodeDetailButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SkillIconButtonArray                      = GetObjectList<IdolSkillIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x38 SkillIconButtonArray        ( ModelClassListType IdolSkillIconView[] IdolSkillIconView[] List<IdolSkillIconView> Pointer )
            value.IdolStatusArray                           = GetObjectList<StatusInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.StatusInfo.FromPointer); // 0x40 IdolStatusArray             ( ModelClassListType StatusInfo[] StatusInfo[] List<StatusInfo> Pointer )
            value.IdolTapAreaViews                          = GetObjectList<IdolTapAreaView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolTapAreaView.FromPointer); // 0x48 IdolTapAreaViews            ( ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer )
            value.IdolParentObjctArray                      = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 IdolParentObjctArray        ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TotalVo                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TotalVo                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalDa                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TotalDa                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalVi                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TotalVi                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalHP                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TotalHP                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalCost                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 TotalCost                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalVoRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x80 TotalVoRank                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TotalDaRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x88 TotalDaRank                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TotalViRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x90 TotalViRank                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TotalMeRank                               = GetObject<UIRawImage>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x98 TotalMeRank                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SupportUnitButton                         = GetObject<UIButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIButton.FromPointer); // 0xA0 SupportUnitButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EmptySupportButtonArray                   = GetObjectList<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 0xA8 EmptySupportButtonArray     ( ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0xB0 SupportButtonArray          ( ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FooterBackGround                          = GetObject<UIImage>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UIImage.FromPointer); // 0xB8 FooterBackGround            ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Particle                                  = GetObject<ParticleSystem>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0xC0 Particle                    ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.PageAnimationTarget                       = GetObjectList<CanvasGroup>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xC8 PageAnimationTarget         ( ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationHideTarget                   = GetObjectList<CanvasGroup>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xD0 PageAnimationHideTarget     ( ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationDistance                     = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 PageAnimationDistance       ( ModelPrimitiveType float float float Single )
            value.PageAnimationTime                         = GetSingle(new IntPtr(p + 0x0DC)); // 0xDC PageAnimationTime           ( ModelPrimitiveType float float float Single )
            value.StartButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xE0 StartButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StartButtonStText                         = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0xE8 StartButtonStText           ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.SubSeasonDetailButton                     = GetObject<ButtonBase>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xF0 SubSeasonDetailButton       ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SubSeasonCheckOn                          = GetObject<GameObject>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.GameObject.FromPointer); // 0xF8 SubSeasonCheckOn            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SubSeasonCheckOff                         = GetObject<GameObject>(new IntPtr(p + 0x100), ReversePrism.DataModels.GameObject.FromPointer); // 0x100 SubSeasonCheckOff           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RightPageButton                           = GetObject<ButtonBase>(new IntPtr(p + 0x108), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x108 RightPageButton             ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LeftPageButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x110), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x110 LeftPageButton              ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ProducePreparationIdolSkillSelectPopupCaller = GetObject<ProducePreparationIdolSkillSelectPopupCaller>(new IntPtr(p + 0x118), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupCaller.FromPointer); // 0x118 ProducePreparationIdolSkillSelectPopupCaller ( ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer )
            value.StaminaUsagePopupCaller                   = GetObject<ProduceStaminaUsagePopupCaller>(new IntPtr(p + 0x120), ReversePrism.DataModels.ProduceStaminaUsagePopupCaller.FromPointer); // 0x120 StaminaUsagePopupCaller     ( ModelClassType ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller ProduceStaminaUsagePopupCaller Pointer )
            value.StaminaUsageStatusText                    = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x128), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x128 StaminaUsageStatusText      ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.UnitNameText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x130), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x130 UnitNameText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ConfirmHowToPlayButton                    = GetObject<UIButton>(new IntPtr(p + 0x138), ReversePrism.DataModels.UIButton.FromPointer); // 0x138 ConfirmHowToPlayButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UnitNameEditButton                        = GetObject<UIButton>(new IntPtr(p + 0x140), ReversePrism.DataModels.UIButton.FromPointer); // 0x140 UnitNameEditButton          ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x148)); // 0x148 HowToPlayManualKey          ( ModelPrimitiveType string string string String )
            value.FesDataPossessionLimitPopupCaller         = GetObject<IFesDataPossessionLimitPopupCaller>(new IntPtr(p + 0x150), ReversePrism.DataModels.IFesDataPossessionLimitPopupCaller.FromPointer); // 0x150 FesDataPossessionLimitPopupCaller ( ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer )
            value.SubSeasonDetailContentViewModel           = GetObject<SubSeasonDetailContentViewModel>(new IntPtr(p + 0x158), ReversePrism.DataModels.SubSeasonDetailContentViewModel.FromPointer); // 0x158 SubSeasonDetailContentViewModel ( ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer )
            value.HowToPlayProduceManualData                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x160), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0x160 HowToPlayProduceManualData  ( ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )
            value.ButtonDisposables                         = GetObject<CompositeDisposable>(new IntPtr(p + 0x198), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x198 ButtonDisposables           ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.OnClickStart                              = GetObject<Action>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Action.FromPointer); // 0x1A0 OnClickStart                ( ModelClassType Action Action Action Pointer )
            value.OnClickEpisodeDetail                      = GetObject<Action>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.Action.FromPointer); // 0x1A8 OnClickEpisodeDetail        ( ModelClassType Action Action Action Pointer )
            value.OnCkickSupportEdit                        = GetObject<Action>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Action.FromPointer); // 0x1B0 OnCkickSupportEdit          ( ModelClassType Action Action Action Pointer )
            value.OnClickSubSeasonButton                    = GetObject<Action>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Action.FromPointer); // 0x1C8 OnClickSubSeasonButton      ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
