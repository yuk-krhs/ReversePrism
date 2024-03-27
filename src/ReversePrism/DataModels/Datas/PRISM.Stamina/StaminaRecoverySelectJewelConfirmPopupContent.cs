using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PopupPath                                string IL2CPP_TYPE_STRING
    // 060 TypeItemContentView                      000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 068 InfoMessageText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 SpecifiedCommercialButton                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 CostJewelAmountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 HaveJewelAmountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 HaveJewelAfterAmountText                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ReplaceTexts                             000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class StaminaRecoverySelectJewelConfirmPopupContent
    {
        public StaminaRecoveryTypeItemContentView?      TypeItemContentView                     { get; set; }
        public UITextMeshProUGUI?                       InfoMessageText                         { get; set; }
        public UIButton?                                SpecifiedCommercialButton               { get; set; }
        public UITextMeshProUGUI?                       CostJewelAmountText                     { get; set; }
        public UITextMeshProUGUI?                       HaveJewelAmountText                     { get; set; }
        public UITextMeshProUGUI?                       HaveJewelAfterAmountText                { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceTexts                            { get; set; }

        public static StaminaRecoverySelectJewelConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectJewelConfirmPopupContent();

            value.TypeItemContentView                       = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x060), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 0270D5617410 0x60 TypeItemContentView         ( 000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.InfoMessageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5617430 0x68 InfoMessageText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpecifiedCommercialButton                 = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5617450 0x70 SpecifiedCommercialButton   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CostJewelAmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5617470 0x78 CostJewelAmountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HaveJewelAmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5617490 0x80 HaveJewelAmountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HaveJewelAfterAmountText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D56174B0 0x88 HaveJewelAfterAmountText    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D56174D0 0x90 ReplaceTexts                ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
