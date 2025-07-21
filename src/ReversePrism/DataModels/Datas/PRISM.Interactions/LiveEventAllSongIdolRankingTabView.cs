using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType LiveEventRankingIdolSelfRankListView LiveEventRankingIdolSelfRankListView LiveEventRankingIdolSelfRankListView Pointer
    // 028 PointRankingView                         ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer
    // 030 BorderListView                           ModelClassType LiveEventAllSongBorderListView LiveEventAllSongBorderListView LiveEventAllSongBorderListView Pointer
    // 038 TabGroup                                 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 040 IdolSelectListView                       ModelClassType LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView Pointer
    // 048 AggregationView                          ModelClassType LiveEventRankingAggregationView LiveEventRankingAggregationView LiveEventRankingAggregationView Pointer
    // 050 CommentInput                             ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 058 ViewModel                                ModelClassType LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel Pointer
    // 060 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 068 LoginUserData                            ModelClassType LoginUserData LoginUserData LoginUserData Pointer
    public partial class LiveEventAllSongIdolRankingTabView : DataModel
    {
        public LiveEventRankingIdolSelfRankListView?    ListView                                { get; set; }
        public LiveEventRankingListView?                PointRankingView                        { get; set; }
        public LiveEventAllSongBorderListView?          BorderListView                          { get; set; }
        public UITabGroupEx?                            TabGroup                                { get; set; }
        public LiveEventRankingIdolSelectListView?      IdolSelectListView                      { get; set; }
        public LiveEventRankingAggregationView?         AggregationView                         { get; set; }
        public CommonInputFieldTMP?                     CommentInput                            { get; set; }
        public LiveEventAllSongRankingTabViewModel?     ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public LoginUserData?                           LoginUserData                           { get; set; }

        public static LiveEventAllSongIdolRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongIdolRankingTabView() { Pointer= p0 };

            value.ListView                                  = GetObject<LiveEventRankingIdolSelfRankListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveEventRankingIdolSelfRankListView.FromPointer); // 0x20 ListView                    ( ModelClassType LiveEventRankingIdolSelfRankListView LiveEventRankingIdolSelfRankListView LiveEventRankingIdolSelfRankListView Pointer )
            value.PointRankingView                          = GetObject<LiveEventRankingListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingListView.FromPointer); // 0x28 PointRankingView            ( ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer )
            value.BorderListView                            = GetObject<LiveEventAllSongBorderListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveEventAllSongBorderListView.FromPointer); // 0x30 BorderListView              ( ModelClassType LiveEventAllSongBorderListView LiveEventAllSongBorderListView LiveEventAllSongBorderListView Pointer )
            value.TabGroup                                  = GetObject<UITabGroupEx>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x38 TabGroup                    ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.IdolSelectListView                        = GetObject<LiveEventRankingIdolSelectListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveEventRankingIdolSelectListView.FromPointer); // 0x40 IdolSelectListView          ( ModelClassType LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView Pointer )
            value.AggregationView                           = GetObject<LiveEventRankingAggregationView>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveEventRankingAggregationView.FromPointer); // 0x48 AggregationView             ( ModelClassType LiveEventRankingAggregationView LiveEventRankingAggregationView LiveEventRankingAggregationView Pointer )
            value.CommentInput                              = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x50 CommentInput                ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ViewModel                                 = GetObject<LiveEventAllSongRankingTabViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveEventAllSongRankingTabViewModel.FromPointer); // 0x58 ViewModel                   ( ModelClassType LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel LiveEventAllSongRankingTabViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x060)); // 0x60 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.LoginUserData                             = GetObject<LoginUserData>(new IntPtr(p + 0x068), ReversePrism.DataModels.LoginUserData.FromPointer); // 0x68 LoginUserData               ( ModelClassType LoginUserData LoginUserData LoginUserData Pointer )

            return value;
        }
    }
}
