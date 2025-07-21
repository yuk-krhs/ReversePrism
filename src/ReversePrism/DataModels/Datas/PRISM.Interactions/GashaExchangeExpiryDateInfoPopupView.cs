using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Template                                 ModelClassType GashaExchangeExpiryDateInfoItemCell GashaExchangeExpiryDateInfoItemCell GashaExchangeExpiryDateInfoItemCell Pointer
    // 028 TxtDivMessage                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 onClosed                                 Subject`1<IGashaExchangePointStatus> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaExchangeExpiryDateInfoPopupView : DataModel
    {
        public GashaExchangeExpiryDateInfoItemCell?     Template                                { get; set; }
        public UITextMeshProUGUI?                       TxtDivMessage                           { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaExchangeExpiryDateInfoPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeExpiryDateInfoPopupView() { Pointer= p0 };

            value.Template                                  = GetObject<GashaExchangeExpiryDateInfoItemCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaExchangeExpiryDateInfoItemCell.FromPointer); // 0x20 Template                    ( ModelClassType GashaExchangeExpiryDateInfoItemCell GashaExchangeExpiryDateInfoItemCell GashaExchangeExpiryDateInfoItemCell Pointer )
            value.TxtDivMessage                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtDivMessage               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
