using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardListView                           ModelClassType AllSongIdolRewardListView AllSongIdolRewardListView AllSongIdolRewardListView Pointer
    // 028 IdolSelectListView                       ModelClassType LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView Pointer
    // 030 ViewModel                                ModelClassType LiveEventAllSongRewardTabViewModel LiveEventAllSongRewardTabViewModel LiveEventAllSongRewardTabViewModel Pointer
    // 038 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    public partial class LiveEventAllSongIdolRewardTabView : DataModel
    {
        public AllSongIdolRewardListView?               RewardListView                          { get; set; }
        public LiveEventRankingIdolSelectListView?      IdolSelectListView                      { get; set; }
        public LiveEventAllSongRewardTabViewModel?      ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static LiveEventAllSongIdolRewardTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongIdolRewardTabView() { Pointer= p0 };

            value.RewardListView                            = GetObject<AllSongIdolRewardListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AllSongIdolRewardListView.FromPointer); // 0x20 RewardListView              ( ModelClassType AllSongIdolRewardListView AllSongIdolRewardListView AllSongIdolRewardListView Pointer )
            value.IdolSelectListView                        = GetObject<LiveEventRankingIdolSelectListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingIdolSelectListView.FromPointer); // 0x28 IdolSelectListView          ( ModelClassType LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView LiveEventRankingIdolSelectListView Pointer )
            value.ViewModel                                 = GetObject<LiveEventAllSongRewardTabViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveEventAllSongRewardTabViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType LiveEventAllSongRewardTabViewModel LiveEventAllSongRewardTabViewModel LiveEventAllSongRewardTabViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x038)); // 0x38 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
