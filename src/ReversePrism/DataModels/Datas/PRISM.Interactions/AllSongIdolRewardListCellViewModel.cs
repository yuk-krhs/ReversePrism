using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolName                                 ModelPrimitiveType string string string String
    // 018 Grade                                    ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32
    // 01C StartRank                                ModelPrimitiveType int int int Int32
    // 020 RankPercent                              ModelPrimitiveType int int int Int32
    // 024 IsUsePercent                             ModelPrimitiveType bool bool bool Bool
    // 028 <RewardList>k__BackingField              IEnumerable`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    public partial class AllSongIdolRewardListCellViewModel : DataModel
    {
        public string                                   IdolName                                { get; set; }
        public EventRankGrade                           Grade                                   { get; set; }
        public int                                      StartRank                               { get; set; }
        public int                                      RankPercent                             { get; set; }
        public bool                                     IsUsePercent                            { get; set; }

        public static AllSongIdolRewardListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllSongIdolRewardListCellViewModel() { Pointer= p0 };

            value.IdolName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 IdolName                    ( ModelPrimitiveType string string string String )
            value.Grade                                     = (EventRankGrade)GetInt32(new IntPtr(p + 0x018)); // 0x18 Grade                       ( ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32 )
            value.StartRank                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StartRank                   ( ModelPrimitiveType int int int Int32 )
            value.RankPercent                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 RankPercent                 ( ModelPrimitiveType int int int Int32 )
            value.IsUsePercent                              = GetBool(new IntPtr(p + 0x024)); // 0x24 IsUsePercent                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
