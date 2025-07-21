using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NativeWebview                            ModelClassType NativeWebview NativeWebview NativeWebview Pointer
    // 028 WebviewController                        ModelClassType WebviewController WebviewController WebviewController Pointer
    // 030 FrameParameter                           ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class WebViewPopupView : DataModel
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
            var value   = new WebViewPopupView() { Pointer= p0 };

            value.NativeWebview                             = GetObject<NativeWebview>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeWebview.FromPointer); // 0x20 NativeWebview               ( ModelClassType NativeWebview NativeWebview NativeWebview Pointer )
            value.WebviewController                         = GetObject<WebviewController>(new IntPtr(p + 0x028), ReversePrism.DataModels.WebviewController.FromPointer); // 0x28 WebviewController           ( ModelClassType WebviewController WebviewController WebviewController Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x30 FrameParameter              ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
