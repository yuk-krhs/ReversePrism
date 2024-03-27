using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 ImgLogo                                  0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 TxtMsg1                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtMsg2                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ProductLabelBase                         0001866053A0 ModelClassType GashaHistoryProductLabel GashaHistoryProductLabel GashaHistoryProductLabel Pointer
    public partial class GashaHistoryCell
    {
        public ButtonBase?                              Btn                                     { get; set; }
        public Image?                                   ImgLogo                                 { get; set; }
        public UITextMeshProUGUI?                       TxtMsg1                                 { get; set; }
        public UITextMeshProUGUI?                       TxtMsg2                                 { get; set; }
        public GashaHistoryProductLabel?                ProductLabelBase                        { get; set; }

        public static GashaHistoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryCell();

            value.Btn                                       = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5305080 0x20 Btn                         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ImgLogo                                   = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270D53050A0 0x28 ImgLogo                     ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtMsg1                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53050C0 0x30 TxtMsg1                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMsg2                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53050E0 0x38 TxtMsg2                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductLabelBase                          = GetObject<GashaHistoryProductLabel>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaHistoryProductLabel.FromPointer); // 0270D5305100 0x40 ProductLabelBase            ( 0001866053A0 ModelClassType GashaHistoryProductLabel GashaHistoryProductLabel GashaHistoryProductLabel Pointer )

            return value;
        }
    }
}
