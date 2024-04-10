using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 <OnAchievementLongPressed>k__BackingField Action`1<int> IL2CPP_TYPE_GENERICINST
    // 040 <OnIdolIconLongPressed>k__BackingField   Action`1<MusicScoreRankingViewModel> IL2CPP_TYPE_GENERICINST
    public partial class MusicScoreRankingContext : DataModel
    {

        public static MusicScoreRankingContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicScoreRankingContext() { Pointer= p0 };


            return value;
        }
    }
}
