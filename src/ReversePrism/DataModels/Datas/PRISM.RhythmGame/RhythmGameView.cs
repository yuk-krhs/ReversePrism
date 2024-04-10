using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera3d                                 0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 028 Camera2d                                 0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 030 ScoreGauge                               00018668B580 ModelClassType RhythmGameScoreGauge RhythmGameScoreGauge RhythmGameScoreGauge Pointer
    // 038 LifeGauge                                000186683000 ModelClassType RhythmGameLifeGauge RhythmGameLifeGauge RhythmGameLifeGauge Pointer
    // 040 JudgeResultView                          000186765FA0 ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer
    // 048 FixedJudgeResultView                     0001867672B0 ModelClassType JudgementLagView JudgementLagView JudgementLagView Pointer
    // 050 FinishEffectView                         0001865852F0 ModelClassType FinishEffectView FinishEffectView FinishEffectView Pointer
    // 058 PauseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 Lane                                     000186778710 ModelClassType Lane Lane Lane Pointer
    // 068 PauseView                                0001865670D0 ModelClassType LivePauseView LivePauseView LivePauseView Pointer
    // 070 SkillNotificationView                    00018657E6E0 ModelClassType LiveSkillNotificationView LiveSkillNotificationView LiveSkillNotificationView Pointer
    // 078 JudgeLine                                000186765AB0 ModelClassType JudgeLine JudgeLine JudgeLine Pointer
    // 080 AutoModeObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 BackgroundBlocker                        000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 090 UnhidePauseViewButton                    0001865140C0 ModelClassType Button Button Button Pointer
    // 098 ResumeCountdownNumber                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0A0 ResumeCountdownNumberSprites             000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 0A8 ResumeCountdownMeter                     0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0B0 PopupSystem                              000186766470 ModelClassType PopupSystem PopupSystem PopupSystem Pointer
    // 0B8 PopupManager                             000186763E60 ModelClassType PopupManager PopupManager PopupManager Pointer
    // 0C0 SuspendPauseView                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 SuspendUnpauseButton                     0001865140C0 ModelClassType Button Button Button Pointer
    // 0D0 RenderOptionWatcher                      00018668ADF0 ModelClassType RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher Pointer
    // 0D8 LiveSettingContent                       000186671910 ModelPrimitiveType string string string String
    // 0E0 FullScreenEffectView                     000186555AE0 ModelClassType LiveFullScreenEffectView LiveFullScreenEffectView LiveFullScreenEffectView Pointer
    // 0E8 StartAnimationView                       000186581720 ModelClassType LiveStartAnimationView LiveStartAnimationView LiveStartAnimationView Pointer
    // 0F0 HowToPlayPopupOpener                     0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0F8 AfterHowToPlayDelayMilliseconds          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 100 SettingPopupCaller                       000186579570 ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer
    // 108 onChangeFocus                            Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 110 ResumeCountdownTween                     0001866BEFF0 ModelClassType Tween Tween Tween Pointer
    // 118 Option                                   000186685720 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 120 JudgeEffectView                          000186764E90 ModelClassType JudgeEffectView JudgeEffectView JudgeEffectView Pointer
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

            value.Camera3d                                  = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 02466505EAE8 0x20 Camera3d                    ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.Camera2d                                  = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 02466505EB08 0x28 Camera2d                    ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.ScoreGauge                                = GetObject<RhythmGameScoreGauge>(new IntPtr(p + 0x030), ReversePrism.DataModels.RhythmGameScoreGauge.FromPointer); // 02466505EB28 0x30 ScoreGauge                  ( 00018668B580 ModelClassType RhythmGameScoreGauge RhythmGameScoreGauge RhythmGameScoreGauge Pointer )
            value.LifeGauge                                 = GetObject<RhythmGameLifeGauge>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameLifeGauge.FromPointer); // 02466505EB48 0x38 LifeGauge                   ( 000186683000 ModelClassType RhythmGameLifeGauge RhythmGameLifeGauge RhythmGameLifeGauge Pointer )
            value.JudgeResultView                           = GetObject<JudgeResultView>(new IntPtr(p + 0x040), ReversePrism.DataModels.JudgeResultView.FromPointer); // 02466505EB68 0x40 JudgeResultView             ( 000186765FA0 ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer )
            value.FixedJudgeResultView                      = GetObject<JudgementLagView>(new IntPtr(p + 0x048), ReversePrism.DataModels.JudgementLagView.FromPointer); // 02466505EB88 0x48 FixedJudgeResultView        ( 0001867672B0 ModelClassType JudgementLagView JudgementLagView JudgementLagView Pointer )
            value.FinishEffectView                          = GetObject<FinishEffectView>(new IntPtr(p + 0x050), ReversePrism.DataModels.FinishEffectView.FromPointer); // 02466505EBA8 0x50 FinishEffectView            ( 0001865852F0 ModelClassType FinishEffectView FinishEffectView FinishEffectView Pointer )
            value.PauseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466505EBC8 0x58 PauseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Lane                                      = GetObject<Lane>(new IntPtr(p + 0x060), ReversePrism.DataModels.Lane.FromPointer); // 02466505EBE8 0x60 Lane                        ( 000186778710 ModelClassType Lane Lane Lane Pointer )
            value.PauseView                                 = GetObject<LivePauseView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LivePauseView.FromPointer); // 02466505EC08 0x68 PauseView                   ( 0001865670D0 ModelClassType LivePauseView LivePauseView LivePauseView Pointer )
            value.SkillNotificationView                     = GetObject<LiveSkillNotificationView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveSkillNotificationView.FromPointer); // 02466505EC28 0x70 SkillNotificationView       ( 00018657E6E0 ModelClassType LiveSkillNotificationView LiveSkillNotificationView LiveSkillNotificationView Pointer )
            value.JudgeLine                                 = GetObject<JudgeLine>(new IntPtr(p + 0x078), ReversePrism.DataModels.JudgeLine.FromPointer); // 02466505EC48 0x78 JudgeLine                   ( 000186765AB0 ModelClassType JudgeLine JudgeLine JudgeLine Pointer )
            value.AutoModeObject                            = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 02466505EC68 0x80 AutoModeObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BackgroundBlocker                         = GetObject<SpriteRenderer>(new IntPtr(p + 0x088), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 02466505EC88 0x88 BackgroundBlocker           ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.UnhidePauseViewButton                     = GetObject<Button>(new IntPtr(p + 0x090), ReversePrism.DataModels.Button.FromPointer); // 02466505ECA8 0x90 UnhidePauseViewButton       ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.ResumeCountdownNumber                     = GetObject<Image>(new IntPtr(p + 0x098), ReversePrism.DataModels.Image.FromPointer); // 02466505ECC8 0x98 ResumeCountdownNumber       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ResumeCountdownNumberSprites              = GetObjectList<Sprite>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Sprite.FromPointer); // 02466505ECE8 0xA0 ResumeCountdownNumberSprites ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.ResumeCountdownMeter                      = GetObject<Image>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Image.FromPointer); // 02466505ED08 0xA8 ResumeCountdownMeter        ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.PopupSystem                               = GetObject<PopupSystem>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PopupSystem.FromPointer); // 02466505ED28 0xB0 PopupSystem                 ( 000186766470 ModelClassType PopupSystem PopupSystem PopupSystem Pointer )
            value.PopupManager                              = GetObject<PopupManager>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PopupManager.FromPointer); // 02466505ED48 0xB8 PopupManager                ( 000186763E60 ModelClassType PopupManager PopupManager PopupManager Pointer )
            value.SuspendPauseView                          = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 02466505ED68 0xC0 SuspendPauseView            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SuspendUnpauseButton                      = GetObject<Button>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Button.FromPointer); // 02466505ED88 0xC8 SuspendUnpauseButton        ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.RenderOptionWatcher                       = GetObject<RhythmGameRenderOptionWatcher>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.RhythmGameRenderOptionWatcher.FromPointer); // 02466505EDA8 0xD0 RenderOptionWatcher         ( 00018668ADF0 ModelClassType RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher RhythmGameRenderOptionWatcher Pointer )
            value.LiveSettingContent                        = GetString(new IntPtr(p + 0x0D8)); // 02466505EDC8 0xD8 LiveSettingContent          ( 000186671910 ModelPrimitiveType string string string String )
            value.FullScreenEffectView                      = GetObject<LiveFullScreenEffectView>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.LiveFullScreenEffectView.FromPointer); // 02466505EDE8 0xE0 FullScreenEffectView        ( 000186555AE0 ModelClassType LiveFullScreenEffectView LiveFullScreenEffectView LiveFullScreenEffectView Pointer )
            value.StartAnimationView                        = GetObject<LiveStartAnimationView>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LiveStartAnimationView.FromPointer); // 02466505EE08 0xE8 StartAnimationView          ( 000186581720 ModelClassType LiveStartAnimationView LiveStartAnimationView LiveStartAnimationView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 02466505EE28 0xF0 HowToPlayPopupOpener        ( 0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.AfterHowToPlayDelayMilliseconds           = GetInt32(new IntPtr(p + 0x0F8)); // 02466505EE48 0xF8 AfterHowToPlayDelayMilliseconds ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SettingPopupCaller                        = GetObject<LiveSettingPopupCaller>(new IntPtr(p + 0x100), ReversePrism.DataModels.LiveSettingPopupCaller.FromPointer); // 02466505EE68 0x100 SettingPopupCaller          ( 000186579570 ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer )
            value.ResumeCountdownTween                      = GetObject<Tween>(new IntPtr(p + 0x110), ReversePrism.DataModels.Tween.FromPointer); // 02466505EEA8 0x110 ResumeCountdownTween        ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x118), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 02466505EEC8 0x118 Option                      ( 000186685720 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.JudgeEffectView                           = GetObject<JudgeEffectView>(new IntPtr(p + 0x120), ReversePrism.DataModels.JudgeEffectView.FromPointer); // 02466505EEE8 0x120 JudgeEffectView             ( 000186764E90 ModelClassType JudgeEffectView JudgeEffectView JudgeEffectView Pointer )

            return value;
        }
    }
}
