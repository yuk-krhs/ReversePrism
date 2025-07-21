using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TypeItemPanelView                        ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer
    // 028 InfoMessageText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SpecifiedCommercialButton                ModelClassType UIButton UIButton UIButton Pointer
    // 038 CostJewelAmountText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 HaveJewelAmountText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 HaveJewelAfterAmountText                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ReplaceTexts                             ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 058 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 ViewModel                                ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer
    // 070 FooterParameter                          ModelClassType FooterInfoParameter FooterInfoParameter FooterInfoParameter Pointer
    // 078 EveryValueChangedDisposable              ModelClassType IDisposable IDisposable IDisposable Pointer
    // 080 PlusButtonEnableDisposable               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 088 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StaminaRecoverySelectJewelPopupView : DataModel
    {
        public StaminaRecoveryTypeItemPanelView?        TypeItemPanelView                       { get; set; }
        public UITextMeshProUGUI?                       InfoMessageText                         { get; set; }
        public UIButton?                                SpecifiedCommercialButton               { get; set; }
        public UITextMeshProUGUI?                       CostJewelAmountText                     { get; set; }
        public UITextMeshProUGUI?                       HaveJewelAmountText                     { get; set; }
        public UITextMeshProUGUI?                       HaveJewelAfterAmountText                { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceTexts                            { get; set; }
        public StaminaRecoveryPopupViewModel?           ViewModel                               { get; set; }
        public FooterInfoParameter?                     FooterParameter                         { get; set; }
        public IDisposable?                             EveryValueChangedDisposable             { get; set; }
        public IDisposable?                             PlusButtonEnableDisposable              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StaminaRecoverySelectJewelPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectJewelPopupView() { Pointer= p0 };

            value.TypeItemPanelView                         = GetObject<StaminaRecoveryTypeItemPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaRecoveryTypeItemPanelView.FromPointer); // 0x20 TypeItemPanelView           ( ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer )
            value.InfoMessageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 InfoMessageText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpecifiedCommercialButton                 = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 SpecifiedCommercialButton   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CostJewelAmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 CostJewelAmountText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HaveJewelAmountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 HaveJewelAmountText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HaveJewelAfterAmountText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 HaveJewelAfterAmountText    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ReplaceTexts                ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ViewModel                                 = GetObject<StaminaRecoveryPopupViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.StaminaRecoveryPopupViewModel.FromPointer); // 0x68 ViewModel                   ( ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer )
            value.FooterParameter                           = GetObject<FooterInfoParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.FooterInfoParameter.FromPointer); // 0x70 FooterParameter             ( ModelClassType FooterInfoParameter FooterInfoParameter FooterInfoParameter Pointer )
            value.EveryValueChangedDisposable               = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0x78 EveryValueChangedDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.PlusButtonEnableDisposable                = GetObject<IDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDisposable.FromPointer); // 0x80 PlusButtonEnableDisposable  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x88 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
