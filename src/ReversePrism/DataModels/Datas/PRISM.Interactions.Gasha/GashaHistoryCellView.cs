using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 ImgLogo                                  ModelClassType Image Image Image Pointer
    // 030 TxtMsg1                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtMsg2                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ProductLabelBase                         ModelClassType GashaHistoryProductLabelView GashaHistoryProductLabelView GashaHistoryProductLabelView Pointer
    public partial class GashaHistoryCellView : DataModel
    {
        public ButtonBase?                              Btn                                     { get; set; }
        public Image?                                   ImgLogo                                 { get; set; }
        public UITextMeshProUGUI?                       TxtMsg1                                 { get; set; }
        public UITextMeshProUGUI?                       TxtMsg2                                 { get; set; }
        public GashaHistoryProductLabelView?            ProductLabelBase                        { get; set; }

        public static GashaHistoryCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryCellView() { Pointer= p0 };

            value.Btn                                       = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 Btn                         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ImgLogo                                   = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 ImgLogo                     ( ModelClassType Image Image Image Pointer )
            value.TxtMsg1                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtMsg1                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMsg2                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtMsg2                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductLabelBase                          = GetObject<GashaHistoryProductLabelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaHistoryProductLabelView.FromPointer); // 0x40 ProductLabelBase            ( ModelClassType GashaHistoryProductLabelView GashaHistoryProductLabelView GashaHistoryProductLabelView Pointer )

            return value;
        }
    }
}
