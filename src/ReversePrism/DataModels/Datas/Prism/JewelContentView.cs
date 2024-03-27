using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 JewelText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 JewelButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 LimitedSaleJewelButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class JewelContentView
    {
        public UITextMeshProUGUI?                       JewelText                               { get; set; }
        public UIButton?                                JewelButton                             { get; set; }
        public UIButton?                                LimitedSaleJewelButton                  { get; set; }

        public static JewelContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JewelContentView();

            value.JewelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004F74A30 0x20 JewelText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 027004F74A50 0x28 JewelButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LimitedSaleJewelButton                    = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 027004F74A70 0x30 LimitedSaleJewelButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
