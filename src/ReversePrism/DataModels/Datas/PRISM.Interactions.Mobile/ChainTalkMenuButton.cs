using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 Label                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ChainTalkMenuButton
    {
        public UIButton?                                Button                                  { get; set; }
        public UITextMeshProUGUI?                       Label                                   { get; set; }

        public static ChainTalkMenuButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkMenuButton();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB0E5CD8 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Label                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E5CF8 0x28 Label                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
