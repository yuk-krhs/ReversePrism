using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartRank                                ModelPrimitiveType int int int Int32
    // 014 EndRank                                  ModelPrimitiveType int int int Int32
    // 018 <RewardList>k__BackingField              IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    public partial class RankingRewardListCellViewModel : DataModel
    {
        public int                                      StartRank                               { get; set; }
        public int                                      EndRank                                 { get; set; }

        public static RankingRewardListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingRewardListCellViewModel() { Pointer= p0 };

            value.StartRank                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartRank                   ( ModelPrimitiveType int int int Int32 )
            value.EndRank                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 EndRank                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
