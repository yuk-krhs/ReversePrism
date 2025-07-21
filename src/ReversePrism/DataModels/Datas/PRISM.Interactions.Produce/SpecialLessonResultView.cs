using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 LevelText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 AppealPointText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 AppealPointGauge                         ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer
    // 048 RankUpProduceCardText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 AppealGaugeAnimationTime                 ModelPrimitiveType float float float Single
    // 058 RankUpCountAnimatorEvent                 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 060 WaitParameterAnimationFrame              ModelPrimitiveType int int int Int32
    // 064 LoopSEPlayback                           ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 068 BonusParameterContent                    ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    // 070 BonusScoreObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 078 NonBonusScoreObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 080 IsUnitParameterUp                        ModelPrimitiveType bool bool bool Bool
    // 088 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 090 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 ScheduleLevelUpContent                   ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 0A0 SupportEffectDemonstrateUIContent        ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 0A8 AnimatorWithEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 0B0 WaitGaugeAnimationFrame                  ModelPrimitiveType int int int Int32
    // 0B8 AnimationPlayer                          ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 0C0 ScriptController                         ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    public partial class SpecialLessonResultView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       LevelText                               { get; set; }
        public UITextMeshProUGUI?                       AppealPointText                         { get; set; }
        public AppealPointGaugeContent?                 AppealPointGauge                        { get; set; }
        public UITextMeshProUGUI?                       RankUpProduceCardText                   { get; set; }
        public float                                    AppealGaugeAnimationTime                { get; set; }
        public AnimatorWithEvent?                       RankUpCountAnimatorEvent                { get; set; }
        public int                                      WaitParameterAnimationFrame             { get; set; }
        public CriAtomExPlayback                        LoopSEPlayback                          { get; set; }
        public ParameterContent?                        BonusParameterContent                   { get; set; }
        public GameObject?                              BonusScoreObject                        { get; set; }
        public GameObject?                              NonBonusScoreObject                     { get; set; }
        public bool                                     IsUnitParameterUp                       { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public ScheduleLevelUpContent?                  ScheduleLevelUpContent                  { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public int                                      WaitGaugeAnimationFrame                 { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }

        public static SpecialLessonResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLessonResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LevelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 LevelText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppealPointText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 AppealPointText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppealPointGauge                          = GetObject<AppealPointGaugeContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.AppealPointGaugeContent.FromPointer); // 0x40 AppealPointGauge            ( ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer )
            value.RankUpProduceCardText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 RankUpProduceCardText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppealGaugeAnimationTime                  = GetSingle(new IntPtr(p + 0x050)); // 0x50 AppealGaugeAnimationTime    ( ModelPrimitiveType float float float Single )
            value.RankUpCountAnimatorEvent                  = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x58 RankUpCountAnimatorEvent    ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x060)); // 0x60 WaitParameterAnimationFrame ( ModelPrimitiveType int int int Int32 )
            value.LoopSEPlayback                            = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x064)); // 0x64 LoopSEPlayback              ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.BonusParameterContent                     = GetObject<ParameterContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParameterContent.FromPointer); // 0x68 BonusParameterContent       ( ModelClassType ParameterContent ParameterContent ParameterContent Pointer )
            value.BonusScoreObject                          = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 BonusScoreObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NonBonusScoreObject                       = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 NonBonusScoreObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IsUnitParameterUp                         = GetBool(new IntPtr(p + 0x080)); // 0x80 IsUnitParameterUp           ( ModelPrimitiveType bool bool bool Bool )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ScheduleLevelUpContent                    = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x098), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 0x98 ScheduleLevelUpContent      ( ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0xA0 SupportEffectDemonstrateUIContent ( ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0xA8 AnimatorWithEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitGaugeAnimationFrame                   = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 WaitGaugeAnimationFrame     ( ModelPrimitiveType int int int Int32 )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0xB8 AnimationPlayer             ( ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0xC0 ScriptController            ( ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )

            return value;
        }
    }
}
