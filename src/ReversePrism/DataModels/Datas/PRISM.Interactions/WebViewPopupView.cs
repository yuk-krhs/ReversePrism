using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NativeWebview                            000186694F40 ModelClassType NativeWebview NativeWebview NativeWebview Pointer
    // 028 WebviewController                        000186553500 ModelClassType WebviewController WebviewController WebviewController Pointer
    // 030 FrameParameter                           000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class WebViewPopupView
    {
        public NativeWebview?                           NativeWebview                           { get; set; }
        public WebviewController?                       WebviewController                       { get; set; }
        public PopupFrameParameter?                     FrameParameter                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static WebViewPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebViewPopupView();

            value.NativeWebview                             = GetObject<NativeWebview>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeWebview.FromPointer); // 0270DB57ECC0 0x20 NativeWebview               ( 000186694F40 ModelClassType NativeWebview NativeWebview NativeWebview Pointer )
            value.WebviewController                         = GetObject<WebviewController>(new IntPtr(p + 0x028), ReversePrism.DataModels.WebviewController.FromPointer); // 0270DB57ECE0 0x28 WebviewController           ( 000186553500 ModelClassType WebviewController WebviewController WebviewController Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0270DB57ED00 0x30 FrameParameter              ( 000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB57ED40 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
