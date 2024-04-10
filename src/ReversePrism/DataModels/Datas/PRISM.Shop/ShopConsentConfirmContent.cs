using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TermsButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 TermsButtonLabel                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ShopConsentConfirmContent : DataModel
    {
        public UIButton?                                TermsButton                             { get; set; }
        public UITextMeshProUGUI?                       TermsButtonLabel                        { get; set; }

        public static ShopConsentConfirmContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopConsentConfirmContent() { Pointer= p0 };

            value.TermsButton                               = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 024665574F18 0x60 TermsButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TermsButtonLabel                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665574F38 0x68 TermsButtonLabel            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
