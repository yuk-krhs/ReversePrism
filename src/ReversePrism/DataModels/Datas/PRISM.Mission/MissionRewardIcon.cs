using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItemIcon                           00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 GaugePointIcon                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GaugePointButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 GaugePointCountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GaugePointIconPopup                      000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    public partial class MissionRewardIcon : DataModel
    {
        public RewardItemIcon?                          RewardItemIcon                          { get; set; }
        public GameObject?                              GaugePointIcon                          { get; set; }
        public UIButton?                                GaugePointButton                        { get; set; }
        public UITextMeshProUGUI?                       GaugePointCountText                     { get; set; }
        public PopupContentBase?                        GaugePointIconPopup                     { get; set; }

        public static MissionRewardIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionRewardIcon() { Pointer= p0 };

            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0246655CA0B0 0x20 RewardItemIcon              ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.GaugePointIcon                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0246655CA0D0 0x28 GaugePointIcon              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GaugePointButton                          = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0246655CA0F0 0x30 GaugePointButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GaugePointCountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246655CA110 0x38 GaugePointCountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GaugePointIconPopup                       = GetObject<PopupContentBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0246655CA130 0x40 GaugePointIconPopup         ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )

            return value;
        }
    }
}
