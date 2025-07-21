using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 PopupPaths                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 JewelPopupPath                           string IL2CPP_TYPE_STRING
    // 068 RecoveryTimeText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 JewelButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 078 ItemStaminaButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 080 ItemLiveBonusButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 088 RecoveryTimeDisposable                   ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.PopupPaths                                = GetStringList(new IntPtr(p + 0x060)); // 0x60 PopupPaths                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.RecoveryTimeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 RecoveryTimeText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelButton                               = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 JewelButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemStaminaButton                         = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 ItemStaminaButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemLiveBonusButton                       = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 ItemLiveBonusButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RecoveryTimeDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 RecoveryTimeDisposable      ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
