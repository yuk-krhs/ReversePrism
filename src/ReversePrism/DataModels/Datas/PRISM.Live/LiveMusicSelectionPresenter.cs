using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 CategoryListView                         000186563C10 ModelClassType LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView Pointer
    // 088 MusicListCarousel                        000186666D80 ModelClassType MusicListCarousel MusicListCarousel MusicListCarousel Pointer
    // 090 MusicDetailView                          000186564AF0 ModelClassType LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView Pointer
    // 098 View                                     000186566710 ModelClassType LiveMusicSelectionView LiveMusicSelectionView LiveMusicSelectionView Pointer
    // 0A0 MusicRateView                            000186565530 ModelClassType LiveMusicSelectionRateView LiveMusicSelectionRateView LiveMusicSelectionRateView Pointer
    // 0A8 MusicRankingOverlayCaller                00018666A2A0 ModelClassType MusicRankingOverlayCaller MusicRankingOverlayCaller MusicRankingOverlayCaller Pointer
    // 0B0 MusicRateOverlayCaller                   00018666D690 ModelClassType MusicRateOverlayCaller MusicRateOverlayCaller MusicRateOverlayCaller Pointer
    // 0B8 HowToPlayPopupResourceConfigRefPc        000186671910 ModelPrimitiveType string string string String
    // 0C0 Model                                    000186564610 ModelClassType LiveMusicSelectionModel LiveMusicSelectionModel LiveMusicSelectionModel Pointer
    public partial class LiveMusicSelectionPresenter
    {
        public LiveMusicSelectionCategoryListView?      CategoryListView                        { get; set; }
        public MusicListCarousel?                       MusicListCarousel                       { get; set; }
        public LiveMusicSelectionMusicDetailView?       MusicDetailView                         { get; set; }
        public LiveMusicSelectionView?                  View                                    { get; set; }
        public LiveMusicSelectionRateView?              MusicRateView                           { get; set; }
        public MusicRankingOverlayCaller?               MusicRankingOverlayCaller               { get; set; }
        public MusicRateOverlayCaller?                  MusicRateOverlayCaller                  { get; set; }
        public string                                   HowToPlayPopupResourceConfigRefPc       { get; set; }
        public LiveMusicSelectionModel?                 Model                                   { get; set; }

        public static LiveMusicSelectionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionPresenter();

            value.CategoryListView                          = GetObject<LiveMusicSelectionCategoryListView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveMusicSelectionCategoryListView.FromPointer); // 0270D515A410 0x80 CategoryListView            ( 000186563C10 ModelClassType LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView Pointer )
            value.MusicListCarousel                         = GetObject<MusicListCarousel>(new IntPtr(p + 0x088), ReversePrism.DataModels.MusicListCarousel.FromPointer); // 0270D515A430 0x88 MusicListCarousel           ( 000186666D80 ModelClassType MusicListCarousel MusicListCarousel MusicListCarousel Pointer )
            value.MusicDetailView                           = GetObject<LiveMusicSelectionMusicDetailView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveMusicSelectionMusicDetailView.FromPointer); // 0270D515A450 0x90 MusicDetailView             ( 000186564AF0 ModelClassType LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView Pointer )
            value.View                                      = GetObject<LiveMusicSelectionView>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveMusicSelectionView.FromPointer); // 0270D515A470 0x98 View                        ( 000186566710 ModelClassType LiveMusicSelectionView LiveMusicSelectionView LiveMusicSelectionView Pointer )
            value.MusicRateView                             = GetObject<LiveMusicSelectionRateView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.LiveMusicSelectionRateView.FromPointer); // 0270D515A490 0xA0 MusicRateView               ( 000186565530 ModelClassType LiveMusicSelectionRateView LiveMusicSelectionRateView LiveMusicSelectionRateView Pointer )
            value.MusicRankingOverlayCaller                 = GetObject<MusicRankingOverlayCaller>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MusicRankingOverlayCaller.FromPointer); // 0270D515A4B0 0xA8 MusicRankingOverlayCaller   ( 00018666A2A0 ModelClassType MusicRankingOverlayCaller MusicRankingOverlayCaller MusicRankingOverlayCaller Pointer )
            value.MusicRateOverlayCaller                    = GetObject<MusicRateOverlayCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MusicRateOverlayCaller.FromPointer); // 0270D515A4D0 0xB0 MusicRateOverlayCaller      ( 00018666D690 ModelClassType MusicRateOverlayCaller MusicRateOverlayCaller MusicRateOverlayCaller Pointer )
            value.HowToPlayPopupResourceConfigRefPc         = GetString(new IntPtr(p + 0x0B8)); // 0270D515A4F0 0xB8 HowToPlayPopupResourceConfigRefPc ( 000186671910 ModelPrimitiveType string string string String )
            value.Model                                     = GetObject<LiveMusicSelectionModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LiveMusicSelectionModel.FromPointer); // 0270D515A510 0xC0 Model                       ( 000186564610 ModelClassType LiveMusicSelectionModel LiveMusicSelectionModel LiveMusicSelectionModel Pointer )

            return value;
        }
    }
}
