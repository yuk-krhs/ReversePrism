using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTextMeshProUGUI                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 FrameParameter                           000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 030 onClickSubject                           Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class MessagePopupView
    {
        public UITextMeshProUGUI?                       UiTextMeshProUGUI                       { get; set; }
        public PopupFrameParameter?                     FrameParameter                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static MessagePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessagePopupView();

            value.UiTextMeshProUGUI                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB563490 0x20 UiTextMeshProUGUI           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0270DB5634B0 0x28 FrameParameter              ( 000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB5634F0 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
