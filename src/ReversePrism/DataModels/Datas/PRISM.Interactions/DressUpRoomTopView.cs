using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnCameraReset                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 BtnSwitchUIDisplay                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 BtnSelectIdol                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 BtnSelectCostume                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 CgTopViewUIArea                          000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 IsUIDisplayed                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 onSwitchUIDisplay                        Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class DressUpRoomTopView
    {
        public UIButton?                                BtnCameraReset                          { get; set; }
        public UIButton?                                BtnSwitchUIDisplay                      { get; set; }
        public UIButton?                                BtnSelectIdol                           { get; set; }
        public UIButton?                                BtnSelectCostume                        { get; set; }
        public CanvasGroup?                             CgTopViewUIArea                         { get; set; }
        public bool                                     IsUIDisplayed                           { get; set; }

        public static DressUpRoomTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomTopView();

            value.BtnCameraReset                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBC0EBB0 0x20 BtnCameraReset              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSwitchUIDisplay                        = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBC0EBD0 0x28 BtnSwitchUIDisplay          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSelectIdol                             = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBC0EBF0 0x30 BtnSelectIdol               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSelectCostume                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBC0EC10 0x38 BtnSelectCostume            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CgTopViewUIArea                           = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DBC0EC30 0x40 CgTopViewUIArea             ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IsUIDisplayed                             = GetBool(new IntPtr(p + 0x048)); // 0270DBC0EC50 0x48 IsUIDisplayed               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
