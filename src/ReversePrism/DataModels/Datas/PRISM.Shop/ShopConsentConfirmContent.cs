using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TermsButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 068 TermsButtonLabel                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
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

            value.TermsButton                               = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 TermsButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TermsButtonLabel                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TermsButtonLabel            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
