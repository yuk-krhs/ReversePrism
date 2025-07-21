using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType StaminaRecoverySelectItemConfirmListView StaminaRecoverySelectItemConfirmListView StaminaRecoverySelectItemConfirmListView Pointer
    // 028 TypeItemPanelView                        ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer
    // 030 InfoMessageText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 ViewModel                                ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer
    // 048 onRecoveryFunc                           Func`2<Action, UniTask> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StaminaRecoverySelectItemConfirmPopupView : DataModel
    {
        public StaminaRecoverySelectItemConfirmListView? ListView                                { get; set; }
        public StaminaRecoveryTypeItemPanelView?        TypeItemPanelView                       { get; set; }
        public UITextMeshProUGUI?                       InfoMessageText                         { get; set; }
        public StaminaRecoveryPopupViewModel?           ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StaminaRecoverySelectItemConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectItemConfirmPopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<StaminaRecoverySelectItemConfirmListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaRecoverySelectItemConfirmListView.FromPointer); // 0x20 ListView                    ( ModelClassType StaminaRecoverySelectItemConfirmListView StaminaRecoverySelectItemConfirmListView StaminaRecoverySelectItemConfirmListView Pointer )
            value.TypeItemPanelView                         = GetObject<StaminaRecoveryTypeItemPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaRecoveryTypeItemPanelView.FromPointer); // 0x28 TypeItemPanelView           ( ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer )
            value.InfoMessageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 InfoMessageText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<StaminaRecoveryPopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.StaminaRecoveryPopupViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel StaminaRecoveryPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
