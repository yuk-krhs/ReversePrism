using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ItemAmountText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ItemInfoText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ItemCountLabelText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class FakeItemDetailPopupContent
    {
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UITextMeshProUGUI?                       ItemAmountText                          { get; set; }
        public UITextMeshProUGUI?                       ItemInfoText                            { get; set; }
        public UITextMeshProUGUI?                       ItemCountLabelText                      { get; set; }

        public static FakeItemDetailPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FakeItemDetailPopupContent();

            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5553B18 0x60 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5553B38 0x68 ItemAmountText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemInfoText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5553B58 0x70 ItemInfoText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemCountLabelText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5553B78 0x78 ItemCountLabelText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
