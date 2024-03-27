using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardListView                           00018660EBF0 ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer
    // 028 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EventRankingRewardTabView
    {
        public RankingRewardListView?                   RewardListView                          { get; set; }
        public int                                      EventId                                 { get; set; }

        public static EventRankingRewardTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankingRewardTabView();

            value.RewardListView                            = GetObject<RankingRewardListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.RankingRewardListView.FromPointer); // 0270DB90B4A0 0x20 RewardListView              ( 00018660EBF0 ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x028)); // 0270DB90B4C0 0x28 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
