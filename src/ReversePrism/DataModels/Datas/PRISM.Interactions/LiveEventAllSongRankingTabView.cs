using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelfRankingView                          ModelClassType LiveEventAllSongSelfRankingView LiveEventAllSongSelfRankingView LiveEventAllSongSelfRankingView Pointer
    // 028 PointRankingView                         ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer
    // 030 TabGroup                                 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 038 DifficultyIcon                           ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer
    // 040 MusicInfoView                            ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 048 AggregationView                          ModelClassType LiveEventRankingAggregationView LiveEventRankingAggregationView LiveEventRankingAggregationView Pointer
    // 050 CommentInput                             ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 058 ViewModel                                ModelClassType LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel Pointer
    // 060 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 068 LoginUserData                            ModelClassType LoginUserData LoginUserData LoginUserData Pointer
    // 070 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class LiveEventAllSongRankingTabView : DataModel
    {
        public LiveEventAllSongSelfRankingView?         SelfRankingView                         { get; set; }
        public LiveEventRankingListView?                PointRankingView                        { get; set; }
        public UITabGroupEx?                            TabGroup                                { get; set; }
        public MusicDifficultyIcon?                     DifficultyIcon                          { get; set; }
        public MusicBasicInfoView?                      MusicInfoView                           { get; set; }
        public LiveEventRankingAggregationView?         AggregationView                         { get; set; }
        public CommonInputFieldTMP?                     CommentInput                            { get; set; }
        public LiveEventAllSongRankingTabViewModel?     ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public LoginUserData?                           LoginUserData                           { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static LiveEventAllSongRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongRankingTabView() { Pointer= p0 };

            value.SelfRankingView                           = GetObject<LiveEventAllSongSelfRankingView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveEventAllSongSelfRankingView.FromPointer); // 0x20 SelfRankingView             ( ModelClassType LiveEventAllSongSelfRankingView LiveEventAllSongSelfRankingView LiveEventAllSongSelfRankingView Pointer )
            value.PointRankingView                          = GetObject<LiveEventRankingListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingListView.FromPointer); // 0x28 PointRankingView            ( ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer )
            value.TabGroup                                  = GetObject<UITabGroupEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x30 TabGroup                    ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.DifficultyIcon                            = GetObject<MusicDifficultyIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicDifficultyIcon.FromPointer); // 0x38 DifficultyIcon              ( ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer )
            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x40 MusicInfoView               ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.AggregationView                           = GetObject<LiveEventRankingAggregationView>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveEventRankingAggregationView.FromPointer); // 0x48 AggregationView             ( ModelClassType LiveEventRankingAggregationView LiveEventRankingAggregationView LiveEventRankingAggregationView Pointer )
            value.CommentInput                              = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x50 CommentInput                ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ViewModel                                 = GetObject<LiveEventAllSongRankingTabViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveEventAllSongRankingTabViewModel.FromPointer); // 0x58 ViewModel                   ( ModelClassType LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x060)); // 0x60 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.LoginUserData                             = GetObject<LoginUserData>(new IntPtr(p + 0x068), ReversePrism.DataModels.LoginUserData.FromPointer); // 0x68 LoginUserData               ( ModelClassType LoginUserData LoginUserData LoginUserData Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x70 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
