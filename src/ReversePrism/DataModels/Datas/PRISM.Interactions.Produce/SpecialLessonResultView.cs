using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 LevelText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 AppealPointText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 AppealPointGauge                         0001866CCFE0 ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer
    // 048 RankUpProduceCardText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 AppealGaugeAnimationTime                 0001866656B0 ModelPrimitiveType float float float Single
    // 058 RankUpCountAnimatorEvent                 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 060 WaitParameterAnimationFrame              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 LoopSEPlayback                           0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 068 BonusParameterContent                    00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    // 070 BonusScoreObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 NonBonusScoreObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 IsUnitParameterUp                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 ScheduleLevelUpContent                   0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 0A0 SupportEffectDemonstrateUIContent        0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 0A8 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 0B0 WaitGaugeAnimationFrame                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B8 AnimationPlayer                          0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 0C0 ScriptController                         0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    // 0C8 PCardRankUpPopupPrefab                   000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0D0 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
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
        public PopupContentBase?                        PCardRankUpPopupPrefab                  { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static SpecialLessonResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLessonResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A260EE8 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A260F08 0x28 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LevelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A260F28 0x30 LevelText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppealPointText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A260F48 0x38 AppealPointText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppealPointGauge                          = GetObject<AppealPointGaugeContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.AppealPointGaugeContent.FromPointer); // 02466A260F68 0x40 AppealPointGauge            ( 0001866CCFE0 ModelClassType AppealPointGaugeContent AppealPointGaugeContent AppealPointGaugeContent Pointer )
            value.RankUpProduceCardText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A260F88 0x48 RankUpProduceCardText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AppealGaugeAnimationTime                  = GetSingle(new IntPtr(p + 0x050)); // 02466A260FA8 0x50 AppealGaugeAnimationTime    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RankUpCountAnimatorEvent                  = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 02466A260FC8 0x58 RankUpCountAnimatorEvent    ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x060)); // 02466A260FE8 0x60 WaitParameterAnimationFrame ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LoopSEPlayback                            = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x064)); // 02466A261008 0x64 LoopSEPlayback              ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.BonusParameterContent                     = GetObject<ParameterContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParameterContent.FromPointer); // 02466A261028 0x68 BonusParameterContent       ( 00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer )
            value.BonusScoreObject                          = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466A261048 0x70 BonusScoreObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NonBonusScoreObject                       = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466A261068 0x78 NonBonusScoreObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsUnitParameterUp                         = GetBool(new IntPtr(p + 0x080)); // 02466A261088 0x80 IsUnitParameterUp           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2610A8 0x88 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ScheduleLevelUpContent                    = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x098), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 02466A2610E8 0x98 ScheduleLevelUpContent      ( 0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 02466A261108 0xA0 SupportEffectDemonstrateUIContent ( 0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 02466A261128 0xA8 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitGaugeAnimationFrame                   = GetInt32(new IntPtr(p + 0x0B0)); // 02466A261148 0xB0 WaitGaugeAnimationFrame     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 02466A261168 0xB8 AnimationPlayer             ( 0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 02466A261188 0xC0 ScriptController            ( 0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )
            value.PCardRankUpPopupPrefab                    = GetObject<PopupContentBase>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PopupContentBase.FromPointer); // 02466A2611A8 0xC8 PCardRankUpPopupPrefab      ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A2611C8 0xD0 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
