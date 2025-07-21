using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 CategoryListView                         ModelClassType LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView Pointer
    // 080 MusicListCarousel                        ModelClassType MusicListCarousel MusicListCarousel MusicListCarousel Pointer
    // 088 MusicDetailView                          ModelClassType LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView Pointer
    // 090 View                                     ModelClassType LiveMusicSelectionView LiveMusicSelectionView LiveMusicSelectionView Pointer
    // 098 MusicRateView                            ModelClassType LiveMusicSelectionRateView LiveMusicSelectionRateView LiveMusicSelectionRateView Pointer
    // 0A0 MusicRankingOverlayCaller                ModelClassType MusicRankingOverlayCaller MusicRankingOverlayCaller MusicRankingOverlayCaller Pointer
    // 0A8 MusicRateOverlayCaller                   ModelClassType MusicRateOverlayCaller MusicRateOverlayCaller MusicRateOverlayCaller Pointer
    // 0B0 ShinyEnabledHowToPlayPopupOpener         ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0B8 HowToPlayPopupResourceConfigRefPc        ModelPrimitiveType string string string String
    // 0C0 Model                                    ModelClassType LiveMusicSelectionModel LiveMusicSelectionModel LiveMusicSelectionModel Pointer
    public partial class LiveMusicSelectionPresenter : DataModel
    {
        public LiveMusicSelectionCategoryListView?      CategoryListView                        { get; set; }
        public MusicListCarousel?                       MusicListCarousel                       { get; set; }
        public LiveMusicSelectionMusicDetailView?       MusicDetailView                         { get; set; }
        public LiveMusicSelectionView?                  View                                    { get; set; }
        public LiveMusicSelectionRateView?              MusicRateView                           { get; set; }
        public MusicRankingOverlayCaller?               MusicRankingOverlayCaller               { get; set; }
        public MusicRateOverlayCaller?                  MusicRateOverlayCaller                  { get; set; }
        public HowToPlayPopupOpener?                    ShinyEnabledHowToPlayPopupOpener        { get; set; }
        public string                                   HowToPlayPopupResourceConfigRefPc       { get; set; }
        public LiveMusicSelectionModel?                 Model                                   { get; set; }

        public static LiveMusicSelectionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionPresenter() { Pointer= p0 };

            value.CategoryListView                          = GetObject<LiveMusicSelectionCategoryListView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveMusicSelectionCategoryListView.FromPointer); // 0x78 CategoryListView            ( ModelClassType LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView LiveMusicSelectionCategoryListView Pointer )
            value.MusicListCarousel                         = GetObject<MusicListCarousel>(new IntPtr(p + 0x080), ReversePrism.DataModels.MusicListCarousel.FromPointer); // 0x80 MusicListCarousel           ( ModelClassType MusicListCarousel MusicListCarousel MusicListCarousel Pointer )
            value.MusicDetailView                           = GetObject<LiveMusicSelectionMusicDetailView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveMusicSelectionMusicDetailView.FromPointer); // 0x88 MusicDetailView             ( ModelClassType LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView LiveMusicSelectionMusicDetailView Pointer )
            value.View                                      = GetObject<LiveMusicSelectionView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveMusicSelectionView.FromPointer); // 0x90 View                        ( ModelClassType LiveMusicSelectionView LiveMusicSelectionView LiveMusicSelectionView Pointer )
            value.MusicRateView                             = GetObject<LiveMusicSelectionRateView>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveMusicSelectionRateView.FromPointer); // 0x98 MusicRateView               ( ModelClassType LiveMusicSelectionRateView LiveMusicSelectionRateView LiveMusicSelectionRateView Pointer )
            value.MusicRankingOverlayCaller                 = GetObject<MusicRankingOverlayCaller>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MusicRankingOverlayCaller.FromPointer); // 0xA0 MusicRankingOverlayCaller   ( ModelClassType MusicRankingOverlayCaller MusicRankingOverlayCaller MusicRankingOverlayCaller Pointer )
            value.MusicRateOverlayCaller                    = GetObject<MusicRateOverlayCaller>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MusicRateOverlayCaller.FromPointer); // 0xA8 MusicRateOverlayCaller      ( ModelClassType MusicRateOverlayCaller MusicRateOverlayCaller MusicRateOverlayCaller Pointer )
            value.ShinyEnabledHowToPlayPopupOpener          = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0xB0 ShinyEnabledHowToPlayPopupOpener ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.HowToPlayPopupResourceConfigRefPc         = GetString(new IntPtr(p + 0x0B8)); // 0xB8 HowToPlayPopupResourceConfigRefPc ( ModelPrimitiveType string string string String )
            value.Model                                     = GetObject<LiveMusicSelectionModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LiveMusicSelectionModel.FromPointer); // 0xC0 Model                       ( ModelClassType LiveMusicSelectionModel LiveMusicSelectionModel LiveMusicSelectionModel Pointer )

            return value;
        }
    }
}
