using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018668E5D0 ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer
    // 018 ProgressManager                          000186569B60 ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer
    // 020 NoteDesign                               0001866203E0 ModelClassType IRhythmGameNoteDesign IRhythmGameNoteDesign IRhythmGameNoteDesign Pointer
    // 028 TouchInputService                        00018668F440 ModelClassType TouchInputService TouchInputService TouchInputService Pointer
    // 030 LiveSkillService                         00018657EE60 ModelClassType LiveSkillService LiveSkillService LiveSkillService Pointer
    // 038 SoundService                             00018668C430 ModelClassType RhythmGameSoundService RhythmGameSoundService RhythmGameSoundService Pointer
    // 040 LiveStartData                            000186582060 ModelClassType LiveStartData LiveStartData LiveStartData Pointer
    // 048 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 050 Option                                   000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 058 ObjectRenderService                      000186685200 ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer
    // 060 VibrateService                           00018668DC50 ModelClassType RhythmGameVibrateService RhythmGameVibrateService RhythmGameVibrateService Pointer
    // 068 ScoreService                             00018668BA60 ModelClassType RhythmGameScoreService RhythmGameScoreService RhythmGameScoreService Pointer
    // 070 State                                    00018668C8C0 ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer
    // 078 ObjectContainer                          0001866845F0 ModelClassType RhythmGameObjectContainer RhythmGameObjectContainer RhythmGameObjectContainer Pointer
    // 080 JudgeService                             000186766460 ModelClassType JudgeService JudgeService JudgeService Pointer
    // 088 Status                                   00018668D280 ModelEnumType RhythmGameStatus RhythmGameStatus RhythmGameStatus Int32
    // 08C IsViewerMode                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 090 CancellationTokenSource                  0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 098 MvPauser                                 0001865D3220 ModelClassType IPausable IPausable IPausable Pointer
    // 0A0 keyBeamOnLaneIndices                     HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 0A8 onJudgeSubject                           Subject`1<ValueTuple`2<JudgmentResult, float>> IL2CPP_TYPE_GENERICINST
    // 0B0 ResumeCountdownCancellationTokenSource   0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class RhythmGamePresenter
    {
        public RhythmGameView?                          View                                    { get; set; }
        public LiveProgressManager?                     ProgressManager                         { get; set; }
        public IRhythmGameNoteDesign?                   NoteDesign                              { get; set; }
        public TouchInputService?                       TouchInputService                       { get; set; }
        public LiveSkillService?                        LiveSkillService                        { get; set; }
        public RhythmGameSoundService?                  SoundService                            { get; set; }
        public LiveStartData?                           LiveStartData                           { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public RhythmGameObjectRenderService?           ObjectRenderService                     { get; set; }
        public RhythmGameVibrateService?                VibrateService                          { get; set; }
        public RhythmGameScoreService?                  ScoreService                            { get; set; }
        public RhythmGameState?                         State                                   { get; set; }
        public RhythmGameObjectContainer?               ObjectContainer                         { get; set; }
        public JudgeService?                            JudgeService                            { get; set; }
        public RhythmGameStatus                         Status                                  { get; set; }
        public bool                                     IsViewerMode                            { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public IPausable?                               MvPauser                                { get; set; }
        public CancellationTokenSource?                 ResumeCountdownCancellationTokenSource  { get; set; }

        public static RhythmGamePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGamePresenter();

            value.View                                      = GetObject<RhythmGameView>(new IntPtr(p + 0x010), ReversePrism.DataModels.RhythmGameView.FromPointer); // 0270D4E221E8 0x10 View                        ( 00018668E5D0 ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer )
            value.ProgressManager                           = GetObject<LiveProgressManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveProgressManager.FromPointer); // 0270D4E22208 0x18 ProgressManager             ( 000186569B60 ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer )
            value.NoteDesign                                = GetObject<IRhythmGameNoteDesign>(new IntPtr(p + 0x020), ReversePrism.DataModels.IRhythmGameNoteDesign.FromPointer); // 0270D4E22228 0x20 NoteDesign                  ( 0001866203E0 ModelClassType IRhythmGameNoteDesign IRhythmGameNoteDesign IRhythmGameNoteDesign Pointer )
            value.TouchInputService                         = GetObject<TouchInputService>(new IntPtr(p + 0x028), ReversePrism.DataModels.TouchInputService.FromPointer); // 0270D4E22248 0x28 TouchInputService           ( 00018668F440 ModelClassType TouchInputService TouchInputService TouchInputService Pointer )
            value.LiveSkillService                          = GetObject<LiveSkillService>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveSkillService.FromPointer); // 0270D4E22268 0x30 LiveSkillService            ( 00018657EE60 ModelClassType LiveSkillService LiveSkillService LiveSkillService Pointer )
            value.SoundService                              = GetObject<RhythmGameSoundService>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameSoundService.FromPointer); // 0270D4E22288 0x38 SoundService                ( 00018668C430 ModelClassType RhythmGameSoundService RhythmGameSoundService RhythmGameSoundService Pointer )
            value.LiveStartData                             = GetObject<LiveStartData>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveStartData.FromPointer); // 0270D4E222A8 0x40 LiveStartData               ( 000186582060 ModelClassType LiveStartData LiveStartData LiveStartData Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D4E222C8 0x48 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x050), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0270D4E222E8 0x50 Option                      ( 000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.ObjectRenderService                       = GetObject<RhythmGameObjectRenderService>(new IntPtr(p + 0x058), ReversePrism.DataModels.RhythmGameObjectRenderService.FromPointer); // 0270D4E22308 0x58 ObjectRenderService         ( 000186685200 ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer )
            value.VibrateService                            = GetObject<RhythmGameVibrateService>(new IntPtr(p + 0x060), ReversePrism.DataModels.RhythmGameVibrateService.FromPointer); // 0270D4E22328 0x60 VibrateService              ( 00018668DC50 ModelClassType RhythmGameVibrateService RhythmGameVibrateService RhythmGameVibrateService Pointer )
            value.ScoreService                              = GetObject<RhythmGameScoreService>(new IntPtr(p + 0x068), ReversePrism.DataModels.RhythmGameScoreService.FromPointer); // 0270D4E22348 0x68 ScoreService                ( 00018668BA60 ModelClassType RhythmGameScoreService RhythmGameScoreService RhythmGameScoreService Pointer )
            value.State                                     = GetObject<RhythmGameState>(new IntPtr(p + 0x070), ReversePrism.DataModels.RhythmGameState.FromPointer); // 0270D4E22368 0x70 State                       ( 00018668C8C0 ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer )
            value.ObjectContainer                           = GetObject<RhythmGameObjectContainer>(new IntPtr(p + 0x078), ReversePrism.DataModels.RhythmGameObjectContainer.FromPointer); // 0270D4E22388 0x78 ObjectContainer             ( 0001866845F0 ModelClassType RhythmGameObjectContainer RhythmGameObjectContainer RhythmGameObjectContainer Pointer )
            value.JudgeService                              = GetObject<JudgeService>(new IntPtr(p + 0x080), ReversePrism.DataModels.JudgeService.FromPointer); // 0270D4E223A8 0x80 JudgeService                ( 000186766460 ModelClassType JudgeService JudgeService JudgeService Pointer )
            value.Status                                    = (RhythmGameStatus)GetInt32(new IntPtr(p + 0x088)); // 0270D4E223C8 0x88 Status                      ( 00018668D280 ModelEnumType RhythmGameStatus RhythmGameStatus RhythmGameStatus Int32 )
            value.IsViewerMode                              = GetBool(new IntPtr(p + 0x08C)); // 0270D4E223E8 0x8C IsViewerMode                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D4E22408 0x90 CancellationTokenSource     ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.MvPauser                                  = GetObject<IPausable>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPausable.FromPointer); // 0270D4E22428 0x98 MvPauser                    ( 0001865D3220 ModelClassType IPausable IPausable IPausable Pointer )
            value.ResumeCountdownCancellationTokenSource    = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D4E22488 0xB0 ResumeCountdownCancellationTokenSource ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
