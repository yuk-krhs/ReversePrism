using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RecoveryTimeText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 JewelButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 030 ItemStaminaButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 038 ItemLiveBonusButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer
    // 050 onClosingFunc                            Func`2<RecoveryTypeSelectFooterButtonType, UniTask> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StaminaRecoveryTypeSelectPopupView : DataModel
    {
        public UITextMeshProUGUI?                       RecoveryTimeText                        { get; set; }
        public UIButton?                                JewelButton                             { get; set; }
        public UIButton?                                ItemStaminaButton                       { get; set; }
        public UIButton?                                ItemLiveBonusButton                     { get; set; }
        public StaminaRecoveryPopupViewModel?           ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StaminaRecoveryTypeSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryTypeSelectPopupView() { Pointer= p0 };

            value.RecoveryTimeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 RecoveryTimeText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 JewelButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemStaminaButton                         = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 ItemStaminaButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemLiveBonusButton                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ItemLiveBonusButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<StaminaRecoveryPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StaminaRecoveryPopupViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
