using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 RewardCountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MedalGashaRewardIcon : DataModel
    {
        public RewardItemIcon?                          Icon                                    { get; set; }
        public UITextMeshProUGUI?                       RewardCountText                         { get; set; }

        public static MedalGashaRewardIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardIcon() { Pointer= p0 };

            value.Icon                                      = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x20 Icon                        ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.RewardCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 RewardCountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
