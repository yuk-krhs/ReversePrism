using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HideNotificationToggleButton             ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 068 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ShopMonthlyChargeAlertContent : DataModel
    {
        public ToggleButton?                            HideNotificationToggleButton            { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }

        public static ShopMonthlyChargeAlertContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopMonthlyChargeAlertContent() { Pointer= p0 };

            value.HideNotificationToggleButton              = GetObject<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x60 HideNotificationToggleButton ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
