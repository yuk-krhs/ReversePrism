using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemAmountText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ItemInfoText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ItemCountLabelText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ItemExpireDate                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ItemAcquiredDate                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ItemLimitDate                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 CmnItem                                  0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 060 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ItemDetailPopupView
    {
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UITextMeshProUGUI?                       ItemAmountText                          { get; set; }
        public UITextMeshProUGUI?                       ItemInfoText                            { get; set; }
        public UITextMeshProUGUI?                       ItemCountLabelText                      { get; set; }
        public UITextMeshProUGUI?                       ItemExpireDate                          { get; set; }
        public UITextMeshProUGUI?                       ItemAcquiredDate                        { get; set; }
        public UITextMeshProUGUI?                       ItemLimitDate                           { get; set; }
        public CmnItem?                                 CmnItem                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ItemDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemDetailPopupView();

            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF1E638 0x20 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF1E658 0x28 ItemAmountText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemInfoText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF1E678 0x30 ItemInfoText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemCountLabelText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF1E698 0x38 ItemCountLabelText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemExpireDate                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF1E6B8 0x40 ItemExpireDate              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAcquiredDate                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF1E6D8 0x48 ItemAcquiredDate            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemLimitDate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBF1E6F8 0x50 ItemLimitDate               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CmnItem                                   = GetObject<CmnItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.CmnItem.FromPointer); // 0270DBF1E718 0x58 CmnItem                     ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBF1E758 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
