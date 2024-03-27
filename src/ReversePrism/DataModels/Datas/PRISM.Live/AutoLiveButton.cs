using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleSwitch                             0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 028 RemainingCountObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 RemainingCountText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoRemainingCountObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 DisabledButton                           000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class AutoLiveButton
    {
        public ToggleSwitch?                            ToggleSwitch                            { get; set; }
        public GameObject?                              RemainingCountObject                    { get; set; }
        public UITextMeshProUGUI?                       RemainingCountText                      { get; set; }
        public GameObject?                              NoRemainingCountObject                  { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public ButtonBase?                              DisabledButton                          { get; set; }

        public static AutoLiveButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoLiveButton();

            value.ToggleSwitch                              = GetObject<ToggleSwitch>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0270D526D118 0x20 ToggleSwitch                ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.RemainingCountObject                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526D138 0x28 RemainingCountObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RemainingCountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D526D158 0x30 RemainingCountText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoRemainingCountObject                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D526D178 0x38 NoRemainingCountObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D526D198 0x40 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.DisabledButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D526D1B8 0x48 DisabledButton              ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
