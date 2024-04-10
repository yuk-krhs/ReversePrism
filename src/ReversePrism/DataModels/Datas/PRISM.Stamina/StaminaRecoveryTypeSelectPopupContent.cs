using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 PopupPaths                               000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 JewelPopupPath                           string IL2CPP_TYPE_STRING
    // 068 RecoveryTimeText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 JewelButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 ItemStaminaButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 ItemLiveBonusButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 088 RecoveryTimeDisposable                   0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StaminaRecoveryTypeSelectPopupContent : DataModel
    {
        public List<string>?                            PopupPaths                              { get; set; }
        public UITextMeshProUGUI?                       RecoveryTimeText                        { get; set; }
        public UIButton?                                JewelButton                             { get; set; }
        public UIButton?                                ItemStaminaButton                       { get; set; }
        public UIButton?                                ItemLiveBonusButton                     { get; set; }
        public IDisposable?                             RecoveryTimeDisposable                  { get; set; }

        public static StaminaRecoveryTypeSelectPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryTypeSelectPopupContent() { Pointer= p0 };

            value.PopupPaths                                = GetStringList(new IntPtr(p + 0x060)); // 02466568A6E8 0x60 PopupPaths                  ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.RecoveryTimeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466568A728 0x68 RecoveryTimeText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelButton                               = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 02466568A748 0x70 JewelButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemStaminaButton                         = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 02466568A768 0x78 ItemStaminaButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemLiveBonusButton                       = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 02466568A788 0x80 ItemLiveBonusButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RecoveryTimeDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 02466568A7A8 0x88 RecoveryTimeDisposable      ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
