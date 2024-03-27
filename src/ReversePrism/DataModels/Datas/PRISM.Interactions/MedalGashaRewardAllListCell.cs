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
    // 030 CountBase                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 CompleteObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PIdolCaller                              000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    public partial class MedalGashaRewardAllListCell
    {
        public RewardItemIcon?                          Icon                                    { get; set; }
        public UITextMeshProUGUI?                       RewardCountText                         { get; set; }
        public GameObject?                              CountBase                               { get; set; }
        public GameObject?                              CompleteObject                          { get; set; }
        public PIdolDetailPopupCaller?                  PIdolCaller                             { get; set; }

        public static MedalGashaRewardAllListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardAllListCell();

            value.Icon                                      = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270DB934540 0x20 Icon                        ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.RewardCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB934560 0x28 RewardCountText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CountBase                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB934580 0x30 CountBase                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CompleteObject                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9345A0 0x38 CompleteObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolCaller                               = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DB9345C0 0x40 PIdolCaller                 ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )

            return value;
        }
    }
}
