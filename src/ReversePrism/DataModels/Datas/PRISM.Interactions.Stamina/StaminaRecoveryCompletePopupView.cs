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
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 ViewModel                                ModelClassType StaminaRecoveryCompleteViewModel StaminaRecoveryCompleteViewModel StaminaRecoveryCompleteViewModel Pointer
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StaminaRecoveryCompletePopupView : DataModel
    {
        public StaminaRecoveryTypeItemPanelView?        TypeItemPanelView                       { get; set; }
        public UITextMeshProUGUI?                       InfoMessageText                         { get; set; }
        public StaminaRecoveryCompleteViewModel?        ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StaminaRecoveryCompletePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryCompletePopupView() { Pointer= p0 };

            value.TypeItemPanelView                         = GetObject<StaminaRecoveryTypeItemPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaRecoveryTypeItemPanelView.FromPointer); // 0x20 TypeItemPanelView           ( ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer )
            value.InfoMessageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 InfoMessageText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<StaminaRecoveryCompleteViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StaminaRecoveryCompleteViewModel.FromPointer); // 0x38 ViewModel                   ( ModelClassType StaminaRecoveryCompleteViewModel StaminaRecoveryCompleteViewModel StaminaRecoveryCompleteViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
