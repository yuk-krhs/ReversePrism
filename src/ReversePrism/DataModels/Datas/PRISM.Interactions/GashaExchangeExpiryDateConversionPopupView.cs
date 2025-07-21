using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoTemplate                               ModelClassType GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell Pointer
    // 028 TxtNow                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtOld                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtPuls                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaExchangeExpiryDateConversionPopupView : DataModel
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
            var value   = new GashaExchangeExpiryDateConversionPopupView() { Pointer= p0 };

            value.GoTemplate                                = GetObject<GashaExchangeExpiryDateConversionItemCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaExchangeExpiryDateConversionItemCell.FromPointer); // 0x20 GoTemplate                  ( ModelClassType GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell GashaExchangeExpiryDateConversionItemCell Pointer )
            value.TxtNow                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtNow                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtOld                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtOld                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPuls                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtPuls                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
