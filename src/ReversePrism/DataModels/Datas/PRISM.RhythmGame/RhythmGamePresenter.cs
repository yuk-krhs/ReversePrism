using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Loader                                   ModelClassType RhythmGameLoader RhythmGameLoader RhythmGameLoader Pointer
    // 018 View                                     ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer
    // 020 ProgressManager                          ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer
    // 028 NoteDesign                               ModelClassType IRhythmGameNoteDesign IRhythmGameNoteDesign IRhythmGameNoteDesign Pointer
    // 030 TouchInputService                        ModelClassType TouchInputService TouchInputService TouchInputService Pointer
    // 038 LiveSkillService                         ModelClassType LiveSkillService LiveSkillService LiveSkillService Pointer
    // 040 SoundService                             ModelClassType RhythmGameSoundService RhythmGameSoundService RhythmGameSoundService Pointer
    // 048 LiveStartData                            ModelClassType LiveStartData LiveStartData LiveStartData Pointer
    // 050 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 058 Option                                   ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 060 ObjectRenderService                      ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer
    // 068 VibrateService                           ModelClassType RhythmGameVibrateService RhythmGameVibrateService RhythmGameVibrateService Pointer
    // 070 ScoreService                             ModelClassType RhythmGameScoreService RhythmGameScoreService RhythmGameScoreService Pointer
    // 078 State                                    ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer
    // 080 ObjectContainer                          ModelClassType RhythmGameObjectContainer RhythmGameObjectContainer RhythmGameObjectContainer Pointer
    // 088 JudgeService                             ModelClassType JudgeService JudgeService JudgeService Pointer
    // 090 Status                                   ModelEnumType RhythmGameStatus RhythmGameStatus RhythmGameStatus Int32
    // 094 IsShinyEnabled                           ModelPrimitiveType bool bool bool Bool
    // 095 IsViewerMode                             ModelPrimitiveType bool bool bool Bool
    // 098 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0A0 MvPauser                                 ModelClassType IPausable IPausable IPausable Pointer
    // 0A8 keyBeamOnLaneIndices                     HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 0B0 ResumeCountdownCancellationTokenSource   ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class RhythmGamePresenter : DataModel
    {
        public RhythmGameLoader?                        Loader                                  { get; set; }
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
        public bool                                     IsShinyEnabled                          { get; set; }
        public bool                                     IsViewerMode                            { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public IPausable?                               MvPauser                                { get; set; }
        public CancellationTokenSource?                 ResumeCountdownCancellationTokenSource  { get; set; }

        public static RhythmGamePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGamePresenter() { Pointer= p0 };

            value.Loader                                    = GetObject<RhythmGameLoader>(new IntPtr(p + 0x010), ReversePrism.DataModels.RhythmGameLoader.FromPointer); // 0x10 Loader                      ( ModelClassType RhythmGameLoader RhythmGameLoader RhythmGameLoader Pointer )
            value.View                                      = GetObject<RhythmGameView>(new IntPtr(p + 0x018), ReversePrism.DataModels.RhythmGameView.FromPointer); // 0x18 View                        ( ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer )
            value.ProgressManager                           = GetObject<LiveProgressManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveProgressManager.FromPointer); // 0x20 ProgressManager             ( ModelClassType LiveProgressManager LiveProgressManager LiveProgressManager Pointer )
            value.NoteDesign                                = GetObject<IRhythmGameNoteDesign>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRhythmGameNoteDesign.FromPointer); // 0x28 NoteDesign                  ( ModelClassType IRhythmGameNoteDesign IRhythmGameNoteDesign IRhythmGameNoteDesign Pointer )
            value.TouchInputService                         = GetObject<TouchInputService>(new IntPtr(p + 0x030), ReversePrism.DataModels.TouchInputService.FromPointer); // 0x30 TouchInputService           ( ModelClassType TouchInputService TouchInputService TouchInputService Pointer )
            value.LiveSkillService                          = GetObject<LiveSkillService>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveSkillService.FromPointer); // 0x38 LiveSkillService            ( ModelClassType LiveSkillService LiveSkillService LiveSkillService Pointer )
            value.SoundService                              = GetObject<RhythmGameSoundService>(new IntPtr(p + 0x040), ReversePrism.DataModels.RhythmGameSoundService.FromPointer); // 0x40 SoundService                ( ModelClassType RhythmGameSoundService RhythmGameSoundService RhythmGameSoundService Pointer )
            value.LiveStartData                             = GetObject<LiveStartData>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveStartData.FromPointer); // 0x48 LiveStartData               ( ModelClassType LiveStartData LiveStartData LiveStartData Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x50 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x058), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0x58 Option                      ( ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.ObjectRenderService                       = GetObject<RhythmGameObjectRenderService>(new IntPtr(p + 0x060), ReversePrism.DataModels.RhythmGameObjectRenderService.FromPointer); // 0x60 ObjectRenderService         ( ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer )
            value.VibrateService                            = GetObject<RhythmGameVibrateService>(new IntPtr(p + 0x068), ReversePrism.DataModels.RhythmGameVibrateService.FromPointer); // 0x68 VibrateService              ( ModelClassType RhythmGameVibrateService RhythmGameVibrateService RhythmGameVibrateService Pointer )
            value.ScoreService                              = GetObject<RhythmGameScoreService>(new IntPtr(p + 0x070), ReversePrism.DataModels.RhythmGameScoreService.FromPointer); // 0x70 ScoreService                ( ModelClassType RhythmGameScoreService RhythmGameScoreService RhythmGameScoreService Pointer )
            value.State                                     = GetObject<RhythmGameState>(new IntPtr(p + 0x078), ReversePrism.DataModels.RhythmGameState.FromPointer); // 0x78 State                       ( ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer )
            value.ObjectContainer                           = GetObject<RhythmGameObjectContainer>(new IntPtr(p + 0x080), ReversePrism.DataModels.RhythmGameObjectContainer.FromPointer); // 0x80 ObjectContainer             ( ModelClassType RhythmGameObjectContainer RhythmGameObjectContainer RhythmGameObjectContainer Pointer )
            value.JudgeService                              = GetObject<JudgeService>(new IntPtr(p + 0x088), ReversePrism.DataModels.JudgeService.FromPointer); // 0x88 JudgeService                ( ModelClassType JudgeService JudgeService JudgeService Pointer )
            value.Status                                    = (RhythmGameStatus)GetInt32(new IntPtr(p + 0x090)); // 0x90 Status                      ( ModelEnumType RhythmGameStatus RhythmGameStatus RhythmGameStatus Int32 )
            value.IsShinyEnabled                            = GetBool(new IntPtr(p + 0x094)); // 0x94 IsShinyEnabled              ( ModelPrimitiveType bool bool bool Bool )
            value.IsViewerMode                              = GetBool(new IntPtr(p + 0x095)); // 0x95 IsViewerMode                ( ModelPrimitiveType bool bool bool Bool )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x098), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x98 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.MvPauser                                  = GetObject<IPausable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IPausable.FromPointer); // 0xA0 MvPauser                    ( ModelClassType IPausable IPausable IPausable Pointer )
            value.ResumeCountdownCancellationTokenSource    = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0xB0 ResumeCountdownCancellationTokenSource ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
