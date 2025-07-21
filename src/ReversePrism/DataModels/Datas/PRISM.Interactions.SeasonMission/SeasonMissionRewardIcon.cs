using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItemIcon                           ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 LockIconObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 BadgeObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 AcquiredImageObject                      ModelClassType GameObject GameObject GameObject Pointer
    public partial class SeasonMissionRewardIcon : DataModel
    {
        public RewardItemIcon?                          RewardItemIcon                          { get; set; }
        public GameObject?                              LockIconObject                          { get; set; }
        public GameObject?                              BadgeObject                             { get; set; }
        public GameObject?                              AcquiredImageObject                     { get; set; }

        public static SeasonMissionRewardIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionRewardIcon() { Pointer= p0 };

            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x20 RewardItemIcon              ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.LockIconObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 LockIconObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeObject                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 BadgeObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AcquiredImageObject                       = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 AcquiredImageObject         ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
