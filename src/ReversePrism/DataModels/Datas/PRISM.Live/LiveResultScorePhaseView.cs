using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 MusicClearStatusLampView                 000186664330 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer
    // 060 ScoreInfoView                            0001865748C0 ModelClassType LiveResultScoreInfoView LiveResultScoreInfoView LiveResultScoreInfoView Pointer
    // 068 ComboInfoView                            00018656D300 ModelClassType LiveResultComboInfoView LiveResultComboInfoView LiveResultComboInfoView Pointer
    // 070 RateInfoView                             000186572550 ModelClassType LiveResultRateInfoView LiveResultRateInfoView LiveResultRateInfoView Pointer
    // 078 AutoLiveAnnotation                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class LiveResultScorePhaseView
    {
        public MusicClearStatusLampView?                MusicClearStatusLampView                { get; set; }
        public LiveResultScoreInfoView?                 ScoreInfoView                           { get; set; }
        public LiveResultComboInfoView?                 ComboInfoView                           { get; set; }
        public LiveResultRateInfoView?                  RateInfoView                            { get; set; }
        public GameObject?                              AutoLiveAnnotation                      { get; set; }

        public static LiveResultScorePhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultScorePhaseView();

            value.MusicClearStatusLampView                  = GetObject<MusicClearStatusLampView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicClearStatusLampView.FromPointer); // 0270D526C548 0x58 MusicClearStatusLampView    ( 000186664330 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer )
            value.ScoreInfoView                             = GetObject<LiveResultScoreInfoView>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveResultScoreInfoView.FromPointer); // 0270D526C568 0x60 ScoreInfoView               ( 0001865748C0 ModelClassType LiveResultScoreInfoView LiveResultScoreInfoView LiveResultScoreInfoView Pointer )
            value.ComboInfoView                             = GetObject<LiveResultComboInfoView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultComboInfoView.FromPointer); // 0270D526C588 0x68 ComboInfoView               ( 00018656D300 ModelClassType LiveResultComboInfoView LiveResultComboInfoView LiveResultComboInfoView Pointer )
            value.RateInfoView                              = GetObject<LiveResultRateInfoView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveResultRateInfoView.FromPointer); // 0270D526C5A8 0x70 RateInfoView                ( 000186572550 ModelClassType LiveResultRateInfoView LiveResultRateInfoView LiveResultRateInfoView Pointer )
            value.AutoLiveAnnotation                        = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526C5C8 0x78 AutoLiveAnnotation          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
