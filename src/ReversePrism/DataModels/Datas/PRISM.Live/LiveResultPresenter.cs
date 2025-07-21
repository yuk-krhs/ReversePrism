using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 MusicInfoView                            ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 058 MusicClearStatusLampView                 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer
    // 060 AutoLiveBadge                            ModelClassType GameObject GameObject GameObject Pointer
    // 068 HeaderView                               ModelClassType LiveResultHeaderView LiveResultHeaderView LiveResultHeaderView Pointer
    // 070 PhaseControlView                         ModelClassType LiveResultPhaseControlView LiveResultPhaseControlView LiveResultPhaseControlView Pointer
    // 078 IdolPhaseView                            ModelClassType LiveResultIdolPhaseView LiveResultIdolPhaseView LiveResultIdolPhaseView Pointer
    // 080 EventPhaseView                           ModelClassType LiveResultEventPhaseView LiveResultEventPhaseView LiveResultEventPhaseView Pointer
    // 088 AllSongEventPhaseView                    ModelClassType LiveResultAllSongEventPhaseView LiveResultAllSongEventPhaseView LiveResultAllSongEventPhaseView Pointer
    // 090 BackgroundScene                          ModelPrimitiveType string string string String
    // 098 AnimatorRoot                             ModelClassType Animator Animator Animator Pointer
    // 0A0 Model3dLoader                            ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer
    // 0A8 FinishLiveReply                          ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer
    // 0B0 Cache                                    ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer
    // 0B8 InGameData                               ModelClassType LiveResultData LiveResultData LiveResultData Pointer
    // 0C0 VoiceType                                ModelPrimitiveType int int int Int32
    // 0C4 ResultType                               ModelPrimitiveType int int int Int32
    // 0C8 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 0D0 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class LiveResultPresenter : DataModel
    {
        public MusicBasicInfoView?                      MusicInfoView                           { get; set; }
        public MusicClearStatusLampView?                MusicClearStatusLampView                { get; set; }
        public GameObject?                              AutoLiveBadge                           { get; set; }
        public LiveResultHeaderView?                    HeaderView                              { get; set; }
        public LiveResultPhaseControlView?              PhaseControlView                        { get; set; }
        public LiveResultIdolPhaseView?                 IdolPhaseView                           { get; set; }
        public LiveResultEventPhaseView?                EventPhaseView                          { get; set; }
        public LiveResultAllSongEventPhaseView?         AllSongEventPhaseView                   { get; set; }
        public string                                   BackgroundScene                         { get; set; }
        public Animator?                                AnimatorRoot                            { get; set; }
        public SimpleModel3dLoader?                     Model3dLoader                           { get; set; }
        public IFinishLiveReply?                        FinishLiveReply                         { get; set; }
        public SongCacheForResult?                      Cache                                   { get; set; }
        public LiveResultData?                          InGameData                              { get; set; }
        public int                                      VoiceType                               { get; set; }
        public int                                      ResultType                              { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static LiveResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultPresenter() { Pointer= p0 };

            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x050), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x50 MusicInfoView               ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.MusicClearStatusLampView                  = GetObject<MusicClearStatusLampView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicClearStatusLampView.FromPointer); // 0x58 MusicClearStatusLampView    ( ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer )
            value.AutoLiveBadge                             = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 AutoLiveBadge               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HeaderView                                = GetObject<LiveResultHeaderView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultHeaderView.FromPointer); // 0x68 HeaderView                  ( ModelClassType LiveResultHeaderView LiveResultHeaderView LiveResultHeaderView Pointer )
            value.PhaseControlView                          = GetObject<LiveResultPhaseControlView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveResultPhaseControlView.FromPointer); // 0x70 PhaseControlView            ( ModelClassType LiveResultPhaseControlView LiveResultPhaseControlView LiveResultPhaseControlView Pointer )
            value.IdolPhaseView                             = GetObject<LiveResultIdolPhaseView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveResultIdolPhaseView.FromPointer); // 0x78 IdolPhaseView               ( ModelClassType LiveResultIdolPhaseView LiveResultIdolPhaseView LiveResultIdolPhaseView Pointer )
            value.EventPhaseView                            = GetObject<LiveResultEventPhaseView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveResultEventPhaseView.FromPointer); // 0x80 EventPhaseView              ( ModelClassType LiveResultEventPhaseView LiveResultEventPhaseView LiveResultEventPhaseView Pointer )
            value.AllSongEventPhaseView                     = GetObject<LiveResultAllSongEventPhaseView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveResultAllSongEventPhaseView.FromPointer); // 0x88 AllSongEventPhaseView       ( ModelClassType LiveResultAllSongEventPhaseView LiveResultAllSongEventPhaseView LiveResultAllSongEventPhaseView Pointer )
            value.BackgroundScene                           = GetString(new IntPtr(p + 0x090)); // 0x90 BackgroundScene             ( ModelPrimitiveType string string string String )
            value.AnimatorRoot                              = GetObject<Animator>(new IntPtr(p + 0x098), ReversePrism.DataModels.Animator.FromPointer); // 0x98 AnimatorRoot                ( ModelClassType Animator Animator Animator Pointer )
            value.Model3dLoader                             = GetObject<SimpleModel3dLoader>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SimpleModel3dLoader.FromPointer); // 0xA0 Model3dLoader               ( ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer )
            value.FinishLiveReply                           = GetObject<IFinishLiveReply>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IFinishLiveReply.FromPointer); // 0xA8 FinishLiveReply             ( ModelClassType IFinishLiveReply IFinishLiveReply IFinishLiveReply Pointer )
            value.Cache                                     = GetObject<SongCacheForResult>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SongCacheForResult.FromPointer); // 0xB0 Cache                       ( ModelClassType SongCacheForResult SongCacheForResult SongCacheForResult Pointer )
            value.InGameData                                = GetObject<LiveResultData>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.LiveResultData.FromPointer); // 0xB8 InGameData                  ( ModelClassType LiveResultData LiveResultData LiveResultData Pointer )
            value.VoiceType                                 = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 VoiceType                   ( ModelPrimitiveType int int int Int32 )
            value.ResultType                                = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 ResultType                  ( ModelPrimitiveType int int int Int32 )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0xC8 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xD0 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
