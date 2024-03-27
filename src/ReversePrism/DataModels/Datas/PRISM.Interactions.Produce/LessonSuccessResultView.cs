using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 NoSupportBonusUI                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 LevelText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SupportBonusUI                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 SupportBonusLevelText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ClearTimeCount                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 RankIcon                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 RankTextImage                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 068 GreatEffect                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ScheduleRewardContent                    0001866D6F50 ModelClassType ScheduleRewardContent ScheduleRewardContent ScheduleRewardContent Pointer
    // 078 ChallengeMission                         00018656BDA0 ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer
    // 080 IsChallengeMissionAchieved               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 090 WaitParameterAnimationFrame              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 AnimationPlayer                          0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 0A0 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0A8 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 ScheduleLevelUpContent                   0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 0B8 SupportEffectDemonstrateUIContent        0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 0C0 GetProduceCardPopupPrefab                000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 0C8 ScriptController                         0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    // 0D0 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class LessonSuccessResultView
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
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static LessonSuccessResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonSuccessResultView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA1D6240 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.NoSupportBonusUI                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1D6260 0x28 NoSupportBonusUI            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LevelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D6280 0x30 LevelText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportBonusUI                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1D62A0 0x38 SupportBonusUI              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportBonusLevelText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D62C0 0x40 SupportBonusLevelText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D62E0 0x48 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearTimeCount                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D6300 0x50 ClearTimeCount              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA1D6320 0x58 RankIcon                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RankTextImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA1D6340 0x60 RankTextImage               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.GreatEffect                               = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1D6360 0x68 GreatEffect                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleRewardContent                     = GetObject<ScheduleRewardContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScheduleRewardContent.FromPointer); // 0270DA1D6380 0x70 ScheduleRewardContent       ( 0001866D6F50 ModelClassType ScheduleRewardContent ScheduleRewardContent ScheduleRewardContent Pointer )
            value.ChallengeMission                          = GetObject<ChallengeMissionContent>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChallengeMissionContent.FromPointer); // 0270DA1D63A0 0x78 ChallengeMission            ( 00018656BDA0 ModelClassType ChallengeMissionContent ChallengeMissionContent ChallengeMissionContent Pointer )
            value.IsChallengeMissionAchieved                = GetBool(new IntPtr(p + 0x080)); // 0270DA1D63C0 0x80 IsChallengeMissionAchieved  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270DA1D63E0 0x88 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x090)); // 0270DA1D6400 0x90 WaitParameterAnimationFrame ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x098), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0270DA1D6420 0x98 AnimationPlayer             ( 0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1D6440 0xA0 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ScheduleLevelUpContent                    = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 0270DA1D6480 0xB0 ScheduleLevelUpContent      ( 0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0270DA1D64A0 0xB8 SupportEffectDemonstrateUIContent ( 0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.GetProduceCardPopupPrefab                 = GetObject<PopupContentBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA1D64C0 0xC0 GetProduceCardPopupPrefab   ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0270DA1D64E0 0xC8 ScriptController            ( 0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA1D6500 0xD0 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
