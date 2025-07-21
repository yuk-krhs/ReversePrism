using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnCameraReset                           ModelClassType UIButton UIButton UIButton Pointer
    // 028 BtnSwitchUIDisplay                       ModelClassType UIButton UIButton UIButton Pointer
    // 030 BtnSelectIdol                            ModelClassType UIButton UIButton UIButton Pointer
    // 038 BtnSelectCostume                         ModelClassType UIButton UIButton UIButton Pointer
    // 040 CgTopViewUIArea                          ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 IsUIDisplayed                            ModelPrimitiveType bool bool bool Bool
    // 050 onSwitchUIDisplay                        Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class DressUpRoomTopView : DataModel
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
            var value   = new DressUpRoomTopView() { Pointer= p0 };

            value.BtnCameraReset                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 BtnCameraReset              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSwitchUIDisplay                        = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnSwitchUIDisplay          ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSelectIdol                             = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BtnSelectIdol               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSelectCostume                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnSelectCostume            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CgTopViewUIArea                           = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CgTopViewUIArea             ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IsUIDisplayed                             = GetBool(new IntPtr(p + 0x048)); // 0x48 IsUIDisplayed               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
