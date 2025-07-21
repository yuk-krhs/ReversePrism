using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera3d                                 ModelClassType Camera Camera Camera Pointer
    // 028 Camera2d                                 ModelClassType Camera Camera Camera Pointer
    // 030 ScoreGauge                               ModelClassType RhythmGameScoreGauge RhythmGameScoreGauge RhythmGameScoreGauge Pointer
    // 038 LifeGauge                                ModelClassType RhythmGameLifeGauge RhythmGameLifeGauge RhythmGameLifeGauge Pointer
    // 040 JudgeResultView                          ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer
    // 048 FixedJudgeResultView                     ModelClassType JudgementLagView JudgementLagView JudgementLagView Pointer
    // 050 FinishEffectView                         ModelClassType FinishEffectView FinishEffectView FinishEffectView Pointer
    // 058 PauseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 Lane                                     ModelClassType Lane Lane Lane Pointer
    // 068 PauseView                                ModelClassType LivePauseView LivePauseView LivePauseView Pointer
    // 070 SkillNotificationView                    ModelClassType LiveSkillNotificationView LiveSkillNotificationView LiveSkillNotificationView Pointer
    // 078 JudgeLine                                ModelClassType JudgeLine JudgeLine JudgeLine Pointer
    // 080 AutoModeObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 088 BackgroundBlocker                        ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 090 UnhidePauseViewButton                    ModelClassType Button Button Button Pointer
    // 098 ResumeCountdownNumber                    ModelClassType Image Image Image Pointer
    // 0A0 ResumeCountdownNumberSprites             ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 0A8 ResumeCountdownMeter                     ModelClassType Image Image Image Pointer
    // 0B0 PopupSystem                              ModelClassType PopupSystem PopupSystem PopupSystem Pointer
    // 0B8 PopupManager                             ModelClassType PopupManager PopupManager PopupManager Pointer
    // 0C0 SuspendPauseView                         ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 SuspendUnpauseButton                     ModelClassType Button Button Button Pointer
    // 0D0 RenderOptionWatcher                      ModelClassType RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher Pointer
    // 0D8 LiveSettingContent                       ModelPrimitiveType string string string String
    // 0E0 FullScreenEffectView                     ModelClassType LiveFullScreenEffectView LiveFullScreenEffectView LiveFullScreenEffectView Pointer
    // 0E8 StartAnimationView                       ModelClassType LiveStartAnimationView LiveStartAnimationView LiveStartAnimationView Pointer
    // 0F0 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0F8 AfterHowToPlayDelayMilliseconds          ModelPrimitiveType int int int Int32
    // 100 SettingPopupCaller                       ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer
    // 108 onChangeFocus                            Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 110 ResumeCountdownTween                     ModelClassType Tween Tween Tween Pointer
    // 118 Option                                   ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 120 JudgeEffectView                          ModelClassType JudgeEffectView JudgeEffectView JudgeEffectView Pointer
    public partial class RhythmGameView : DataModel
    {
        public Camera?                                  Camera3d                                { get; set; }
        public Camera?                                  Camera2d                                { get; set; }
        public RhythmGameScoreGauge?                    ScoreGauge                              { get; set; }
        public RhythmGameLifeGauge?                     LifeGauge                               { get; set; }
        public JudgeResultView?                         JudgeResultView                         { get; set; }
        public JudgementLagView?                        FixedJudgeResultView                    { get; set; }
        public FinishEffectView?                        FinishEffectView                        { get; set; }
        public ButtonBase?                              PauseButton                             { get; set; }
        public Lane?                                    Lane                                    { get; set; }
        public LivePauseView?                           PauseView                               { get; set; }
        public LiveSkillNotificationView?               SkillNotificationView                   { get; set; }
        public JudgeLine?                               JudgeLine                               { get; set; }
        public GameObject?                              AutoModeObject                          { get; set; }
        public SpriteRenderer?                          BackgroundBlocker                       { get; set; }
        public Button?                                  UnhidePauseViewButton                   { get; set; }
        public Image?                                   ResumeCountdownNumber                   { get; set; }
        public List<Sprite>?                            ResumeCountdownNumberSprites            { get; set; }
        public Image?                                   ResumeCountdownMeter                    { get; set; }
        public PopupSystem?                             PopupSystem                             { get; set; }
        public PopupManager?                            PopupManager                            { get; set; }
        public GameObject?                              SuspendPauseView                        { get; set; }
        public Button?                                  SuspendUnpauseButton                    { get; set; }
        public RhythmGameRenderOptionWatcher?           RenderOptionWatcher                     { get; set; }
        public string                                   LiveSettingContent                      { get; set; }
        public LiveFullScreenEffectView?                FullScreenEffectView                    { get; set; }
        public LiveStartAnimationView?                  StartAnimationView                      { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public int                                      AfterHowToPlayDelayMilliseconds         { get; set; }
        public LiveSettingPopupCaller?                  SettingPopupCaller                      { get; set; }
        public Tween?                                   ResumeCountdownTween                    { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public JudgeEffectView?                         JudgeEffectView                         { get; set; }

        public static RhythmGameView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameView() { Pointer= p0 };

            value.Camera3d                                  = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 Camera3d                    ( ModelClassType Camera Camera Camera Pointer )
            value.Camera2d                                  = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0x28 Camera2d                    ( ModelClassType Camera Camera Camera Pointer )
            value.ScoreGauge                                = GetObject<RhythmGameScoreGauge>(new IntPtr(p + 0x030), ReversePrism.DataModels.RhythmGameScoreGauge.FromPointer); // 0x30 ScoreGauge                  ( ModelClassType RhythmGameScoreGauge RhythmGameScoreGauge RhythmGameScoreGauge Pointer )
            value.LifeGauge                                 = GetObject<RhythmGameLifeGauge>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameLifeGauge.FromPointer); // 0x38 LifeGauge                   ( ModelClassType RhythmGameLifeGauge RhythmGameLifeGauge RhythmGameLifeGauge Pointer )
            value.JudgeResultView                           = GetObject<JudgeResultView>(new IntPtr(p + 0x040), ReversePrism.DataModels.JudgeResultView.FromPointer); // 0x40 JudgeResultView             ( ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer )
            value.FixedJudgeResultView                      = GetObject<JudgementLagView>(new IntPtr(p + 0x048), ReversePrism.DataModels.JudgementLagView.FromPointer); // 0x48 FixedJudgeResultView        ( ModelClassType JudgementLagView JudgementLagView JudgementLagView Pointer )
            value.FinishEffectView                          = GetObject<FinishEffectView>(new IntPtr(p + 0x050), ReversePrism.DataModels.FinishEffectView.FromPointer); // 0x50 FinishEffectView            ( ModelClassType FinishEffectView FinishEffectView FinishEffectView Pointer )
            value.PauseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 PauseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Lane                                      = GetObject<Lane>(new IntPtr(p + 0x060), ReversePrism.DataModels.Lane.FromPointer); // 0x60 Lane                        ( ModelClassType Lane Lane Lane Pointer )
            value.PauseView                                 = GetObject<LivePauseView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LivePauseView.FromPointer); // 0x68 PauseView                   ( ModelClassType LivePauseView LivePauseView LivePauseView Pointer )
            value.SkillNotificationView                     = GetObject<LiveSkillNotificationView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveSkillNotificationView.FromPointer); // 0x70 SkillNotificationView       ( ModelClassType LiveSkillNotificationView LiveSkillNotificationView LiveSkillNotificationView Pointer )
            value.JudgeLine                                 = GetObject<JudgeLine>(new IntPtr(p + 0x078), ReversePrism.DataModels.JudgeLine.FromPointer); // 0x78 JudgeLine                   ( ModelClassType JudgeLine JudgeLine JudgeLine Pointer )
            value.AutoModeObject                            = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 AutoModeObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BackgroundBlocker                         = GetObject<SpriteRenderer>(new IntPtr(p + 0x088), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0x88 BackgroundBlocker           ( ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.UnhidePauseViewButton                     = GetObject<Button>(new IntPtr(p + 0x090), ReversePrism.DataModels.Button.FromPointer); // 0x90 UnhidePauseViewButton       ( ModelClassType Button Button Button Pointer )
            value.ResumeCountdownNumber                     = GetObject<Image>(new IntPtr(p + 0x098), ReversePrism.DataModels.Image.FromPointer); // 0x98 ResumeCountdownNumber       ( ModelClassType Image Image Image Pointer )
            value.ResumeCountdownNumberSprites              = GetObjectList<Sprite>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Sprite.FromPointer); // 0xA0 ResumeCountdownNumberSprites ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.ResumeCountdownMeter                      = GetObject<Image>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Image.FromPointer); // 0xA8 ResumeCountdownMeter        ( ModelClassType Image Image Image Pointer )
            value.PopupSystem                               = GetObject<PopupSystem>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PopupSystem.FromPointer); // 0xB0 PopupSystem                 ( ModelClassType PopupSystem PopupSystem PopupSystem Pointer )
            value.PopupManager                              = GetObject<PopupManager>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PopupManager.FromPointer); // 0xB8 PopupManager                ( ModelClassType PopupManager PopupManager PopupManager Pointer )
            value.SuspendPauseView                          = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 SuspendPauseView            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SuspendUnpauseButton                      = GetObject<Button>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Button.FromPointer); // 0xC8 SuspendUnpauseButton        ( ModelClassType Button Button Button Pointer )
            value.RenderOptionWatcher                       = GetObject<RhythmGameRenderOptionWatcher>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.RhythmGameRenderOptionWatcher.FromPointer); // 0xD0 RenderOptionWatcher         ( ModelClassType RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher Pointer )
            value.LiveSettingContent                        = GetString(new IntPtr(p + 0x0D8)); // 0xD8 LiveSettingContent          ( ModelPrimitiveType string string string String )
            value.FullScreenEffectView                      = GetObject<LiveFullScreenEffectView>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.LiveFullScreenEffectView.FromPointer); // 0xE0 FullScreenEffectView        ( ModelClassType LiveFullScreenEffectView LiveFullScreenEffectView LiveFullScreenEffectView Pointer )
            value.StartAnimationView                        = GetObject<LiveStartAnimationView>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LiveStartAnimationView.FromPointer); // 0xE8 StartAnimationView          ( ModelClassType LiveStartAnimationView LiveStartAnimationView LiveStartAnimationView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0xF0 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.AfterHowToPlayDelayMilliseconds           = GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 AfterHowToPlayDelayMilliseconds ( ModelPrimitiveType int int int Int32 )
            value.SettingPopupCaller                        = GetObject<LiveSettingPopupCaller>(new IntPtr(p + 0x100), ReversePrism.DataModels.LiveSettingPopupCaller.FromPointer); // 0x100 SettingPopupCaller          ( ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer )
            value.ResumeCountdownTween                      = GetObject<Tween>(new IntPtr(p + 0x110), ReversePrism.DataModels.Tween.FromPointer); // 0x110 ResumeCountdownTween        ( ModelClassType Tween Tween Tween Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x118), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0x118 Option                      ( ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.JudgeEffectView                           = GetObject<JudgeEffectView>(new IntPtr(p + 0x120), ReversePrism.DataModels.JudgeEffectView.FromPointer); // 0x120 JudgeEffectView             ( ModelClassType JudgeEffectView JudgeEffectView JudgeEffectView Pointer )

            return value;
        }
    }
}
