using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Button                                   0001866E1450 ModelClassType UIButton UIButton UIButton Pointer
    // 018 Label                                    0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ButtonLabelPair
    {
        public UIButton?                                Button                                  { get; set; }
        public UITextMeshProUGUI?                       Label                                   { get; set; }

        public static ButtonLabelPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonLabelPair();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x010), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBE5C058 0x10 Button                      ( 0001866E1450 ModelClassType UIButton UIButton UIButton Pointer )
            value.Label                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x018), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBE5C078 0x18 Label                       ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
