using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 MusicInfoView                            0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 060 MusicClearStatusLampView                 000186664330 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer
    // 068 AutoLiveBadge                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 HeaderView                               00018656EC70 ModelClassType LiveResultHeaderView LiveResultHeaderView LiveResultHeaderView Pointer
    // 078 PhaseControlView                         0001865718B0 ModelClassType LiveResultPhaseControlView LiveResultPhaseControlView LiveResultPhaseControlView Pointer
    // 080 IdolPhaseView                            000186570060 ModelClassType LiveResultIdolPhaseView LiveResultIdolPhaseView LiveResultIdolPhaseView Pointer
    // 088 EventPhaseView                           00018656DF90 ModelClassType LiveResultEventPhaseView LiveResultEventPhaseView LiveResultEventPhaseView Pointer
    // 090 BackgroundScene                          000186671910 ModelPrimitiveType string string string String
    // 098 AnimatorRoot                             0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 0A0 OnStageIdols                             000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 0A8 FinishLiveReply                          00018650F090 ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer
    // 0B0 Cache                                    000186528930 ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer
    // 0B8 VoiceType                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0BC ResultType                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C0 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    public partial class LiveResultPresenter : DataModel
    {
        public MusicBasicInfoView?                      MusicInfoView                           { get; set; }
        public MusicClearStatusLampView?                MusicClearStatusLampView                { get; set; }
        public GameObject?                              AutoLiveBadge                           { get; set; }
        public LiveResultHeaderView?                    HeaderView                              { get; set; }
        public LiveResultPhaseControlView?              PhaseControlView                        { get; set; }
        public LiveResultIdolPhaseView?                 IdolPhaseView                           { get; set; }
        public LiveResultEventPhaseView?                EventPhaseView                          { get; set; }
        public string                                   BackgroundScene                         { get; set; }
        public Animator?                                AnimatorRoot                            { get; set; }
        public List<UnitIdol>?                          OnStageIdols                            { get; set; }
        public IFinishLiveReply?                        FinishLiveReply                         { get; set; }
        public SongCacheForResult?                      Cache                                   { get; set; }
        public int                                      VoiceType                               { get; set; }
        public int                                      ResultType                              { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }

        public static LiveResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultPresenter() { Pointer= p0 };

            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 02466509AE30 0x58 MusicInfoView               ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.MusicClearStatusLampView                  = GetObject<MusicClearStatusLampView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicClearStatusLampView.FromPointer); // 02466509AE50 0x60 MusicClearStatusLampView    ( 000186664330 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer )
            value.AutoLiveBadge                             = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466509AE70 0x68 AutoLiveBadge               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.HeaderView                                = GetObject<LiveResultHeaderView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveResultHeaderView.FromPointer); // 02466509AE90 0x70 HeaderView                  ( 00018656EC70 ModelClassType LiveResultHeaderView LiveResultHeaderView LiveResultHeaderView Pointer )
            value.PhaseControlView                          = GetObject<LiveResultPhaseControlView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveResultPhaseControlView.FromPointer); // 02466509AEB0 0x78 PhaseControlView            ( 0001865718B0 ModelClassType LiveResultPhaseControlView LiveResultPhaseControlView LiveResultPhaseControlView Pointer )
            value.IdolPhaseView                             = GetObject<LiveResultIdolPhaseView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveResultIdolPhaseView.FromPointer); // 02466509AED0 0x80 IdolPhaseView               ( 000186570060 ModelClassType LiveResultIdolPhaseView LiveResultIdolPhaseView LiveResultIdolPhaseView Pointer )
            value.EventPhaseView                            = GetObject<LiveResultEventPhaseView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveResultEventPhaseView.FromPointer); // 02466509AEF0 0x88 EventPhaseView              ( 00018656DF90 ModelClassType LiveResultEventPhaseView LiveResultEventPhaseView LiveResultEventPhaseView Pointer )
            value.BackgroundScene                           = GetString(new IntPtr(p + 0x090)); // 02466509AF10 0x90 BackgroundScene             ( 000186671910 ModelPrimitiveType string string string String )
            value.AnimatorRoot                              = GetObject<Animator>(new IntPtr(p + 0x098), ReversePrism.DataModels.Animator.FromPointer); // 02466509AF30 0x98 AnimatorRoot                ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.OnStageIdols                              = GetObjectList<UnitIdol>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UnitIdol.FromPointer); // 02466509AF50 0xA0 OnStageIdols                ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.FinishLiveReply                           = GetObject<IFinishLiveReply>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IFinishLiveReply.FromPointer); // 02466509AF70 0xA8 FinishLiveReply             ( 00018650F090 ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer )
            value.Cache                                     = GetObject<SongCacheForResult>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SongCacheForResult.FromPointer); // 02466509AF90 0xB0 Cache                       ( 000186528930 ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer )
            value.VoiceType                                 = GetInt32(new IntPtr(p + 0x0B8)); // 02466509AFB0 0xB8 VoiceType                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResultType                                = GetInt32(new IntPtr(p + 0x0BC)); // 02466509AFD0 0xBC ResultType                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ScenarioManager.FromPointer); // 02466509AFF0 0xC0 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
