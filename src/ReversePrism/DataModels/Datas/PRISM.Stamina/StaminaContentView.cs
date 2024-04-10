using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RecoveryTimeText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 StaminaText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 StaminaGauge                             0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 StaminaFullGaugeObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 RecoveryButtonEnabled                    000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 RecoveryButtonDisabled                   000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class StaminaContentView : DataModel
    {
        public UITextMeshProUGUI?                       RecoveryTimeText                        { get; set; }
        public UITextMeshProUGUI?                       StaminaText                             { get; set; }
        public Image?                                   StaminaGauge                            { get; set; }
        public GameObject?                              StaminaFullGaugeObject                  { get; set; }
        public ButtonBase?                              RecoveryButtonEnabled                   { get; set; }
        public ButtonBase?                              RecoveryButtonDisabled                  { get; set; }

        public static StaminaContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaContentView() { Pointer= p0 };

            value.RecoveryTimeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A4F63850 0x20 RecoveryTimeText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A4F63870 0x28 StaminaText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaGauge                              = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0245A4F63890 0x30 StaminaGauge                ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.StaminaFullGaugeObject                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4F638B0 0x38 StaminaFullGaugeObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RecoveryButtonEnabled                     = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0245A4F638D0 0x40 RecoveryButtonEnabled       ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RecoveryButtonDisabled                    = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0245A4F638F0 0x48 RecoveryButtonDisabled      ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
