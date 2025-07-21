using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 NoSupportBonusUI                         ModelClassType GameObject GameObject GameObject Pointer
    // 030 LevelText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SupportBonusUI                           ModelClassType GameObject GameObject GameObject Pointer
    // 040 SupportBonusLevelText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ClearTimeCount                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 RankIcon                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 RankTextImage                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 068 GreatEffect                              ModelClassType GameObject GameObject GameObject Pointer
    // 070 ScheduleRewardContent                    ModelClassType ScheduleRewardContent ScheduleRewardContent ScheduleRewardContent Pointer
    // 078 ChallengeMission                         ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer
    // 080 IsChallengeMissionAchieved               ModelPrimitiveType bool bool bool Bool
    // 088 AnimatorWithEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 090 WaitParameterAnimationFrame              ModelPrimitiveType int int int Int32
    // 098 AnimationPlayer                          ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 0A0 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 0A8 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 ScheduleLevelUpContent                   ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 0B8 SupportEffectDemonstrateUIContent        ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 0C0 GetProduceCardPopupPrefab                ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0C8 ScriptController                         ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    public partial class LessonSuccessResultView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GameObject?                              NoSupportBonusUI                        { get; set; }
        public UITextMeshProUGUI?                       LevelText                               { get; set; }
        public GameObject?                              SupportBonusUI                          { get; set; }
        public UITextMeshProUGUI?                       SupportBonusLevelText                   { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       ClearTimeCount                          { get; set; }
        public UIRawImage?                              RankIcon                                { get; set; }
        public UIRawImage?                              RankTextImage                           { get; set; }
        public GameObject?                              GreatEffect                             { get; set; }
        public ScheduleRewardContent?                   ScheduleRewardContent                   { get; set; }
        public ChallengeMissionContent?                 ChallengeMission                        { get; set; }
        public bool                                     IsChallengeMissionAchieved              { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public int                                      WaitParameterAnimationFrame             { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public ScheduleLevelUpContent?                  ScheduleLevelUpContent                  { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }
        public PopupContentBase?                        GetProduceCardPopupPrefab               { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }

        public static LessonSuccessResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonSuccessResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.NoSupportBonusUI                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 NoSupportBonusUI            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LevelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 LevelText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusUI                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SupportBonusUI              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportBonusLevelText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 SupportBonusLevelText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearTimeCount                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ClearTimeCount              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x58 RankIcon                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RankTextImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x60 RankTextImage               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.GreatEffect                               = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 GreatEffect                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleRewardContent                     = GetObject<ScheduleRewardContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScheduleRewardContent.FromPointer); // 0x70 ScheduleRewardContent       ( ModelClassType ScheduleRewardContent ScheduleRewardContent ScheduleRewardContent Pointer )
            value.ChallengeMission                          = GetObject<ChallengeMissionContent>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChallengeMissionContent.FromPointer); // 0x78 ChallengeMission            ( ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer )
            value.IsChallengeMissionAchieved                = GetBool(new IntPtr(p + 0x080)); // 0x80 IsChallengeMissionAchieved  ( ModelPrimitiveType bool bool bool Bool )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x88 AnimatorWithEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x090)); // 0x90 WaitParameterAnimationFrame ( ModelPrimitiveType int int int Int32 )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x098), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0x98 AnimationPlayer             ( ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIButton.FromPointer); // 0xA0 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ScheduleLevelUpContent                    = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 0xB0 ScheduleLevelUpContent      ( ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0xB8 SupportEffectDemonstrateUIContent ( ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.GetProduceCardPopupPrefab                 = GetObject<PopupContentBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0xC0 GetProduceCardPopupPrefab   ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0xC8 ScriptController            ( ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )

            return value;
        }
    }
}
