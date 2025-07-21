using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 GetIcon                                  ModelClassType GameObject GameObject GameObject Pointer
    public partial class ChallengeTourRewardIcon : DataModel
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public GameObject?                              GetIcon                                 { get; set; }

        public static ChallengeTourRewardIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourRewardIcon() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x20 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.GetIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GetIcon                     ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
