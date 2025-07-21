using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NothingHistoryText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 GashaHistoryCell                         ModelClassType GashaHistoryCell GashaHistoryCell GashaHistoryCell Pointer
    // 070 ContentRoot                              ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class GashaHistoryContent : DataModel
    {
        public UITextMeshProUGUI?                       NothingHistoryText                      { get; set; }
        public GashaHistoryCell?                        GashaHistoryCell                        { get; set; }
        public RectTransform?                           ContentRoot                             { get; set; }

        public static GashaHistoryContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryContent() { Pointer= p0 };

            value.NothingHistoryText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 NothingHistoryText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GashaHistoryCell                          = GetObject<GashaHistoryCell>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaHistoryCell.FromPointer); // 0x68 GashaHistoryCell            ( ModelClassType GashaHistoryCell GashaHistoryCell GashaHistoryCell Pointer )
            value.ContentRoot                               = GetObject<RectTransform>(new IntPtr(p + 0x070), ReversePrism.DataModels.RectTransform.FromPointer); // 0x70 ContentRoot                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
