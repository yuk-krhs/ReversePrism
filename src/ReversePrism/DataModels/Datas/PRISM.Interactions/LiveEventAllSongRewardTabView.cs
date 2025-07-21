using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardListView                           ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer
    // 028 EventId                                  ModelPrimitiveType int int int Int32
    public partial class LiveEventAllSongRewardTabView : DataModel
    {
        public RankingRewardListView?                   RewardListView                          { get; set; }
        public int                                      EventId                                 { get; set; }

        public static LiveEventAllSongRewardTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongRewardTabView() { Pointer= p0 };

            value.RewardListView                            = GetObject<RankingRewardListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.RankingRewardListView.FromPointer); // 0x20 RewardListView              ( ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 EventId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
