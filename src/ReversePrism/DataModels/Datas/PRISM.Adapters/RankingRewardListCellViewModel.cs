using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartRank                                0001865F4260 ModelPrimitiveType int int int Int32
    // 014 EndRank                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 <RewardList>k__BackingField              IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    public partial class RankingRewardListCellViewModel
    {
        public int                                      StartRank                               { get; set; }
        public int                                      EndRank                                 { get; set; }

        public static RankingRewardListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingRewardListCellViewModel();

            value.StartRank                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D6411D58 0x10 StartRank                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EndRank                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D6411D78 0x14 EndRank                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
