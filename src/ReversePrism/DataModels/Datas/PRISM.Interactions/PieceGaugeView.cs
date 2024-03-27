using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgFillColor                             0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 TxtPieceCount                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtRequiredPieceCount                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class PieceGaugeView
    {
        public Image?                                   ImgFillColor                            { get; set; }
        public UITextMeshProUGUI?                       TxtPieceCount                           { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredPieceCount                   { get; set; }

        public static PieceGaugeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceGaugeView();

            value.ImgFillColor                              = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DA290DF0 0x20 ImgFillColor                ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtPieceCount                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA290E10 0x28 TxtPieceCount               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtRequiredPieceCount                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA290E30 0x30 TxtRequiredPieceCount       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
