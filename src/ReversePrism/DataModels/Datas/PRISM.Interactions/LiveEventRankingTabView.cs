using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 UserRankingView                          ModelClassType UserRankingView UserRankingView UserRankingView Pointer
    // 030 LiveEventRankingListView                 ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer
    // 038 DifficultyIcon                           ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer
    // 040 MusicInfoView                            ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 048 PointIcon                                ModelClassType RawImage RawImage RawImage Pointer
    // 050 AggregationView                          ModelClassType LiveEventRankingAggregationView LiveEventRankingAggregationView LiveEventRankingAggregationView Pointer
    // 058 CommentInput                             ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 060 ViewModel                                ModelClassType LiveEventRankingTabViewModel LiveEventRankingTabViewModel LiveEventRankingTabViewModel Pointer
    // 068 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    public partial class LiveEventRankingTabView : DataModel
    {
        public UITabGroupEx?                            TabGroup                                { get; set; }
        public UserRankingView?                         UserRankingView                         { get; set; }
        public LiveEventRankingListView?                LiveEventRankingListView                { get; set; }
        public MusicDifficultyIcon?                     DifficultyIcon                          { get; set; }
        public MusicBasicInfoView?                      MusicInfoView                           { get; set; }
        public RawImage?                                PointIcon                               { get; set; }
        public LiveEventRankingAggregationView?         AggregationView                         { get; set; }
        public CommonInputFieldTMP?                     CommentInput                            { get; set; }
        public LiveEventRankingTabViewModel?            ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static LiveEventRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingTabView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.UserRankingView                           = GetObject<UserRankingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UserRankingView.FromPointer); // 0x28 UserRankingView             ( ModelClassType UserRankingView UserRankingView UserRankingView Pointer )
            value.LiveEventRankingListView                  = GetObject<LiveEventRankingListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveEventRankingListView.FromPointer); // 0x30 LiveEventRankingListView    ( ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer )
            value.DifficultyIcon                            = GetObject<MusicDifficultyIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicDifficultyIcon.FromPointer); // 0x38 DifficultyIcon              ( ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer )
            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x40 MusicInfoView               ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.PointIcon                                 = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0x48 PointIcon                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.AggregationView                           = GetObject<LiveEventRankingAggregationView>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveEventRankingAggregationView.FromPointer); // 0x50 AggregationView             ( ModelClassType LiveEventRankingAggregationView LiveEventRankingAggregationView LiveEventRankingAggregationView Pointer )
            value.CommentInput                              = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x058), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x58 CommentInput                ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ViewModel                                 = GetObject<LiveEventRankingTabViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveEventRankingTabViewModel.FromPointer); // 0x60 ViewModel                   ( ModelClassType LiveEventRankingTabViewModel LiveEventRankingTabViewModel LiveEventRankingTabViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x068)); // 0x68 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
