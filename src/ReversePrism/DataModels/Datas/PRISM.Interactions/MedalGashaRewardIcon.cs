using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 RewardCountText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 PIdolCaller                              000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    public partial class MedalGashaRewardIcon
    {
        public RewardItemIcon?                          Icon                                    { get; set; }
        public UITextMeshProUGUI?                       RewardCountText                         { get; set; }
        public PIdolDetailPopupCaller?                  PIdolCaller                             { get; set; }

        public static MedalGashaRewardIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardIcon();

            value.Icon                                      = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270DB934AF0 0x20 Icon                        ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.RewardCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB934B10 0x28 RewardCountText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PIdolCaller                               = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DB934B30 0x30 PIdolCaller                 ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )

            return value;
        }
    }
}
