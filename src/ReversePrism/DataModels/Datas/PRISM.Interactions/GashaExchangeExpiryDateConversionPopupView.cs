using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoTemplate                               0001865FE560 ModelClassType GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell Pointer
    // 028 TxtNow                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtOld                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtPuls                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaExchangeExpiryDateConversionPopupView
    {
        public GashaExchangeExpiryDateConversionItemCell? GoTemplate                              { get; set; }
        public UITextMeshProUGUI?                       TxtNow                                  { get; set; }
        public UITextMeshProUGUI?                       TxtOld                                  { get; set; }
        public UITextMeshProUGUI?                       TxtPuls                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaExchangeExpiryDateConversionPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeExpiryDateConversionPopupView();

            value.GoTemplate                                = GetObject<GashaExchangeExpiryDateConversionItemCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaExchangeExpiryDateConversionItemCell.FromPointer); // 0270DB9F6F88 0x20 GoTemplate                  ( 0001865FE560 ModelClassType GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell Pointer )
            value.TxtNow                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F6FA8 0x28 TxtNow                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtOld                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F6FC8 0x30 TxtOld                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPuls                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F6FE8 0x38 TxtPuls                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB9F7028 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
