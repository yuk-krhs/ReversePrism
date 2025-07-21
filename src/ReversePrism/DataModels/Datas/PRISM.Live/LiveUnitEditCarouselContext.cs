using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 <TryCalculateUnitParameterBonus>k__BackingField Action`1<LiveUnit> IL2CPP_TYPE_GENERICINST
    // 060 <RequestExchangeMemberPositionAsync>k__BackingField Func`4<LiveUnit, int, int, UniTask> IL2CPP_TYPE_GENERICINST
    // 068 <IdolStatusDisplayType>k__BackingField   ReactiveProperty`1<LiveIdolIconStatusDisplayType> IL2CPP_TYPE_GENERICINST
    // 070 <IsSupportMemberTabOn>k__BackingField    ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 MusicDifficulty                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    public partial class LiveUnitEditCarouselContext : DataModel
    {
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }

        public static LiveUnitEditCarouselContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCarouselContext() { Pointer= p0 };

            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x078)); // 0x78 MusicDifficulty             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )

            return value;
        }
    }
}
