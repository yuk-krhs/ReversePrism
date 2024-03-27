using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TypeItemContentView                      000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 068 InfoMessageText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class StaminaRecoveryCompletePopupContent
    {
        public StaminaRecoveryTypeItemContentView?      TypeItemContentView                     { get; set; }
        public UITextMeshProUGUI?                       InfoMessageText                         { get; set; }

        public static StaminaRecoveryCompletePopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryCompletePopupContent();

            value.TypeItemContentView                       = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x060), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 0270D560D9D0 0x60 TypeItemContentView         ( 000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.InfoMessageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D560D9F0 0x68 InfoMessageText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
