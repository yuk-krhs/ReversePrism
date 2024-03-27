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
    // 068 NoItemText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ResetButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 TypeItemContentView                      000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 080 ReplaceTexts                             000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class StaminaRecoverySelectItemPopupContent
    {
        public UIRepeatedGridLayout?                    UigreadSystem                           { get; set; }
        public UITextMeshProUGUI?                       NoItemText                              { get; set; }
        public UIButton?                                ResetButton                             { get; set; }
        public StaminaRecoveryTypeItemContentView?      TypeItemContentView                     { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceTexts                            { get; set; }

        public static StaminaRecoverySelectItemPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectItemPopupContent();

            value.UigreadSystem                             = GetObject<UIRepeatedGridLayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRepeatedGridLayout.FromPointer); // 0270D5616B70 0x60 UigreadSystem               ( 0001866F0C40 ModelClassType UIRepeatedGridLayout UIRepeatedGridLayout UIRepeatedGridLayout Pointer )
            value.NoItemText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5616B90 0x68 NoItemText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ResetButton                               = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5616BB0 0x70 ResetButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TypeItemContentView                       = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x078), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 0270D5616BD0 0x78 TypeItemContentView         ( 000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.ReplaceTexts                              = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5616BF0 0x80 ReplaceTexts                ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
