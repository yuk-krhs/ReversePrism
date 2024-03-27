using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 <RewardList>k__BackingField              IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 030 CellType                                 00018666F3A0 ModelEnumType MusicRateRewardListCellType MusicRateRewardListCellType MusicRateRewardListCellType Int32
    public partial class MusicRateRewardListCellData
    {
        public MusicRateRewardListCellType              CellType                                { get; set; }

        public static MusicRateRewardListCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListCellData();

            value.CellType                                  = (MusicRateRewardListCellType)GetInt32(new IntPtr(p + 0x030)); // 0270D640C808 0x30 CellType                    ( 00018666F3A0 ModelEnumType MusicRateRewardListCellType MusicRateRewardListCellType MusicRateRewardListCellType Int32 )

            return value;
        }
    }
}
