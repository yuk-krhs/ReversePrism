using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 AnimatorEvent                            0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 040 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 048 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class ChallengeTourResultRewardViewCell
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public Animator?                                Animator                                { get; set; }
        public AnimatorWithEvent?                       AnimatorEvent                           { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }

        public static ChallengeTourResultRewardViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultRewardViewCell();

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270DA1CAA98 0x20 ItemIcon                    ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1CAAB8 0x28 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0270DA1CAAD8 0x30 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.AnimatorEvent                             = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270DA1CAAF8 0x38 AnimatorEvent               ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DA1CAB18 0x40 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270DA1CAB38 0x48 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
