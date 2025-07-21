using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 <RewardList>k__BackingField              IEnumerable`1<ValueTuple`2<ProductKey, int>> IL2CPP_TYPE_GENERICINST
    // 030 CellType                                 ModelEnumType MusicRateRewardListCellType MusicRateRewardListCellType MusicRateRewardListCellType Int32
    // 034 AcquiredType                             ModelEnumType MusicRateRewardListAcquiredType MusicRateRewardListAcquiredType MusicRateRewardListAcquiredType Int32
    public partial class MusicRateRewardListCellData : DataModel
    {
        public MusicRateRewardListCellType              CellType                                { get; set; }
        public MusicRateRewardListAcquiredType          AcquiredType                            { get; set; }

        public static MusicRateRewardListCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListCellData() { Pointer= p0 };

            value.CellType                                  = (MusicRateRewardListCellType)GetInt32(new IntPtr(p + 0x030)); // 0x30 CellType                    ( ModelEnumType MusicRateRewardListCellType MusicRateRewardListCellType MusicRateRewardListCellType Int32 )
            value.AcquiredType                              = (MusicRateRewardListAcquiredType)GetInt32(new IntPtr(p + 0x034)); // 0x34 AcquiredType                ( ModelEnumType MusicRateRewardListAcquiredType MusicRateRewardListAcquiredType MusicRateRewardListAcquiredType Int32 )

            return value;
        }
    }
}
