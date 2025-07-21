using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaRateView                            ModelClassType GashaRateView GashaRateView GashaRateView Pointer
    // 028 IconTapInfoText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaRatesPopupView : DataModel
    {
        public GashaRateView?                           GashaRateView                           { get; set; }
        public UITextMeshProUGUI?                       IconTapInfoText                         { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaRatesPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesPopupView() { Pointer= p0 };

            value.GashaRateView                             = GetObject<GashaRateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaRateView.FromPointer); // 0x20 GashaRateView               ( ModelClassType GashaRateView GashaRateView GashaRateView Pointer )
            value.IconTapInfoText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 IconTapInfoText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
