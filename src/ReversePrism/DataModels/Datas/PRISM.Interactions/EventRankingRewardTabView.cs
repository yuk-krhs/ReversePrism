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
    public partial class EventRankingRewardTabView : DataModel
    {
        public RankingRewardListView?                   RewardListView                          { get; set; }
        public int                                      EventId                                 { get; set; }

        public static EventRankingRewardTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRankingRewardTabView() { Pointer= p0 };

            value.RewardListView                            = GetObject<RankingRewardListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.RankingRewardListView.FromPointer); // 02466B992778 0x20 RewardListView              ( 00018660EBF0 ModelClassType RankingRewardListView RankingRewardListView RankingRewardListView Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x028)); // 02466B992798 0x28 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
