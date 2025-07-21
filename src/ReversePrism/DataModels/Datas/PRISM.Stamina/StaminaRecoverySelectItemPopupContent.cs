using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PopupPath                                string IL2CPP_TYPE_STRING
    // 060 UigreadSystem                            ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer
    // 068 NoItemText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ResetButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 078 EntrustButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 080 TypeItemContentView                      ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 088 ReplaceTexts                             ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class StaminaRecoverySelectItemPopupContent : DataModel
    {
        public UIRepeatedGridLayout?                    UigreadSystem                           { get; set; }
        public UITextMeshProUGUI?                       NoItemText                              { get; set; }
        public UIButton?                                ResetButton                             { get; set; }
        public UIButton?                                EntrustButton                           { get; set; }
        public StaminaRecoveryTypeItemContentView?      TypeItemContentView                     { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceTexts                            { get; set; }

        public static StaminaRecoverySelectItemPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectItemPopupContent() { Pointer= p0 };

            value.UigreadSystem                             = GetObject<UIRepeatedGridLayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRepeatedGridLayout.FromPointer); // 0x60 UigreadSystem               ( ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer )
            value.NoItemText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 NoItemText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ResetButton                               = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ResetButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EntrustButton                             = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 EntrustButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TypeItemContentView                       = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x080), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 0x80 TypeItemContentView         ( ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 ReplaceTexts                ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
