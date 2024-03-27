using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 scoreRankRewardDic                       Dictionary`2<SongDifficultyLevel, Dictionary`2<ScoreRank, IScoreRankRewardStatus>> IL2CPP_TYPE_GENERICINST
    // 018 comboRankRewardDic                       Dictionary`2<SongDifficultyLevel, Dictionary`2<ComboRank, IComboRankRewardStatus>> IL2CPP_TYPE_GENERICINST
    public partial class MusicRewardHandler
    {

        public static MusicRewardHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRewardHandler();


            return value;
        }
    }
}
