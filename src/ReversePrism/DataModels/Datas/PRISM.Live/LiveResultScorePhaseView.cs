using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MusicClearStatusLampView                 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer
    // 068 ScoreInfoView                            ModelClassType LiveResultScoreInfoView LiveResultScoreInfoView LiveResultScoreInfoView Pointer
    // 070 ComboInfoView                            ModelClassType LiveResultComboInfoView LiveResultComboInfoView LiveResultComboInfoView Pointer
    // 078 RateInfoView                             ModelClassType LiveResultRateInfoView LiveResultRateInfoView LiveResultRateInfoView Pointer
    // 080 AutoLiveAnnotation                       ModelClassType GameObject GameObject GameObject Pointer
    // 088 ShinyEnabledHowToPlayPopupOpener         ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 090 OpenRateOverlayButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 098 RateOverlayCaller                        ModelClassType MusicRateOverlayCaller MusicRateOverlayCaller MusicRateOverlayCaller Pointer
    public partial class LiveResultScorePhaseView : DataModel
    {
        public MusicClearStatusLampView?                MusicClearStatusLampView                { get; set; }
        public LiveResultScoreInfoView?                 ScoreInfoView                           { get; set; }
        public LiveResultComboInfoView?                 ComboInfoView                           { get; set; }
        public LiveResultRateInfoView?                  RateInfoView                            { get; set; }
        public GameObject?                              AutoLiveAnnotation                      { get; set; }
        public HowToPlayPopupOpener?                    ShinyEnabledHowToPlayPopupOpener        { get; set; }
        public UIButton?                                OpenRateOverlayButton                   { get; set; }
        public MusicRateOverlayCaller?                  RateOverlayCaller                       { get; set; }

        public static LiveResultScorePhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultScorePhaseView() { Pointer= p0 };

            value.MusicClearStatusLampView                  = GetObject<MusicClearStatusLampView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicClearStatusLampView.FromPointer); // 0x60 MusicClearStatusLampView    ( ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer )
            value.ScoreInfoView                             = GetObject<LiveResultScoreInfoView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultScoreInfoView.FromPointer); // 0x68 ScoreInfoView               ( ModelClassType LiveResultScoreInfoView LiveResultScoreInfoView LiveResultScoreInfoView Pointer )
            value.ComboInfoView                             = GetObject<LiveResultComboInfoView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveResultComboInfoView.FromPointer); // 0x70 ComboInfoView               ( ModelClassType LiveResultComboInfoView LiveResultComboInfoView LiveResultComboInfoView Pointer )
            value.RateInfoView                              = GetObject<LiveResultRateInfoView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveResultRateInfoView.FromPointer); // 0x78 RateInfoView                ( ModelClassType LiveResultRateInfoView LiveResultRateInfoView LiveResultRateInfoView Pointer )
            value.AutoLiveAnnotation                        = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 AutoLiveAnnotation          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShinyEnabledHowToPlayPopupOpener          = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x088), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x88 ShinyEnabledHowToPlayPopupOpener ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.OpenRateOverlayButton                     = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0x90 OpenRateOverlayButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RateOverlayCaller                         = GetObject<MusicRateOverlayCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.MusicRateOverlayCaller.FromPointer); // 0x98 RateOverlayCaller           ( ModelClassType MusicRateOverlayCaller MusicRateOverlayCaller MusicRateOverlayCaller Pointer )

            return value;
        }
    }
}
