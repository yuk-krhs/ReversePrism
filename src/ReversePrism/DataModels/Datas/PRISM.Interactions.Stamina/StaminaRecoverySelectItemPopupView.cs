using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType StaminaRecoverySelectItemLiveView StaminaRecoverySelectItemLiveView StaminaRecoverySelectItemLiveView Pointer
    // 028 NoItemText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ResetButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 038 EntrustButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 040 TypeItemPanelView                        ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer
    // 048 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 050 RecoveryButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 058 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 ViewModel                                ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer
    // 068 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StaminaRecoverySelectItemPopupView : DataModel
    {
        public StaminaRecoverySelectItemLiveView?       ListView                                { get; set; }
        public UITextMeshProUGUI?                       NoItemText                              { get; set; }
        public UIButton?                                ResetButton                             { get; set; }
        public UIButton?                                EntrustButton                           { get; set; }
        public StaminaRecoveryTypeItemPanelView?        TypeItemPanelView                       { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public UIButton?                                RecoveryButton                          { get; set; }
        public StaminaRecoveryPopupViewModel?           ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StaminaRecoverySelectItemPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectItemPopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<StaminaRecoverySelectItemLiveView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaRecoverySelectItemLiveView.FromPointer); // 0x20 ListView                    ( ModelClassType StaminaRecoverySelectItemLiveView StaminaRecoverySelectItemLiveView StaminaRecoverySelectItemLiveView Pointer )
            value.NoItemText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 NoItemText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ResetButton                               = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 ResetButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EntrustButton                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 EntrustButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TypeItemPanelView                         = GetObject<StaminaRecoveryTypeItemPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.StaminaRecoveryTypeItemPanelView.FromPointer); // 0x40 TypeItemPanelView           ( ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RecoveryButton                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 RecoveryButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<StaminaRecoveryPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.StaminaRecoveryPopupViewModel.FromPointer); // 0x60 ViewModel                   ( ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x68 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
