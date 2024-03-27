using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventRankingText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 HighScoreRankingText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveEventResultPopupView
    {
        public UITextMeshProUGUI?                       EventRankingText                        { get; set; }
        public UITextMeshProUGUI?                       HighScoreRankingText                    { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveEventResultPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventResultPopupView();

            value.EventRankingText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB915E68 0x20 EventRankingText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HighScoreRankingText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB915E88 0x28 HighScoreRankingText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB915EC8 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
