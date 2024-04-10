using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AchievementData                          000185CC0AE8 ModelClassListType AchievementData[] AchievementData[] List<AchievementData> Pointer
    // 018 achievementMap                           Dictionary`2<int, AchievementInfo> IL2CPP_TYPE_GENERICINST
    public partial class ProfileAchievementIsNewSaveData : DataModel
    {
        public List<AchievementData>?                   AchievementData                         { get; set; }

        public static ProfileAchievementIsNewSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementIsNewSaveData() { Pointer= p0 };

            value.AchievementData                           = GetObjectList<AchievementData>(new IntPtr(p + 0x010), ReversePrism.DataModels.AchievementData.FromPointer); // 0245A3A78818 0x10 AchievementData             ( 000185CC0AE8 ModelClassListType AchievementData[] AchievementData[] List<AchievementData> Pointer )

            return value;
        }
    }
}
