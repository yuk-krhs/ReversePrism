using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NothingHistoryText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 GashaHistoryCell                         ModelClassType GashaHistoryCellView GashaHistoryCellView GashaHistoryCellView Pointer
    // 030 ContentRoot                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaHistoryPopupView : DataModel
    {
        public UITextMeshProUGUI?                       NothingHistoryText                      { get; set; }
        public GashaHistoryCellView?                    GashaHistoryCell                        { get; set; }
        public RectTransform?                           ContentRoot                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaHistoryPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryPopupView() { Pointer= p0 };

            value.NothingHistoryText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 NothingHistoryText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GashaHistoryCell                          = GetObject<GashaHistoryCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaHistoryCellView.FromPointer); // 0x28 GashaHistoryCell            ( ModelClassType GashaHistoryCellView GashaHistoryCellView GashaHistoryCellView Pointer )
            value.ContentRoot                               = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 ContentRoot                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
