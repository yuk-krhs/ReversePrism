using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleSwitch                             ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 028 RemainingCountObject                     ModelClassType GameObject GameObject GameObject Pointer
    // 030 RemainingCountText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoRemainingCountObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 040 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 DisabledButton                           ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class AutoLiveButton : DataModel
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
            var value   = new AutoLiveButton() { Pointer= p0 };

            value.ToggleSwitch                              = GetObject<ToggleSwitch>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x20 ToggleSwitch                ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.RemainingCountObject                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 RemainingCountObject        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RemainingCountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 RemainingCountText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoRemainingCountObject                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 NoRemainingCountObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x40 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.DisabledButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 DisabledButton              ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
