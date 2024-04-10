using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProgressBar                              00018651CF50 ModelClassType Slider Slider Slider Pointer
    // 028 PercentageText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class DownloadOverlayView : DataModel
    {
        public Slider?                                  ProgressBar                             { get; set; }
        public UITextMeshProUGUI?                       PercentageText                          { get; set; }

        public static DownloadOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DownloadOverlayView() { Pointer= p0 };

            value.ProgressBar                               = GetObject<Slider>(new IntPtr(p + 0x020), ReversePrism.DataModels.Slider.FromPointer); // 02466BD258E0 0x20 ProgressBar                 ( 00018651CF50 ModelClassType Slider Slider Slider Pointer )
            value.PercentageText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BD25900 0x28 PercentageText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
