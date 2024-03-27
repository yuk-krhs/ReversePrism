using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PopupPath                                string IL2CPP_TYPE_STRING
    // 060 UigreadSystem                            0001866F0C40 ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer
    // 068 TypeItemContentView                      000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 070 InfoMessageText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 RecoveryItemModels                       000185CA7168 ModelClassListType StaminaRecoveryUseItemModel[] StaminaRecoveryUseItemModel[] List<StaminaRecoveryUseItemModel> Pointer
    // 080 OnItemReloadEvent                        0001866792B0 ModelClassType Action Action Action Pointer
    public partial class StaminaRecoverySelectItemConfirmPopupContent
    {
        public UIRepeatedGridLayout?                    UigreadSystem                           { get; set; }
        public StaminaRecoveryTypeItemContentView?      TypeItemContentView                     { get; set; }
        public UITextMeshProUGUI?                       InfoMessageText                         { get; set; }
        public List<StaminaRecoveryUseItemModel>?       RecoveryItemModels                      { get; set; }
        public Action?                                  OnItemReloadEvent                       { get; set; }

        public static StaminaRecoverySelectItemConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectItemConfirmPopupContent();

            value.UigreadSystem                             = GetObject<UIRepeatedGridLayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRepeatedGridLayout.FromPointer); // 0270D5616960 0x60 UigreadSystem               ( 0001866F0C40 ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer )
            value.TypeItemContentView                       = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x068), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 0270D5616980 0x68 TypeItemContentView         ( 000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.InfoMessageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D56169A0 0x70 InfoMessageText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecoveryItemModels                        = GetObjectList<StaminaRecoveryUseItemModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.StaminaRecoveryUseItemModel.FromPointer); // 0270D56169C0 0x78 RecoveryItemModels          ( 000185CA7168 ModelClassListType StaminaRecoveryUseItemModel[] StaminaRecoveryUseItemModel[] List<StaminaRecoveryUseItemModel> Pointer )
            value.OnItemReloadEvent                         = GetObject<Action>(new IntPtr(p + 0x080), ReversePrism.DataModels.Action.FromPointer); // 0270D56169E0 0x80 OnItemReloadEvent           ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
