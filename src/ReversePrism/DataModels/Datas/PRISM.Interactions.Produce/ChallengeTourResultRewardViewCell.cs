using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 038 AnimatorEvent                            ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    public partial class ChallengeTourResultRewardViewCell : DataModel
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public Animator?                                Animator                                { get; set; }
        public AnimatorWithEvent?                       AnimatorEvent                           { get; set; }

        public static ChallengeTourResultRewardViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultRewardViewCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x20 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.AnimatorEvent                             = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x38 AnimatorEvent               ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )

            return value;
        }
    }
}
